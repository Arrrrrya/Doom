using System.Windows;

namespace MessageBoxDemo
{
    /// <summary>
    /// MyMessageBox.xaml 的交互逻辑
    /// </summary>
    public partial class MyMessageBox : Window
    {
        private static MyMessageBox mmb = new MyMessageBox();

        public MyMessageBox()
        {
            InitializeComponent();
            Title = "";
            tip.Content = "";
            btns.Visibility = Visibility.Collapsed;
        }

        public static MyMessageBox getMMB()
        {
            return mmb;
        }

        public void show(string msg,string title = "")
        {
            Title = title;
            tip.Content = msg;
            ShowDialog();
        }

        public void show(string msg, string btn1, string btn2, string title = "")
        {
            Title = title;
            tip.Content = msg;
            btns.Visibility = Visibility.Visible;
            button.Content = btn1;
            button2.Content = btn2;
            ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
