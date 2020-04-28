using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyHttpClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        static string url = "http://127.0.0.1:8888/";
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = url;
        }

        #region 单一用户 瞬间发送多次消息
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (button.Content.ToString() == "连接")
            {
                test = HttpPost(url, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss  " + "用户连接成功！"));
                button.Content = "发送";
                label.Content = test;
            }
            else
            {
                HttpPost(url, /*DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss  " + (n == 1 ? "" : i + "") + "  ") + */textBox1.Text);

                //int n = 1;
                //try { n = Convert.ToInt32(textBox2.Text.Trim()); }
                //catch (Exception) { n = 1; }

                //for (int i = 0; i < n; i++)
                //{
                //    HttpPost(url, /*DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss  " + (n == 1 ? "" : i + "") + "  ") + */textBox1.Text);
                //}
                button.IsEnabled = false;
            }

        }
        static string test = "";
        private static string HttpPost(string url, string postDataStr)
        {
            //Task.Factory.StartNew(() =>
            //{
            try
            {
                string strReturn;
                //在转换字节时指定编码格式
                byte[] byteData = Encoding.UTF8.GetBytes(postDataStr);

                //配置Http协议头
                HttpWebRequest resquest = (HttpWebRequest)WebRequest.Create(url);
                resquest.Method = "POST";
                resquest.ContentType = "application/x-www-form-urlencoded";
                resquest.ContentLength = byteData.Length;

                //发送数据
                using (Stream resquestStream = resquest.GetRequestStream())
                {
                    resquestStream.Write(byteData, 0, byteData.Length);
                }

                //接受并解析信息
                using (WebResponse response = resquest.GetResponse())
                {
                    //解决乱码：utf-8 + streamreader.readToEnd
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                    strReturn = reader.ReadToEnd();
                    test = strReturn;
                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                MessageBox.Show(e.Message);
            }
            //});
            return test;
        }
        #endregion

        #region 多用户同时访问
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int n = 1;
            //try { n = Convert.ToInt32(textBox3.Text.Trim()); }
            //catch (Exception) { n = 1; }

            List<User> userList = new List<User>();
            for (int i = 0; i < n; i++)
            {
                userList.Add(new User(i + 1));
            }

            // 利用并行循环模拟多用户操作
            Parallel.ForEach(userList, (user, loopState) =>
            {
                user.sendMsg();
            });
        }
        #endregion
    }

    /// <summary>
    /// 模拟多用户
    /// </summary>
    class User
    {
        string url = "http://192.168.0.110/";
        int userId = 0;

        public User(int userId)
        {
            this.userId = userId;
        }

        public void sendMsg()
        {
            HttpPost(url, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss  " + "我是用户" + userId));
        }

        #region 发送消息
        public static void HttpPost(string url, string postDataStr)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    string strReturn;
                    //在转换字节时指定编码格式
                    byte[] byteData = Encoding.UTF8.GetBytes(postDataStr);

                    //配置Http协议头
                    HttpWebRequest resquest = (HttpWebRequest)WebRequest.Create(url);
                    resquest.Method = "POST";
                    resquest.ContentType = "application/x-www-form-urlencoded";
                    resquest.ContentLength = byteData.Length;

                    //发送数据
                    using (Stream resquestStream = resquest.GetRequestStream())
                    {
                        resquestStream.Write(byteData, 0, byteData.Length);
                    }

                    //接受并解析信息
                    using (WebResponse response = resquest.GetResponse())
                    {
                        //解决乱码：utf-8 + streamreader.readToEnd
                        StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                        strReturn = reader.ReadToEnd();
                        reader.Close();
                        reader.Dispose();
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    MessageBox.Show(e.Message);
                }
            });
        }
        #endregion
    }
}
