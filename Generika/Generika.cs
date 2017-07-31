/* Najvacsie vyuzitie pri vytvarani kolekcii
 * Metody mozu mat definovanu logiku pre rozne typy dat (ine chovanie pri int, string, abc, ...)
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
 * https://www.dotnetperls.com/generic
 * 
 * Vyhody
 *  - type safety -> pracuje sa vzdy nad jednym datovym typom, nemoze sa stat ze by sa pomiesali napr int a string
 *  - performance -> neprebieha boxing a unboxing
 *  - prepouzitie binarneho kodu -> jeden kod pre viacero datovych typov
 *  
 *  Constrainty - str 119
 */

using System;

namespace Generika
{
    class Generika
    {
        static void Main()
        {
            int a = 1;
            int b = 2;

            string x = "ahoj";
            string y = "serus";

            void Vymen<T>(ref T left, ref T right)
            {
                var temp = right;
                right = left;
                left = temp;
            }

            Vymen(ref a,ref b);
            Vymen(ref x, ref y);

            Zoznam<string> zoznam = new Zoznam<string>("Ahoj");
            zoznam.Vypis();
            Zoznam<double> zoznam2 = new Zoznam<double>(2.2);
            zoznam2.Vypis();
            Zoznam<Clovek> clovek = new Zoznam<Clovek>(new Clovek());
            clovek.Vypis();
            Console.Read();
        }
    }
    public class Clovek { }

    public interface IZoznam<T>
    {
        T MyProperty { get; set; }
    }

    public class Zoznam<T> : IZoznam<T>
    {
        private T properta;
        T IZoznam<T>.MyProperty { get { return properta; } set { value = properta; } }

        public Zoznam(T typ)
        {
            properta = typ;
            //properta = default(T); -> priradi defaultnu hodnotu reference type / value type premennej
        }

        public void Vypis() {
            Console.WriteLine($"{properta.GetType()}");
        }
    }

    //public class Disposable<T> where T : IDisposable
    //{
    //   vyzaduje datovy typ, ktory implementuje IDisposable
    //}

    //public class MusiBytStruktura<T> where T : struct
    //{
    //}

    //public class PozadujeTrieduSKonstruktorom<V> where V : class, new()
    //{
    //}
}
