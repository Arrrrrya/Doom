using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace HttpListenerDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string test { get; set; } = "";

        public MainWindow()
        {
            InitializeComponent();
            refreshTextBlock();
        }

        string url = "http://127.0.0.1:8888/";
        //string url = "http://192.168.1.3/";

        private void checkListen_Checked(object sender, RoutedEventArgs e)
        {
            test = exercise.Text;
            Task.Factory.StartNew(() =>
            {
                HttpListener listener = new HttpListener();
                while (true)
                {
                    try
                    {
                        listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;//指定身份验证 Anonymous匿名访问
                        listener.Prefixes.Add(url);
                        listener.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("服务启动失败..." + ex.Message);
                        break;
                    }
                    Console.WriteLine("服务器启动成功.......");

                    //线程池
                    int minThreadNum;
                    int portThreadNum;
                    int maxThreadNum;
                    ThreadPool.GetMaxThreads(out maxThreadNum, out portThreadNum);
                    ThreadPool.GetMinThreads(out minThreadNum, out portThreadNum);
                    Console.WriteLine("最大线程数：{0}", maxThreadNum);
                    Console.WriteLine("最小空闲线程数：{0}", minThreadNum);
                    //ThreadPool.QueueUserWorkItem(new WaitCallback(TaskProc1), x);

                    Console.WriteLine("\n\n等待客户连接中。。。。");
                    while (true)
                    {
                        //等待请求连接
                        //没有请求则GetContext处于阻塞状态
                        HttpListenerContext ctx = listener.GetContext();
                        ThreadPool.QueueUserWorkItem(new WaitCallback(TaskProc), ctx);
                    }
                }
            });
        }

        void TaskProc(object o)
        {
            try
            {
                HttpListenerContext ctx = (HttpListenerContext)o;

                ctx.Response.StatusCode = 200;//设置返回给客服端http状态代码

                //接收POST参数
                Stream stream = ctx.Request.InputStream;
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string body = reader.ReadToEnd();
                text = "收到POST数据:" + body;
                text = body;
                Console.WriteLine(text);
                isNeedFresh = true;

                //使用Writer输出http响应代码,UTF8格式
                using (StreamWriter writer = new StreamWriter(ctx.Response.OutputStream, Encoding.UTF8))
                {
                    writer.Write(test);
                    writer.Close();
                    ctx.Response.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        bool isNeedFresh = false;
        string text = "";
        DispatcherTimer timer = new DispatcherTimer();//计时器，用于刷新显示文字
        void refreshTextBlock()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);//测试每0.1秒执行一次
            timer.Tick += (object sender, EventArgs e) =>
            {
                if (isNeedFresh)
                {
                    if (text == "c")
                    {
                        bar_c.Value += 10;
                    }
                    else if (text == "b")
                    {
                        bar_b.Value += 10;
                    }
                    else if (text == "a")
                    {
                        bar_a.Value += 10;
                    }
                    isNeedFresh = false;
                }
            };
            timer.Start();
        }
    }
}
