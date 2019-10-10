namespace BLS {
    partial class Admin_addUser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_star = new System.Windows.Forms.Label();
            this.radioButton_userType = new System.Windows.Forms.RadioButton();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.textBox_userPhone = new System.Windows.Forms.TextBox();
            this.textBox_userInfo = new System.Windows.Forms.TextBox();
            this.textBox_userGender = new System.Windows.Forms.TextBox();
            this.textBox_userAge = new System.Windows.Forms.TextBox();
            this.textBox_userPassword = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_userType = new System.Windows.Forms.Label();
            this.label_userId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编    号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓    名：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.label_star);
            this.panel1.Controls.Add(this.radioButton_userType);
            this.panel1.Controls.Add(this.btn_addUser);
            this.panel1.Controls.Add(this.textBox_userPhone);
            this.panel1.Controls.Add(this.textBox_userInfo);
            this.panel1.Controls.Add(this.textBox_userGender);
            this.panel1.Controls.Add(this.textBox_userAge);
            this.panel1.Controls.Add(this.textBox_userPassword);
            this.panel1.Controls.Add(this.textBox_userName);
            this.panel1.Controls.Add(this.label_userType);
            this.panel1.Controls.Add(this.label_userId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 286);
            this.panel1.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(123, 241);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_star
            // 
            this.label_star.AutoSize = true;
            this.label_star.ForeColor = System.Drawing.Color.Red;
            this.label_star.Location = new System.Drawing.Point(82, 69);
            this.label_star.Name = "label_star";
            this.label_star.Size = new System.Drawing.Size(11, 12);
            this.label_star.TabIndex = 18;
            this.label_star.Text = "*";
            // 
            // radioButton_userType
            // 
            this.radioButton_userType.AutoSize = true;
            this.radioButton_userType.Checked = true;
            this.radioButton_userType.Location = new System.Drawing.Point(102, 42);
            this.radioButton_userType.Name = "radioButton_userType";
            this.radioButton_userType.Size = new System.Drawing.Size(14, 13);
            this.radioButton_userType.TabIndex = 17;
            this.radioButton_userType.TabStop = true;
            this.radioButton_userType.UseVisualStyleBackColor = true;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(23, 242);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(75, 23);
            this.btn_addUser.TabIndex = 16;
            this.btn_addUser.Text = "确认添加";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // textBox_userPhone
            // 
            this.textBox_userPhone.Location = new System.Drawing.Point(97, 198);
            this.textBox_userPhone.Name = "textBox_userPhone";
            this.textBox_userPhone.Size = new System.Drawing.Size(100, 21);
            this.textBox_userPhone.TabIndex = 15;
            // 
            // textBox_userInfo
            // 
            this.textBox_userInfo.Location = new System.Drawing.Point(97, 170);
            this.textBox_userInfo.Name = "textBox_userInfo";
            this.textBox_userInfo.Size = new System.Drawing.Size(100, 21);
            this.textBox_userInfo.TabIndex = 14;
            // 
            // textBox_userGender
            // 
            this.textBox_userGender.Location = new System.Drawing.Point(97, 144);
            this.textBox_userGender.Name = "textBox_userGender";
            this.textBox_userGender.Size = new System.Drawing.Size(100, 21);
            this.textBox_userGender.TabIndex = 13;
            // 
            // textBox_userAge
            // 
            this.textBox_userAge.Location = new System.Drawing.Point(97, 118);
            this.textBox_userAge.Name = "textBox_userAge";
            this.textBox_userAge.Size = new System.Drawing.Size(100, 21);
            this.textBox_userAge.TabIndex = 12;
            // 
            // textBox_userPassword
            // 
            this.textBox_userPassword.Location = new System.Drawing.Point(97, 92);
            this.textBox_userPassword.Name = "textBox_userPassword";
            this.textBox_userPassword.ReadOnly = true;
            this.textBox_userPassword.Size = new System.Drawing.Size(100, 21);
            this.textBox_userPassword.TabIndex = 11;
            this.textBox_userPassword.Text = "123456";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(97, 65);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(100, 21);
            this.textBox_userName.TabIndex = 10;
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Location = new System.Drawing.Point(123, 43);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(53, 12);
            this.label_userType.TabIndex = 9;
            this.label_userType.Text = "普通用户";
            // 
            // label_userId
            // 
            this.label_userId.AutoSize = true;
            this.label_userId.Location = new System.Drawing.Point(100, 17);
            this.label_userId.Name = "label_userId";
            this.label_userId.Size = new System.Drawing.Size(53, 12);
            this.label_userId.TabIndex = 8;
            this.label_userId.Text = "自动生成";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "手 机 号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "备    注：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "性    别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "年    龄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密    码：";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("宋体", 16F);
            this.label_title.Location = new System.Drawing.Point(24, 24);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(131, 22);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "*添加新用户";
            // 
            // Admin_addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_addUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅系统";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_userId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_userPhone;
        private System.Windows.Forms.TextBox textBox_userInfo;
        private System.Windows.Forms.TextBox textBox_userGender;
        private System.Windows.Forms.TextBox textBox_userAge;
        private System.Windows.Forms.TextBox textBox_userPassword;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label_userType;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.RadioButton radioButton_userType;
        private System.Windows.Forms.Label label_star;
        private System.Windows.Forms.Button btn_Cancel;
    }
}