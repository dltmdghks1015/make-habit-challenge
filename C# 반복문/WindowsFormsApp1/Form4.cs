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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            for (i = 8; i >= 2; i -=2)
            {
                for (j = 1; j <= 9;j++)
                {
                    for (k = 0; k <=1;k++)
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + ((i + k) * j) + "     ";
                    }
                    textBox1.Text = textBox1.Text + Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
