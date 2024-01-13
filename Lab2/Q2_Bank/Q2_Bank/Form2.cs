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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //textBox1.Text="aanya";


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           // textBox2.Text = "Rs 1000";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // textBox3.Text = "12 Jan 2024";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //textBox4.Text = "13 Jan 2024";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //textBox5.Text = "Rs 100, Rs 300, Rs 12, Rs 90,Rs 50";
        }
    }
}
