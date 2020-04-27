using System.Windows;
using System.Windows.Threading;

namespace MessageBoxDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            startListening();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("这是系统弹窗", "提示：", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //MyMessageBox.getMMB().show("hehe");

            MyMessageBox mmb = new MyMessageBox();
            //mmb.show("hehe");
            //mmb.show("hehe","只是个提示");
            //new MyMessageBox().show("hehe");
            //new MyMessageBox().show("hehe","只是个提示");
            new MyMessageBox().show("hehe", "按钮1","按钮2","只是个提示");
            endFlag = true;
        }
        
        bool endFlag = false;
        void startListening()
        {
            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = new System.TimeSpan(0, 0, 0, 1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (endFlag)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
