using BLS.model;
using BLS.service;
using MySDK;
using System;
using System.Windows.Forms;

/// <summary>
/// 新增用户窗口
/// </summary>
namespace BLS {
    public partial class Admin_addBook : Form {
        private BookService bookService = new BookServiceImpl();

        public Admin_addBook() {
            InitializeComponent();
            initialize();
        }

        private void initialize() {
            comboBox_status.Items.Add(Common.bookStatus_1);
            comboBox_status.Items.Add(Common.bookStatus_2);
            comboBox_status.SelectedIndex = 0;
        }

        // 点击确认新增按钮
        private void btn_addBook_Click(object sender, EventArgs e) {
            Book book = new Book();
            book.book_id = AutoCreateTool.getBookID();
            book.book_name = textBox1.Text;
            book.book_author = textBox2.Text;
            book.book_type = textBox3.Text;
            if(comboBox_status.SelectedIndex == 0) {
                book.book_status = Common.bookStatus_1;
            } else {
                book.book_status = Common.bookStatus_2;
            }
            book.book_out_date = textBox4.Text;
            book.book_in_date = textBox5.Text;

            if(book.book_name == "") {
                MessageBox.Show("书名不能为空");
            } else {
                bookService.addBook(book);
                MessageBox.Show("添加成功");
                Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("是否放弃添加？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK) {
                Close();
            }
        }
    }
}
