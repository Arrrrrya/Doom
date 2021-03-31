using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;

namespace Links
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private NotifyIcon notifyIcon = null;

        public MainWindow()
        {
            InitializeComponent();

            setNotifyIcon(); // 设置到托盘

            addHyperLink();

            setTime();
        }

        private DispatcherTimer showTimer = new DispatcherTimer();
        private void setTime()
        {
            showTimer.Interval = new TimeSpan(0, 0, 0, 1);
            showTimer.Tick += ShowTimer_Tick;
            showTimer.Start();
        }

        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Content = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //this.notifyIcon.ShowBalloonTip(1000);
            e.Cancel = true;
            try { showOrHide(); }
            catch (Exception) { }
        }

        #region 设置托盘图标
        private void setNotifyIcon()
        {
            this.notifyIcon = new NotifyIcon()
            {
                Icon = new System.Drawing.Icon(@"icon.ico"),
                Visible = true,
                Text = "Links",
                BalloonTipText = "喵喵喵~"
            };
            this.notifyIcon.ShowBalloonTip(1000);
            notifyIcon.MouseClick += (s, e) =>
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    showOrHide();
                }
            };

            System.Windows.Forms.MenuItem m1 = new System.Windows.Forms.MenuItem("close");
            m1.Click += (s, e) =>
            {
                if (System.Windows.MessageBox.Show("sure to exit?", "喵？", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                {
                    this.notifyIcon.Dispose();
                    System.Windows.Application.Current.Shutdown();
                }
            }; ;
            System.Windows.Forms.MenuItem[] m = new System.Windows.Forms.MenuItem[] { m1 };
            this.notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(m);
        }
        private void showOrHide()
        {
            if (this.Visibility == Visibility.Visible)
            {
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                this.Visibility = Visibility.Visible;
                this.Activate();
            }
        }
        #endregion

        #region 添加配置文件里的超链接
        private void addHyperLink()
        {
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                System.Windows.Controls.Label label = new System.Windows.Controls.Label()
                {
                    Margin = new Thickness(15, 0, 0, 0),
                    FontSize = 12
                };
                string[] keyInfo = key.Split('.');
                Hyperlink link = new Hyperlink(new Run(keyInfo[1]))
                {
                    NavigateUri = new Uri(ConfigurationManager.AppSettings[key])
                };
                link.Click += Hyperlink_Click;
                label.Content = link;
                if (Convert.ToInt32(keyInfo[0]) < 50)
                {
                    panel1.Children.Add(label);
                }
                else
                {
                    panel2.Children.Add(label);
                }
            }
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(((Hyperlink)sender).NavigateUri.AbsoluteUri));
        }
        #endregion
    }
}
