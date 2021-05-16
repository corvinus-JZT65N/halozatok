var kérdések;
var kérdésSorszám = 0;
var helyesValasz;
var jóVálasz;
var questionId = 1;
var timerHandler;
var questionsInHotList = 3;

var hotList = [];
var következőKérdés = 1;
var kérdésekSzáma;

//   function letöltés() {
//        fetch('/questions.json')
//            .then(response => response.json())
//            .then(data => letöltésBefejeződött(data))
//            //.then(data => kérdésMegjelenítés(data));
//    }

//    function letöltésBefejeződött(d) {
//        console.log("Sikeres letöltés")
//        console.log(d)
//        kérdések = d;
//        kérdésekSzáma = d.length;
//        kérdésMegjelenítés(kérdésSorszám);
//    }

//function kérdésMegjelenítés2(kérdés) {
//    console.log(kérdés);
//    document.getElementById("kérdés_szöveg").innerText = kérdés.questionText
//    document.getElementById("válasz1").innerText = kérdés.answer1
//    document.getElementById("válasz2").innerText = kérdés.answer2
//    document.getElementById("válasz3").innerText = kérdés.answer3
//    document.getElementById("kép").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
//    kérdésBetöltés(kérdésSorszám);
//}

//function kérdésBetöltés(id) {
//    fetch(`/questions/${id}`)
//        .then(response => {
//            if (!response.ok) {
//                console.error(`Hibás válasz: ${response.status}`)
//            }
//            else {
//                return response.json()
//            }
//        })
//        .then(data => kérdésMegjelenítés(data));
//}    

//var kérdésMegjelenítés = function (kérdésSzáma) {
//    let kérdés_szöveg = document.getElementById("kérdés_szöveg");
//    let kép = document.getElementById("kép1");
//    let válasz1 = document.getElementById("válasz1");
//    let válasz2 = document.getElementById("válasz2");
//    let válasz3 = document.getElementById("válasz3");

//    kérdés_szöveg.innerHTML = kérdések[kérdésSzáma].questionText
//    kép.src = "https://szoft1.comeback.hu/hajo/" + kérdések[kérdésSzáma].image
//    válasz1.innerText = kérdések[kérdésSzáma].answer1
//    válasz2.innerText = kérdések[kérdésSzáma].answer2
//    válasz3.innerText = kérdések[kérdésSzáma].answer3
//    helyesValasz = kérdések[kérdésSzáma].correctAnswer
//}

//window.onload = function () {
//    console.log("Oldal betöltve...");
//    console.log("minta fut!");

//    letöltés();

//    document.getElementById("válasz1").onclick = () => {
//        if (helyesValasz == 1) {
//            document.getElementById("válasz1").classList.remove('valaszKattinthato');
//            document.getElementById("válasz1").classList.add('valaszHelyes');
//        }
//    }

//    document.getElementById("válasz2").onclick = () => {
//        if (helyesValasz == 2) {
//            document.getElementById("válasz2").classList.remove('valaszKattinthato');
//            document.getElementById("válasz2").classList.add('valaszHelyes');
//        }
//    }

//    document.getElementById("válasz3").onclick = () => {
//        if (helyesValasz == 3) {
//            document.getElementById("válasz3").classList.remove('valaszKattinthato');
//            document.getElementById("válasz3").classList.add('valaszHelyes');
//        }
//    }

//    document.getElementById("Vissza").onclick = () => {
//        if (kérdésSorszám == 0) {
//            kérdésSorszám = kérdések.length - 1;
//            letöltés();
//        }
//        else {
//            kérdésSorszám--;
//            letöltés();
//        }

//        document.getElementById("válasz1").classList.remove('valaszHelyes');
//        document.getElementById("válasz2").classList.remove('valaszHelyes');
//        document.getElementById("válasz3").classList.remove('valaszHelyes');

//        document.getElementById("válasz1").classList.add('valaszKattinthato');
//        document.getElementById("válasz2").classList.add('valaszKattinthato');
//        document.getElementById("válasz3").classList.add('valaszKattinthato');
//    }

//    document.getElementById("Előre").onclick = () => {
//        if (kérdésSorszám == kérdések.length - 1) {
//            kérdésSorszám = 0;
//            letöltés();
            
//        }
//        else {
//            kérdésSorszám++;
//            letöltés();
//        }

//        document.getElementById("válasz1").classList.remove('valaszHelyes');
//        document.getElementById("válasz2").classList.remove('valaszHelyes');
//        document.getElementById("válasz3").classList.remove('valaszHelyes');

//        document.getElementById("válasz1").classList.add('valaszKattinthato');
//        document.getElementById("válasz2").classList.add('valaszKattinthato');
//        document.getElementById("válasz3").classList.add('valaszKattinthato');
//    }
    
    
//}


document.addEventListener("DOMContentLoaded", () => {
    for (var i = 0; i < questionsInHotList; i++) {
        hotList[i] = {
            question: {},
            jóVálaszokSzáma: 0
        }
    }


    for (let i = 0; i < questionsInHotList; i++) {
        kérdésBetöltés(következőKérdés, i);
        következőKérdés++;
    }


    fetch("questions/count")
        .then(result => result.text())
        .then(n => { Number = parseInt(n) })


    if (localStorage.getItem("hotList")) {
        hotList = JSON.parse(localStorage.getItem("hotList"));
    }

    if (localStorage.getItem("questionId")) {
        questionId = parseInt(localStorage.getItem("questionId"));
    }

    if (localStorage.getItem("következőKérdés")) {
        következőKérdés = parseInt(localStorage.getItem("következőKérdés"));
    }

    if (hotList.length > 0) {
        kérdésBetöltés(következőKérdés, i)
        következőKérdés++;
    } else {
        kérdésMegjelenítés();
    }

});

function kérdésBetöltés(id) {
    fetch(`/questions/${id}`)
        .then(response => {
            if (!response.ok) {
                console.error(`Hibás válasz: ${response.status}`)
            }
            else {
                return response.json()
                hotList = response.json();
            }
        }).then(x=> kérdésMegjelenítés(x))
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
        document.getElementById("kép1").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
        document.getElementById("kép1").style.display = "block";
    }
    else {
        document.getElementById("kép1").style.display = "none";
    }

    for (var i = 1; i <= 3; i++) {
        document.getElementById("válasz" + i).classList.remove("jó", "rossz")
    }

    document.getElementById("válaszok").style.pointerEvents = "auto";
}

function előre() {
    clearTimeout(timerHandler);
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
    var osszeg = n + jóVálasz;

    if (n === jóVálasz) {
        document.getElementById("válasz" + n).classList.add("jó");

        if (n == 1) {
            document.getElementById("válasz2").classList.add("rossz");
            document.getElementById("válasz3").classList.add("rossz");
        } else if (n == 2) {
            document.getElementById("válasz1").classList.add("rossz");
            document.getElementById("válasz3").classList.add("rossz");
        } else {
            document.getElementById("válasz1").classList.add("rossz");
            document.getElementById("válasz2").classList.add("rossz");
        }

        document.getElementById("válaszok").style.pointerEvents = "none";

        hotList[questionId].jóVálaszokSzáma++;
        if (hotList[questionId].jóVálaszokSzáma==3) {
            kérdésBetöltés(questionId + 1);
            questionId++;
            következőKérdés++;
        }
    }
    else {
        document.getElementById("válasz" + n).classList.add("rossz");
        document.getElementById("válasz" + jóVálasz).classList.add("jó");

        if (osszeg < 3) {
            document.getElementById("válasz" + osszeg).classList.add("rossz");
        } else if (osszeg == 4) {
            document.getElementById("válasz" + 2).classList.add("rossz");
        } else {
            document.getElementById("válasz" + 1).classList.add("rossz");
        }
        document.getElementById("válaszok").style.pointerEvents = "none";
    }

    document.getElementById("válaszok").style.pointerEvents = "none";

    timerHandler = setTimeout(előre, 3000);

    localStorage.setItem("", JSON.stringify(hotList));
    localStorage.setItem("questionId", questionId);
    localStorage.setItem("következőKérdés", következőKérdés);
}
