using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C샵_계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num = 0;
        string Operation = "";
        Boolean Clear_Flag = false; // true : 한번 지우고 숫자 표시, False : 그냥 표시

        public void Operation_function()
        {
            if (Operation == "+")
            {
                textBox1.Text = (num + double.Parse(textBox1.Text)).ToString();
            }
            else if (Operation == "-")
            {
                textBox1.Text = (num - double.Parse(textBox1.Text)).ToString();
            }
            else if (Operation == "x")
            {
                textBox1.Text = (num * double.Parse(textBox1.Text)).ToString();
            }
            else if (Operation == "÷")
            {
                textBox1.Text = (num / double.Parse(textBox1.Text)).ToString();
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "x";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "-";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + "000";
            }
        }

        Boolean bJjeom_Flag = false; // true : 점 찍힘 false : 점 안찍힘
        private void button12_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (bJjeom_Flag == false)
            {
                if(textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                textBox1.AppendText(".");
                bJjeom_Flag = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            bJjeom_Flag = false;
            num = 0;
            Operation = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (textBox1.Text.Substring(textBox1.TextLength - 1) == ".")
                {
                    bJjeom_Flag = false;
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "";
                }
            }
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "+";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "÷";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();

                bJjeom_Flag = false;
                Clear_Flag = true;
                Operation = "";
            }
        }
    }
}
