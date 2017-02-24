

using System;
using System.Net;
using Renci.SshNet;

namespace ConnectViaSsh
{
    class Program
    {
        static void Main()
        {
            string username = "administrator";
            string password = "Password1";
            string hostIpAddress = "10.140.126.221";

            using (var sshClient = new SshClient(hostIpAddress,username,password))
            {
                sshClient.Connect();
                using (var command = sshClient.CreateCommand("ls"))
                {
                    command.Execute();
                    Console.WriteLine(command.CommandText);
                }
                
                sshClient.Disconnect();
                //Console.WriteLine(command);
            }

            Console.Read();
        }
    }
}
