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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            i = 8;
            j = 1;
            k = 0;
            while(i >= 2)
            {
                while (j <= 9)
                {
                    while (k <= 1)
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + ((i + k) * j) + "     ";
                        k++;
                    }
                    k = 0;
                    textBox1.Text = textBox1.Text + Environment.NewLine;
                    j++;
                }
                j = 1;
                textBox1.Text = textBox1.Text + Environment.NewLine;
                i -= 2;
            }
        }
    }
}
