using System;

namespace Eventy1
{
    public delegate void PisanieZvukov(Zver zvieratko);
    class Program
    {
        static void Main()
        {
            Zvieratko psik = new Zvieratko();
            psik.ZrobCosi(2, 3, (x, y) => x + y);
            psik.ZrobCosi(2, 3, (x, y) => x * (y + 7));
            psik.NapisZvuk += Pis;
            psik.VydajZvuk(Zver.Pes);            
            
            Console.ReadLine();
        }

        private static void Pis(Zver zvieratko)
        {
            Console.WriteLine($"Zvieratko '{zvieratko}' vydava zvuk.");
        }
    }

    public class Zvieratko
    {
        
        public event PisanieZvukov NapisZvuk;
        public void VydajZvuk(Zver zvieratko)
        {
            Random random = new Random();
            while (true)
            {
                OnVydajZvuk(zvieratko);
                System.Threading.Thread.Sleep(random.Next(100,2000));
            }
        }

        private void OnVydajZvuk(Zver zvieratko)
        {
            var del = NapisZvuk;
            del?.Invoke(zvieratko);
        }

        public void ZrobCosi(int x, int y, Func<int, int, int> cosiUrob)
        {
            var result = cosiUrob(x,y);
            Console.WriteLine(result);
        }
    }

    public enum Zver
    {
        Pes,
        Macka,
        Krokodil,
        Hus
    }
}
