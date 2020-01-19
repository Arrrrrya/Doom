/* ----------------------------------------------------------
文件名称：FaceCapture.cs

作者：秦建辉

微信：splashcn

博客：http://www.firstsolver.com/wordpress/

开发环境：
    Visual Studio V2015
    .NET Framework 4 Client Profile
    AForge.NET 2.2.5
 
版本历史：
    V1.0	2016年11月01日
			基于AForge.NET实现视频与图像抓取

参考资料：
    http://www.aforgenet.com/framework/
------------------------------------------------------------ */
using AForge.Video.DirectShow;
using System;
using System.Windows.Forms;

namespace Splash
{
    public partial class FaceCapture : Form
    {
        public FaceCapture()
        {
            InitializeComponent();

            // 设置窗体图标
            this.Icon = Properties.Resources.FingerPictureBox;
        }

        private void FaceCapture_Load(object sender, EventArgs e)
        {   // 设定初始视频设备
            comboBoxVideoDevices.DataSource = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBoxVideoDevices.DisplayMember = "Name";
            if (comboBoxVideoDevices.Items.Count > 0)
            {
                comboBoxVideoDevices.SelectedIndex = 0;
                if (comboBoxVideoDevices.Items.Count == 1) comboBoxVideoDevices.Enabled = false;
            }
            else
            {
                button_Play.Enabled = false;
                button_Capture.Enabled = false;               
            }

            // 设置图片框初始图像
            for (Int32 i = 1; i <= 4; i++)
            {
                FingerPictureBox box = (FingerPictureBox)this.Controls["fingerPictureBox" + i];
                box.InitialImage = Properties.Resources.noimage; 
            }
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (((Button)sender).ImageIndex == 0)
            {
                if (comboBoxVideoDevices.SelectedIndex != -1)
                {   // 开启视频
                    vsp.VideoSource = new VideoCaptureDevice(((FilterInfo)comboBoxVideoDevices.SelectedItem).MonikerString);
                    vsp.Start();
                    if (vsp.IsRunning)
                    {   // 改变按钮为“停止”状态
                        ((Button)sender).ImageIndex = 1;
                        ((Button)sender).Text = "停止";

                        // 允许拍照
                        button_Capture.Enabled = true;
                    }
                }
            }
            else
            {
                if (vsp.IsRunning)
                {
                    // 停止视频
                    vsp.SignalToStop();
                    vsp.WaitForStop();

                    // 改变按钮为“开始”状态
                    ((Button)sender).ImageIndex = 0;
                    ((Button)sender).Text = "开启视频";

                    // 关闭拍照
                    button_Capture.Enabled = false;
                }
            }
        }

        private void button_Capture_Click(object sender, EventArgs e)
        {
            // 判断视频设备是否开启
            if (vsp.IsRunning)
            {   // 进行拍照
                for (Int32 i = 1; i <= 4; i++)
                {
                    FingerPictureBox box = (FingerPictureBox)this.Controls["fingerPictureBox" + i];
                    if (box.ActiveImage == box.InitialImage)
                    {   // 更新图像
                        box.ActiveImage = vsp.GetCurrentVideoFrame();
                        break;
                    }
                }
            }
        }

        private void FaceCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vsp.IsRunning)
            {   // 停止视频
                vsp.SignalToStop();
                vsp.WaitForStop();
            }
        }        
    }
}
