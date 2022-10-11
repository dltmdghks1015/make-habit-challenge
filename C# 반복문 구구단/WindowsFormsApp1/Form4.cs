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
            i = 1;
            j = 1;
            k = 0;
            textBox1.Text = "";
            while (true)
            {
                while (true)
                {
                    while (true)
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + ((i + k) * j) + "          ";
                        k++;
                        if (k > 2) break;
                    }
                    j++;
                    k = 0; textBox1.Text = textBox1.Text + Environment.NewLine;
                    if (j > 9) break;
                }
                j = 1;
                i += 3; textBox1.Text = textBox1.Text + Environment.NewLine;
                if (i > 9) break;
            }
        }
    }
}
