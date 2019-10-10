using BLS.model;
using BLS.service;
using MySDK;
using System;
using System.Windows.Forms;

/// <summary>
/// 新增用户窗口
/// </summary>
namespace BLS {
    public partial class Admin_lendBook : Form {
        private LendService lendService = new LendServiceImpl();

        public Admin_lendBook() {
            InitializeComponent();
            initialize();
        }

        /// <summary>
        /// 初始化界面显示
        /// </summary>
        private void initialize() {
            textBox1.Text = Common.bookDetail.book_id;
            textBox2.Text = Common.bookDetail.book_name;

            textBox5.Text = AutoCreateTool.getNowDate("yyyyMMdd");
        }

        /// <summary>
        /// 点击确认借出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addBook_Click(object sender, EventArgs e) {
            Lend lend = new Lend();
            lend.lend_id = AutoCreateTool.getlendID();
            lend.lend_book_id = Common.bookDetail.book_id;
            lend.lend_book_name = Common.bookDetail.book_name;
            lend.lend_user_id = Convert.ToInt32(textBox3.Text);
            lend.lend_user_name = textBox4.Text;
            lend.lend_create_date = AutoCreateTool.getNowDate("yyyyMMdd");
            
            lendService.addLend(lend);
            MessageBox.Show("借出成功");
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("是否放弃借出？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK) {
                Close();
            }
        }
    }
}
