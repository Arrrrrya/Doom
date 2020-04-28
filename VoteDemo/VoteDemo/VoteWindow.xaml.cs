using System;
using System.Windows;
using System.Windows.Controls;
using static VoteDemo.MainWindow;

namespace VoteDemo
{
    /// <summary>
    /// VoteWindow.xaml 的交互逻辑
    /// </summary>
    public partial class VoteWindow : Window
    {
        //【3】创建委托变量
        public StartVoteDelegate voteDelegate = null;

        public VoteWindow()
        {
            InitializeComponent();
        }

        //开始投票
        private void btnVoteClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            //【5】通过委托变量传递数据
            voteDelegate(Convert.ToInt32(btn.Tag));
            this.Title = "投票完成";
            //投票后按钮禁用
            foreach (UIElement item in (this.Content as Grid).Children)
            {
                if (item is Button)
                {
                    ((Button)item).IsEnabled = false;
                }
            }
        }
    }
}
