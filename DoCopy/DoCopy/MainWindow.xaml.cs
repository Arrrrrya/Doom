using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows;

namespace DoCopy
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string sourcePath = "F:\\vpn.zip";
        string destPath = "F:\\test.rar";
        BackgroundWorker worker;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtWords.Content = "";
        }

        private void copy_start(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(sourcePath))
            {
                MessageBox.Show("文件不存在！");
                return;
            }
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            progressBar.Value = 0;
            txtWords.Content = "复制中...";
            worker.RunWorkerAsync();
            btn_start.IsEnabled = false;
            btn_end.IsEnabled = true;
        }

        private void btn_cancel(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
            txtWords.Content = "";
            progressBar.Value = 0;
            btn_start.IsEnabled = true;
            btn_end.IsEnabled = false;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Action<string> act = delegate (string str)
            {
                txtWords.Content = str;
            };
            if (e.Cancelled)
            {
                this.Dispatcher.BeginInvoke(act, "取消复制");
            }
            else
            {
                this.Dispatcher.BeginInvoke(act, e.Result.ToString());
                btn_end.IsEnabled = false;
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            rate.Content = ((Per)e.UserState).value + "/" + ((Per)e.UserState).max;
            rate2.Content = e.ProgressPercentage + "%";
            if (progressBar.Value == 100)
            {
                btn_start.IsEnabled = true;
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = copy(sender, e);
            Console.WriteLine(e);
        }
        private string copy(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = sender as BackgroundWorker;
            FileInfo f = new FileInfo(sourcePath);
            FileStream fsR = f.OpenRead();
            FileStream fsW = File.Create(destPath);
            long fileLength = f.Length;
            byte[] buffer = new byte[10240 * 4]; // 缓冲区大小 默认4KB
            int n = 0;
            while (true)
            {
                //读写文件
                n = fsR.Read(buffer, 0, buffer.Length);
                if (n == 0)
                {
                    break;
                }
                fsW.Write(buffer, 0, n);
                Per obj = new Per() { value = fsR.Position, max = fileLength };
                int rate = (int)Math.Floor((double)obj.value * 100 / (double)obj.max);
                w.ReportProgress(rate, obj);
                if (w.CancellationPending)
                {
                    e.Cancel = true;
                    fsR.Close();
                    fsW.Close();
                    return "";
                }
                fsW.Flush();
                Thread.Sleep(1); // 只是为了看进度条的效果
            }
            fsR.Close();
            fsW.Close();

            return "复制完成";
        }

    }

    class Per
    {
        public long value;
        public long max;
    }
}
