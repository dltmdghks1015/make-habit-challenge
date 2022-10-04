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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint i, j;
            i = 1;
            j = 1;
            do
            {
                do
                {
                    textBox1.Text = textBox1.Text + i + " X " + j + " = " + (i * j) + "\r\n";
                    j++;
                } while (j <= 9);
                j = 1;
                i++;
                textBox1.Text = textBox1.Text + Environment.NewLine;
            } while (i <= 9);
        }
    }
}
