var kérdések;
var kérdésSorszám = 0;
var helyesValasz;
//var jóVálasz;
var questionId = 4;



   function letöltés() {
        fetch('/questions.json')
            .then(response => response.json())
            .then(data => letöltésBefejeződött(data))
            //.then(data => kérdésMegjelenítés(data));
    }

    function letöltésBefejeződött(d) {
        console.log("Sikeres letöltés")
        console.log(d)
        kérdések = d;
        kérdésekSzáma = d.length;
        kérdésMegjelenítés(kérdésSorszám);
    }

function kérdésMegjelenítés2(kérdés) {
    console.log(kérdés);
    document.getElementById("kérdés_szöveg").innerText = kérdés.questionText
    document.getElementById("válasz1").innerText = kérdés.answer1
    document.getElementById("válasz2").innerText = kérdés.answer2
    document.getElementById("válasz3").innerText = kérdés.answer3
    document.getElementById("kép").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
    kérdésBetöltés(kérdésSorszám);
}

function kérdésBetöltés(id) {
    fetch(`/questions/${id}`)
        .then(response => {
            if (!response.ok) {
                console.error(`Hibás válasz: ${response.status}`)
            }
            else {
                return response.json()
            }
        })
        .then(data => kérdésMegjelenítés(data));
}    

var kérdésMegjelenítés = function (kérdésSzáma) {
    let kérdés_szöveg = document.getElementById("kérdés_szöveg");
    let kép = document.getElementById("kép1");
    let válasz1 = document.getElementById("válasz1");
    let válasz2 = document.getElementById("válasz2");
    let válasz3 = document.getElementById("válasz3");

    kérdés_szöveg.innerHTML = kérdések[kérdésSzáma].questionText
    kép.src = "https://szoft1.comeback.hu/hajo/" + kérdések[kérdésSzáma].image
    válasz1.innerText = kérdések[kérdésSzáma].answer1
    válasz2.innerText = kérdések[kérdésSzáma].answer2
    válasz3.innerText = kérdések[kérdésSzáma].answer3
    helyesValasz = kérdések[kérdésSzáma].correctAnswer
}

window.onload = function () {
    console.log("Oldal betöltve...");
    console.log("minta fut!");

    letöltés();

    document.getElementById("válasz1").onclick = () => {
        if (helyesValasz == 1) {
            document.getElementById("válasz1").classList.remove('valaszKattinthato');
            document.getElementById("válasz1").classList.add('valaszHelyes');
        }
    }

    document.getElementById("válasz2").onclick = () => {
        if (helyesValasz == 2) {
            document.getElementById("válasz2").classList.remove('valaszKattinthato');
            document.getElementById("válasz2").classList.add('valaszHelyes');
        }
    }

    document.getElementById("válasz3").onclick = () => {
        if (helyesValasz == 3) {
            document.getElementById("válasz3").classList.remove('valaszKattinthato');
            document.getElementById("válasz3").classList.add('valaszHelyes');
        }
    }

    document.getElementById("Vissza").onclick = () => {
        if (kérdésSorszám == 0) {
            kérdésSorszám = kérdések.length - 1;
            letöltés();
        }
        else {
            kérdésSorszám--;
            letöltés();
        }

        document.getElementById("válasz1").classList.remove('valaszHelyes');
        document.getElementById("válasz2").classList.remove('valaszHelyes');
        document.getElementById("válasz3").classList.remove('valaszHelyes');

        document.getElementById("válasz1").classList.add('valaszKattinthato');
        document.getElementById("válasz2").classList.add('valaszKattinthato');
        document.getElementById("válasz3").classList.add('valaszKattinthato');
    }

    document.getElementById("Előre").onclick = () => {
        if (kérdésSorszám == kérdések.length - 1) {
            kérdésSorszám = 0;
            letöltés();
            
        }
        else {
            kérdésSorszám++;
            letöltés();
        }

        document.getElementById("válasz1").classList.remove('valaszHelyes');
        document.getElementById("válasz2").classList.remove('valaszHelyes');
        document.getElementById("válasz3").classList.remove('valaszHelyes');

        document.getElementById("válasz1").classList.add('valaszKattinthato');
        document.getElementById("válasz2").classList.add('valaszKattinthato');
        document.getElementById("válasz3").classList.add('valaszKattinthato');
    }
    
    
}



/*function kérdésBetöltés(id) {
    fetch(`/questions/${id}`)
        .then(response => {
            if (!response.ok) {
                console.error(`Hibás válasz: ${response.status}`)
            }
            else {
                kérdésMegjelenítés(response.json())
            }
        })
}

function kérdésMegjelenítés(kérdés) {
    if (!kérdés) return; //Ha undefined a kérdés objektum, nincs mit tenni
    console.log(kérdés);
    document.getElementById("kérdés_szöveg").innerText = kérdés.questionText
    document.getElementById("válasz1").innerText = kérdés.answer1
    document.getElementById("válasz2").innerText = kérdés.answer2
    document.getElementById("válasz3").innerText = kérdés.answer3
    jóVálasz = kérdés.correctAnswer;
    if (kérdés.image) {
        document.getElementById("kép").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
        document.getElementById("kép").classList.remove("rejtett")
    }
    else {
        document.getElementById("kép").classList.add("rejtett")
    }
    //Jó és rossz kérdések jelölésének levétele
    document.getElementById("válasz1").classList.remove("jó", "rossz");
    document.getElementById("válasz2").classList.remove("jó", "rossz");
    document.getElementById("válasz3").classList.remove("jó", "rossz");
}

function előre() {
    questionId++;
    kérdésBetöltés(questionId)
}

function vissza() {
    questionId--;
    kérdésBetöltés(questionId)
}

window.onload = function (e) {
    console.log("Oldal betöltve...");
    document.getElementById("Előre").onclick = előre;
    document.getElementById("Vissza").onclick = vissza;
    kérdésBetöltés(questionId)
}

function választás(n) {
    if (n != jóVálasz) {
        document.getElementById(`válasz${n}`).classList.add("valaszKattinthatoRossz");
        document.getElementById(`válasz${jóVálasz}`).classList.add("valaszKattinthatoJó");
    }
    else {
        document.getElementById(`válasz${jóVálasz}`).classList.add("valaszKattinthatoJó");
    }
}
*/