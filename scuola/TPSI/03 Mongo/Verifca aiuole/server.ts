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

let collectionName = "aiuole";

const queryIndex = 6


/*   #################### query ####################### */
executeQuery(queryIndex);



async function executeQuery(queryNumber: number) {
    try {
        const db = await models.getDB()
        const collection = db.collection(collectionName)
        let result: any;

        switch (queryNumber) {
            case 1:
                // Trovare tutte le aiuole dove la coltura principale è "Basilico" oppure "Sedano".
                // Riportare nome della’aiuola, coltura principale e modello del sensore utilizzato.

                result = await collection.find({"colturaPrincipale": {"$in": ["Basilico", "Sedano"]}}, {"projection": {"nomeAiuola": 1, "colturaPrincipale": 1, "sensorePrincipale.modello": 1, "_id": 0}}).toArray()
                break;
            case 2:
                // Trovare tutte le aiuole con superficie maggiore o uguale a 15 m², ordinati in modo decrescente
                // Riportare nome della’aiuola e superficie.
                result = await collection.find({"superficie": {"$gte": 15}}, {"projection": {"nomeAiuola": 1, "superficie": 1, "_id": 0}}).sort({"superficie": 1}).toArray()
                break;
            case 3:
                // Trovare tutte le aiuole dove tra i parassiti rilevati ci sono sia le lumache che gli acari
                // Riportare nome dell’aiuola, coltura Principale e parassiti rilevati.
                result = await collection.find({"parassitiRilevati": {"$all": ["lumache", "acari"]}}, {"projection": {"nomeAiuola": 1, "colturaPrincipale": 1, "parassitiRilevati": 1, "_id": 0}}).toArray()
                break;
            case 4:
                // Trovare tutte le aiuole della zona Centrale in cui i sensori hanno una percentuale residua di batteria inferiore
                // al 80% , ordinate per superficie decrescente. Riportare nome dell’aiuola, superficie e tutte le
                // informazioni relative al sensore.
                let regex = new RegExp("^Aiuola Centrale", "i");
                result = await collection.find({"nomeAiuola": regex, "sensorePrincipale.batteria_percent": {"$lt": 80}}, {"projection": {"nomeAiuola": 1, "_id": 0, "superficie": 1, "sensorePrincipale": 1}}).sort({"superficie": -1}).toArray()
                break;
            case 5:
                // Trovare tutte le aiuole che hanno almeno una rilevazione giornaliera con umidita maggiore di 40 % e
                // acquaUtilizzata maggiore di 12 litri. Visualizzare il nome dell’aiuola e tutti i dati della singola
                // rilevazione che ha dato match.
                result = await collection.aggregate([
                    {"$unwind": "$rilevazioniGiornaliere"},
                    {"$match": {"rilevazioniGiornaliere.umidita": {"$gt": 40}, "rilevazioniGiornaliere.acquaUtilizzata": {"$gt": 12}}},
                    {"$project": {"_id": 0, "nomeAiuola": 1, "rilevazioniGiornaliere": 1}}
                ]).toArray()
                break;
            case 6:
                // Scrivere un comando che imposti a true il campo irrigazioneAutomatica dell’aiuola "Aiuola
                // Est-2" che si può scrivere liberamente in formato case in-sensitive

                let regex1 = new RegExp("^Aiuola Est-2$", "i");
                result = await collection.updateOne({"name": regex1}, {"$set": {"irrigazioneAutomatica": true}})
                break;
            case 7:
                result = await collection.find({"vaccinated": {"$ne": true}}).toArray()
                //result = await collection.find({"or": [{"vaccinated": false}, {"vaccinated": {"$exists": false}}]}).toArray()
                break;
            case 8:
                result = await collection.find({"gender": "m", "loves": {"$nin": ["apple"]}}).toArray()
                break;
            case 9:
                result = await collection.find({"gender": "f"}).toArray()
                break;
            case 10:
                const id = new ObjectId("6ae1b29a366397246aed95e5");
                result = await collection.find({"_id": id}).toArray()
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