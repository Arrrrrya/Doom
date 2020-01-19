/* ----------------------------------------------------------
文件名称：MainWindow.xaml.cs

作者：秦建辉

微信：splashcn

博客：http://www.firstsolver.com/wordpress/

开发环境：
    Visual Studio V2015
    .NET Framework 4 Client Profile
    WPFMediaKit 2.1
 
版本历史：
    V1.0	2016年11月01日
			基于WPFMediaKit实现视频与图像抓取

参考资料：
    https://github.com/Sascha-L/WPF-MediaKit
------------------------------------------------------------ */
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WPFMediaKit.DirectShow.Controls;

namespace Splash
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapSource ImagePlay;
        private BitmapSource ImageStop;

        public MainWindow()
        {
            InitializeComponent();

            // 设置窗体图标
            this.Icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(
                Properties.Resources.FingerPictureBox.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            // 图像源初始化
            ImagePlay = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                Properties.Resources.Button_Play_icon2.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            ImageStop = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                Properties.Resources.Button_Stop_icon.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            // 设置按钮图像
            image_Play.Source = ImagePlay;
            image_Capture.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                Properties.Resources.capture.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            // 设置窗体装载后事件处理器
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            vce.Width = vce.ActualWidth;
            vce.Height = vce.ActualHeight;


            // 设定初始视频设备
            comboBoxVideoDevices.ItemsSource = MultimediaUtil.VideoInputNames;
            if (comboBoxVideoDevices.Items.Count > 0)
            {
                comboBoxVideoDevices.SelectedIndex = 0;
                if (comboBoxVideoDevices.Items.Count == 1) comboBoxVideoDevices.IsEnabled = false;
            }
            else
            {
                button_Play.IsEnabled = false;
                button_Capture.IsEnabled = false;
            }

            // 设置图片框初始图像
            BitmapSource bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                Properties.Resources.noimage.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            fingerPictureBox1.InitialImage = bs;
            fingerPictureBox2.InitialImage = bs;
            fingerPictureBox3.InitialImage = bs;
            fingerPictureBox4.InitialImage = bs;
        }

        private void button_Play_Click(object sender, RoutedEventArgs e)
        {
            if (image_Play.Source == ImagePlay)
            {
                if (comboBoxVideoDevices.SelectedIndex != -1)
                {   // 开启视频
                    vce.VideoCaptureSource = (string)comboBoxVideoDevices.SelectedItem;
                    vce.Play();

                    // 改变按钮为“停止”状态
                    image_Play.Source = ImageStop;
                    label_Play.Content = "停止";
                    button_Capture.IsEnabled = true;    // 允许拍照
                }
            }
            else
            {   // 停止视频
                vce.Stop();

                // 改变按钮为“开始”状态
                image_Play.Source = ImagePlay;
                label_Play.Content = "开启视频";
                button_Capture.IsEnabled = false;   // 关闭拍照
            }
        }

        private void button_Capture_Click(object sender, RoutedEventArgs e)
        {
            // 进行拍照
            for (Int32 i = 1; i <= 4; i++)
            {
                object box = this.FindName("fingerPictureBox" + i);
                if (box is FingerPictureBox)
                {
                    if ((box as FingerPictureBox).ActiveImage == (box as FingerPictureBox).InitialImage)
                    {
                        RenderTargetBitmap bmp = new RenderTargetBitmap((int)vce.ActualWidth, (int)vce.ActualHeight, 96, 96, PixelFormats.Default);
                        vce.Measure(vce.RenderSize);
                        vce.Arrange(new Rect(vce.RenderSize));
                        bmp.Render(vce);

                        // 更新图像
                        (box as FingerPictureBox).ActiveImage = bmp;
                        break;
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vce.Close();
        }

        private void button_X_Click(object sender, RoutedEventArgs e)
        {
            double x = vce.ActualWidth / 2;
            double y = vce.ActualHeight / 2;
            RotateTransform rt = new RotateTransform(180, x, y);
            vce.RenderTransform = rt;
        }


    }
}
