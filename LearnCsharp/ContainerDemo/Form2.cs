using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerDemo {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private int btnNumber = 0;

        private void btnAdd_Click(object sender, EventArgs e) {
            Button b = new Button();
            b.Text = "btn" + (++btnNumber);
            flowLayoutPanel1.Controls.Add(b);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            this.flowLayoutPanel1.WrapContents = this.checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            flowLayoutPanel1.AutoScroll = !flowLayoutPanel1.AutoScroll;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            foreach(Control c in this.flowLayoutPanel1.Controls) {
                if(c.Text == ("btn" + btnNumber)) {
                    flowLayoutPanel1.Controls.Remove(c);
                }
            }
            if(btnNumber > 0) {
                btnNumber--;
            }
        }
    }
}
