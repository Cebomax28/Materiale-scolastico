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

let collectionName = "F1";

const queryIndex = 10


/*   #################### query ####################### */
executeQuery(queryIndex);



async function executeQuery(queryNumber: number) {
    try {
        const db = await models.getDB()
        const collection = db.collection(collectionName)
        let result: any;

        switch (queryNumber) {
        case 1:
            result = await collection.find({"pneumatici": "Pirelli", "motore": "Ferrari"}, {"projection": {"scuderia": 1, "pneumatici": 1, "motore": 1, "_id": 0}}).toArray()
            break;
        case 2:
            result = await collection.find({"motore": {"$nin": ["Ferrari", "Mercedes"]}}, {"projection": {"scuderia": 1, "motore": 1, "_id": 0}}).toArray()
            break;
        case 3:
            result = await collection.find({}, {"projection": {"_id": 0, "scuderia": 1, "punti_totali": 1}}).sort("punti_totali", -1).toArray()
            break;
        case 4:
            let regex1 = new RegExp("rosso", "i");
            let regex2 = new RegExp("arancione", "i");
            result = await collection.find({"colori": {"$in": [regex1, regex2]}}, {"projection": {"_id": 0, "scuderia": 1, "colori": 1}}).toArray()
            break;
        case 5:
            let regex3 = new RegExp("AlphaTauri", "i");
            result = await collection.updateOne(
                    {"scuderia": regex3}, 
                    {
                        "$set": {"pneumatici": "Goodyear", "info.nazionalità": "USA", "info.countryCode": "US"}
                    });
            break;
        case 6:
            result = await collection.find({"pneumatici": "Pirelli", "info.mondiali_vinti": {"$gt": 5}}, {"projection": {"_id": 0, "scuderia": 1, "info.mondiali_vinti": 1}}).sort("info.mondiali_vinti", -1).toArray()
            break;
        case 7: 
            result = await collection.find(
                {"piloti": {"$elemMatch": {"nazione": "Regno Unito", "punti": {"$gt": 10}}}},
                {"projection": {"_id": 0, "scuderia": 1, "piloti.nome.$": 1, "piloti.punti": 1}}
            
        ).toArray()
            break;
        case 8:
            result = await collection.aggregate([
                {"$unwind": "$piloti"},
                {"$group": {"_id": {}, "etaMedia": {"$avg": "$piloti.eta"}}},
                {"$project": {"_id": 0, "etaMedia": 1}}
            ]
            ).toArray();
            break;
        case 9: 
            result = await collection.aggregate([
                {"$unwind": "$piloti"},
                {"$group": {"_id": "$piloti.nazione", "numPiloti": {"$sum": 1}, "etaMedia": {"$avg": "$piloti.eta"}}},
                {"$match": {"numPiloti": {"$gt": 1}}},
                {"$project": {"numPiloti": 1, "etaMedia": 1, "nazione": "$_id", "_id": 0}},
                {"$sort": {"etaMedia": 1}}
            ]).toArray();
            break;

        case 10:
            let regex5 = new RegExp("Red Bull", "i");
            let regex6 = new RegExp("Verstappen", "i");
            result = await collection.updateMany({"scuderia": regex5, "piloti.nome": regex6}, {"$inc": {"punti_totali": 2, "piloti.$.punti": 2}})

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