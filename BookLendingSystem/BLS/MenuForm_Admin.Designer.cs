namespace BLS {
    partial class MenuForm_Admin {
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
            this.currentUser_panel = new System.Windows.Forms.Panel();
            this.label_current = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuPanel_admin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAllUser = new System.Windows.Forms.Button();
            this.btnAllBook = new System.Windows.Forms.Button();
            this.btnAllLending = new System.Windows.Forms.Button();
            this.btnAllApply = new System.Windows.Forms.Button();
            this.currentUser_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuPanel_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentUser_panel
            // 
            this.currentUser_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUser_panel.Controls.Add(this.label_current);
            this.currentUser_panel.Controls.Add(this.label);
            this.currentUser_panel.Location = new System.Drawing.Point(634, 5);
            this.currentUser_panel.Name = "currentUser_panel";
            this.currentUser_panel.Size = new System.Drawing.Size(145, 44);
            this.currentUser_panel.TabIndex = 1;
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Location = new System.Drawing.Point(86, 16);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(41, 12);
            this.label_current.TabIndex = 1;
            this.label_current.Text = "未登录";
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
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.Controls.Add(this.panel1);
            this.main_panel.Controls.Add(this.menuPanel_admin);
            this.main_panel.Location = new System.Drawing.Point(17, 68);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(755, 382);
            this.main_panel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnLend);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(94, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 245);
            this.panel1.TabIndex = 4;
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(372, 3);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(75, 23);
            this.btnLend.TabIndex = 7;
            this.btnLend.Text = "借出";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(207, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(123, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(14, 3);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 21);
            this.textBox_search.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(630, 194);
            this.dataGridView.TabIndex = 2;
            // 
            // menuPanel_admin
            // 
            this.menuPanel_admin.Controls.Add(this.btnAllUser);
            this.menuPanel_admin.Controls.Add(this.btnAllBook);
            this.menuPanel_admin.Controls.Add(this.btnAllLending);
            this.menuPanel_admin.Controls.Add(this.btnAllApply);
            this.menuPanel_admin.Location = new System.Drawing.Point(3, 3);
            this.menuPanel_admin.Name = "menuPanel_admin";
            this.menuPanel_admin.Size = new System.Drawing.Size(85, 245);
            this.menuPanel_admin.TabIndex = 1;
            // 
            // btnAllUser
            // 
            this.btnAllUser.Location = new System.Drawing.Point(3, 3);
            this.btnAllUser.Name = "btnAllUser";
            this.btnAllUser.Size = new System.Drawing.Size(75, 23);
            this.btnAllUser.TabIndex = 0;
            this.btnAllUser.Text = "用户管理";
            this.btnAllUser.UseVisualStyleBackColor = true;
            this.btnAllUser.Click += new System.EventHandler(this.btnAllUser_Click);
            // 
            // btnAllBook
            // 
            this.btnAllBook.Location = new System.Drawing.Point(3, 32);
            this.btnAllBook.Name = "btnAllBook";
            this.btnAllBook.Size = new System.Drawing.Size(75, 23);
            this.btnAllBook.TabIndex = 1;
            this.btnAllBook.Text = "图书管理";
            this.btnAllBook.UseVisualStyleBackColor = true;
            this.btnAllBook.Click += new System.EventHandler(this.btnAllBook_Click);
            // 
            // btnAllLending
            // 
            this.btnAllLending.Location = new System.Drawing.Point(3, 61);
            this.btnAllLending.Name = "btnAllLending";
            this.btnAllLending.Size = new System.Drawing.Size(75, 23);
            this.btnAllLending.TabIndex = 2;
            this.btnAllLending.Text = "借阅管理";
            this.btnAllLending.UseVisualStyleBackColor = true;
            this.btnAllLending.Click += new System.EventHandler(this.btnAllLending_Click);
            // 
            // btnAllApply
            // 
            this.btnAllApply.Location = new System.Drawing.Point(3, 90);
            this.btnAllApply.Name = "btnAllApply";
            this.btnAllApply.Size = new System.Drawing.Size(75, 23);
            this.btnAllApply.TabIndex = 3;
            this.btnAllApply.Text = "申请管理";
            this.btnAllApply.UseVisualStyleBackColor = true;
            this.btnAllApply.Click += new System.EventHandler(this.btnAllApply_Click);
            // 
            // MenuForm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.currentUser_panel);
            this.Name = "MenuForm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅系统-管理员";
            this.currentUser_panel.ResumeLayout(false);
            this.currentUser_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuPanel_admin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel currentUser_panel;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.FlowLayoutPanel menuPanel_admin;
        private System.Windows.Forms.Button btnAllUser;
        private System.Windows.Forms.Button btnAllBook;
        private System.Windows.Forms.Button btnAllLending;
        private System.Windows.Forms.Button btnAllApply;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLend;
    }
}