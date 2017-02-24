/*Tento programek ukazuje sekvenciu volania statickych fieldov, konstruktorov
a nestatickych fieldov, konstruktorov v bazovej a zdedenej triede pri
inicializacii objektov*/
using System;

namespace Konstruktory
{
    class Program
    {
        static void Main()
        {
            /*
            1. Trieda2 - staticky field
            2. Trieda2 - staticky konstruktor
            3. Trieda2 - nestaticky field
            4. Trieda1 - staticky field
            5. Trieda1 - staticky konstruktor
            6. Trieda1 - nestaticky field
            7. Trieda1 - nestaticky konstruktor
            8. Trieda2 - nestaticky konstruktor
            */
            var konst1 = new Trieda2();
            Console.ReadLine();
        }
    }

    //Base trieda
    public class Trieda1
    {
        //vykona sa ako 4.
        private static readonly string First = "First";

        //vykona sa ako 6.
        private readonly string Second = "Second";

        //vykona sa ako 5.
        static Trieda1()
        {
            
        }

        //vykona sa ako 7.
        public Trieda1()
        {
            Console.WriteLine("Trieda1");
        }
    }

    //Dedic
    public class Trieda2 : Trieda1
    {
        //vykona sa ako 1.
        private static readonly string Third = "Third";

        //vykona sa ako 3.
        private readonly string Fourth = "Fourth";

        //vykona sa ako 2.
        static Trieda2()
        {
            
        }

        //vykona sa ako 8.
        public Trieda2()
        {
            Console.WriteLine("Trieda2");
        }
    }
}
