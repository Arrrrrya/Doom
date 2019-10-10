using BLS.service;
using System;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// 普通用户操作界面
/// </summary>
namespace BLS {
    public partial class MenuForm_User : Form {
        private UserService userService = new UserServiceImpl();
        private BookService bookService = new BookServiceImpl();
        private LendService lendService = new LendServiceImpl();

        public MenuForm_User() {
            InitializeComponent();
            label_current.Text = Common.user.user_name;
        }

        /// <summary>
        /// 点击当前用户名，可修改用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_current_Click(object sender, EventArgs e) {
            Common.userDetail = Common.user;

            Form form = new Admin_updateUser();
            form.ShowDialog();
        }

        /// <summary>
        /// 点击所有图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_allBook_Click(object sender, EventArgs e) {
            DataTable dt = bookService.getBook();
            if(dt.Rows.Count > 0) {
                dataGridView.Visible = true;
                dataGridView.DataSource = dt;

                dataGridView.Columns["book_id"].HeaderText = "编号";
                dataGridView.Columns["book_name"].HeaderText = "书名";
                dataGridView.Columns["book_author"].HeaderText = "作者";
                dataGridView.Columns["book_type"].HeaderText = "类型";
                dataGridView.Columns["book_status"].HeaderText = "状态";
                dataGridView.Columns["book_out_date"].HeaderText = "借出日期";
                dataGridView.Columns["book_in_date"].HeaderText = "归还日期";
            } else {
                dataGridView.Visible = false;
            }
        }

        /// <summary>
        /// 点击借阅历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lendRecord_Click(object sender, EventArgs e) {
            DataTable dt = lendService.getLendByKeyWord(Common.user.user_name);
            if(dt.Rows.Count > 0) {
                dataGridView.Visible = true;
                dataGridView.DataSource = dt;

                dataGridView.Columns["lend_id"].HeaderText = "编号";
                dataGridView.Columns["lend_user_id"].HeaderText = "用户编号";
                dataGridView.Columns["lend_user_name"].HeaderText = "用户姓名";
                dataGridView.Columns["lend_book_id"].HeaderText = "图书编号";
                dataGridView.Columns["lend_book_name"].HeaderText = "书名";
                dataGridView.Columns["lend_create_date"].HeaderText = "借出日期";
                dataGridView.Columns["lend_update_date"].HeaderText = "更新日期";
                dataGridView.Columns["lend_status"].HeaderText = "借阅状态";
            } else {
                dataGridView.Visible = false;
            }
        }

        /// <summary>
        /// 点击查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e) {

        }
    }
}
