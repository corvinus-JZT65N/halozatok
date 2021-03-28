var kérdések;
var kérdésSorszám = 0;

    function letöltés() {
        fetch('/questions.json')
            .then(response => response.json())
            .then(data => letöltésBefejeződött(data));
    }

    function letöltésBefejeződött(d) {
        console.log("Sikeres letöltés")
        console.log(d)
        kérdések = d;
        kérdésekSzáma = d.length;
        kérdésMegjelenítés(kérdésSorszám);
    }

var kérdésMegjelenítés = function (kérdésSzáma) {
    let kérdés_szöveg = document.getElementById("kérdés_szöveg");
    let kép = document.getElementById("kép1");
    let válasz1 = document.getElementById("válasz1");
    let válasz2 = document.getElementById("válasz2");
    let válasz3 = document.getElementById("válasz3");
    let helyesValasz;

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

    document.getElementById("Vissza").onclick = () => {
        if (kérdésSorszám == 0) {
            kérdésSorszám = kérdések.length - 1;
            letöltés();
        }
        else {
            kérdésSorszám--;
            letöltés();
        }
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
    }
}



