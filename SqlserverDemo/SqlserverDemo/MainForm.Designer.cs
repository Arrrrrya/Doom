namespace SqlserverDemo {
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
            this.btn_select = new System.Windows.Forms.Button();
            this.dbDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_select = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textbox_select = new System.Windows.Forms.TextBox();
            this.panel_current = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_current = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).BeginInit();
            this.panel_select.SuspendLayout();
            this.panel_current.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(56, 56);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "查询用户";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dbDataGridView
            // 
            this.dbDataGridView.AllowUserToAddRows = false;
            this.dbDataGridView.AllowUserToDeleteRows = false;
            this.dbDataGridView.AllowUserToResizeColumns = false;
            this.dbDataGridView.AllowUserToResizeRows = false;
            this.dbDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView.Location = new System.Drawing.Point(12, 109);
            this.dbDataGridView.Name = "dbDataGridView";
            this.dbDataGridView.RowTemplate.Height = 23;
            this.dbDataGridView.Size = new System.Drawing.Size(426, 171);
            this.dbDataGridView.TabIndex = 1;
            this.dbDataGridView.Visible = false;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(218, 16);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_select
            // 
            this.panel_select.Controls.Add(this.btn_reset);
            this.panel_select.Controls.Add(this.btn_add);
            this.panel_select.Controls.Add(this.btn_login);
            this.panel_select.Controls.Add(this.btn_delete);
            this.panel_select.Controls.Add(this.textbox_select);
            this.panel_select.Controls.Add(this.btn_select);
            this.panel_select.Location = new System.Drawing.Point(12, 12);
            this.panel_select.Name = "panel_select";
            this.panel_select.Size = new System.Drawing.Size(303, 91);
            this.panel_select.TabIndex = 6;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(137, 16);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "重新输入";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(218, 56);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "新增";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(137, 56);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // textbox_select
            // 
            this.textbox_select.Location = new System.Drawing.Point(3, 18);
            this.textbox_select.Name = "textbox_select";
            this.textbox_select.Size = new System.Drawing.Size(128, 21);
            this.textbox_select.TabIndex = 1;
            // 
            // panel_current
            // 
            this.panel_current.Controls.Add(this.btn_logout);
            this.panel_current.Controls.Add(this.label2);
            this.panel_current.Controls.Add(this.label_current);
            this.panel_current.Location = new System.Drawing.Point(321, 12);
            this.panel_current.Name = "panel_current";
            this.panel_current.Size = new System.Drawing.Size(117, 91);
            this.panel_current.TabIndex = 8;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(39, 56);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "退出登录";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前用户:";
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Location = new System.Drawing.Point(73, 21);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(41, 12);
            this.label_current.TabIndex = 0;
            this.label_current.Text = "未登录";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 292);
            this.Controls.Add(this.panel_current);
            this.Controls.Add(this.panel_select);
            this.Controls.Add(this.dbDataGridView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).EndInit();
            this.panel_select.ResumeLayout(false);
            this.panel_select.PerformLayout();
            this.panel_current.ResumeLayout(false);
            this.panel_current.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView dbDataGridView;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel_select;
        private System.Windows.Forms.TextBox textbox_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel_current;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_reset;
    }
}

