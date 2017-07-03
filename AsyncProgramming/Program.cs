/* https://msdn.microsoft.com/library/hh191443(vs.110).aspx
 * 2 druhy awaitable - Task a Task<T> (Task.Yield / WinRT)
 * 
 */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class Program
    {
        static void Main()
        {
            var demo = new AsyncExamples();
            demo.NiecoUrob();
            demo.NapisDoCmd();

            while (true)
            {
                Console.WriteLine("Robim nieco v MAIN threade...");
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }
        
    }

    public class AsyncExamples
    {
        public async Task NiecoUrob()
        {
            await Task.Run(DlhoBeziaciProces);
            //v pripade ze odmazem Task.Run procesy pobezia seriovo po sebe -> DlhoBeziaciProces();
        }

        public async Task NapisDoCmd() {
            var returnedString = await Task.Run(VratString);
            Console.WriteLine(returnedString);
        }

        private static async Task<string> DlhoBeziaciProces()
        {
            int counter;
            for (counter = 0;  counter< 50; counter++)
            {
                Console.WriteLine(counter);
                Thread.Sleep(300);
            }
            return "Counter = " + counter;
        }
        private static async Task<string> VratString() {
            Thread.Sleep(5000);
            return "Hotovo";
        }
    }
}
