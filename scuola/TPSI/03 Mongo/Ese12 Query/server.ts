import { MongoClient, Db, ObjectId, MongoError } from "mongodb";
import dotenv from "dotenv"


dotenv.config({ path: ".env" })

const DBNAME = process.env.DBNAME
const CONNECTION_STRING = process.env.CONNECTION_STRING_LOCAL!

export interface CustomError extends Error {
    status: number
}

class Models {
    private client: MongoClient | undefined

    private async openConnection() {
        if (!this.client) {
            console.log("connecting to " + CONNECTION_STRING + ".....")
            this.client = new MongoClient(CONNECTION_STRING)

            try {
                await this.client.connect()
                console.log("Connection to MongoDb established")
            } catch (err) {
                this.client = undefined;
                this.emitError(503, "errore di connessione al database: " + err)
            }
        }
    }

    public async getDB(): Promise<Db> {
        await this.openConnection()
        return this.client!.db(DBNAME)
    }


    public async closeConnection() {
        if (this.client) {
            await this.client.close()
        }
    }

    private emitError(status: number, msg: string) {
        const err = new Error(msg) as CustomError
        err.status = status
        throw err
    }

    private getObjectId(id: string): ObjectId | string {
        return ObjectId.isValid(id) ? new ObjectId(id) : id
    }

}





const models = new Models()

let collectionName = "";

const queryIndex = 40
if (queryIndex <= 23 || queryIndex >= 33 && queryIndex <= 39)
    collectionName = "unicorns"
else if (queryIndex >= 24 && queryIndex <= 30)
    collectionName = "biblioteca"
else if (queryIndex >= 31 && queryIndex <= 32)
    collectionName = "orders"
else if (queryIndex >= 40)
    collectionName = "biblioteca"


/*   #################### query ####################### */
executeQuery(queryIndex);



async function executeQuery(queryNumber: number) {
    try {
        const db = await models.getDB()
        const collection = db.collection(collectionName)
        let result: any;

        switch (queryNumber) {
            case 1:
                // Trova tutti i documenti con peso (weight) strettamente compreso tra 700 e 800 (esclusi)
                result = await collection.find({"weight": { "$gt": 700, "$lt": 800 }}).toArray()
                break;
            case 2:
                // Trova i documenti di genere maschile ("m") che amano "grape" e hanno un valore di "vampires" superiore a 60
                result = await collection.find({"gender": "m", "loves": "grape", "vampires": { "$gt": 60 }}).toArray()
                break;
            case 3:
                // Trova i documenti con genere femminile ("f") OPPURE con peso inferiore a 700
                result = await collection.find({"$or": [{ "gender": "f" }, { "weight": { "$lt": 700 } }]}).toArray()
                break;
            case 4:
                // Trova i documenti con più di 60 vampiri E che amano "grape" oppure "apple"
                result = await collection.find({"vampires": {"$gt": 60}, "$or": [{"loves": "grape"}, {"loves": "apple"}]}).toArray()
                break;
            case 5:
                // Trova i documenti con più di 60 vampiri E che contengono SIA "grape" CHE "watermelon" nell'array "loves"
                result = await collection.find({"vampires": {"$gt": 60}, "loves": {"$all": ["grape", "watermelon"]}}).toArray()
                break;
            case 6:
                // Trova i documenti con colore dei capelli ("hair") uguale a "brown" oppure "grey"
                result = await collection.find({"hair": {"$in": ["brown", "grey"]}}).toArray()
                break;
            case 7:
                // Trova i documenti in cui il campo "vaccinated" NON è uguale a true (include false e i casi in cui il campo non esiste)
                result = await collection.find({"vaccinated": {"$ne": true}}).toArray()
                //result = await collection.find({"or": [{"vaccinated": false}, {"vaccinated": {"$exists": false}}]}).toArray()
                break;
            case 8:
                // Trova i documenti maschili ("m") che NON contengono "apple" tra le preferenze nell'array "loves"
                result = await collection.find({"gender": "m", "loves": {"$nin": ["apple"]}}).toArray()
                break;
            case 9:
                // Trova i documenti femminili ("f") il cui nome inizia con la lettera "a" (case-insensitive)
                const regex = new RegExp("^a", "i")
                result = await collection.find({"gender": "f", "name": regex}).toArray()
                break;
            case 10:
                // Trova il documento specifico identificato dall'ObjectId fornito
                const id = new ObjectId("6ae1b29a366397246aed95e5");
                result = await collection.find({"_id": id}).toArray()
                break;
            case 11:
                // Trova i maschi, proietta solo name e vampires (escludendo _id), ordina per vampires decrescente e weight crescente, salta il primo risultato e prende i 3 successivi
                //.skip(1); sono i record che voglio saltare
                result = await collection.find({"gender": "m"}).project({name: 1, vampires: 1, _id: 0}).sort({"vampires": "desc", "weight": "asc"}).limit(3).skip(1).toArray()
                //result = await collection.find({"gender": "m"}, {"projection": {"name": 1, "vampires": 1}}).toArray()
                break;
            case 12:
                // Calcola il numero di documenti aventi un peso maggiore di 500 contando la lunghezza dell'array dei risultati ottenuti
                //result = await collection.countDocuments({ "weight": {"$gt": 500}}).toArray().length
                result = (await collection.find({ "weight": {"$gt": 500}}).toArray()).length
                break;
            case 13:
                // Trova il primo documento con nome "Aurora" e ne restituisce solo i campi hair, weight e name (senza _id)
                result = await collection.findOne({ "name": "Aurora"}, {"projection": {hair: 1, weight: 1, name: 1, _id: 0}});
                break;
            case 14:
                // Restituisce l'elenco dei valori unici presenti nel campo/array "loves" per i documenti di genere femminile
                result = await collection.distinct("loves", {"gender": "f"});
                break;
            case 15:
                // Inserisce un nuovo documento (l'unicorno "Minnie") nella collezione
                const unicorn = {
                    "name": "Minnie",
                    "dob": "1999-11-20",
                    "loves": [
                        "grape",
                        "energon"
                    ],
                    "weight": 540,
                    "gender": "f",
                    "hair": "blonde",
                    "vaccinated": true
                }
                result = await collection.insertOne(unicorn)
                break;      
            case 16:
                // Elimina il primo documento il cui nome è "minnie" (confronto case-insensitive)
                const regex2 = new RegExp("^minnie$", "i");
                result = await collection.deleteOne({"name": regex2});
                break;  
            case 17:
                // Incrementa di 1 il valore del campo "vampires" nel documento con nome "Pilot"
                result = await collection.updateOne({"name": "Pilot"}, {"$inc": {"vampires": 1}})
                break;  
            case 18:
                // Aggiorna "Aurora": aggiunge senza duplicati "carrot" e "sugar" in "loves", aumenta il peso di 10 e imposta "vaccinated" a true
                result = await collection.updateOne(
                    {"name": "Aurora"}, 
                    {
                        "$addToSet": {"loves": {"$each": ["carrot", "sugar"]}}, 
                        "$inc": {"weight": 10},
                        "$set": {"vaccinated": true}
                    });
                break;  
            case 19:
                // Incrementa di 1 "vampires" per "Pluto"; se il documento non esiste, lo crea grazie all'opzione "upsert": true
                result = await collection.updateOne(
                    { "name": "Pluto"}, 
                    {
                        "$inc": {"vampires": 1}
                    },
                    {
                        "upsert": true
                    }
                )
                break;  
            case 20:
                // Imposta "vaccinated" a false in tutti i documenti in cui il campo "vaccinated" non esiste ancora
                result = await collection.updateMany(
                    { "vaccinated": {"$exists": false}},
                    {
                        "$set": {"vaccinated": false}
                    }
                )
                break;  
            case 21:
                // Elimina tutti i documenti il cui array "loves" contiene sia "carrot" che "grape"
                result = await collection.deleteMany({ "loves": {"$all": ["carrot","grape"]}})
                break;  
            case 22:
                // Trova la femmina con il maggior numero di vampiri (ordinamento decrescente, limite 1) proiettando name e vampires (senza _id)
                result = await collection.find(
                    { "gender": "f"},
                    {
                         "projection": {name: 1, vampires: 1, _id: 0} 
                    }
                ).sort({"vampires": "desc"}).limit(1).toArray();
                break;  
            case 23:
                // Sostituisce completamente il documento con nome "Pluto" con il nuovo oggetto specificato
                result = await collection.replaceOne(
                    { "name": "Pluto"},
                    { 
                        "name": "Pluto",
                        "gender": "m",
                        "weight": 250,
                        "hair": "blonde"
                    }
                );
                break;  
            case 24:
                // Trova i documenti con oggetto nidificato posizione (stanza 2 e scaffale 3) proiettando titolo, autore, posizione e pubblicazioni
                result = await collection.find({"posizione.stanza": 2, "posizione.scaffale": 3}, 
                    {"projection": {"titolo": 1, "autore": 1, "posizione": 1, "_id": 0, "pubblicazioni": 1}}).toArray()
                break;  
            case 25:
                // Restituisce l'elenco di tutti gli editori unici presenti nel sottocampo/array "pubblicazioni.editore"
                result = await collection.distinct("pubblicazioni.editore")
                break;  
            case 26:
                // Cerca i documenti che contengono l'editore "einaudi" (case-insensitive) all'interno dell'array/oggetto pubblicazioni
                let regex3 = new RegExp("^einaudi$", "i");
                result = await collection.find({"pubblicazioni.editore": regex3},
                    {"projection": {"titolo": 1, "autore": 1, "pubblicazioni.editore": 1, "_id": 0}}
                ).toArray()
                break;  
            case 27:
                // Cerca elementi nell'array pubblicazioni che abbiano editore "einaudi" E anno 2010 ($elemMatch); proietta solo l'editore della prima pubblicazione corrispondente ($) e gli anni delle pubblicazioni
                let regex4 = new RegExp("^einaudi$", "i");
                result = await collection.find({"pubblicazioni": {"$elemMatch": {"editore": regex4, "anno": 2010}}}, 
                    {"projection": {"titolo": 1, "autore": 1, "pubblicazioni.editore.$": 1, "pubblicazioni.anno": 1, "_id": 0}}
                ).toArray()
                break;  
            case 28:
                // Trova i documenti con una pubblicazione con editore "einaudi" e anno 2010, proiettando l'intero elemento dell'array che ha soddisfatto il filtro ($)
                let regex5 = new RegExp("^einaudi$", "i");
                 result = await collection.find({"pubblicazioni": {"$elemMatch": {"editore": regex5, "anno": 2010}}}, 
                    {"projection": {"titolo": 1, "autore": 1, "pubblicazioni.$": 1, "_id": 0}}
                ).toArray()
                break;  
            case 29:
                // Incrementa di 1 il numero di pagine (nPagine) della prima pubblicazione dell'editore "Mondadori" del libro "Promessi Sposi" (operatore posizionale $)
                let regex6 = new RegExp("^Mondadori$", "i");
                let regex7 = new RegExp("^Promessi Sposi$", "i");
                result = await collection.updateOne({"titolo": regex7, "pubblicazioni.editore": regex6}, {"$inc": {"pubblicazioni.$.nPagine": 1}});
                break;      
            case 30:
                // Incrementa di 1 il numero di pagine (nPagine) di TUTTE le pubblicazioni contenute nell'array del libro "Promessi Sposi" (operatore posizionale all $[])
                let regex8 = new RegExp("^Promessi Sposi$", "i");
                result = await collection.updateOne({"titolo": regex8}, {"$inc": {"pubblicazioni.$[].nPagine": 1}});
                break;      
            case 31:
                // Aggregazione: filtra per status "A", raggruppa per cliente (cust_id) calcolando la somma degli importi (amount), e ordina per totale decrescente
                result = await collection.aggregate(
                    [
                        {"$match": {"status": "A"}},
                        {"$group": {"_id": "$cust_id", "totale": {"$sum" : "$amount"}}},
                        {"$sort": {"totale": -1}}
                    ]
                ).toArray();
                break;
            case 32:
                // Aggregazione: filtra status "A", raggruppa per cliente calcolando la media dell'importo e la media del totale di riga (amount * qta), poi ordina per media decrescente
                result = await collection.aggregate(
                    [
                        {"$match": {"status": "A"}},
                        {"$group": {"_id": "$cust_id", "media": {"$avg" : "$amount"},
                        "mediaTotali": {"$avg": {"$multiply": ["$amount", "$qta"]}}}},
                        {"$sort": {"media": -1}}
                    ]
                ).toArray();
                break;

            case 33:
                // Aggregazione: raggruppa i documenti per genere (gender), conta quanti esemplari ci sono per ciascuno e ordina per conteggio decrescente
                result = await collection.aggregate(
                    [
                        {"$group": 
                            {   "_id": "$gender",
                                "nEsemplari": {"$sum": 1}
                            }
                        },
                        {"$sort": {"nEsemplari": -1}}
                    ]
                ).toArray();
                break;
                
            case 34:
                // Aggregazione: raggruppa i documenti per genere (gender) calcolando la media del numero di vampiri uccisi (vampires)
                result = await collection.aggregate(
                    [
                        {"$group": 
                            {   "_id": "$gender",
                                "vampiriUccisi": {"$avg": "$vampires"}
                            }
                        },
                        {"$sort": {"nEsemplari": -1}}
                    ]
                ).toArray();
                break;
            case 35:
                // Aggregazione: raggruppa per combinazione di genere e colore pelo/capelli contando gli elementi, poi proietta il risultato rimodellando la struttura ed eliminando _id
                result = await collection.aggregate(
                    [
                        {"$group": 
                            {   "_id": {"gender":  "$gender", "hair": "$hair"},
                                "vampiriUccisi": {"$sum": 1}
                            }
                        },
                        {"$project": {"genere": "$_id.gender", "pelo": "$_id.hair", "nEsemplari": 1, "_id": 0}}
                    ]
                ).toArray();
                break;
            case 36:
                // Aggregazione: calcola la media complessiva dei vampiri uccisi sull'intera collezione e la arrotonda all'intero più vicino
                result = await collection.aggregate([
                    {
                        "$group": { "_id": {}, "vampiriUccisi": { "$avg": "$vampires" } }
                    },
                    {
                        "$project": { "_id": 0, "mediaVampiriUccisi": { "$round": ["$vampiriUccisi", 0] } }
                    }
                ]).toArray();
                break;
            case 37:
                // Aggregazione: calcola le medie dei voti individuali per studente (quiz, lab, esami), poi raggruppa tutti i record per calcolare le medie generali di classe
                result = await collection.aggregate([
                    {
                        "$project":
                        {
                            "avgQuiz": { "$round": [{ "$avg": "$quizzes" }, 1] },
                            "avglab": { "$round": [{ "$avg": "$labs" }, 1] },
                            "avgExam": { "$round": [{ "$avg": ["$midterm", "$final"] }, 1] }
                        }
                    },
                    {
                        "$group":
                        {
                            "_id": {},
                            "mediaQuizs": { "$avg": "$avgQuiz" },
                            "mediaLabs": { "$avg": "$avgLab" },
                            "mediaExams": { "$avg": "$avgExam " }
                        }
                    },
                    {
                        "$project": { "_id": 0 }
                    }
                ]).toArray();
                break;
            case 38:
                // Aggregazione: filtra le femmine, calcola la media voti arrotondata a 1 decimale per ciascuna, ordina in modo decrescente e seleziona il secondo risultato (skip 1, limit 1)
                result = await collection.aggregate([
                    {
                        "$match": { "genere": "f" }
                    },
                    {
                        "$project":
                        {
                            "_id": 0,
                            "nome": 1,
                            "mediaVoti": { "$round": [{ "$avg": "$voti" }, 1] }
                        }
                    },
                    { "$sort": { "mediaVoti": -1 } },
                    { "$skip": 1 },
                    { "$limit": 1 }
                ]).toArray();
                break;
            case 39:
                // Caso vuoto (nessuna operazione specificata)
                break;
            case 40:
                // Aggregazione: separa gli elementi dell'array pubblicazioni ($unwind), filtra per editore "einaudi" e anno 2010, poi proietta titolo, autore e l'oggetto pubblicazione
                let regex9 = new RegExp("^einaudi$", "i");
                result = await collection.aggregate(
                [
                    {
                        "$unwind": "$pubblicazioni"     
                    },
                    {
                        "$match": {"pubblicazioni.editore": regex9, "pubblicazioni.anno": 2010}
                    },
                    {
                        "$project": {"_id": 0, "titolo": 1, "pubblicazioni": 1, "autore": 1}
                    }
                
                ]).toArray();
                break;
            }


        console.log(JSON.stringify(result, null, 3))
        if (result instanceof Array)   //instace of verifica che l'object è un array o no (verifica il tipo di un object)
        {
            console.log("numero di record trovati: " + result.length)
        }


    } catch (err: any) {
        console.log("Errore esecuzione query: " + err.status)
    }
    finally {
        await models.closeConnection()
    }
}