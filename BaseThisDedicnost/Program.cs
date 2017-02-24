using System;

namespace BaseThisDedicnost
{
    class Program
    {
        static void Main()
        {
            var trieda = new DerivedClass("Michal");
            
            Console.ReadLine();
        }
    }

    class BaseClass
    {
        public string message;

        //jedine pouzitie je pri navrhovom vzore singletonu
        private BaseClass(string message)
        {
            this.message = message;
            Console.WriteLine(SkombinujSpravy()+"+BaseClass");
        }

        //private konstruktor sa neda dedit a preto ho nahradim protected a ten odkazem na privatny cez :this()
        protected BaseClass(int message):this("mmm")
        {
            Console.WriteLine(SkombinujSpravy()+"+BaseClass");
        }

        private string SkombinujSpravy()
        {
            return this.message + "ABC";
        }
    }

    class  DerivedClass : BaseClass
    {
        //prepisuje premennu v base triede
        public new string message = "AAA";
        public DerivedClass(string message1) : base(5)
        {
            Console.WriteLine(message1 + "DerivedClass");
            Console.WriteLine(base.message);
            Console.WriteLine(this.message);
        }
    }
}
