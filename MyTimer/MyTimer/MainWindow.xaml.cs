using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace MyTimer
{
    /// <summary>
    /// 倒计时小工具
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer myTimer = null;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;

        bool isRunning = false;

        public MainWindow()
        {
            InitializeComponent();
            initialize();
        }

        void initialize()
        {
            if (myTimer != null)
            {
                myTimer.Stop();
                myTimer = null;
            }
            textBox.Text = "0";
            textBox.Width = 150;
            textBox.IsReadOnly = false;
            label.Visibility = Visibility.Visible;
            isRunning = false;
        }

        // 00:00:00
        void setTimeContent(int seconds)
        {
            minutes = seconds / 60;
            hours = minutes / 60;
            int second = seconds % 60;
            textBox.Text = (hours < 10 ? ("0" + hours) : ("" + hours)) + ":" + (minutes % 60 < 10 ? ("0" + minutes % 60) : ("" + minutes % 60)) + ":" + (second % 60 < 10 ? "0" + second : second + "");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Grid_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            int minute = 0;
            //try
            //{
            //    minute = Convert.ToInt32(textBox.Text.Trim());
            //}
            //catch (Exception)
            //{
            //}
            int result;
            if (int.TryParse(textBox.Text.Trim(), out result))
            {
                minute = result;
            }

            if (!isRunning)
            {
                if (minute == 0 || minute > 999)
                {
                    MessageBox.Show("别闹，好好填时间！");
                }
                else
                {
                    seconds = minute * 60;
                    setTimeContent(seconds);
                    myTimer = new DispatcherTimer()
                    {
                        Interval = new TimeSpan(0, 0, 0, 1)
                    };
                    myTimer.Tick += (s, o) =>
                    {
                        setTimeContent(--seconds);
                        if (seconds == 0)
                        {
                            if (myTimer != null)
                            {
                                myTimer.Stop();
                                myTimer = null;
                            }
                            textBox.Text = "倒计时结束！";
                        }
                    };
                    myTimer.Start();
                    textBox.Width = 250;
                    textBox.IsReadOnly = true;
                    label.Visibility = Visibility.Collapsed;
                    isRunning = true;
                }
            }
            else
            {
                if (MessageBox.Show("确定要重置倒计时吗?", "重置倒计时", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    initialize();
                }
            }
        }
    }
}
