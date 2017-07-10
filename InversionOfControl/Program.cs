/* IoC - pattern na implementaciu Dependency Inversion
 * Dependency Inversion - High-level moduly nezavisia na low-level moduloch. Oboje zavisia na abstrakciach
 *                      - Abstrakcie nezavisia na detailoch ale opacne
 *  
 */

 
// Trieda Pracovnik je zavisla na triede Lopata
//class Pracovnik
//{
//    Lopata lopata = new Lopata();
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
        void AkciaPriPouzitiLopaty();
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
}
