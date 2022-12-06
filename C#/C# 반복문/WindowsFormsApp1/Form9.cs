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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            uint[] j = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            textBox1.Text = "";
            foreach(uint aa in i)
            {
                foreach (uint dd in j)
                {
                    textBox1.Text = textBox1.Text + aa + " X " + dd + " = " + (aa * dd) + "\r\n";
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }
    }
}
