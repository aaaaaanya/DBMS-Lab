using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name = "aanya";
        string pw = "correct";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pw = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == name && textBox2.Text == pw)
            {
                
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect details");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
