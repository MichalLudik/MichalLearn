using System;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;

namespace Eventy
{
    class Program
    {
        static void Main()
        {
            const string Retazec = "ababcdefagha";

            Subor file = new Subor(Retazec);
            file.ReaderEvent += (sender, e) => { Console.WriteLine("aa"); };
            file.ReaderEvent += NapisNieco;
            file.Read(SuborFarba.Cervena);
            Console.ReadLine();
        }

        static void NapisNieco(object sender, FileEventArgs e)
        {
            Console.WriteLine($"Pismenko najdene: {e.Vlastnost}.");
        }
    }

    class Subor
    {
        private readonly string Retazec;

        public event EventHandler<FileEventArgs> ReaderEvent;

        public Subor(string retazec)
        {
            Retazec = retazec;
        }

        public void Read(SuborFarba vlastnost)
        {
            Console.WriteLine(Retazec);
            foreach (var letter in Retazec)
            {
                if (letter == 'a')
                {
                    System.Threading.Thread.Sleep(500);
                    OnLetterFound(this,vlastnost);
                }
            }
        }

        protected void OnLetterFound(object sender, SuborFarba vlastnost)
        {
            var delegat = ReaderEvent;
            delegat?.Invoke(this,new FileEventArgs(vlastnost));
        }

    }

    public enum SuborFarba
    {
        Cervena,
        Modra,
        Fialova,
        Biela
    }

    public class FileEventArgs : EventArgs
    {
        public SuborFarba Vlastnost { get; set; }

        public FileEventArgs(SuborFarba vlastnost)
        {
            Vlastnost = vlastnost;
        }
    }
}
