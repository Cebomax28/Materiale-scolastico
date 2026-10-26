import { MongoClient, Db, ObjectId } from "mongodb";

const DBNAME = "dbUnicorns"
const CONNECTION_STRING = "mongodb://127.0.0.1:27017"

export interface CustomError extends Error {
        status: number;
}

class Models{
    private client: MongoClient | undefined; // Oggetto che gestisce la comunicazione con il db

    public async connectDB(){
        if (!this.client){
            console.log("Connecting to " + CONNECTION_STRING + ".....");
            this.client = new MongoClient(CONNECTION_STRING);

            try{
                await this.client.connect();
                console.log("Connection to mongodb established");
            } catch (err){
                this.client = undefined;
                this.emitError(503, "MongoDB connection failed " + err);
            } 
        }

    }

    async getDB() : Promise<Db>{
        await this.connectDB();
        return this.client!.db(DBNAME);
    }

    emitError(status: number, msg: string){
    const err = new Error(msg) as CustomError;
    err.status = status;
    throw err;
}
}



const models = new Models()

const collectionName = "unicorns";
executeQuery(1);

async function executeQuery(queryNumber: number){
    try{
        const db = await.models.getDB();
        let collection = db.collection(collectionName);
        let result: any;

        switch (queryNumber){
            case 1:
                result = await collection.find({"weight": {"$gt": 700, "$lt": 800}}).toArray();
                break;
            case 2:
                result = await collection.find({"gender": "m", "loves": "grape", "vampires": {"$gt": 60}}).toArray();
                break;
            case 3:
                result = await collection.find({"$or": [{"gender": "f"}, {"weight": {"$lt": 700}}]}).toArray();
                break;
                
        }
        console.log(result);
        if (result instanceof Array){
            // instanceof si usa solo negli oggetti
            console.log("Numero di record trovati: " + result.length)
        }

    }catch(err: any){
        console.log("Errore esecuzione query: " + err.stack)
    }finally{
        await models.closeConnection();
    }
}



//export default models
