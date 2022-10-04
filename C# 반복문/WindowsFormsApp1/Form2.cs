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
            if (textBox1.Text == "")
            {
                MessageBox.Show("textBox1에 단을 입력하세요", "경고 1");
                textBox1.Focus();
                goto Exit;
            }
            uint i, num1;
            num1 = uint.Parse(textBox1.Text);
            i = 1;

            textBox2.Text = "";

            while(i <=9)
            {
                textBox2.Text = textBox2.Text + num1 + " X " + i + " = " + (num1 * i) + "\r\n";
                i++;
            }
            
        Exit:;
        }
    }
}
