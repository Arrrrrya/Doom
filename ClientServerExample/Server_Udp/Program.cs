using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server_Udp
{
    class Program
    {
        private IPEndPoint serverEndPoint;
        private Socket serverSocket;
        public Program()
        {
            serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            serverSocket.Bind(serverEndPoint);
            EndPoint ep = (EndPoint)serverEndPoint;
            Console.WriteLine("服务器端已经启动");
            while (true)
            {
                byte[] byteArray = new byte[1024 * 1024];
                int count = serverSocket.ReceiveFrom(byteArray, ref ep);
                string str = Encoding.UTF8.GetString(byteArray, 0, count);
                Console.WriteLine("客户端发来的信息：" + str);
            }
        }
        static void Main(string[] args)
        {
            Program server = new Program();
        }
    }
}
