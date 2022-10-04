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
            int i, j;
            for (i = 1;i <=9; i++)
            {
                for(j = 1; j<=9; j++)
                {
                    textBox1.Text = textBox1.Text + i + " X " + j + " = " + (i * j) + "\r\n";
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }
    }
}
