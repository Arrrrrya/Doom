using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChessGameDemo
{
    /// <summary>
    /// MyChessGame.xaml 的交互逻辑
    /// </summary>
    public partial class MyChessGame : Window
    {
        string player1 = "〇";
        string player2 = "×";

        public MyChessGame()
        {
            InitializeComponent();

            initializeGameControl();
            initializeGamePanel();
        }

        #region 初始化游戏点击事件
        void initializeGameControl()
        {
            foreach(Canvas canvas in chess_border.Children)
            {
                canvas.MouseDown += WrapPanel_MouseDown;
            }
            last_winner.Text = "";
        }
        #endregion

        #region 初始化游戏面板显示
        int step_player1;
        int step_player2;
        void initializeGamePanel()
        {
            step_player1 = 0;
            step_player2 = 0;
            current_first.Text = new Random().Next(2) == 0 ? player1 : player2;
            current_player.Text = current_first.Text;
            current_winner.Text = "";
            total_step_O.Text = step_player1 + "";
            total_step_X.Text = step_player2 + "";
            foreach (Canvas canvas in chess_border.Children)
            {
                canvas.Children.Clear();
            }
        }
        #endregion

        #region 重新开始
        private void btn_restart_Click(object sender, RoutedEventArgs e)
        {
            initializeGamePanel();
        }
        #endregion

        #region 下棋操作
        Canvas currentCanvas;
        TextBlock currentTextBlock;
        private void WrapPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            currentCanvas = sender as Canvas;
            //MessageBox.Show(currentCanvas.Name);
            if (currentCanvas.Children.Count == 0)
            {
                if (current_player.Text == player1)
                {
                    step_player1++;
                    total_step_O.Text = step_player1 + "";
                }
                else
                {
                    step_player2++;
                    total_step_X.Text = step_player2 + "";
                }
                currentTextBlock = new TextBlock()
                {
                    Height = currentCanvas.Height,
                    Width = currentCanvas.Width,
                    TextWrapping = TextWrapping.Wrap,
                    Text = current_player.Text,
                    TextAlignment = TextAlignment.Center,
                    FontSize = 22
                };
                currentCanvas.Children.Add(currentTextBlock);
                current_player.Text = current_player.Text == player1 ? player2 : player1;

                if (checkCurrent(currentCanvas.Name) != "")
                {
                    current_winner.Text = current_player.Text == player1 ? player2 : player1;
                    last_winner.Text = current_winner.Text + " 获胜";
                    MessageBox.Show("游戏结束！");
                    initializeGamePanel();
                }
            }
        }
        #endregion

        #region 检查是否有玩家获胜
        Canvas[] heng = new Canvas[5];
        string[] shu = new string[5];
        string[] xie1 = new string[5];
        string[] xie2 = new string[5];
        int x;
        int y;
        List<string> result = new List<string>();
        string checkCurrent(string currentCanvasName)
        {
            resetCheckArray();
            result.Clear();

            x = Convert.ToInt32(currentCanvasName.Split('_')[1]);
            y = Convert.ToInt32(currentCanvasName.Split('_')[2]);

            if (x - 2 > 0 && x + 2 < 20 && y - 2 > 0 && y + 2 < 20)
            {
                heng[0] = findByName("canvas_" + (x - 2) + "_" + (y));
                heng[1] = findByName("canvas_" + (x - 1) + "_" + (y));
                heng[2] = findByName(currentCanvasName);
                heng[3] = findByName("canvas_" + (x + 1) + "_" + (y));
                heng[4] = findByName("canvas_" + (x + 2) + "_" + (y));

                for (int i = 0; i < heng.Length; i++)
                {
                    if (heng[i].Children.Count > 0)
                    {
                        Console.WriteLine(((TextBlock)heng[i].Children[0]).Text);
                        result.Add(((TextBlock)heng[2].Children[0]).Text);
                    }
                    else
                    {
                        Console.WriteLine("?");
                        result.Add("?");
                    }
                }
            }
            else
            {

            }

            if (result.Count == 5 && !result.Contains("?"))
            {
                return currentCanvasName;
            }

            return "";
        }
        void resetCheckArray()
        {
            for (int i = 0; i < 5; i++)
            {
                heng[i] = null;
                shu[i] = "";
                xie1[i] = "";
                xie2[i] = "";
            }
        }
        Canvas findByName(string name)
        {
            foreach (Canvas canvas in chess_border.Children)
            {
                if (canvas.Name == name)
                {
                    return canvas;
                }
            }
            return null;
        }

        #endregion

        
    }
}
