using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravaExistujucehoSuboru
{
    class Program
    {
        static void Main(string[] args)
        {
            string installserverPs1 = "installServer.ps1";
            string text = File.ReadAllText(installserverPs1);
            text = text.Replace("127.0.0.1", "abc");
            File.WriteAllText(installserverPs1,text);
        }
    }
}
