import { MongoClient, Db, ObjectId } from "mongodb";
import { error } from "node:console";
import dotenv from "dotenv"


dotenv.config({ path: ".env" })

const DBNAME = process.env.DBNAME
const CONNECTION_STRING = process.env.CONNECTION_STRING_LOCAL!

export interface CustomError extends Error {
    status: number
}

class Models {
    private client: MongoClient | undefined //oggetto che gestisce la comunicazione con il db

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

    private async getDB(): Promise<Db> {
        /*se openCollection fallisce essendoci l'await, la procedura si interrompe immediatamente 
        //rimandando l'errore al chiamante.
        se il chiamante riceve una promise fallita,
        anche lui termina immediatamente rimandando l'errore al chiamante */

        await this.openConnection()
        // .db accede ai databesa memorizzati sul DBMS

        //non effettua nessuna operazione di rete
        //anche se il db non esiste non va in errore
        return this.client!.db(DBNAME)
    }


     async closeConnection() {
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

    // ************** USER METHODS ************* //

    collectionName = "unicorns"

    async getData(gender?: string) {
        //accedo al database
        const db = await this.getDB()
        //accedo alla collezione


        //in coda a find occorre 
        // se il db o la collection non esistono, restituisce un array vuoto.
        const collections = db.collection(this.collectionName)
        return await collections.find({ "gender": gender }).toArray()
    }

    async getDataById(idValue: string) {
        const db = await this.getDB()
        const collections = db.collection(this.collectionName)

        const id = this.getObjectId(idValue)
        const data = await collections.findOne({ "_id": id as any })


        if (!data) {
            this.emitError(404, "Documento non trovato");
        }
        else
            return data;
    }

    async addDocument(document: any) {
        const db = await this.getDB()
        const collection = db.collection(this.collectionName)
        const result = await collection.insertOne(document)

        if (!result) {
            this.emitError(500, "Inserimento non riuscito");
        } else
            return result;
    }
    async updateDocumentByName(name: string, action: any) {
        const db = await this.getDB()
        const collection = db.collection(this.collectionName)

        //creo un campo json con il name(dato che accetta i json) e action non tra graffe pk è gia un json
        const result = await collection.updateOne({ name }, { "$set": action })

        if (result.matchedCount == 0) {
            this.emitError(404, "Aggiornamento non riuscito, Documento non trovato");
        } else
            return result;
    }

    async deleteDocumentByName(name: string) {
        const db = await this.getDB()
        const collection = db.collection(this.collectionName)

        const result = await collection.deleteOne({ name })

        if (result.deletedCount == 0) {
            this.emitError(404, "Cancellazione non riuscita, documento non trovato");
        } else
            return result;
    }
}


const models = new Models()

process.on("SIGINT", async() => {
    await models.closeConnection()
    console.log("connessione al database terminata correttamente")
    process.exit();
})


export { models }
//export default models
