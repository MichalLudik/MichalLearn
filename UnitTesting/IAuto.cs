using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public interface IAuto
    {
        string znacka { get; set; }
        string farba { get; set; }

        string Nastartuj();

        double Spotreba(int pocetKm, int natankovanychLitrov);
    }
}
