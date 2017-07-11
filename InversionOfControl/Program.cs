/* Suvisi s DIWindsorContainer
 * 
 * *https://www.codeproject.com/Articles/615139/An-Absolute-Beginners-Tutorial-on-Dependency-Inver
 * *http://joelabrahamsson.com/inversion-of-control-an-introduction-with-examples-in-net/
 * *https://msdn.microsoft.com/en-us/library/ff921087.aspx
 * 
 * https://www.codementor.io/copperstarconsulting/getting-started-with-dependency-injection-using-castle-windsor-4meqzcsvh
 * https://roland.kierkels.net/c-asp-net/dependency-injection-using-castle-windsor/
 * http://www.codeguru.com/columns/experts/implementing-the-inversion-of-control-pattern-in-c.htm
 * 
 * IoC - pattern na implementaciu Dependency Inversion
 *     - je mozne ho implementovat aj pomocou Service Locatoru
 *     
 * Dependency Inversion - High-level moduly nezavisia na low-level moduloch. Oboje zavisia na abstrakciach
 *                      - Abstrakcie nezavisia na detailoch ale opacne
 *                      
 * Constructor injection - vkladame priamo do konstruktoru, rovnaky objekt plati pri volani akejkolvek funkcie pocas jeho existencie
 * Method injection - je mozne pouzit vzdy novy objekt pocas kazdeho spustenia metody
 */


// Trieda Pracovnik je zavisla na triede Lopata
//class Pracovnik
//{
//    Lopata konkretnaLopata = new Lopata();
//}
//class Lopata
//{ 
//}

namespace InversionOfControl
{
    class Program
    {
        static void Main()
        {

        }
    }

    public interface IPouziLopatu
    {
        void AkciaPriPouzitiLopaty(string message);
    }

    class Pracovnik
    {
        IPouziLopatu pouziLopatu = null;

        public void Kopaj()
        {
            if (pouziLopatu != null)
            {
                //namapovanie Interface na konkretnu triedu
            }
        }
    }

    class ConstructorInjection
    {
        private IPouziLopatu lopata;

        public ConstructorInjection(IPouziLopatu konkretnaLopata)
        {
            lopata = konkretnaLopata;
        }
    }

    class MethodInjection
    {
        private IPouziLopatu lopata;

        public void NiecoNapis(IPouziLopatu konkretnaLopata)
        {
            lopata = konkretnaLopata;
            lopata.AkciaPriPouzitiLopaty("halo");
        }
    }
}
