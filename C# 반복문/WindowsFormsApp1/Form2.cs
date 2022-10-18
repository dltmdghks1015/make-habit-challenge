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
            i = 2;
            j = 1;
            k = 0;
            while (true)
            {
                while (true)
                {
                    while (true)
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + ((i + k) * j) + "       ";
                        k++;
                        if (k > 3) break;
                    }
                    k = 0; textBox1.Text = textBox1.Text + Environment.NewLine;
                    j++;
                    if (j > 9) break;
                }
                j = 1; textBox1.Text = textBox1.Text + Environment.NewLine;
                i += 4;
                if (i > 9) break;
            }
        }
    }
}
