using BLS.model;
using BLS.service;
using System;
using System.Windows.Forms;

/// <summary>
/// 新增用户窗口
/// </summary>
namespace BLS {
    public partial class Admin_updateBook : Form {
        private BookService bookService = new BookServiceImpl();

        public Admin_updateBook() {
            InitializeComponent();
            initialize();
        }

        private void initialize() {
            label_bookId.Text = Common.bookDetail.book_id;
            textBox1.Text = Common.bookDetail.book_name;
            textBox2.Text = Common.bookDetail.book_author;
            textBox3.Text = Common.bookDetail.book_type;

            comboBox_status.Items.Add(Common.bookStatus_1);
            comboBox_status.Items.Add(Common.bookStatus_2);
            string bookStatus = Common.bookDetail.book_status;
            if(Common.bookDetail.book_status == Common.bookStatus_2) {
                comboBox_status.SelectedIndex = 1;
            } else {
                comboBox_status.SelectedIndex = 0;
            }

            textBox4.Text = Common.bookDetail.book_out_date;
            textBox5.Text = Common.bookDetail.book_in_date;


        }

        // 点击确认修改按钮
        private void btn_addBook_Click(object sender, EventArgs e) {
            Book book = new Book();
            book.book_id = label_bookId.Text;
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

            bookService.updateBook(book);
            MessageBox.Show("修改成功");
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("是否放弃修改？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK) {
                Close();
            }
        }
    }
}
