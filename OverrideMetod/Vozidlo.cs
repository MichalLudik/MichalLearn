using System;

namespace OverrideMetod
{
    public class Vozidlo
    {
        public Vozidlo()
        {
            Console.WriteLine("Vozidlo.");
        }
    }

    public class Auto : Vozidlo
    {
        public Auto()
        {
            Console.WriteLine("Auto.");
        }
    }

    public class Nakladak
    {
    }
}