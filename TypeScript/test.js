var message = "123";
var assertion = message;

//assertion = "a"; - nepojde pretoze uz je tam ulozeny number
console.log(message);
console.log(assertion);

function napisMeno(meno, priezvisko, vek) {
    if (typeof vek === "undefined") { vek = 12; }
    console.log("Clovek - " + meno + " " + priezvisko + " " + vek);
}

napisMeno("Michal", "Ludik");
napisMeno("Michal", "Ludik", 28);

function restParametre() {
    var params = [];
    for (var _i = 0; _i < (arguments.length - 0); _i++) {
        params[_i] = arguments[_i + 0];
    }
    var result;
    for (var i; i < params.length; i++) {
        result += params[i];
        console.log(params[i]);
    }
    ;
    console.log(result);
}

restParametre(1, 2);
restParametre(123, 456);

//anonymne funkcie
var anonymFunkce = function (skladatel, pesnicka) {
    console.log("Autor skladby: " + skladatel + "\r\nNazov skladby: " + pesnicka);
};

anonymFunkce("Scooter", "One");

//Function();
var mojaFunkcia = new Function("a", "b", "return a+b");
console.log(mojaFunkcia(5, 7));

//lambda
var foo = function (x) {
    return Math.pow(x, 2);
};
console.log(foo(5));

//tuple - pouziva sa ako pole na ulozenie premennyc rozneho typu
var tuple = [1, "ahoj", true];
console.log("Number: " + tuple[0]);
console.log("String: " + tuple[1]);
console.log("Boolean: " + tuple[2]);
