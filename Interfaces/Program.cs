/*Interface je zmluva, ten kto ho implementuje sa zavazuje implementovat vsetky jeho sucasti.
Za zaciatok sa zvykne davat "I" kvoli citatelnosti.
Interface obsahuje len deklaraciu metod, propert, eventov, nie ich implementaciu. Tak je dokoncena v triede ktora ho implementuje.
Je mozne dedit s viacerych interface sucasne -> nutno implementovat vsetky.
Nesmie byt private alebo protected.
*/
using System;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            var bankomat = new Bankomat();
            bankomat.DoplnenieHotovosti();
            bankomat.Vklad();
            bankomat.Vyber();
            Console.WriteLine(bankomat.Zostatok());

            var pracka = new ElektrickySpotrebic();
            pracka.ZavolatServis();
            //pracka.DoplnenieHotovosti(); zavola non implemented vynimku

            Console.ReadLine();
        }
    }

    //toto nebude fungovat, pretoze interface su public alebo internal
    //private interface ISluzby
    //{
    //}

    public interface ITransakcie
    {
        void Vyber();
        void Vklad();
        int Zostatok();

        //interface nesmie obsahovat implementaciu metod, iba ich deklaraciu
        //void Metoda1()
        //{
        //}
    }

    //interface mozu byt dedene
    //internal interface IServis : ITransakcie
    internal interface IServis
    {
        void DoplnenieHotovosti();
        void ZavolatServis();
    }

    //je mozme implementovat viacero interfacov
    public class Bankomat : ITransakcie, IServis
    {
        public void Vyber()
        {
            Console.WriteLine("Prebehol vyber hotovosti.");
        }

        public void Vklad()
        {
            Console.WriteLine("Prebehol vklad hotovosti.");
        }

        public int Zostatok()
        {
            return 100;
        }


        public void DoplnenieHotovosti()
        {
            Console.WriteLine("Bola zavolana sluzba na doplnenie hotovosti.");
        }

        public void ZavolatServis()
        {
            throw new NotImplementedException();
        }
    }

    public class ElektrickySpotrebic : IServis
    {
        public void DoplnenieHotovosti()
        {
            throw new NotImplementedException();
        }

        public void ZavolatServis()
        {
            Console.WriteLine("Spotrebic sa pokazil a bol zavolany technik.");
        }
    }
}
