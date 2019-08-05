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
            this.SuspendLayout();
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(17, 23);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(41, 35);
            this.btnDecrease.TabIndex = 0;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 35);
            this.progressBar1.TabIndex = 1;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(404, 23);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(36, 35);
            this.btnIncrease.TabIndex = 2;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(17, 101);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(75, 50);
            this.btnControl.TabIndex = 3;
            this.btnControl.Text = "start";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(116, 101);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(324, 50);
            this.progressBar2.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 189);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDecrease);
            this.Name = "Form1";
            this.Text = "TimerDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
    }
}

