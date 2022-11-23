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

        double dSutja_Stored = 0;
        string sOperation_Stored = "";
        Boolean Clear_Flag = false; // true : 한번 지우고 숫자 표시, False : 그냥 표시

        public void Operation_function()
        {
            if (sOperation_Stored == "+")
            {
                textBox1.Text = (dSutja_Stored + double.Parse(textBox1.Text)).ToString();
            }
            else if (sOperation_Stored == "-")
            {
                textBox1.Text = (dSutja_Stored - double.Parse(textBox1.Text)).ToString();
            }
            else if (sOperation_Stored == "x")
            {
                textBox1.Text = (dSutja_Stored * double.Parse(textBox1.Text)).ToString();
            }
            else if (sOperation_Stored == "÷")
            {
                textBox1.Text = (dSutja_Stored / double.Parse(textBox1.Text)).ToString();
            }
            else if (sOperation_Stored == "^")
            {
                textBox1.Text = Math.Pow(dSutja_Stored, double.Parse(textBox1.Text)).ToString();
            }
            else if (sOperation_Stored == "%")
            {
                textBox1.Text = (dSutja_Stored % double.Parse(textBox1.Text)).ToString();
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
                if (textBox1.Text == "")
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
            dSutja_Stored = 0;
            sOperation_Stored = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
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
            sOperation_Stored = "";
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();
                dSutja_Stored = double.Parse(textBox1.Text);
                sOperation_Stored = "+";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            sOperation_Stored = "";
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();
                dSutja_Stored = double.Parse(textBox1.Text);
                sOperation_Stored = "-";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            sOperation_Stored = "";
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();
                dSutja_Stored = double.Parse(textBox1.Text);
                sOperation_Stored = "x";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }


        private void button18_Click(object sender, EventArgs e)
        {
            sOperation_Stored = "";
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();
                dSutja_Stored = double.Parse(textBox1.Text);
                sOperation_Stored = "÷";
                bJjeom_Flag = false;
                Clear_Flag = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();

                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {   // 1/x 버튼
            if (textBox1.Text != "")
            {


                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                double x = double.Parse(textBox1.Text);
                textBox1.Text = (x * x).ToString();
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        { //+/- 버튼
            if (textBox1.Text != "")
            {
                //편집 버전
                //if (double.Parse(textBox1.Text) == 0)
                //    textBox1.Text = textBox1.Text;
                //else if (double.Parse(textBox1.Text) > 0)
                //    textBox1.Text = "-" + textBox1.Text;
                //else if (double.Parse(textBox1.Text) < 0)
                //    textBox1.Text = textBox1.Text.Substring(1, textBox1.TextLength - 1);

                //계산버전
                textBox1.Text = (-(double.Parse(textBox1.Text))).ToString();



            }
        }

        private void 계사니사용법ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반계산기";
            this.Width = 305;
            일반계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;
        }

        private void 일반계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반계산기";
            this.Width = 305;
            textBox1.Width = 267;
            일반계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;
            label1.Text = "By L.S.H in Dept.Software Engineering of Seoil Univ.";
        }

        private void 공학계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            this.Text = "공학계산기";
            this.Width = 450;
            textBox1.Width = 410;
            일반계산기ToolStripMenuItem.Checked = false;
            공학계산기ToolStripMenuItem.Checked = true;
            label1.Text = "This calculator is maded By L.S.H in Dept.Software Engineering of Seoil Univ.";
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public double Factorial(double n)
        {   //재귀 함수 : Recusrisve 
            if (n == 1)
                return 1;
            else
                return Factorial(n - 1) * n;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {// n! 버튼
            if (textBox1.Text != "")
            {
                //double dFac, dSum = 1;
                //dFac = double.Parse(textBox1.Text);
                //for (int i = 1; i <= dFac; i++)
                //    dSum = dSum * i;
                //for (double i = dFac; i >= 1; i--)
                //    dSum = dSum * i;
                //textBox1.Text = dSum.ToString();



                textBox1.Text = Factorial(double.Parse(textBox1.Text)).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {//sin 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Sin(double.Parse(textBox1.Text)* Math.PI/180).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {//cos 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Cos(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {//tan 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Tan(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text),3).ToString();
                bJjeom_Flag = false;
                Clear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                goto Exit;    
            if (sOperation_Stored != "")
                Operation_function();

            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "^";
            Clear_Flag = true;
            bJjeom_Flag = false;
        Exit:;
        }
    }
    
}