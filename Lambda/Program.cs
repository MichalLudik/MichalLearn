using System;
using System.Security.Cryptography.X509Certificates;

namespace Lambda
{
    delegate int AddDelegate(int a, int b);

    public delegate int Del(int x, int y);
    class Program
    {
        static void Main()
        {
            AddDelegate ad = (x, y) => x*y;
            Console.WriteLine(ad(5, 6));

            var bbb = ad.Invoke(10, 20);
            Console.WriteLine(bbb);

            //-----
            Del del1 = (x, y) => x + y;
            Del del2 = (x, y) => x * y;

            Pocty pocty = new Pocty();
            pocty.Pocitaj(5, 6, del1);
            pocty.Pocitaj(5, 6, del2);
            //-----

            Action<int, int> mojaAkcia = (x, y) => Console.WriteLine(x*y);
            pocty.VykonajAkciu(5,10,mojaAkcia);
            Console.ReadLine();
        }
    }

    public class Pocty
    {

        public void Pocitaj(int x, int y, Del del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }

        public void VykonajAkciu(int x, int y, Action<int, int> akcia)
        {
            akcia(x, y);
        }
    }
}
