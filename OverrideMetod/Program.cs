/*Abstraktna trieda obsahuje abstraktne metody (abstract, virtual)
- abstract -> nesmie sa implementovat v parentovi, musi v childe
- virtual -> musi sa implementovat, moze a nemusi sa overridovat
          -> pri overridovani sa musi zavolat base metoda, inak to porusuje princip dedicnosti
Dedicnost:
- private class -> nie je mozne z nej dedit
- sealed class -> nesmie sa z nej dedit

Metody:
- abstract
- virtual
- override -> rozsirujeme funkcionalitu base triedy, musime ju zavolat napr. base.BaseMethod();
- new -> skryje povodnu metodu
*/
using System;

namespace OverrideMetod
{
    class Program
    {
        static void Main()
        {
            Pes pes = new Pes();
            pes.OblubenaCinnost();
            pes.VydajZvuk();
            Console.WriteLine("-----------------");

            Vozidlo vozidlo1 = new Vozidlo();
            Vozidlo vozidlo2 = new Auto();
            Auto vozidlo3 = new Auto();
            Console.WriteLine("-----------------");

            //Console.WriteLine("Barak1");
            //Budova barak1 = new Budova();
            //barak1.PocetOkien();
            //barak1.PocetPoschodi();
            Console.WriteLine("Barak2");
            Budova barak2 = new Dom();
            barak2.VirtualMethod2();
            barak2.VirtualMethod1();
            Console.WriteLine("Barak3");
            Dom barak3 = new Dom();
            barak3.VirtualMethod2();
            barak3.VirtualMethod1();
            Console.WriteLine("-----------------");

            Console.ReadLine();
        }
    }

    //abstraktna trieda obsahujuca abstraktne metody
    abstract class Zvieratka
    {
        //abstract = nesmie sa implementovat. Jej implementaciu urobime az v metode, ktora z nej dedi
        public abstract void VydajZvuk();

        //virtual = musime implementovat
        public virtual void OblubenaCinnost()
        {
            Console.WriteLine("OblubenaCinnost.");
        }
    }

    //z tejto metody nie je mozne dedit
    sealed class Pes : Zvieratka
    {
        //implementacia abstraktnej metody
        //je nutne ju overridovat
        public override void VydajZvuk()
        {
            Console.WriteLine("Haf.");
        }

        //implementacia virtual metody, prepisujeme jej kod
        //neni treba ju overridovat
        public override void OblubenaCinnost()
        {
            //chyba zavolanie base metody, je to CHYBA, pretoze to potom nesuvisi s dedicnostou
            //Liskov substitution principle (pokrocila technika)
            Console.WriteLine("Hrabanie.");
        }
    }

    //toto nebude fungovat, pretoze trieda Pes je sealed, co znamena ze sa z nej nesmie dedit
    //class Civava : Pes
    //{
    //}

    class Budova
    {
        public virtual void VirtualMethod1()
        {
            Console.WriteLine("Budova - virtual VirtualMethod1.");
        }

        public virtual void VirtualMethod2()
        {
            Console.WriteLine("Budova - virtual VirtualMethod2.");
        }
    }

    class Dom : Budova
    {
        public override void VirtualMethod1()
        {
            //k base ma nikto nenuti ale je to best practice
            base.VirtualMethod1();
            Console.WriteLine("Dom - override VirtualMethod1.");
        }

        public new void VirtualMethod2()
        {
            Console.WriteLine("Dom - new VirtualMethod2.");
        }
    }
}
