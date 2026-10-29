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


/*   #################### query ####################### */
const collectionName = "unicorns"
executeQuery(23);



async function executeQuery(queryNumber: number) {
    try {
        const db = await models.getDB()
        const collection = db.collection(collectionName)
        let result: any;

        switch (queryNumber) {
            case 1:
                result = await collection.find({"weight": { "$gt": 700, "$lt": 800 }}).toArray()
                break;
            case 2:
                result = await collection.find({"gender": "m", "loves": "grape", "vampires": { "$gt": 60 }}).toArray()
                break;
            case 3:
                result = await collection.find({"$or": [{ "gender": "f" }, { "weight": { "$lt": 700 } }]}).toArray()
                break;
            case 4:
                result = await collection.find({"vampires": {"$gt": 60}, "$or": [{"loves": "grape"}, {"loves": "apple"}]}).toArray()
                break;
            case 5:
                result = await collection.find({"vampires": {"$gt": 60}, "loves": {"$all": ["grape", "watermelon"]}}).toArray()
                break;
            case 6:
                result = await collection.find({"hair": {"$in": ["brown", "grey"]}}).toArray()
                break;
            case 7:
                result = await collection.find({"vaccinated": {"$ne": true}}).toArray()
                //result = await collection.find({"or": [{"vaccinated": false}, {"vaccinated": {"$exists": false}}]}).toArray()
                break;
            case 8:
                result = await collection.find({"gender": "m", "loves": {"$nin": ["apple"]}}).toArray()
                break;
            case 9:
                const regex = new RegExp("^a", "i")
                result = await collection.find({"gender": "f", "name": regex}).toArray()
                break;
            case 10:
                const id = new ObjectId("6ae1b29a366397246aed95e5");
                result = await collection.find({"_id": id}).toArray()
                break;
            case 11:
                //.skip(1); sono i record che voglio saltare
                result = await collection.find({"gender": "m"}).project({name: 1, vampires: 1, _id: 0}).sort({"vampires": "desc", "weight": "asc"}).limit(3).skip(1).toArray()
                //result = await collection.find({"gender": "m"}, {"projection": {"name": 1, "vampires": 1}}).toArray()
                break;
            case 12:
                //result = await collection.countDocuments({ "weight": {"$gt": 500}}).toArray().length
                result = (await collection.find({ "weight": {"$gt": 500}}).toArray()).length
                break;
            case 13:
                result = await collection.findOne({ "name": "Aurora"}, {"projection": {hair: 1, weight: 1, name: 1, _id: 0}});
                break;
            case 14:
                result = await collection.distinct("loves", {"gender": "f"});
                break;
            case 15:
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
                const regex2 = new RegExp("^minnie$", "i");
                result = await collection.deleteOne({"name": regex2});
                break;  
            case 17:
                result = await collection.updateOne({"name": "Pilot"}, {"$inc": {"vampires": 1}})
                break;  
            case 18:
                result = await collection.updateOne(
                    {"name": "Aurora"}, 
                    {
                        "$addToSet": {"loves": {"$each": ["carrot", "sugar"]}}, 
                        "$inc": {"weight": 10},
                        "$set": {"vaccinated": true}
                    });
                break;  
            case 19:
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
                result = await collection.updateMany(
                    { "vaccinated": {"$exists": false}},
                    {
                        "$set": {"vaccinated": false}
                    }
                )
                break;  
            case 21:
                result = await collection.deleteMany({ "loves": {"$all": ["carrot","grape"]}})
                break;  
            case 22:
                result = await collection.find(
                    { "gender": "f"},
                    {
                         "projection": {name: 1, vampires: 1, _id: 0} 
                    }
                ).sort({"vampires": -1}).limit(1).toArray();
                break;  
            case 23:
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
                result = await collection.find({ }).toArray()
                break;  
            case 25:
                result = await collection.find({ }).toArray()
                break;  
            case 26:
                result = await collection.find({ }).toArray()
                break;  
            case 27:
                result = await collection.find({ }).toArray()
                break;  
            case 28:
                result = await collection.find({ }).toArray()
                break;  
            case 29:
                result = await collection.find({ }).toArray()
                break;      
            case 30:
                result = await collection.find({}).toArray()
                break;                                                                                                                        
        }


        console.table(result)
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