using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C샵_계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num = 0;
        string Operation = "";
        Boolean Clear_Flag = false; // true : 한번 지우고 숫자 표시, False : 그냥 표시

        public void Operation_function()
        {
            if (Operation == "+")
            {
                textBox1.Text = (num + double.Parse(textBox1.Text)).ToString();
            }
            else if (Operation == "-")
            {
                textBox1.Text = (num - double.Parse(textBox1.Text)).ToString();
            }
            else if (Operation == "x")
            {
                textBox1.Text = (num * double.Parse(textBox1.Text)).ToString();
            }
            else if (Operation == "÷")
            {
                textBox1.Text = (num / double.Parse(textBox1.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + "000";
            }
        }

        Boolean bJjeom_Flag = false; // true : 점 찍힘 false : 점 안찍힘
        private void button12_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (bJjeom_Flag == false)
            {
                if(textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                textBox1.AppendText(".");
                bJjeom_Flag = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            bJjeom_Flag = false;
            num = 0;
            Operation = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (textBox1.Text.Substring(textBox1.TextLength - 1) == ".")
                {
                    bJjeom_Flag = false;
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "";
                }
            }
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            // Operation = "";
            if(textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "+";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            // Operation = "";
            if (textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "-";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            // Operation = "";
            if (textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "x";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }


        private void button18_Click(object sender, EventArgs e)
        {
            // Operation = "";
            if (textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();
                num = double.Parse(textBox1.Text);
                Operation = "÷";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (Operation != "")
                    Operation_function();

                bJjeom_Flag = false;
                Clear_Flag = true;
                num = 0;
                Operation = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                num = 0;
                Operation = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        { // x ^ 2 버튼
            if (textBox1.Text != "")
            {
                // double x = double.Parse(textBox1.Text);
                // textBox1.Text = (x * x).ToString();
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                num = 0;
                Operation = ""; 
            }
        }

        private void button22_Click(object sender, EventArgs e)
        { // + / - 버튼
            if (textBox1.Text != "")
            {
                // 편집 버전
                //if (double.Parse(textBox1.Text) == 0)
                //  textBox1.Text = textBox1.Text;
                //else if (double.Parse(textBox1.Text) > 0)
                //textBox1.Text = "-" + textBox1.Text;
                //else if (double.Parse(textBox1.Text) < 0)
                //textBox1.Text = textBox1.Text.Substring(1, textBox1.TextLength - 1);

                // 계산 버전
                textBox1.Text = (-(double.Parse(textBox1.Text))).ToString();
            }
        }

        private void 일반계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 집보내주십쇼ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반 계산기";
            this.Width = 370;
            공학계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem1.Checked = false;
        }

        private void 공학계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반 계산기";
            this.Width = 370;
            textBox1.Width = 270;
            공학계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem1.Checked = false;
            label1.Text = "By L.S.H in Dept. Software Engineering of Seoil University!";
        }

        private void 공학계산기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            this.Text = "공학 계산기";
            this.Width = 525;
            textBox1.Width = 420;
            공학계산기ToolStripMenuItem.Checked = false;
            공학계산기ToolStripMenuItem1.Checked = true;
            label1.Text = "This Calculator is maded by L.S.H in Dept. Software Engineering of Seoil University!";
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
