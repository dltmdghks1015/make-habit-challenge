using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,num;
            int sum1 = 0, sum2 = 0, sum3 = 0;
            num = int.Parse(textBox1.Text);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            for (i = 1; i <= num; i++)
            {
                if((i % 3) == 0)
                {
                    sum1 = sum1 + i;
                    textBox2.Text = textBox2.Text + i + "+";
                }
                else if((i % 3) == 1)
                {
                    sum2 = sum2 + i;
                    textBox3.Text = textBox3.Text + i + "+";
                }
                else
                {
                    sum3 = sum3 + i;
                    textBox4.Text = textBox4.Text + i + "+";
                }
            }
            textBox2.Text = textBox2.Text.Substring(0, textBox2.TextLength - 1);
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 1);
            textBox4.Text = textBox4.Text.Substring(0, textBox4.TextLength - 1);
            textBox2.Text = textBox2.Text + "=" + sum1;
            textBox3.Text = textBox3.Text + "=" + sum2;
            textBox4.Text = textBox4.Text + "=" + sum3;
        }
    }
}
