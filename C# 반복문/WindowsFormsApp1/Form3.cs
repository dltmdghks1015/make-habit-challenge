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
            if(textBox1.Text == "")
            {
                MessageBox.Show("textBox1에 단을 입력하세요", "경고 1");
                textBox1.Focus();
                goto Nagayo;
            }
            uint iDan = uint.Parse(textBox1.Text);
            uint i = 1;
            textBox2.Text = "";
            while(true)
            {
                textBox2.Text = textBox2.Text + iDan + " X " + i + " = " + (iDan * i) + "\r\n";
                i++;
                if (i > 9)
                    break;
            }
        Nagayo:;
        }
    }
}
