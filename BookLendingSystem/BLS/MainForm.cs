using BLS.model;
using BLS.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 登录窗口
/// </summary>
namespace BLS {
    public partial class MainForm : Form {
        private UserService userService = new UserServiceImpl();

        public MainForm() {
            InitializeComponent();
        }

        //点击登录按钮
        private void btn_login_Click(object sender, EventArgs e) {
            Form form = null;
            int type = -1;
            if(radioBtn_admin.Checked) {
                type = 0;
            } else if(radioBtn_user.Checked) {
                type = 1;
            }
            string name = textBox_name.Text;
            string password = textBox_password.Text;
            User user = new User(type,name,password);

            // 登录
            User loginUser = userService.login(user);

            if(loginUser != null) {
                //MessageBox.Show("登录成功！");
                if(!checkBox_remember.Checked) {
                    textBox_name.Text = "";
                    textBox_password.Text = "";
                }
                Common.user = loginUser;
                if(loginUser.user_type == 0) {
                    form = new MenuForm_Admin();
                } else if(loginUser.user_type == 1) {
                    form = new MenuForm_User();
                }
            } else {
                MessageBox.Show("登录失败！\r\n用户不存在，密码错误或用户类型错误！");
            }

            if(form != null) {
                form.ShowDialog();
            }
        }

        private void label_visitor_Click(object sender, EventArgs e) {
            Form form = new MenuForm_Visitor();
            form.ShowDialog();
        }
    }
}
