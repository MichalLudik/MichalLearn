using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CloudPerfPreparation
{
    class Program
    {
        static void Main()
        {
            //File.WriteAllText("..\\json.txt",Regex.Replace(File.ReadAllText("..\\json.txt"), "\"PublicIpAddress\": \"(.*)\"", "\"PublicIpAddress\" : \"{IP}\""));
            const string ipfile = "..\\IP_addresses.txt";
            const string macfile = "..\\MAC_addresses.txt";

            var listIP = LoadFileToArray(ipfile);
            var listMac = LoadFileToArray(macfile);

            const string file = "..\\AKIAIHVJR7TGKUQPRMSA.json";
            const string output = "..\\json2.txt";



            using (StreamReader reader = new StreamReader(file))
            {
                using (StreamWriter writer = File.AppendText(output))
                {
                    string read;
                    int counter = 0;
                    int arraycounter = 0;
                    while ((read = reader.ReadLine()) != null)
                    {
                        
                        if (Regex.IsMatch(read, "\"PublicIpAddress\": \"(.*)\"") && counter < 10)
                        {
                            writer.WriteLine(Regex.Replace(read, "\"PublicIpAddress\": \"(.*)\"",
                                $"\"PublicIpAddress\" : \"{listIP[arraycounter]}\""));
                            counter++;
                            
                        }

                        if (Regex.IsMatch(read, "\"MacAddress\": \"(.*)\"") && counter < 10)
                        {
                            writer.WriteLine(Regex.Replace(read, "\"PublicIpAddress\": \"(.*)\"",
                                $"\"MacAddress\" : \"{listMac[arraycounter]}\""));
                            counter++;
                            arraycounter++;

                        }

                        if (counter == 10)
                        {
                            counter = 0;
                            //arraycounter++;
                        }
                        //if (arraycounter==listIP.Count)
                        //{
                        //    break;
                        //}
                        writer.WriteLine(read);
                    }
                }
                Console.ReadLine();
            }

            
        }

        public static List<string> LoadFileToArray(string path)
        {
            List< string> listOfAddresses = new List<string>();
            string line;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line=reader.ReadLine())!=null)
                {
                    listOfAddresses.Add(line);
                }
            }
            return listOfAddresses;
        }
    }
    }