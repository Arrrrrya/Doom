using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MyTimer
{
    /// <summary>
    /// 看书and逗猫の倒计时小工具
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer myTimer = null;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            initialize();
        }

        void initialize()
        {
            comboBox.SelectedIndex = 0;
            setIsEnable(true, true, false, false);
            seconds = (comboBox.SelectedIndex + 1) * 30 * 60;
            setLabelContent(seconds);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            setIsEnable(false, false, true, true);
            myTimer = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 0, 1)
            };
            myTimer.Tick += (s, o) => {
                seconds--;
                setLabelContent(seconds);
                if (seconds == 0)
                {
                    myTimer.Stop();
                    if (MessageBox.Show("倒计时结束啦！喵！") == MessageBoxResult.OK)
                    {
                        initialize();
                    }
                }
            };
            myTimer.Start();

        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            if(btnPause.Content.ToString() == "暂停")
            {
                myTimer.Stop();
                btnPause.Content = "继续";
            }
            else
            {
                myTimer.Start();
                btnPause.Content = "暂停";
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            myTimer.Stop();
            initialize();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (labelRestTime!=null)
            {
                seconds = (comboBox.SelectedIndex + 1) * 30 * 60;
                setLabelContent(seconds);
            }
        }
        
        void setIsEnable(bool comboxFlag, bool btnFlag1,bool btnFlag2, bool btnFlag3)
        {
            comboBox.IsEnabled = comboxFlag;
            btnStart.IsEnabled = btnFlag1;
            btnPause.IsEnabled = btnFlag2;
            btnReset.IsEnabled = btnFlag3;
        }

        // 00:00:00
        void setLabelContent(int seconds)
        {
            minutes = seconds / 60;
            hours = minutes / 60;
            int second = seconds % 60;

            labelRestTime.Content = "0" + hours + ":" + ((minutes % 60 < 10) ?
                "0" + minutes % 60 :
                minutes % 60 + "") + ":" +
                ((second % 60 < 10) ? "0" + second : second + "");
        }
    }
}
