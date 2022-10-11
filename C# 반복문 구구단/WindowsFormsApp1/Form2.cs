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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            i = 1;
            j = 1;
            k = 0;
            textBox1.Text = "";
            while (i<=9)
            {
                while (j <= 9)
                {
                    while (k <= 2)
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + ((i + k) * j) + "          ";
                        k++;
                    }
                    j++;
                    k = 0; textBox1.Text = textBox1.Text + Environment.NewLine;
                }
                j = 1;
                i += 3; textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
