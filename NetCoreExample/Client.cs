using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetCoreClient
{
    class Client
    {
        static void Main(string[] args)
        {
            if (args.Length!=2)
            {
                throw new Exception("You must enter IP address of server and communicating port...");
            }

            var serverIpAddress = IPAddress.Parse(args[0]);
            var port = Int32.Parse(args[1]);

            TcpClient client = new TcpClient();
            client.Client.Connect(serverIpAddress,port);

            ReadDataLoop(client);
            
        }

        private static void ReadDataLoop(TcpClient client)
        {
            while (true)
            {
                if (!client.Connected)
                {
                    break;
                }
                var receivedData = ReadData(client);
                Console.WriteLine(receivedData);
            }
        }

        static string ReadData(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] myReadBuffer = new byte[1024];
            StringBuilder myCompleteMessage = new StringBuilder();

            do
            {
                var numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);

                myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead));
            }
            while (stream.DataAvailable);
            
            var retVal = myCompleteMessage.ToString();
            return retVal;
        }
    }
}