import fs from "fs/promises" // Versione tradizionale: import fs from "fs"
import states from "./states.json" with {type:"json"}
import radios from "./radios.json" with {type:"json"}

states.forEach(function(state, i){
    let stateRadios = radios.filter(function(item){
        return state.name == item.state;
    })

    state.stationcount = stateRadios.length.toString();

    // Versione promises
    try{
        fs.writeFile("./states.json", JSON.stringify(states));
        console.log("File salvato corretamente")
    } catch (err: any){
        console.log("Errore nel salvataggio del file");
    }

    // Versione tradizionale
    /*
    fs.writeFile("./states.json", JSON.stringify(states), function(err){
        if (err){
            console.log("Errore nel salvataggio del file");
        }
        else
            console.log("File salvato corretamente")
    });
    */
})

