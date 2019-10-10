using BLS.model;
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
/// 游客界面
/// </summary>
namespace BLS {
    public partial class MenuForm_Visitor : Form {
        public MenuForm_Visitor() {
            InitializeComponent();
            label_current.Text = "未登录";
        }

        public void btn_applyAcount_Click(object sender, EventArgs e) {
            Form form = new Visitor_addApply();
            form.ShowDialog();
        }
    }
}
