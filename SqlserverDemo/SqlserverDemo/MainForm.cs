using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlserverDemo {
    public partial class MainForm : Form {
        // 数据库信息
        private string conn = "Data Source=.;Initial Catalog=DB_Test_20190921;Integrated Security=True";
        private string dbTable = "TB_test";
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        private string sql = "";

        public MainForm() {
            InitializeComponent();
        }

        //连接到数据库
        private void connectToDB() {
            sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
        }

        //断开数据库连接
        private void disconnectToDB() {
            sqlConnection.Close();
        }

        // 查询数据库
        private int selectFromDB(string str) {
            connectToDB();

            sql = "select * from " + dbTable + str + " order by id asc";

            DataTable dataTable = new DataTable();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dbDataGridView.DataSource = dataTable;

            disconnectToDB();

            int count = dataTable.Rows.Count;

            return count;
        }

        // 点击查询按钮
        private void btn_select_Click(object sender, EventArgs e) {
            dbDataGridView.Visible = true;
            string name = textbox_select.Text.Trim();
            string str = "";
            if(name != "") {
                str = " where name = '" + name + "'";
            }
            selectFromDB(str);
        }

        //点击登录按钮
        private void btn_login_Click(object sender, EventArgs e) {
            connectToDB();

            string name = textbox_select.Text.Trim();
            sql = "select * from " + dbTable + " where name = '" + name + "'";
            DataTable dataTable = new DataTable();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0) {
                label_current.Text = name;
                btn_logout.Visible = true;
            } else {
                MessageBox.Show("无此用户！");
            }

            disconnectToDB();
        }

        // 点击新增按钮
        private void btn_add_Click(object sender, EventArgs e) {
            connectToDB();

            string name = textbox_select.Text.Trim();
            if(name != "") {
                sql = "select * from " + dbTable + " where name = '" + name + "'";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                //用户名是否已经存在
                if(id > 0) {
                    MessageBox.Show("用户已存在，新建失败！");
                } else {
                    // 获取当前数据库中最大的id
                    sql = "select max(id) from " + dbTable;
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    // 新增数据
                    sql = "insert into " + dbTable + " values ('" + (id + 1) + "','" + name + "','')";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("新增成功！");
                }
                selectFromDB("");
            } else {
                MessageBox.Show("用户不能为空，新增失败！");
            }

            disconnectToDB();
        }

        // 点击退出登录按钮
        private void btn_logout_Click(object sender, EventArgs e) {
            label_current.Text = "未登录";
            btn_logout.Visible = false;
        }

        // 点击重新输入按钮
        private void btn_reset_Click(object sender, EventArgs e) {
            textbox_select.Text = "";
        }

        // 点击删除按钮
        private void btn_delete_Click(object sender, EventArgs e) {
            connectToDB();

            // 获取选中行的id
            int rowIndex = dbDataGridView.CurrentRow.Index;
            int id = Convert.ToInt32(dbDataGridView.Rows[rowIndex].Cells[0].Value);
            sql = "delete from " + dbTable + " where id = '" + id + "'";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            selectFromDB("");
            MessageBox.Show("删除成功！");

            disconnectToDB();
        }
    }
}
