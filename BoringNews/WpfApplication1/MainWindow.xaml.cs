using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Create_Click(object sender, RoutedEventArgs e)
        {
            textBlock_3.Text = "        " + textBox_1.Text + textBox_2.Text + "是怎么回事呢？" + textBox_1.Text + "相信大家都很熟悉，但是" + textBox_1.Text + textBox_2.Text + "是怎么回事呢，下面就让小编带大家一起了解吧。\r\n"
                + "        " + textBox_1.Text + textBox_2.Text + "其实就是" + textBox_3.Text + "。大家可能会很惊讶" + textBox_1.Text + "怎么会" + textBox_2.Text + "呢？但事实就是这样，小编也感到非常惊讶。\r\n"
                + "        " + "这就是关于" + textBox_1.Text + textBox_2.Text + "的事情了，大家有什么想法呢，欢迎在评论区告诉小编一起讨论哦！";
            button_Copy.Visibility = Visibility.Visible;
        }
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(textBlock_3.Text);
            MessageBox.Show("已复制到剪贴板。");
        }
    }
}
