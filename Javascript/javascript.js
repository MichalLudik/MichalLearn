//novy objekt
var zamestnanec = new Object();
zamestnanec.meno = "Michal"; //property
zamestnanec.priezvisko = "Ludik";

function napisNieco(){
    document.write("Meno autora tejto stranky je: "+zamestnanec.meno+" "+zamestnanec.priezvisko);
}

//funkcia s 'this' - odkazuje na objekt ktory bol predany funkcii
function kniha(nazov, autor){
    this.nazov = nazov;
    this.autor = autor;
    this.pridajCenu = pridajCenu; //metoda ako properta
}

function zavolajThisMetodu(){
    var knizka = new kniha("Snehulak", "Jo Nesbo");
    knizka.pridajCenu(250);
    document.write("Mame knizku: ");
    document.write(knizka.autor);
    document.write(" - ");
    document.write(knizka.nazov);
    document.write(" za "+ knizka.cena + " Kc.")
}

function pridajCenu(suma){
    this.cena = suma;
}