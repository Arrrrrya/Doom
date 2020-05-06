using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace CreateQRCodeDemo
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                image.Source = createQRCode(textBox.Text, 1000, 1000);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (image.Source != null)
            {
                MessageBox.Show($"二维码内容为：{readQRCode(image)}");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (image.Source != null)
            {
                saveImage(image);
            }
        }

        #region 生成二维码
        [DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="content"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private ImageSource createQRCode(string content, int width, int height)
        {
            EncodingOptions options;
            //包含一些编码、大小等的设置
            //BarcodeWriter :一个智能类来编码一些内容的条形码图像
            BarcodeWriter write = null;
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = width,
                Height = height,
                Margin = 0
            };
            write = new BarcodeWriter();
            //设置条形码格式
            write.Format = BarcodeFormat.QR_CODE;
            //获取或设置选项容器的编码和渲染过程。
            write.Options = options;
            //对指定的内容进行编码，并返回该条码的呈现实例。渲染属性渲染实例使用，必须设置方法调用之前。
            Bitmap bitmap = write.Write(content);
            IntPtr bmpHandle = bitmap.GetHbitmap();
            //从GDI+ Bitmap创建GDI位图对象
            //Imaging.CreateBitmapSourceFromHBitmap方法，基于所提供的非托管位图和调色板信息的指针，返回一个托管的BitmapSource
            BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(bmpHandle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            DeleteObject(bmpHandle);

            return bitmapSource;
        }
        #endregion

        #region 识别二维码
        /// <summary>
        /// 识别二维码
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Result readQRCode(System.Windows.Controls.Image image)
        {
            Result result = null;
            try
            {
                result = new BarcodeReader().Decode(imageToBitmap(image));//解析条码
            }
            catch { }
            return result;
        }
        #endregion

        #region Image转换为Bitmap
        /// <summary>
        /// Image转换为Bitmap
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Bitmap imageToBitmap(System.Windows.Controls.Image image)
        {
            MemoryStream ms = new MemoryStream();
            BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)(image.Source)));
            encoder.Save(ms);
            Bitmap bitmap = new Bitmap(ms);
            ms.Close();

            return bitmap;
        }
        #endregion

        #region 保存到本地
        /// <summary>
        /// 保存到本地
        /// </summary>
        /// <param name="image"></param>
        private void saveImage(System.Windows.Controls.Image image)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png|*.png|Jpg|*.jpg|Bmp|*.bmp|Image Files (*.bmp, *.png, *.jpg)|*.bmp;*.png;*.jpg";
            sfd.RestoreDirectory = true;//是否记忆上次打开的目录 
            if (sfd.ShowDialog() == true)
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)image.Source));
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    encoder.Save(stream);
                }
                MessageBox.Show("保存成功！");
            }
        }
        #endregion

    }
}
