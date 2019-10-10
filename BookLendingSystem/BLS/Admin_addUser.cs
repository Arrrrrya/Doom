using BLS.model;
using BLS.service;
using System;
using System.Windows.Forms;

/// <summary>
/// 新增用户窗口
/// </summary>
namespace BLS {
    public partial class Admin_addUser : Form {
        private UserService userService = new UserServiceImpl();

        public Admin_addUser() {
            InitializeComponent();
        }

        // 点击确认新增按钮
        private void btn_addUser_Click(object sender, EventArgs e) {
            User user = new User();

            if(radioButton_userType.Checked) {
                user.user_type = 1;
            }
            user.user_name = textBox_userName.Text;
            user.user_password = textBox_userPassword.Text;
            user.user_age = textBox_userAge.Text;
            user.user_gender = textBox_userGender.Text;
            user.user_info = textBox_userInfo.Text;
            user.user_phone = textBox_userPhone.Text;

            if(user.user_name == "") {
                MessageBox.Show("姓名不能为空");
            } else {
                userService.addUser(user);
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
