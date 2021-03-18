window.onload = function () {
console.log("Oldal betöltve...");
    console.log("minta fut!")


    var faktoriális = function (n) {
        let eredmeny = 1;

        for (var i = 2; i <= n; i++) {
            eredmeny = eredmeny * i;
        }
        return eredmeny;
    }

document.wriln("<div id='pascal'>");
    console.log("betöltődött")
for (var i = 0; i < 10; i++) {
    document.write("<div class='sor'>");
    for (var j = 0; j <= i; j++) {
        var eredmeny = 1;
        eredmeny = faktoriális(i) / (faktoriális(j) * (faktoriális(i - j)));
        document.write("<div class='elem'>"+eredmeny+"</div>")
    }
    document.write('</div>');
    }
    document.write('</div>');
}