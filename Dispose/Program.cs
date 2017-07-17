/* po zavolani Dispose sa objekt zahodi a nie je mozne ho revertnut alebo volat jeho metody
 * viacnasobne zavolanie Dispose(); nevyhadzuje exception
 * ak objekt Auto pouziva objekt Motorka, pri zavolani Auto.Dispose() sa zavola automaticky aj Motorka.Dispose()
 * 
 * Dispose() by sa malo volat na 'unmanaged resources' -> praca so subormi, sietove spojenie, ...
 * 
 * Roots - udrzuje objekt pri zivote
 *       - je jedno z nasledujucich:
 *          - lokalna premenna alebo parameter aktualne beziacej metody (alebo navazujucej metody v call stacku)
 *          - staticka premenna
 *          - objekt uchovavajuci objekty pripravene na finalizaciu (?)
 *          
 * Ako funguje GC?
 *  1. GC prejde rooty a oznaci vsetky objekty na ktore siahne ako 'dostupne'
 *  2. Objekty, ktore toto oznacenie nedostali su okamzite posunute na garbage collection
 *  3. Objekty, ktore nemaju finalizery su okamzite zahodene
 *  4. Objekty, ktore maju finalizery su posunute do spesl fronty kde sa ich fin. vykonaju a su posunute k zahodeniu v dalsom kole GC
 *  
 *  Optimalizacne techniky:
 *   - 'generational' - vyuziva vedomost, ze niektore objekty su dlho trvajuce a tak neni potreba ich zakazdym kontrolovat
 *   - halda velkych objektov - objekty vacsie ako nejaky threshold (85000 bajtov)
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

    // Finalizer
    class Test
    {
        /* 1. Garbage Collector identifikuje nepouzite objekty zrale pre zmazanie
         * 2. Tie bez finalizera su zmazane hned, tie s finalizerom su posunute do specialnej fronty
         * 3a. Hotovo (program bezi dalej)
         * 3b. Paralelne sa nastartuje Finalizer Thread a zacne postupne spracovavat frontu a finalizery jej objektov
         * 4. Finalizery sa dokoncia, objekty su oznacene ako hotove (ako bez finalizeru) a pri najblizsom GC su zmazane
         * - musia byt rychle, nedat sa zablokovat, nereferencovat ine finelizery, nehadzat exception
         */
        ~Test()// finalizer, nesmie mat parametre a volat base triedu
        {
            // logika finalizeru
        }
    }
}
