using System;
using System.Windows;
using System.Windows.Threading;

namespace ChangeLabelDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private DispatcherTimer timer = null;
        private int num = 0;
        private void Button_Click(object sender, RoutedEventArgs e) {
            if(timer != null) {
                timer.Stop();
                timer = null;
                num = 0;
                Button_Click(sender, e);
            } else {
                timer = new DispatcherTimer();
                timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();
                btn.Content = "重新开始";
            }

        }

        private void Timer_Tick(object sender, EventArgs e) {
            label.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)(() => {
                label.Content = "当前进度为：" + (++num) + "%";
                if(num == 100) {
                    timer.Stop();
                    label.Content += "    已完成！";
                    num = 0;
                    btn.Content = "开始";
                }
            }));
        }
    }
}
