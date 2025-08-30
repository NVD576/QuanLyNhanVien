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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = true;
            if (this.Opacity > 0)
            {
                e.Cancel = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_Ten.Text = Form1.tenDN ;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_hoTen.Text != "")
            {
                ListViewItem item = new ListViewItem(textBox_hoTen.Text);
                item.SubItems.Add(dateTimePicker1.Text);
                item.SubItems.Add(radioButton1.Checked ? "Nam" : "Nu");
                item.ImageIndex=radioButton1.Checked? 1 : 0;
                listView1.Items.Add(item);
                textBox_hoTen.Text = "";
                textBox_hoTen.Focus(); 
            }
            
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.Opacity -= 0.1;
            if (this.Opacity ==0)
            {
                
                Application.Exit();
            }

        }
    }
}
