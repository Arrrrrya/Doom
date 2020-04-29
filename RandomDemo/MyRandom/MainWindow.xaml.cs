using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MyRandom
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> nameList;
        public MainWindow()
        {
            InitializeComponent();
            initializeControl();
        }

        void initializeControl()
        {
            textBlock.Text = "";
            foreach (CheckBox item in boxes.Children)
            {
                item.IsChecked = true;
            }
            for (int i = 0; i < boxes.Children.Count; i++)
            {
                ((Label)labels.Children[i]).Content = 0;
            }
        }

        Random random = new Random();
        int n = 0;
        string result;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            nameList = new List<string>(3);
            foreach (CheckBox item in boxes.Children)
            {
                if ((bool)item.IsChecked)
                {
                    nameList.Add(item.Content.ToString());
                }
            }
            result = nameList[random.Next(nameList.Count)];
            if (nameList.Count > 0)
            {
                textBlock.Text += "第" + ++n + "次随机结果：" + result + "\n";
                scrollViewer.ScrollToVerticalOffset(scrollViewer.ActualHeight * n);
                for(int i=0;i< boxes.Children.Count; i++)
                {
                    if (((CheckBox)boxes.Children[i]).Content.ToString() == result)
                    {
                        ((Label)labels.Children[i]).Content = Convert.ToInt32(((Label)labels.Children[i]).Content) + 1;
                    }
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            initializeControl();
        }
    }
}
