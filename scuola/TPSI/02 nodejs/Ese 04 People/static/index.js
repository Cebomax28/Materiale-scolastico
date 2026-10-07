"use strict"

let people;  // vettore enumerativo delle Persone attualmente visualizzate
                 // comodo per gestire i pulsanti di navigazione
let currentPos;   

// i seguenti puntatori sono tutti definiti tramite ID
// let lstCountries 
// let tabStudenti  
// let divDettagli 

// Listeners di evento
btnAdd.addEventListener("click", function(){
	window.location.href = "./inserisci.html"
})

// Avvio
divDettagli.style.display="none"
getCountries()


async function getCountries(){
    let response = await myFetch.sendRequest("GET", "/getCountries");
    if (response.ok){
        console.log(response.data)
        for (const country of response.data)
        {
            // <a class="dropdown-item" href="#">Country</a>
            const a = document.createElement("a");
            a.classList.add("dropdown-item");
            a.href = "#";
            a.textContent = country;
            lstCountries.appendChild(a);

            a.addEventListener("click", function(){
                //dropdownMenuButton.textContent = this.textContent;
                this.parentElement.parentElement.firstElementChild.textContent = this.textContent;
                visualizzaTabella();
            });

        }
    }
    else{
        alert(response.status + ": " + response.err);
    }
}

async function visualizzaTabella(){
    const country = lstCountries.parentElement.firstElementChild.textContent
    const response = await myFetch.sendRequest("GET", "/getPeople", {country});
    if (response.ok){
        console.log(response.data)
        people = response.data;
        tabStudenti.innerHTML = "";

        people.forEach(person => {
            const tr = document.createElement("tr")
            tabStudenti.appendChild(tr);
            
            for (const key in person){
                let td = document.createElement("td");
                tr.appendChild(td);
                if (key == "name"){
                    td.textContent = person[key].title + " " + person[key].first + " " + person[key].last;
                }
                else
                    td.textContent = person[key]
            }

            let td = document.createElement("td")
            tr.appendChild(td)
            let button = document.createElement("button")
            td.appendChild(button)
            button.textContent = "Dettagli"

            td = document.createElement("td")
            tr.appendChild(td)
            button = document.createElement("button")
            td.appendChild(button)
            button.textContent = "Elimina"
        });
        
    }
    else{
        alert(response.status + ": " + response.err);
    }
}