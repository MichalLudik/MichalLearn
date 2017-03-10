using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    internal class Auto :IAuto
    {
        public Auto(string znacka = "skoda", string farba = "modra")
        {
            this.znacka = znacka;
            this.farba = farba;
        }

        public string znacka { get; set; }
        public string farba { get; set; }
        public string Nastartuj()
        {
            return "Vrci";
        }

        public double Spotreba(int pocetKm, int natankovanychLitrov)
        {
            return natankovanychLitrov/pocetKm/100;
        }
    }
}
