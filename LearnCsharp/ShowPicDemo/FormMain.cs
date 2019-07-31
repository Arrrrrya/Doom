using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowPicDemo {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            loadPic();
        }

        private void loadPic() {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                // MessageBox.Show(openFileDialog1.FileName);
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
