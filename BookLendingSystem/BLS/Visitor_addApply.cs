using BLS.model;
using BLS.service;
using MySDK;
using System;
using System.Windows.Forms;

/// <summary>
/// 用户申请窗口
/// </summary>
namespace BLS {
    public partial class Visitor_addApply : Form {
        private ApplyService applyService = new ApplyServiceImpl();

        public Visitor_addApply() {
            InitializeComponent();
            initialize();
        }

        // 初始化获得当前日期
        private void initialize() {
            string date = AutoCreateTool.getNowDate("yyyyMMdd");
            textBox3.Text = date;
        }

        // 点击确认新增按钮
        private void btn_addApply_Click(object sender, EventArgs e) {
            Apply apply = new Apply();
            apply.apply_id = AutoCreateTool.getApplyID();
            apply.apply_title = textBox1.Text;
            apply.apply_info = textBox2.Text;
            apply.apply_create_date = textBox3.Text;

            applyService.addApply(apply);
            MessageBox.Show("申请成功，将于24小时内审核。\r\n审核通过后可通过用户名登录，初始密码为123456");
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("是否放弃申请？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK) {
                Close();
            }
        }
    }
}
