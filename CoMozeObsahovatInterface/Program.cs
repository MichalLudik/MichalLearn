/*
Interface moze obsahovat metody void alebo s navratovym typom a property.
Neobsahuju staticke cleny, fieldy, konstanty, enumy...
*/namespace CoMozeObsahovatInterface
{
    class Program
    {
        static void Main()
        {
        }
    }

    interface IRozhranie
    {
        void Metoda0();
        string Metoda1();
        string Property { get; set; }

        //cleny interface su vzdy public
        //private void Metoda2();
        //protected void Metoda3();
        //internal void Metoda4();

        //interface neimplementuje staticke fieldy a metody
        //static void Metoda5();
        //static string StaticString;

        //interface neimplementuje ziadne fieldy
        //string nazov;

        //interface neimplementuje konstanty
        //const string konstanta = "konstanta";
    }
}
