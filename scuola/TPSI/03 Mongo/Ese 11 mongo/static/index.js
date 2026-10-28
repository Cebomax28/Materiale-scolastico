const btns = document.querySelectorAll("button")
const tbody = document.getElementsByTagName("tbody")[0];
// Visualizza unicorni
btns[0].addEventListener("click", visualizza)


btns[1].addEventListener("click", aggiungiDocumento)
btns[2].addEventListener("click", aggiornaDocumento)
btns[3].addEventListener("click", eliminaDocumento)


async function visualizza() {
    const gender = document.querySelector("input[type=radio]:checked").value
    const response = await myFetch.sendRequest("GET", "/getUnicorns/" + gender)
    if (response.ok) {
        console.log(response.data);

        tbody.innerHTML = ""
        for (const unicorn of response.data) {
            const tr = document.createElement("tr")
            tbody.appendChild(tr)
            for (const key in unicorn) {
                const td = document.createElement("td")
                td.textContent = unicorn[key]
                tr.appendChild(td)

                if (key == "_id") {
                    td.style.cursor = "pointer"
                    td.addEventListener("click", getUnicorn)
                }
            }
        }
    }
    else
        alert(response.status + ": " + response.err)
}


async function getUnicorn() {

    const id = this.textContent;
    const response = await myFetch.sendRequest("GET", "getUnicorn/" + id);

    if (response.ok) {

        alert(JSON.stringify(response.data))
    } else {

        alert(response.status + ": " + response.err)
    }
}

async function aggiungiDocumento() {
    const unicorn = {
        "name": txtName.value,
        "dob": (new Date()).toLocaleDateString().replaceAll("/", "-"),
        "loves": ["wartermelon", "grapes"],
        "weight": 100,
        "gender": document.querySelector("input[name=gender]:checked").value,


    }
    const response = await myFetch.sendRequest("POST", "addUnicorn", { unicorn })
    if (response.ok) {
        console.log(response.data)
        alert("record aggiunto correttamente")
        visualizza();
    } else {
        alert(response.status + ": " + response.err)
    }

}

async function aggiornaDocumento() {
    let name = txtName.value;

    const response = await myFetch.sendRequest("PATCH", "updateUnicorn/" + name, { "hair": "blonde" })  //myfetch toglie gli slash quindi è uguale metterli o no

    if (response.ok) {
        console.log(response.data)
        alert("record aggiornato correttamente")
        visualizza();
    } else {
        alert(response.status + ": " + response.err)
    }
}

async function eliminaDocumento() {
    let name = txtName.value;
    const response = await myFetch.sendRequest("DELETE", "deleteUnicorn/" + name)

    if (response.ok) {
        console.log(response.data)
        alert("record eliminato correttamente")
        visualizza();
    } else {
        alert(response.status + ": " + response.err)
    }
}