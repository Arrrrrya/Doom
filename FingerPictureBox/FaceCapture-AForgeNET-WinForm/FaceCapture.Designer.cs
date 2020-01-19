namespace Splash
{
    partial class FaceCapture
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceCapture));
            this.vsp = new AForge.Controls.VideoSourcePlayer();
            this.button_Capture = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Play = new System.Windows.Forms.Button();
            this.fingerPictureBox4 = new Splash.FingerPictureBox();
            this.fingerPictureBox3 = new Splash.FingerPictureBox();
            this.fingerPictureBox2 = new Splash.FingerPictureBox();
            this.fingerPictureBox1 = new Splash.FingerPictureBox();
            this.comboBoxVideoDevices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // vsp
            // 
            this.vsp.BackColor = System.Drawing.Color.Black;
            this.vsp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vsp.ForeColor = System.Drawing.Color.White;
            this.vsp.Location = new System.Drawing.Point(12, 45);
            this.vsp.Name = "vsp";
            this.vsp.Size = new System.Drawing.Size(318, 335);
            this.vsp.TabIndex = 0;
            this.vsp.VideoSource = null;
            // 
            // button_Capture
            // 
            this.button_Capture.Enabled = false;
            this.button_Capture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Capture.ImageIndex = 2;
            this.button_Capture.ImageList = this.imageList1;
            this.button_Capture.Location = new System.Drawing.Point(215, 386);
            this.button_Capture.Name = "button_Capture";
            this.button_Capture.Size = new System.Drawing.Size(115, 40);
            this.button_Capture.TabIndex = 4;
            this.button_Capture.Text = "抓拍图像";
            this.button_Capture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Capture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Capture.UseVisualStyleBackColor = true;
            this.button_Capture.Click += new System.EventHandler(this.button_Capture_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Button-Play-icon2.png");
            this.imageList1.Images.SetKeyName(1, "Button-Stop-icon.png");
            this.imageList1.Images.SetKeyName(2, "capture.png");
            // 
            // button_Play
            // 
            this.button_Play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Play.ImageIndex = 0;
            this.button_Play.ImageList = this.imageList1;
            this.button_Play.Location = new System.Drawing.Point(16, 386);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(115, 40);
            this.button_Play.TabIndex = 5;
            this.button_Play.Text = "开启视频";
            this.button_Play.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // fingerPictureBox4
            // 
            this.fingerPictureBox4.ActiveImage = null;
            this.fingerPictureBox4.AllowDrop = true;
            this.fingerPictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerPictureBox4.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fingerPictureBox4.ImageSize = new System.Drawing.Size(173, 196);
            this.fingerPictureBox4.InitialImage = null;
            this.fingerPictureBox4.Location = new System.Drawing.Point(541, 230);
            this.fingerPictureBox4.Name = "fingerPictureBox4";
            this.fingerPictureBox4.Size = new System.Drawing.Size(173, 196);
            this.fingerPictureBox4.TabIndex = 9;
            // 
            // fingerPictureBox3
            // 
            this.fingerPictureBox3.ActiveImage = null;
            this.fingerPictureBox3.AllowDrop = true;
            this.fingerPictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerPictureBox3.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fingerPictureBox3.ImageSize = new System.Drawing.Size(173, 196);
            this.fingerPictureBox3.InitialImage = null;
            this.fingerPictureBox3.Location = new System.Drawing.Point(345, 230);
            this.fingerPictureBox3.Name = "fingerPictureBox3";
            this.fingerPictureBox3.Size = new System.Drawing.Size(173, 196);
            this.fingerPictureBox3.TabIndex = 8;
            // 
            // fingerPictureBox2
            // 
            this.fingerPictureBox2.ActiveImage = null;
            this.fingerPictureBox2.AllowDrop = true;
            this.fingerPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerPictureBox2.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fingerPictureBox2.ImageSize = new System.Drawing.Size(173, 196);
            this.fingerPictureBox2.InitialImage = null;
            this.fingerPictureBox2.Location = new System.Drawing.Point(541, 12);
            this.fingerPictureBox2.Name = "fingerPictureBox2";
            this.fingerPictureBox2.Size = new System.Drawing.Size(173, 196);
            this.fingerPictureBox2.TabIndex = 7;
            // 
            // fingerPictureBox1
            // 
            this.fingerPictureBox1.ActiveImage = null;
            this.fingerPictureBox1.AllowDrop = true;
            this.fingerPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerPictureBox1.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fingerPictureBox1.ImageSize = new System.Drawing.Size(173, 196);
            this.fingerPictureBox1.InitialImage = null;
            this.fingerPictureBox1.Location = new System.Drawing.Point(345, 12);
            this.fingerPictureBox1.Name = "fingerPictureBox1";
            this.fingerPictureBox1.Size = new System.Drawing.Size(173, 196);
            this.fingerPictureBox1.TabIndex = 6;
            // 
            // comboBoxVideoDevices
            // 
            this.comboBoxVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoDevices.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxVideoDevices.FormattingEnabled = true;
            this.comboBoxVideoDevices.Location = new System.Drawing.Point(12, 7);
            this.comboBoxVideoDevices.Name = "comboBoxVideoDevices";
            this.comboBoxVideoDevices.Size = new System.Drawing.Size(318, 29);
            this.comboBoxVideoDevices.TabIndex = 10;
            // 
            // FaceCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 444);
            this.Controls.Add(this.comboBoxVideoDevices);
            this.Controls.Add(this.fingerPictureBox4);
            this.Controls.Add(this.fingerPictureBox3);
            this.Controls.Add(this.fingerPictureBox2);
            this.Controls.Add(this.fingerPictureBox1);
            this.Controls.Add(this.button_Capture);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.vsp);
            this.MaximizeBox = false;
            this.Name = "FaceCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceCapture-AForgeNET-WinForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaceCapture_FormClosing);
            this.Load += new System.EventHandler(this.FaceCapture_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vsp;
        private System.Windows.Forms.Button button_Capture;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_Play;
        private Splash.FingerPictureBox fingerPictureBox1;
        private Splash.FingerPictureBox fingerPictureBox2;
        private Splash.FingerPictureBox fingerPictureBox3;
        private Splash.FingerPictureBox fingerPictureBox4;
        private System.Windows.Forms.ComboBox comboBoxVideoDevices;
    }
}

