"use strict"

let people;  // vettore enumerativo delle Persone attualmente visualizzate
                 // comodo per gestire i pulsanti di navigazione
let currentPos;   

// i seguenti puntatori sono tutti definiti tramite ID
// let lstCountries 
// let tabStudenti  
// let divDettagli 

const dettagliImg = divDettagli.querySelector("img");
const dettagliTitle = divDettagli.querySelector("h5");
const dettagliText = divDettagli.querySelector("p");
const btnNavigazione = divDettagli.querySelectorAll("a");


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

        people.forEach((person, index) => {
            const tr = document.createElement("tr")
            tabStudenti.appendChild(tr);
            
            for (const key in person){
                let td = document.createElement("td");
                tr.appendChild(td);
                if (key == "name"){
                    td.textContent = convertName(person.name)
                }
                else
                    td.textContent = person[key]
            }

            let td = document.createElement("td")
            tr.appendChild(td)
            let button = document.createElement("button")
            td.appendChild(button)
            button.textContent = "Dettagli"
            button.addEventListener("click",function(){
                currentPos = index;
                visualizzaDettagli(person["name"])
            } );

            td = document.createElement("td")
            tr.appendChild(td)
            button = document.createElement("button")
            td.appendChild(button)
            button.textContent = "Elimina";
            button.addEventListener("click", function(){
                elimina(person.name);
            })
        });
        
    }
    else{
        alert(response.status + ": " + response.err);
    }

}

function convertName(name){
    return `${name.title} ${name.first} ${name.last}`
}


async function visualizzaDettagli(name){
    const response = await myFetch.sendRequest("GET", "/getDetails", {name});
    if (response.ok){
        console.log(response.data)
        const person = response.data;
        divDettagli.style.display = "";
        if (person.picture.large){
            dettagliImg.src = person.picture.large
        }
        else{
            dettagliImg.src = "./img/user.png" // Immagine di default
        }

        dettagliTitle.textContent = convertName(person.name)
        dettagliText.innerHTML = 
        `
        <b>gender</b>: ${person.gender} <br/>
        <b>address</b>: ${JSON.stringify(person.location)} <br/>
        <b>email</b>: ${person.email} <br/>
        <b>dob</b>: ${JSON.stringify(person.dob)} <br/>
        `
    }
    else{
        alert(response.status + ": " + response.err);
    }
}

async function elimina(name){
    if (confirm("Sei sicuro di voler rimuovere questa persona?")){
         const response = await myFetch.sendRequest("DELETE", "/delete", name)
        if (response.ok){
            console.log(response.data);
            divDettagli.innerHTML = "";
            divDettagli.style.display = "none"
            alert("Record rimosso corretamente")
            visualizzaTabella();
        }
        else{
            alert(response.status + ": " + response.err);
        }
    }
}

btnNavigazione[0].addEventListener("click", function(){
    if (currentPos != 0){
        currentPos = 0
        visualizzaDettagli(people[currentPos].name)
    }
})

btnNavigazione[1].addEventListener("click", function(){
    if (currentPos > 0){
        currentPos--
        visualizzaDettagli(people[currentPos].name)
    }
})

btnNavigazione[2].addEventListener("click", function(){
    if (currentPos < people.length - 1){
        currentPos++
        visualizzaDettagli(people[currentPos].name)
    }
})

btnNavigazione[3].addEventListener("click", function(){
     if (currentPos != people.length - 1){
        currentPos = people.length - 1;
        visualizzaDettagli(people[currentPos].name)
    }
})