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
            int i, j, k;
            i = 1;
            j = 1;
            k = 0;
            textBox1.Text = "";
            do
            {
                do
                {
                    do
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + ((i + k) * j) + "          ";
                        k++;
                    } while (k <= 2);
                    j++;
                    k = 0; textBox1.Text = textBox1.Text + Environment.NewLine;
                } while (j <= 9);
                j = 1;
                i += 3; textBox1.Text = textBox1.Text + Environment.NewLine;
            } while (i <= 9);
        }
    }
}
