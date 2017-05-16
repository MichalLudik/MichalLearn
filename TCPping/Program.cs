using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace TCPping
{
    class Program
    {
        static int port = 80;
        static string ip = "10.140.46.254";

        static void Main(string[] args)
        {
            //sokety();
            while (true)
            {
                using (var connection = new TcpClient())
                {
                    Stopwatch watch = new Stopwatch();

                    ping(watch, connection);
                    connection.Close();

                }
            }
            Console.Read();
        }

        public static void ping(Stopwatch watch, TcpClient client)
        {
            watch.Start();
            client.Connect(ip, port);
            watch.Stop();
            Console.WriteLine("Ping = "+watch.Elapsed.TotalMilliseconds+" ms");
        }

        static void networkBandwidth(Stopwatch watch, TcpClient client)
        {
            NetworkStream ns = client.GetStream();
                
            if (ns.CanWrite)
            {
                Byte[] sendBytes = Encoding.UTF8.GetBytes("Je tam niekto?");
                watch.Reset();
                ns.Write(sendBytes, 0, sendBytes.Length);
                watch.Stop();
                Console.WriteLine("Network stream: "+watch.Elapsed.TotalMilliseconds+ " ms");
            }
            ns.Close();    
        }

        static void sokety()
        {
            string input = "Ahoj vole.";
            byte[] receiveddata = new byte[1024];
            using (var connection = new TcpClient())
            {
                using (Socket socket = connection.Client)
                {
                    socket.Connect(ip, port);
                    byte[] data = Encoding.ASCII.GetBytes(input);
                    socket.Send(data, data.Length, SocketFlags.None);
                    //socket.Receive(receiveddata);
                    Console.WriteLine(Encoding.ASCII.GetString(receiveddata));
                    socket.Close();
                }
                connection.Close();
            }
        }

    }
}
