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
            if (textBox1.Text == "")
            {
                MessageBox.Show("textBox1에 단을 입력하세요", "경고 1");
                textBox1.Focus();
                goto Nagayo;
            }
            uint iDan = uint.Parse(textBox1.Text);
            uint[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            textBox2.Text = "";
            foreach(uint dd in i)
            {
                textBox2.Text = textBox2.Text + iDan + " X " + dd + " = " + (iDan * dd) + "\r\n";
            }
        Nagayo:;
        }
    }
}
