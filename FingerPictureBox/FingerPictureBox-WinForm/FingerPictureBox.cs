/* ----------------------------------------------------------
文件名称：FingerPictureBox.cs

作者：秦建辉

微信：splashcn

博客：http://www.firstsolver.com/wordpress/

开发环境：
    Visual Studio V2010
    .NET Framework 4 Client Profile
 
版本历史：
    V1.0	2011年07月12日
			基于WinForm，实现一个具有拖入和删除功能的图片框控件
------------------------------------------------------------ */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Splash
{
    /// <summary>
    /// 方便手指操作的用户控件，轻松完成图像拖入和删除
    /// 主要属性：
    ///     ImageLayout：设置图像布局（None、Tile、Center、Stretch、Zoom）
    ///     ImageSize：控件大小
    ///     InitialImage：初始图像
    ///     ActiveImage：活动图像
    /// </summary>
    public partial class FingerPictureBox : UserControl
    {
        private Int32 mouseX;
        private Int32 mouseY;
        private Image _InitialImage = null;

        public FingerPictureBox()
        {
            InitializeComponent();

            // 设置用户控件属性，允许用户在上面拖放数据
            this.AllowDrop = true;

            // 设置装载事件处理器
            this.Load += new EventHandler(this.FingerPictureBox_Load);

            // 设置拖动事件处理器
            this.DragDrop += new DragEventHandler(this.FingerPictureBox_DragDrop);
            this.DragEnter += new DragEventHandler(this.FingerPictureBox_DragEnter);
        }

        private void FingerPictureBox_Load(object sender, EventArgs e)
        {
            // 设置图片框停靠位置和方式
            this.Controls[0].Dock = DockStyle.None;

            // 设定图片框背景图像布局
            this.Controls[0].BackgroundImageLayout = ImageLayout.Stretch;

            // 设置图片框的起始位置和大小
            this.Controls[0].Location = new Point(0, 0);
            this.Controls[0].Size = this.Size;

            // 设置背景图像改变事件处理器
            this.Controls[0].BackgroundImageChanged += new EventHandler(this.FingerPictureBox_BackgroundImageChanged);
        }

        private void FingerPictureBox_DragDrop(object sender, DragEventArgs e)
        {   //  获取拖入的文件
            String[] DropFiles = (String[])(e.Data.GetData(DataFormats.FileDrop));
            if (DropFiles != null)
            {   // 设置控件背景图像
                this.Controls[0].BackgroundImage = Image.FromFile(DropFiles[0]);
            }  
        }

        private void FingerPictureBox_DragEnter(object sender, DragEventArgs e)
        {   // 拖放时显示的效果
            e.Effect = DragDropEffects.Link;
        }

        private void FingerPictureBox_MouseDown(object sender, MouseEventArgs e)
        {   // 记录鼠标单击时的初始位置
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
        }

        private void FingerPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ((PictureBox)sender).Left = Cursor.Position.X - mouseX;
                ((PictureBox)sender).Top = Cursor.Position.Y - mouseY;
            }
        }

        private void FingerPictureBox_MouseUp(object sender, MouseEventArgs e)
        {   // 判断图像是否移出边界
            if (((PictureBox)sender).Left > this.Width || ((PictureBox)sender).Right < 0 ||
                ((PictureBox)sender).Top > this.Height || ((PictureBox)sender).Bottom < 0)
            {   // 图像已经移出边界，恢复初始图像
                ((PictureBox)sender).BackgroundImage = _InitialImage;
            }

            // 图片框复位
            this.Controls[0].Location = new Point(0, 0);
        }

        private void FingerPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (this.Controls[0].BackgroundImage == _InitialImage)
            {   // 禁止图像拖动删除功能
                ((PictureBox)sender).MouseDown -= FingerPictureBox_MouseDown;
                ((PictureBox)sender).MouseMove -= FingerPictureBox_MouseMove;
                ((PictureBox)sender).MouseUp -= FingerPictureBox_MouseUp;
            }
            else
            {   // 恢复图像拖动删除功能
                ((PictureBox)sender).MouseDown += FingerPictureBox_MouseDown;
                ((PictureBox)sender).MouseMove += FingerPictureBox_MouseMove;
                ((PictureBox)sender).MouseUp += FingerPictureBox_MouseUp;
            }
        }

        /// <summary>
        /// 控件上图像的布局
        /// </summary>
        public ImageLayout ImageLayout
        {
            get
            {
                return this.Controls[0].BackgroundImageLayout;
            }
            set
            {
                this.Controls[0].BackgroundImageLayout = value;
            }
        }

        /// <summary>
        /// 控件大小
        /// </summary>
        public Size ImageSize
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Controls[0].Size = this.Size = value;
            }
        }

        /// <summary>
        /// 初始图像
        /// </summary>
        public Image InitialImage
        {
            get
            {
                return _InitialImage;
            }
            set
            {
                this.Controls[0].BackgroundImage = _InitialImage = value;
            }
        }

        /// <summary>
        /// 活动图像
        /// </summary>
        public Image ActiveImage
        {
            get
            {
                return this.Controls[0].BackgroundImage;
            }
            set
            {
                this.Controls[0].BackgroundImage = value;
            }
        }
    }
}
