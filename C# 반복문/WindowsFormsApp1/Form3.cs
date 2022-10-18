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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] i = { 2,6 };
            int[] j = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] k = { 0, 1, 2, 3 };

            foreach (int num1 in i)
            {
                foreach (int num2 in j)
                {
                    foreach (int num3 in k)
                    {
                        textBox1.Text = textBox1.Text + (num1 + num3) + " X " + num2 + " = " + ((num1 + num3) * num2) + "       ";
                    }
                    textBox1.Text = textBox1.Text + Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
