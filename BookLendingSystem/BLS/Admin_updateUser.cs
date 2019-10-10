using BLS.model;
using BLS.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 更新用户信息窗口
/// </summary>
namespace BLS {
    public partial class Admin_updateUser : Form {
        private UserService userService = new UserServiceImpl();

        public Admin_updateUser() {
            InitializeComponent();
            initialize();
        }

        // 初始化用户信息
        private void initialize() {
            label_userId.Text = Common.userDetail.user_id + "";
            if(Common.userDetail.user_type == 0) {
                label_userType.Text = "管理员";
            } else if(Common.userDetail.user_type == 1) {
                label_userType.Text = "普通用户";
            }
            textBox_userName.Text = Common.userDetail.user_name;
            textBox_userPassword.Text = Common.userDetail.user_password;
            textBox_userAge.Text = Common.userDetail.user_age;
            textBox_userGender.Text = Common.userDetail.user_gender;
            textBox_userInfo.Text = Common.userDetail.user_info;
            textBox_userPhone.Text = Common.userDetail.user_phone;
        }

        // 点击确认修改按钮
        private void btn_updateUser_Click(object sender, EventArgs e) {
            User user = new User();
            user.user_id = Convert.ToInt32(label_userId.Text);
            user.user_name = textBox_userName.Text;
            user.user_password = textBox_userPassword.Text;
            user.user_age = textBox_userAge.Text;
            user.user_gender = textBox_userGender.Text;
            user.user_info = textBox_userInfo.Text;
            user.user_phone = textBox_userPhone.Text;

            userService.updateUser(user);
            MessageBox.Show("修改成功");
            Close();
        }
    }
}
