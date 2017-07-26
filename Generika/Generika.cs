/* Najvacsie vyuzitie pri vytvarani kolekcii
 * Metody mozu mat definovanu logiku pre rozne typy dat (ine chovanie pri int, string, abc, ...)
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
 * Vyhody
 *  - type safety -> pracuje sa vzdy nad jednym datovym typom, nemoze sa stat ze by sa pomiesali napr int a string
 *  - performance -> neprebieha boxing a unboxing
 *  - prepouzitie binarneho kodu -> jeden kod pre viacero datovych typov
 */

using System.Collections;

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
        }
    }
}
