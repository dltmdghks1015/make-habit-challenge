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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            for (i = 2; i <= 9; i += 4) // i = idan
            {
                for (j = 1; j <= 9; j++) // j = i
                {
                    for (k = 0; k <= 3; k++) // k = iTap
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + ((i + k) * j) + "      ";
                    }
                    textBox1.Text = textBox1.Text + Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
