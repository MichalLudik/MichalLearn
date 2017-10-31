using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetCoreServer
{
    class Server
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                throw new Exception("You must enter IP and port which the communication will perform on...");
            }

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Parse(args[0]), Int32.Parse(args[1])));
            
            socket.Listen(1);

            var acceptedData = socket.Accept();
            var data = new byte[acceptedData.SendBufferSize];
            int j = acceptedData.Receive(data);
            var adata = new byte[j];
            for (int i = 0; i < j; i++)
            {
                adata[i] = data[i];
            }

            var dat = Encoding.ASCII.GetString(adata);
            Console.WriteLine(dat);
        }
    }
}