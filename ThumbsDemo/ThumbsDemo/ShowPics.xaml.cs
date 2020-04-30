using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ThumbsDemo
{
    /// <summary>
    /// ShowPics.xaml 的交互逻辑
    /// </summary>
    public partial class ShowPics : UserControl
    {
        private List<string> current_pics;
        private int current_index = 0;
        private bool showInVertical = false;

        public ShowPics()
        {
            InitializeComponent();
        }

        public void setPics(List<string> picList, bool isVertical = false)
        {
            initializeStart(picList, isVertical);
        }

        public ShowPics(List<string> picList, bool isVertical = false)
        {
            InitializeComponent();
            initializeStart(picList, isVertical);
        }

        #region 初始显示第一张图
        private void initializeStart(List<string> picList, bool isVertical)
        {
            if (picList.Count == 0)
            {
                return;
            }
            current_pics = picList;
            showInVertical = isVertical;
            foreach (Image image in mainCanvas.Children)
            {
                image.Visibility = Visibility.Collapsed;
            }
            mainCanvas.Background = new VisualBrush()
            {
                Visual = new Image()
                {
                    Source = new BitmapImage(new Uri(current_pics[0], UriKind.RelativeOrAbsolute))
                }
            };

            if (current_pics.Count > 1)
            {
                if (showInVertical)
                {
                    icon_down.Visibility = Visibility.Visible;
                    icon_down.MouseDown += nextPage_MouseDown;
                    icon_up.MouseDown += pastPage_MouseDown;
                }
                else
                {
                    icon_right.Visibility = Visibility.Visible;
                    icon_right.MouseDown += nextPage_MouseDown;
                    icon_left.MouseDown += pastPage_MouseDown;
                }
            }
        }
        /// <summary>
        /// 点击下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            current_index++;
            mainCanvas.Background = new VisualBrush()
            {
                Visual = new Image()
                {
                    Source = new BitmapImage(new Uri(current_pics[current_index], UriKind.RelativeOrAbsolute))
                }
            };
            if(current_index == current_pics.Count - 1)
            {
                ((Image)sender).Visibility = Visibility.Collapsed;
            }
            if (showInVertical)
            {
                icon_up.Visibility = Visibility.Visible;
            }else
            {
                icon_left.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// 点击上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pastPage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            current_index--;
            mainCanvas.Background = new VisualBrush()
            {
                Visual = new Image()
                {
                    Source = new BitmapImage(new Uri(current_pics[current_index], UriKind.RelativeOrAbsolute))
                }
            };
            if (current_index == 0)
            {
                ((Image)sender).Visibility = Visibility.Collapsed;
            }
            if (showInVertical)
            {
                icon_down.Visibility = Visibility.Visible;
            }
            else
            {
                icon_right.Visibility = Visibility.Visible;
            }
        }
        #endregion

    }
}
