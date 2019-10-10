namespace BLS {
    partial class MenuForm_User {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_lendRecord = new System.Windows.Forms.Button();
            this.btn_allBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_current = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_lendRecord);
            this.panel1.Controls.Add(this.btn_allBook);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 245);
            this.panel1.TabIndex = 0;
            // 
            // btn_lendRecord
            // 
            this.btn_lendRecord.Location = new System.Drawing.Point(5, 32);
            this.btn_lendRecord.Name = "btn_lendRecord";
            this.btn_lendRecord.Size = new System.Drawing.Size(75, 23);
            this.btn_lendRecord.TabIndex = 1;
            this.btn_lendRecord.Text = "借阅历史";
            this.btn_lendRecord.UseVisualStyleBackColor = true;
            this.btn_lendRecord.Click += new System.EventHandler(this.btn_lendRecord_Click);
            // 
            // btn_allBook
            // 
            this.btn_allBook.Location = new System.Drawing.Point(5, 3);
            this.btn_allBook.Name = "btn_allBook";
            this.btn_allBook.Size = new System.Drawing.Size(75, 23);
            this.btn_allBook.TabIndex = 0;
            this.btn_allBook.Text = "所有图书";
            this.btn_allBook.UseVisualStyleBackColor = true;
            this.btn_allBook.Click += new System.EventHandler(this.btn_allBook_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_current);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(636, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 44);
            this.panel2.TabIndex = 1;
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_current.ForeColor = System.Drawing.Color.Blue;
            this.label_current.Location = new System.Drawing.Point(86, 16);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(41, 12);
            this.label_current.TabIndex = 1;
            this.label_current.Text = "未登录";
            this.label_current.Click += new System.EventHandler(this.label_current_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 12);
            this.label.TabIndex = 0;
            this.label.Text = "当前用户：";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("宋体", 20F);
            this.label_title.Location = new System.Drawing.Point(12, 15);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(148, 27);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "* 功能导航";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.textBox_search);
            this.panel3.Location = new System.Drawing.Point(112, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 245);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 32);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(639, 210);
            this.dataGridView.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(118, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(12, 5);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 21);
            this.textBox_search.TabIndex = 0;
            // 
            // MenuForm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuForm_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅系统-普通用户";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_allBook;
        private System.Windows.Forms.Button btn_lendRecord;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}