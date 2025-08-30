using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhanvien
{
    public partial class Form1 : Form
    {
        public static string tenDN="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                Application.Exit();
            }
            if(textBox2.Text == "admin")
            {
                tenDN = textBox1.Text;
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bị sai!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
