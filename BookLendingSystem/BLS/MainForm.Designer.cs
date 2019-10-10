namespace BLS {
    partial class MainForm {
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.lable_title = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.checkBox_remember = new System.Windows.Forms.CheckBox();
            this.label_visitor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtn_user = new System.Windows.Forms.RadioButton();
            this.radioBtn_admin = new System.Windows.Forms.RadioButton();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(92, 59);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名：";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(92, 94);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(41, 12);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "密码：";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(139, 56);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.Text = "admin";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(139, 91);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 21);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.Text = "admin";
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("宋体", 16F);
            this.lable_title.Location = new System.Drawing.Point(95, 12);
            this.lable_title.Margin = new System.Windows.Forms.Padding(0);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(142, 22);
            this.lable_title.TabIndex = 4;
            this.lable_title.Text = "图书借阅系统";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(91, 192);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Controls.Add(this.checkBox_remember);
            this.panel_main.Controls.Add(this.label_visitor);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.lable_title);
            this.panel_main.Controls.Add(this.label_name);
            this.panel_main.Controls.Add(this.btn_login);
            this.panel_main.Controls.Add(this.label_password);
            this.panel_main.Controls.Add(this.textBox_password);
            this.panel_main.Controls.Add(this.textBox_name);
            this.panel_main.Location = new System.Drawing.Point(12, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(323, 235);
            this.panel_main.TabIndex = 6;
            // 
            // checkBox_remember
            // 
            this.checkBox_remember.AutoSize = true;
            this.checkBox_remember.Checked = true;
            this.checkBox_remember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_remember.Location = new System.Drawing.Point(140, 127);
            this.checkBox_remember.Name = "checkBox_remember";
            this.checkBox_remember.Size = new System.Drawing.Size(72, 16);
            this.checkBox_remember.TabIndex = 10;
            this.checkBox_remember.Text = "记住密码";
            this.checkBox_remember.UseVisualStyleBackColor = true;
            // 
            // label_visitor
            // 
            this.label_visitor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_visitor.ForeColor = System.Drawing.Color.Blue;
            this.label_visitor.Location = new System.Drawing.Point(183, 197);
            this.label_visitor.Name = "label_visitor";
            this.label_visitor.Size = new System.Drawing.Size(58, 18);
            this.label_visitor.TabIndex = 8;
            this.label_visitor.Text = "游客进入";
            this.label_visitor.Click += new System.EventHandler(this.label_visitor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtn_user);
            this.panel1.Controls.Add(this.radioBtn_admin);
            this.panel1.Location = new System.Drawing.Point(92, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 23);
            this.panel1.TabIndex = 7;
            // 
            // radioBtn_user
            // 
            this.radioBtn_user.AutoSize = true;
            this.radioBtn_user.Location = new System.Drawing.Point(76, 4);
            this.radioBtn_user.Name = "radioBtn_user";
            this.radioBtn_user.Size = new System.Drawing.Size(71, 16);
            this.radioBtn_user.TabIndex = 7;
            this.radioBtn_user.Text = "普通用户";
            this.radioBtn_user.UseVisualStyleBackColor = true;
            // 
            // radioBtn_admin
            // 
            this.radioBtn_admin.AutoSize = true;
            this.radioBtn_admin.Checked = true;
            this.radioBtn_admin.Location = new System.Drawing.Point(3, 4);
            this.radioBtn_admin.Name = "radioBtn_admin";
            this.radioBtn_admin.Size = new System.Drawing.Size(59, 16);
            this.radioBtn_admin.TabIndex = 6;
            this.radioBtn_admin.TabStop = true;
            this.radioBtn_admin.Text = "管理员";
            this.radioBtn_admin.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 259);
            this.Controls.Add(this.panel_main);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅系统";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label lable_title;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.RadioButton radioBtn_admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtn_user;
        private System.Windows.Forms.Label label_visitor;
        private System.Windows.Forms.CheckBox checkBox_remember;
    }
}

