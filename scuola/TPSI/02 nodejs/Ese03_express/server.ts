import http from "http";
import fs from "fs";
import express from "express";

/* ============ CONFIGURAZIONE ============*/
const port = 3000;
let paginaErrore = "";
const app = express();

/* ============ MIDDLEWARE ============*/
// A - Request Log
app.use("/", function (req, res, next){
    console.log(`----> ${req.method} : ${req.originalUrl}`);
});

// B - Gestione delle risorse statiche
app.use("/", express.static("./static"));

// C - Lettura e Parsing dele risorse statiche
// Restituiscono i parametri POST (parsificati) al'interno di request.body
app.use("/", express.json({"limit": "50mb"}));
app.use("/", express.urlencoded({"limit": "50mb", "extended": true}));

// D - Lettura e Parsing dei parametri GET
// I parametri GET sono disponibili come stringa dentro a request.query
app.use("/", function(req, res, next){
    if (req.query)
    {
        let parsedQuery : any = [];
        for (const key in req.query)
        {
            let value : any = req["query"][key];
            try
            {
                parsedQuery[key] = JSON.parse(value);
            } 
            catch (err)
            { // Le stringhe semplici rimangono come sono, non vengono parsificate
                parsedQuery[key] = value;
            }
        }
        // Questa riga non funziona perchè non è possibile sovrascrivere req.query
        // req.query = parsedQuery;
        Object.defineProperty(req, "query", {
            value : parsedQuery,
            writable: true, // Permtette modifiche future se necessario
            enumerable: true, // Lo rende visibile nei ciclie e nei log
            configurable: true // Permette di sovrascriverlo di nuovo
        });
    }
    next();
});

// E - Log dei parametri
app.use("/", function(req, res, next){
    if (req.query && Object.keys(req.query).length > 0){
        console.log(`ParamQuery: ${JSON.stringify(req.query)}`);
    }  
    
    if (req.body && Object.keys(req.query).length > 0){
        console.log(`ParamQuery: ${JSON.stringify(req.body)}`);
    }  
})

/* ============ DISPATCHING (SMISTAMENTO DELLE RICHIESTE) ============*/
// .sendRequest("GET", "/richiesta1?id=3", params)
// Route per servire /richiesta1
app.get("/api/richiesta1", function(req, res, next){
    const params = req.query;
    if (params)
        res.send(params); // Se params è un JSON viene automaticamente SERIALIZZATO
    else
        res.status(400).send("Parametri mancanti");
});

/* ============ DEFAULT RUOTE (GESTIONE DEGLI ERRORI) ============*/
/* ============ CREAZIONE AVVIO DEL SERVER ============*/

const server = http.createServer(app);
function startServer(){
    fs.readFile("./static/error.html", function(err, data){
        if (err)
            paginaErrore = "<h2> Risorsa non trovata </h2>"
        else
            paginaErrore = data.toString();
    })

    server.listen(port, function(){
        console.log("server in ascolto sulla porta: " + port);
    }) 
}
startServer();