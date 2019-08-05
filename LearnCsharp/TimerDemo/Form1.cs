using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerDemo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(progressBar1.Value == progressBar1.Minimum) {
                progressBar1.Value = progressBar1.Minimum;
            } else {
                progressBar1.Value -= 5;
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e) {
            if(progressBar1.Value == progressBar1.Maximum) {
                progressBar1.Value = progressBar1.Maximum;
            } else {
                progressBar1.Value += 5;
            }
        }

        private void btnControl_Click(object sender, EventArgs e) {
            if(btnControl.Text == "start") {
                btnControl.Text = "end";
            } else {
                btnControl.Text = "start";
            }
            timer1.Enabled = !timer1.Enabled;
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if(progressBar2.Value == progressBar2.Maximum) {
                progressBar2.Value = 0;
            } else {
                progressBar2.Value += 5;
            }
        }
    }
}
