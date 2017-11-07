/* Je to akt kedy sa objekt v pamati premeni na stream bytov alebo XML
 * XML serializacia by mala pre lepsi vykon prepouzivat rovnaky XmlSerializer objekt
 * Pouziva sa na - prenos objektov mimo hranice aplikacie alebo po sieti
 *               - ulozenie objektov do suboru alebo databaze
 * Deli sa na:
 *  - Data Contract serializer [DataContractSerializer]
 *  - Binarny serializer [NetDataContractSerializer]
 *  - XmlSerializer
 *
 * Formatter: 
 *  - binarny
 *  - XML
 *  
 * Explicitna serializacia - vybera sa serializacny engine + formatter
 * Implicitna serializacia - spustena automaticky frameworkom (ked sa serializuje nejaky potomok, ked pouzivame ficuru ktora zavisi na serializacii)
 * 
 */

using System.Runtime.Serialization;
using System.IO;
using System.Xml;

namespace Serializace
{
    class Serializace
    {
        static void Main()
        {
            XmlSerializacia();

            BinarnaSerializacia();

            System.Console.Read();
        }

        private static void BinarnaSerializacia()
        {
            var ns = new NetDataContractSerializer();
            Osoba clovek = new Osoba() { Meno = "Jano", Vek = 36 };

            using (Stream s = File.Create("serialized.txt"))
            {
                ns.WriteObject(s, clovek);
            }
        }

        private static void XmlSerializacia()
        {
            Osoba osoba = new Osoba() { Meno = "Michal", Vek = 28 };
            var settings = new XmlWriterSettings() { Indent = true }; // nastavi XML aby ho pekne sformatovala
            var serializacia = new DataContractSerializer(typeof(Osoba));

            using (Stream s = File.Create("serialized.xml"))
            {
                serializacia.WriteObject(s, osoba);
            }

            using (XmlWriter writer = XmlWriter.Create("xmlFile.xml", settings))
            {
                serializacia.WriteObject(writer, osoba);
            }

            System.Diagnostics.Process.Start("xmlFile.xml"); // otvori editor

            Osoba osoba2;
            using (Stream s = File.OpenRead("serialized.xml"))
            {
                osoba2 = (Osoba)serializacia.ReadObject(s);
            }

            System.Console.WriteLine($"Meno: {osoba2.Meno} \r\n Vek: {osoba2.Vek}");
        }
    }

    [DataContract] public class Osoba
    {
        [DataMember] public string Meno { get; set; }
        public int Vek { get; set; } // nema [DataMember] takze sa nezahrnie do serializacie
    }
}
