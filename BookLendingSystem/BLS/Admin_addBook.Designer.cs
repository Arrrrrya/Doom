﻿namespace BLS {
    partial class Admin_addBook {
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
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_star = new System.Windows.Forms.Label();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_bookId = new System.Windows.Forms.Label();
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
            this.label2.Text = "书    名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "作    者：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_status);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.label_star);
            this.panel1.Controls.Add(this.btn_addBook);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label_bookId);
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
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(97, 118);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(100, 20);
            this.comboBox_status.TabIndex = 103;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 100;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(123, 225);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 107;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_star
            // 
            this.label_star.AutoSize = true;
            this.label_star.ForeColor = System.Drawing.Color.Red;
            this.label_star.Location = new System.Drawing.Point(82, 42);
            this.label_star.Name = "label_star";
            this.label_star.Size = new System.Drawing.Size(11, 12);
            this.label_star.TabIndex = 18;
            this.label_star.Text = "*";
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(23, 226);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(75, 23);
            this.btn_addBook.TabIndex = 106;
            this.btn_addBook.Text = "确认添加";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 105;
            this.textBox5.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 144);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 104;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 102;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 101;
            // 
            // label_bookId
            // 
            this.label_bookId.AutoSize = true;
            this.label_bookId.Location = new System.Drawing.Point(100, 17);
            this.label_bookId.Name = "label_bookId";
            this.label_bookId.Size = new System.Drawing.Size(53, 12);
            this.label_bookId.TabIndex = 8;
            this.label_bookId.Text = "自动生成";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "归还日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "借出日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "是否可借：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "图书类型：";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("宋体", 16F);
            this.label_title.Location = new System.Drawing.Point(24, 24);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(131, 22);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "*添加新图书";
            // 
            // Admin_addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_addBook";
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
        private System.Windows.Forms.Label label_bookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Label label_star;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_status;
    }
}