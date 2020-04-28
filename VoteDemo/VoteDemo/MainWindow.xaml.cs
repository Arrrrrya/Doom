using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;

namespace VoteDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void StartVoteDelegate(int num);

        //创建保存嘉宾对象集合
        private Dictionary<int, Guest> dicGuest = null;
        //创建投票器窗体集合
        private List<Window> windowList = new List<Window>();
        public MainWindow()
        {
            InitializeComponent();
            //初始化嘉宾对象集合
            this.dicGuest = new Dictionary<int, Guest>()
            {
                [1] = new Guest { Num = 1, Name = "A " },
                [2] = new Guest { Num = 2, Name = "B " },
                [3] = new Guest { Num = 3, Name = "C " },
            };
        }
        //【2】根据委托创建方法
        private void Receiver(int num)
        {
            //根据序号找到嘉宾对象，并使其投票总数+1
            this.dicGuest[num].VoteCounter++;
            //同步显示投票结果
            this.labelCounter1.Content = this.dicGuest[1].Name + this.dicGuest[1].VoteCounter.ToString() + "票";
            this.labelCounter2.Content = this.dicGuest[2].Name + this.dicGuest[2].VoteCounter.ToString() + "票";
            this.labelCounter3.Content = this.dicGuest[3].Name + this.dicGuest[3].VoteCounter.ToString() + "票";
        }

        //创建投票器对象
        private void btnStartVoteClick(object sender, RoutedEventArgs e)
        {
            int counter = Convert.ToInt32(this.voteCounterForm.Text.Trim());
            for (int i = 0; i < counter; i++)
            {
                //通过反射创建窗体(根据壹个类的完全限定名创建对象)
                VoteWindow voteWindow = (VoteWindow)Assembly.Load("VoteDemo").CreateInstance("VoteDemo.VoteWindow");
                voteWindow.Title = "投票器:" + (i + 1).ToString();
                //【4】将投票器窗体对象中的委托变量和当前窗体的委托实现方法关联
                voteWindow.voteDelegate = this.Receiver;
                voteWindow.Show();
                //添加投票器窗体到集合当中
                this.windowList.Add(voteWindow);
            }

        }
        //结束投票
        private void btnEndVoteClick(object sender, RoutedEventArgs e)
        {
            foreach (Window item in this.windowList)
            {
                item.Close();
            }
            this.btnStartVote.IsEnabled = false;
        }
    }

    class Guest
    {
        //序号
        public int Num { get; set; }
        //姓名
        public string Name { get; set; }
        //票数
        public int VoteCounter { get; set; } = 0;
    }
}
