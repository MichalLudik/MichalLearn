/*Explicitna implementacia interface sa hodi v pripade, ze mame 2 interface s rovnakymi metodami a chceme ich rozlisit.
Nie je mozne k nemu pristupit cez instanciu triedy ale cez instanciu interface.
*/

using System;

namespace InterfacesExplicitne
{
    class Program
    {
        static void Main()
        {
            var clovek = new Clovek();

            //volame metodu Cloveka
            clovek.Chod();

            //volame metodu interfacov
            ((IPomaly)clovek).Chod();
            ((IRychlo)clovek).Chod();

            Console.ReadLine();
        }
    }

    public interface IPomaly
    {
        void Chod();
    }

    interface IRychlo
    {
        void Chod();
    }

    public class Clovek : IPomaly, IRychlo
    {
        //metoda patriaca triede Clovek
        public void Chod()
        {
            Console.WriteLine("Serus.");
        }

        //explicitna implementacia, brani konfliktu 3 metod
        //metoda patriaca interfacu IPomaly
        void IPomaly.Chod()
        {
            Console.WriteLine("IPomaly chod.");
        }

        //metoda patriaca interfacu IRychlo
        void IRychlo.Chod()
        {
            Console.WriteLine("IRychlo chod.");
        }
    }
}
