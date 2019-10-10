using BLS.model;
using BLS.service;
using MySDK;
using System;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// 管理员操作界面
/// </summary>
namespace BLS {
    public partial class MenuForm_Admin : Form {
        private UserService userService = new UserServiceImpl();
        private BookService bookService = new BookServiceImpl();
        private LendService lendService = new LendServiceImpl();
        private ApplyService applyService = new ApplyServiceImpl();

        public MenuForm_Admin() {
            InitializeComponent();
            InitializeBtn();
            InitializeDataGridClick();
        }

        /// <summary>
        /// 初始化当前用户名和按钮的显示情况
        /// </summary>
        private void InitializeBtn() {
            label_current.Text = Common.user.user_name;
            textBox_search.Visible = false;
            btnSearch.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnLend.Visible = false;
        }

        /// <summary>
        /// 绑定单元格点击事件，单击/双击
        /// </summary>
        private void InitializeDataGridClick() {
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
        }

        /// <summary>
        /// 点击用户管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllUser_Click(object sender, EventArgs e) {
            Common.currentDataGrid = "用户";
            btnSearch.Text = "查询用户";
            btnAdd.Text = "新增用户";
            btnDelete.Text = "删除用户";
            textBox_search.Visible = true;
            btnSearch.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnLend.Visible = false;

            DataTable dt = userService.getUser();
            if(dt.Rows.Count > 0) {
                dataGridView.Visible = true;
                dataGridView.DataSource = dt;

                dataGridView.Columns["user_id"].HeaderText = "编号";
                dataGridView.Columns["user_name"].HeaderText = "姓名";
                dataGridView.Columns["user_type"].HeaderText = "用户类型";
                dataGridView.Columns["user_password"].HeaderText = "密码";
                dataGridView.Columns["user_info"].HeaderText = "备注";
                dataGridView.Columns["user_gender"].HeaderText = "性别";
                dataGridView.Columns["user_phone"].HeaderText = "手机号";
                dataGridView.Columns["user_age"].HeaderText = "年龄";
            } else {
                dataGridView.Visible = false;
            }
        }

        /// <summary>
        /// 点击图书管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllBook_Click(object sender, EventArgs e) {
            Common.currentDataGrid = "图书";
            btnSearch.Text = "查询图书";
            btnAdd.Text = "新增图书";
            btnDelete.Text = "删除图书";
            textBox_search.Visible = true;
            btnSearch.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;

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
        /// 点击借阅管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllLending_Click(object sender, EventArgs e) {
            Common.currentDataGrid = "借阅记录";
            btnSearch.Text = "查询借阅";
            textBox_search.Visible = true;
            btnSearch.Visible = true;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnLend.Visible = false;

            DataTable dt = lendService.getLend();
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
        /// 点击申请管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllApply_Click(object sender, EventArgs e) {
            Common.currentDataGrid = "申请记录";
            btnSearch.Text = "查询申请";
            textBox_search.Visible = true;
            btnSearch.Visible = true;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnLend.Visible = false;

            DataTable dt = applyService.getApply();
            if(dt.Rows.Count > 0) {
                dataGridView.Visible = true;
                dataGridView.DataSource = dt;

                dataGridView.Columns["apply_id"].HeaderText = "编号";
                dataGridView.Columns["apply_title"].HeaderText = "标题";
                dataGridView.Columns["apply_info"].HeaderText = "内容";
                dataGridView.Columns["apply_create_date"].HeaderText = "申请日期";
            } else {
                dataGridView.Visible = false;
            }
        }

        /// <summary>
        /// 点击查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e) {
            string btnType = btnSearch.Text;
            string keyWord = textBox_search.Text.Trim();
            DataTable dt = null;
            switch(btnType) {
                case "查询用户":
                    dt = userService.getUserByKeyWord(keyWord);
                    break;
                case "查询图书":
                    dt = bookService.getBookByKeyWord(keyWord);
                    break;
                case "查询借阅":
                    dt = lendService.getLendByKeyWord(keyWord);
                    break;
                case "查询申请":
                    dt = applyService.getApplyByKeyWord(keyWord);
                    break;
                default:
                    break;
            }
            if(dt.Rows.Count > 0) {
                dataGridView.DataSource = dt;
                dataGridView.Visible = true;
            } else {
                dataGridView.Visible = false;
            }
        }

        /// <summary>
        /// 点击添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) {
            string btnType = btnAdd.Text;
            Form form = null;
            switch(btnType) {
                case "新增用户":
                    form = new Admin_addUser();
                    break;
                case "新增图书":
                    form = new Admin_addBook();
                    break;
                default:
                    break;
            }

            if(form != null) {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// 点击删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) {
            string btnType = btnDelete.Text;
            // 获取选中行的id
            int rowIndex = dataGridView.CurrentRow.Index;
            string id = "" + dataGridView.Rows[rowIndex].Cells[0].Value;
            DialogResult result;
            switch(btnType) {
                case "删除用户":
                    int user_id = Convert.ToInt32(id);
                    if(user_id == 0) {
                        MessageBox.Show("系统管理账户无法删除！\r\n请联系程序员！");
                        break;
                    }
                    result = MessageBox.Show("是否确认删除？", "删除用户", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK) {
                        userService.deleteUser(user_id);
                        MessageBox.Show("用户已经删除！");
                    }
                    break;
                case "删除图书":
                    string book_id = id;
                    result = MessageBox.Show("是否确认删除？", "删除图书", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK) {
                        bookService.deleteBook(id);
                        MessageBox.Show("图书已经删除！");
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 点击借出/归还按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLend_Click(object sender, EventArgs e) {
            DataTable dt = (DataTable)dataGridView.DataSource;
            // 获取选中行的id
            string book_id = "" + dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value;
            string book_name = "" + dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[1].Value;
            string book_out_date;
            string book_in_date;

            switch(btnLend.Text) {
                case "借出":
                    Common.bookDetail = new Book(book_id, book_name);
                    Form form = new Admin_lendBook();
                    form.ShowDialog();
                    book_out_date = AutoCreateTool.getNowDate("yyyyMMdd");
                    book_in_date = AutoCreateTool.getNextBookInDate(book_out_date);

                    bookService.updateBookStatusOut(book_id, book_out_date, book_in_date);
                    break;
                case "归还":
                    book_in_date = AutoCreateTool.getNowDate("yyyyMMdd");

                    bookService.updateBookStatusIn(book_id, book_in_date);
                    MessageBox.Show("归还成功！");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 单击列表某行，可以修改btn显示名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex >= 0) {
                DataTable dt = (DataTable)dataGridView.DataSource;
                switch(Common.currentDataGrid) {
                    case "图书":
                        btnLend.Visible = true;
                        // 获取选中行的id
                        int rowIndex = dataGridView.CurrentRow.Index;
                        string book_status = "" + dataGridView.Rows[rowIndex].Cells[4].Value;
                        if(book_status == Common.bookStatus_1) {
                            btnLend.Text = "借出";
                        } else if(book_status == Common.bookStatus_2) {
                            btnLend.Text = "归还";
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 双击列表某行，可以修改详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex >= 0) {
                DataTable dt = (DataTable)dataGridView.DataSource;
                switch(Common.currentDataGrid) {
                    case "用户":
                        updateUser(sender, e, dt);
                        break;
                    case "图书":
                        updateBook(sender, e, dt);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="dt">当前datagrid</param>
        private void updateUser(object sender, DataGridViewCellEventArgs e, DataTable dt) {
            int user_id = Convert.ToInt32(dt.Rows[e.RowIndex]["user_id"].ToString());
            int user_type = Convert.ToInt32(dt.Rows[e.RowIndex]["user_id"].ToString());
            string user_name = dt.Rows[e.RowIndex]["user_name"].ToString();
            string user_password = dt.Rows[e.RowIndex]["user_password"].ToString();
            string user_age = dt.Rows[e.RowIndex]["user_age"].ToString();
            string user_gender = dt.Rows[e.RowIndex]["user_gender"].ToString();
            string user_info = dt.Rows[e.RowIndex]["user_info"].ToString();
            string user_phone = dt.Rows[e.RowIndex]["user_phone"].ToString();

            Common.userDetail = new User(user_id, user_type, user_name, user_password, user_age, user_gender, user_info, user_phone);

            Form form = new Admin_updateUser();
            form.ShowDialog();
        }

        /// <summary>
        /// 更新图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="dt"></param>
        private void updateBook(object sender, DataGridViewCellEventArgs e, DataTable dt) {
            string book_id = dt.Rows[e.RowIndex]["book_id"].ToString();
            string book_name = dt.Rows[e.RowIndex]["book_name"].ToString();
            string book_author = dt.Rows[e.RowIndex]["book_author"].ToString();
            string book_type = dt.Rows[e.RowIndex]["book_type"].ToString();
            string book_status = dt.Rows[e.RowIndex]["book_status"].ToString();
            string book_out_date = dt.Rows[e.RowIndex]["book_out_date"].ToString();
            string book_in_date = dt.Rows[e.RowIndex]["book_in_date"].ToString();

            Common.bookDetail = new Book(book_id, book_name, book_author, book_type, book_status, book_out_date, book_in_date);

            Form form = new Admin_updateBook();
            form.ShowDialog();
        }
    }
}