import { Router } from "express"
import peopleObject from "./people.json" with {type: "json"}

// Config
const app = Router()
let people = peopleObject.results;

//routes
app.get("/getCountries", function(req, res, next){
    const countries = people.map(function(person){
        return person.location.country; // Se ci sono i duplicati li mette!
    });
    // Trasformo il vettore in un set eliminando i duplicati
    const results = new Set(countries)
    // L ho ritrasfrormo in array
    const resultsArray = Array.from(results);
    resultsArray.sort();
    res.send(resultsArray);
});

app.get("/getPeople", function(req, res, next){
    const country = req.query.country;
    const filteredPeople = people.filter(function(person){
        return person.location.country == country;
    })
    const result = filteredPeople.map(function(person){
        return {
            "name" : person.name,  // json completo con i 3 sottocampi
            "city" : person.location.city ,
            "state" : person.location.state ,
            "cell" : person.cell

        }
    })
    res.send(result);
})

// se nessuna route viene eseguita,
// automaticamente il controllo ritorna al file principale

export default app