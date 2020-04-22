using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server_Tcp
{
    class Program
    {
        private Socket socket; //服务器监听套接字 
        private bool isListen = true;//判断服务器是否在监听（目的是为了方便退出）
        public Program()
        {
            //定义网络终结点（封装IP和端口）
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //实例化套接字（监听套接字）
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务器端绑定地址
            socket.Bind(endPoint);
            //开始监听
            socket.Listen(10);//10表示“监听对列”的最大长度
            Console.WriteLine("服务器端已经启动");
            try
            {
                while (isListen)
                {
                    //Accept()接收客户端的连接
                    //会阻断当前线程的进行
                    Socket acceptSocket = socket.Accept();
                    Console.WriteLine("--有一个客户端连入。");
                    //开启一个后台线程，进行客户端的会话
                    Thread clientMsg = new Thread(ClientMsg);
                    clientMsg.IsBackground = true;//设置为后台线程
                    clientMsg.Name = "clientMsg";//设置线程名字
                    clientMsg.Start(acceptSocket);
                }
            }
            catch (Exception)
            {
            }

        }
        public void ClientMsg(object sockMsg)
        {
            Socket socketMsg = sockMsg as Socket;//通讯Socket
            while (true)
            {
                //准备一个“数据缓存（数组）”
                byte[] msg = new byte[1024 * 1024];
                //接收客户端发来的数据，返回数据真实长度
                try
                {
                    int count = socketMsg.Receive(msg);
                    //byte数组转换为string
                    string str = Encoding.UTF8.GetString(msg, 0, count);
                    //显示客户端发过来的数据
                    Console.WriteLine("--客户端发过来的数据：" + str);
                }
                catch (Exception)
                {
                    //显示客户端发过来的数据
                    Console.WriteLine("--客户端已断开连接");
                    break;
                }
            }

        }

        static void Main(string[] args)
        {
            Program server = new Program();
        }
    }
}
