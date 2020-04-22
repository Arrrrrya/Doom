using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_Tcp
{
    class Program
    {
        private Socket clientSocket;//客户端通讯套接字
        private IPEndPoint serverEndPoiint;//连接到的服务器IP和端口
        public Program()
        {
            serverEndPoiint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(serverEndPoiint);

                // 接收服务端发来的消息
                byte[] data = new byte[1024];
                int length = clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine(message);
            }
            catch (Exception)
            {
            }
        }
        public void SendMsg()
        {
            try
            {
                while (true)
                {//输入数据
                    string str = Console.ReadLine();
                    //发送数据到服务端
                    clientSocket.Send(Encoding.UTF8.GetBytes(str));
                    Console.WriteLine("我：" + str);
                }
            }
            catch (Exception)
            {
                //关闭连接
                clientSocket.Shutdown(SocketShutdown.Both);
                //清理连接资源
                clientSocket.Close();
            }
        }
        static void Main(string[] args)
        {
            Program client = new Program();
            client.SendMsg();
        }
    }
}
