using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
            foreach (Canvas canvas in chess_border.Children)
            {
                canvas.MouseDown += WrapPanel_MouseDown;
            }
            end_pic.Background = Brushes.Transparent;
            last_winner.Text = "";
            last_winner_step.Text = "";
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

                if (checkWin())
                {
                    current_winner.Text = current_player.Text == player1 ? player2 : player1;
                    last_winner.Text = current_winner.Text + " 获胜";
                    last_winner_step.Text = current_winner.Text == player1 ? "所用步数：" + total_step_O.Text + "" : "所用步数：" + total_step_X.Text + "";
                    MessageBox.Show("游戏结束，再来一局吧!");
                    showLastGamePic();
                    initializeGamePanel();
                }
            }
        }
        #endregion

        #region 检查是否有玩家获胜
        Canvas[] resultCanvas = new Canvas[5];
        List<string> resultList = new List<string>();
        bool checkWin()
        {
            if (checkHorizentol() || checkVertical() || checkOblique_1() || checkOblique_2())
            {
                return true;
            }
            return false;
        }
        bool checkHorizentol()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    resultList.Clear();
                    resultCanvas[0] = chess_border.Children[(i) * 20 + j] as Canvas;
                    resultCanvas[1] = chess_border.Children[(i) * 20 + j + 1] as Canvas;
                    resultCanvas[2] = chess_border.Children[(i) * 20 + j + 2] as Canvas;
                    resultCanvas[3] = chess_border.Children[(i) * 20 + j + 3] as Canvas;
                    resultCanvas[4] = chess_border.Children[(i) * 20 + j + 4] as Canvas;
                    if (checkResultList(resultCanvas))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool checkVertical()
        {;
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    resultList.Clear();
                    resultCanvas[0] = chess_border.Children[(i) * 20 + j] as Canvas;
                    resultCanvas[1] = chess_border.Children[(i + 1) * 20 + j] as Canvas;
                    resultCanvas[2] = chess_border.Children[(i + 2) * 20 + j] as Canvas;
                    resultCanvas[3] = chess_border.Children[(i + 3) * 20 + j] as Canvas;
                    resultCanvas[4] = chess_border.Children[(i + 4) * 20 + j] as Canvas;
                    if (checkResultList(resultCanvas))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool checkOblique_1()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    resultList.Clear();
                    resultCanvas[0] = chess_border.Children[(i) * 20 + j] as Canvas;
                    resultCanvas[1] = chess_border.Children[(i + 1) * 20 + j + 1] as Canvas;
                    resultCanvas[2] = chess_border.Children[(i + 2) * 20 + j + 2] as Canvas;
                    resultCanvas[3] = chess_border.Children[(i + 3) * 20 + j + 3] as Canvas;
                    resultCanvas[4] = chess_border.Children[(i + 4) * 20 + j + 4] as Canvas;
                    if (checkResultList(resultCanvas))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool checkOblique_2()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 4; j < 20; j++)
                {
                    resultList.Clear();
                    resultCanvas[0] = chess_border.Children[(i) * 20 + j] as Canvas;
                    resultCanvas[1] = chess_border.Children[(i + 1) * 20 + j - 1] as Canvas;
                    resultCanvas[2] = chess_border.Children[(i + 2) * 20 + j - 2] as Canvas;
                    resultCanvas[3] = chess_border.Children[(i + 3) * 20 + j - 3] as Canvas;
                    resultCanvas[4] = chess_border.Children[(i + 4) * 20 + j - 4] as Canvas;
                    if (checkResultList(resultCanvas))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// 检查五星连珠
        /// </summary>
        /// <param name="resultCanvas"></param>
        /// <param name="currentCanvasName"></param>
        /// <returns></returns>
        bool checkResultList(Canvas[] resultCanvas)
        {
            for (int i = 0; i < resultCanvas.Length; i++)
            {
                if (resultCanvas[i].Children.Count > 0)
                {
                    resultList.Add(((TextBlock)resultCanvas[i].Children[0]).Text);
                }
                else
                {
                    resultList.Add("?");
                }
            }
            if (!resultList.Contains("?") && !(resultList.Contains(player1) && resultList.Contains(player2)))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 保存并显示上局截图
        void showLastGamePic()
        {
            end_pic.Background = new ImageBrush() { ImageSource = screenShotLastGamePic(chess_border, 600, 600) };

        }
        RenderTargetBitmap screenShotLastGamePic(Visual vsual, int width, int height)
        {
            RenderTargetBitmap pic = new RenderTargetBitmap(width, height, 96, 96, PixelFormats.Default);
            pic.Render(vsual);
            return pic;
        }
        #endregion
    }
}
