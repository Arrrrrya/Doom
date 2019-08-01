using System;
using System.Windows.Forms;
using System.Numerics;

namespace BigIntDemo {
    public partial class MyCalculater : Form {
        public MyCalculater() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int n = 0;
            int.TryParse(textBox1.Text, out n);

            textBox2.Text = n + "! = " + doFactorial(n);

        }

        private BigInteger doFactorial(int n) {
            if(n > 1) {
                return (n * doFactorial(n - 1));
            } else {
                return n;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void MyCalculater_Load(object sender, EventArgs e) {

        }
    }
}
