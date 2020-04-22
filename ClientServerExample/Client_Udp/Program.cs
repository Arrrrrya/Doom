using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_Udp
{
    class Program
    {
        private IPEndPoint clientEndPoint;
        private Socket clientrSocket;
        public Program()
        {
            clientEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            clientrSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint ep = (EndPoint)clientEndPoint;
            while (true)
            {
                string str = Console.ReadLine();
                byte[] byteArray = new byte[1024 * 1024];
                byteArray = Encoding.UTF8.GetBytes(str);
                clientrSocket.SendTo(byteArray, ep);
                Console.WriteLine("我发的信息：" + str);
            }
        }
        static void Main(string[] args)
        {
            Program client = new Program();
        }
    }
}
