using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char Operator;
        double res = 0.0;


                
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void cmd_plus_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '+';
            input = string.Empty;
        }

        private void cmd_minus_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void cmd_prod_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void cmd_divide_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        
        private void cmd_clr_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        private void cmd_sqrt_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 'q';
            input = string.Empty;
        }

        private void cmd_pwr_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '^';
            input = string.Empty;
        }

        private void cmd_sqr_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 's';
            input = string.Empty;
        }

        private void cmd_log_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 'l';
            input = string.Empty;
        }

        private void cmd_exp_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 'e';
            input = string.Empty;
        }

        private void cmd_sin_Click(object sender, EventArgs e)
        {

        }

        private void cmd_cos_Click(object sender, EventArgs e)
        {

        }

        private void cmd_tan_Click(object sender, EventArgs e)
        {

        }
        private void cmd_equals_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1, num2; double.TryParse(op1, out num1);

            if (Operator == 'q' || Operator == 's' || Operator == 'l' || Operator == 'e')
            {
                if (Operator == 'q')
                {
                    res = Math.Sqrt(num1) ; this.textBox1.Text = res.ToString();
                }
                if (Operator == 's')
                {
                    res = Math.Pow(num1,2); this.textBox1.Text = res.ToString();
                }
                if (Operator == 'l')
                {
                    res = Math.Log10(num1); this.textBox1.Text = res.ToString();
                }
                if (Operator == 'e')
                {
                    res = Math.Pow(2.7182,num1); this.textBox1.Text = res.ToString();
                }

            }
            else
            {


                

                double.TryParse(op2, out num2);
                if (Operator == '+')
                {
                    res = num1 + num2; this.textBox1.Text = res.ToString();
                }
                else if (Operator == '-')
                {
                    res = num1 - num2; textBox1.Text = res.ToString();
                }
                else if (Operator == '*')
                {
                    res = num1 * num2; textBox1.Text = res.ToString();
                }

                else if (Operator == '/')
                {
                    if (num2 != 0)
                    {
                        res = num1 / num2; textBox1.Text = res.ToString();
                    }

                    else
                    {
                        textBox1.Text = "DIV/Zero!";
                    }
                }
                else if (Operator == '^')
                {
                    res = Math.Pow(num1, num2); textBox1.Text = res.ToString();
                }
                input = string.Empty;
            }
        }

    }
}
