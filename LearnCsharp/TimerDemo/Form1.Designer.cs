namespace TimerDemo {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_upper = new System.Windows.Forms.Panel();
            this.panel_downer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEnded = new System.Windows.Forms.RadioButton();
            this.radioStarted = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelCounter = new System.Windows.Forms.Label();
            this.panel_upper.SuspendLayout();
            this.panel_downer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(5, 36);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(41, 35);
            this.btnDecrease.TabIndex = 0;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 35);
            this.progressBar1.TabIndex = 1;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(373, 36);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(36, 35);
            this.btnIncrease.TabIndex = 2;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(5, 38);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(75, 50);
            this.btnControl.TabIndex = 3;
            this.btnControl.Text = "start";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(99, 38);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(310, 50);
            this.progressBar2.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_upper
            // 
            this.panel_upper.Controls.Add(this.progressBar1);
            this.panel_upper.Controls.Add(this.btnDecrease);
            this.panel_upper.Controls.Add(this.btnIncrease);
            this.panel_upper.Location = new System.Drawing.Point(12, 12);
            this.panel_upper.Name = "panel_upper";
            this.panel_upper.Size = new System.Drawing.Size(446, 118);
            this.panel_upper.TabIndex = 5;
            // 
            // panel_downer
            // 
            this.panel_downer.Controls.Add(this.progressBar2);
            this.panel_downer.Controls.Add(this.btnControl);
            this.panel_downer.Location = new System.Drawing.Point(12, 136);
            this.panel_downer.Name = "panel_downer";
            this.panel_downer.Size = new System.Drawing.Size(446, 139);
            this.panel_downer.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEnded);
            this.groupBox1.Controls.Add(this.radioStarted);
            this.groupBox1.Location = new System.Drawing.Point(464, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态栏";
            // 
            // radioEnded
            // 
            this.radioEnded.AutoSize = true;
            this.radioEnded.Location = new System.Drawing.Point(7, 69);
            this.radioEnded.Name = "radioEnded";
            this.radioEnded.Size = new System.Drawing.Size(59, 16);
            this.radioEnded.TabIndex = 1;
            this.radioEnded.Text = "停止中";
            this.radioEnded.UseVisualStyleBackColor = true;
            this.radioEnded.CheckedChanged += new System.EventHandler(this.radioEnded_CheckedChanged);
            // 
            // radioStarted
            // 
            this.radioStarted.AutoSize = true;
            this.radioStarted.Location = new System.Drawing.Point(7, 41);
            this.radioStarted.Name = "radioStarted";
            this.radioStarted.Size = new System.Drawing.Size(59, 16);
            this.radioStarted.TabIndex = 0;
            this.radioStarted.Text = "启动中";
            this.radioStarted.UseVisualStyleBackColor = true;
            this.radioStarted.CheckedChanged += new System.EventHandler(this.radioStarted_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.labelCounter);
            this.groupBox2.Location = new System.Drawing.Point(464, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 118);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已操作次数";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(7, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置计数";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCounter.Location = new System.Drawing.Point(6, 36);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(20, 22);
            this.labelCounter.TabIndex = 0;
            this.labelCounter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_downer);
            this.Controls.Add(this.panel_upper);
            this.Name = "Form1";
            this.Text = "TimerDemo";
            this.panel_upper.ResumeLayout(false);
            this.panel_downer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_upper;
        private System.Windows.Forms.Panel panel_downer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEnded;
        private System.Windows.Forms.RadioButton radioStarted;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Button btnReset;
    }
}

