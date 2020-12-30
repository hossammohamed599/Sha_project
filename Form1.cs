using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = "hossam";
            int pass = 123;
            string username = (textBox1.Text);
            int password = Convert.ToInt32(textBox2.Text);
            if (name == username && pass == password)
            {
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                label7.Visible = true;
            }
        }  }
}
