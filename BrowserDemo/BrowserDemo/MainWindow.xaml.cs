using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace BrowserDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string uri = "http://www.baidu.com";

        public MainWindow()
        {
            InitializeComponent();
            uri = "C:\\Users\\arya\\Desktop";
            openBrowser(2);
        }

        void openBrowser(int n)
        {
            switch (n)
            {
                case 1:
                    showWebBrowser();
                    break;
                case 2:
                    openSystemBrowser();
                    break;
                default:
                    break;
            }
        }

        WebBrowser wBrowser;
        void showWebBrowser()
        {
            wBrowser = new WebBrowser();
            wBrowser.Navigating += WBrowser_Navigating;
            wBrowser.Source = new Uri(uri);
            this.Content = wBrowser;
        }

        private void WBrowser_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            SuppressScriptErrors(wBrowser, true);
        }

        void openSystemBrowser()
        {
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = uri;
            proc.Start();
            this.Close();
        }

        public void SuppressScriptErrors(WebBrowser wb, bool Hide)
        {
            FieldInfo fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;

            object objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null) return;

            objComWebBrowser.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, objComWebBrowser, new object[] { Hide });
        }
    }
}
