/*
Linq pracuje jednotlivo s kazdym elementom vstupu, nie s celou kolekciou

Where => vyvolava filtrovanu verziu vstupu
OrderBy => vyvolava zoradenu verziu vstupu
Select => vyvolava sekvenciu kde je kazdy vstupny element transformovany alebo zobrazeny jeho lambda expression

where (filter) -> order (zoradenie) -> select (zobrazenie)
*/

using System;
using System.Linq;

namespace LinqQueries
{
    class LinqQueries
    {
        static void Main()
        {
            string[] names = {"Libor", "Michal", "Juraj", "Fero"};
            
            //uloz vsetky mena ktore maju "a"
            var filteredNames = names.Where(n=>n.Contains("a"));
            //vypis vsetky vyfiltrovane mena
            foreach (var filteredName in filteredNames)
            {
                Console.WriteLine(filteredName);
            }

            //vyber mena obsajujuce "a", zorad ich podla dlzky a preved na velke pismena
            var filteredAndOrdered = names.Where(n => n.Contains("a")).OrderBy(n => n.Length).Select(n => n.ToUpper());
            foreach (var name in filteredAndOrdered)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
