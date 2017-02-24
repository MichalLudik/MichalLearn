/*Enum sa inkrementuje od 0
*/
using System;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            int startTyzdna = (int) Dni.Pondelok;
            int koniecTyzdna = (int) Dni.Piatok;
            Console.WriteLine("Pondelok = "+startTyzdna);
            Console.WriteLine("Piatok = "+koniecTyzdna);

            if (Console.ReadLine()==Dni.Pondelok.ToString())
            {
                Console.WriteLine("ANOOO");
            }

            Console.ReadLine();
        }
    }

    public enum Dni
    {
        Pondelok,
        Utorok,
        Streda,
        Stvrtok,
        Piatok,
        Sobota,
        Nedela
    }
}
