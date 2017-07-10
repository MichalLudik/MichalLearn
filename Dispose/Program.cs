/* po zavolani Dispose sa objekt zahodi a nie je mozne ho revertnut alebo volat jeho metody
 * viacnasobne zavolanie Dispose(); nevyhadzuje exception
 * ak objekt Auto pouziva objekt Motorka, pri zavolani Auto.Dispose() sa zavola automaticky aj Motorka.Dispose()
 * 
 * Dispose() by sa malo volat na 'unmanaged resources' -> praca so subormi, sietove spojenie, ...
 */

using System;
using System.IO;

namespace Dispose
{
    class Program
    {
        static byte[] fileBuffer;
        static void Main()
        {
            using (FileStream subor = new FileStream("text.txt", FileMode.Open))
            using (FileStream fs = new FileStream("text.txt", FileMode.Open)) {
                fs.Read(fileBuffer, 10, 10);
                var name = subor.Name;
            }

            //takto kompilator prekoduje using vyssie
            //FileStream fStream = new FileStream("text.txt", FileMode.Open);
            //try {
            //    fStream.Read(fileBuffer, 10, 10);
            //}
            //finally
            //{
            //    if (fStream != null) ((IDisposable)fStream).Dispose();
            //}
        }
    }

    //trieda definujuca vlastny dispose pristup
    sealed class Auto : IDisposable
    {
        public void Dispose()
        {
            // ToDo
        }
    }
}
