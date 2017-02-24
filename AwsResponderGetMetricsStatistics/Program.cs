using System;
using System.IO;

namespace AwsResponderGetMetricsStatistics
{
    class Program
    {
        
        static void Main()
        {
            const string file = "C:\\ProgramData\\AwsResponder\\ResponderLog\\AwsResponder.log";
            string time = DateTime.Now.ToString("HH:mm");
            int linenumber = 0;
            int numberOfGetMetricStatistics = 0;

            using (StreamReader reader = new StreamReader(file))
            {
                string record;
                
                while (!reader.ReadLine().Contains("08:41")) //time
                {
                    //linenumber++;
                }
                
                while ((record=reader.ReadLine())!=null)
                {
                    if (record.Contains("Action=GetMetricStatistics"))
                    {
                        numberOfGetMetricStatistics++;
                    }   
                }

                Console.WriteLine(numberOfGetMetricStatistics);
            }
        }
    }
}
