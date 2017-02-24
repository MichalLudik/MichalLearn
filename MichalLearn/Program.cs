using System;

namespace ref_out
{
    
    class Program
    {
        delegate int Cislo(int x);
        static void Main()
        {
            //delegat
            Cislo cislo = Vozidlo.Spocitaj;
            int a = cislo(1);
            Console.WriteLine(a);
            //----

            string x = "Michal";
            string y;

            Vozidlo auto = new Vozidlo();
            Console.WriteLine("Meno pred REF: "+x);
            auto.RefMetoda(ref x);
            Console.WriteLine("Meno po REF: " + x);
            x = "AAA";
            Console.WriteLine("Meno po uprave: " + x);

            auto.OutMetoda(out y);
            Console.WriteLine("Meno po OUT: " + y);

            Console.ReadLine();

        }
    }

    class Vozidlo
    {
        public void RefMetoda(ref string x)
        {
            x = "Ludik";
        }
        
        public void OutMetoda(out string name)
        {
            name = "Michal Ludik";
        }

        public static int Spocitaj(int x)
        {
            return x+x;
        }
    }
}
