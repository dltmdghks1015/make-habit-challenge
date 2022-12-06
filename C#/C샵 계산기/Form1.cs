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
        Boolean bClear_Flag = false; // true : 한번 지우고 숫자 표시, False : 그냥 표시

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
            else if (sOperation_Stored == "mod")
            {
                textBox1.Text = (dSutja_Stored % double.Parse(textBox1.Text)).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //9버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 0버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 000버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + "000";
            }
        }

        Boolean bJjeom_Flag = false; // true : 점 찍힘 false : 점 안찍힘
        private void button12_Click(object sender, EventArgs e)
        {
            //.점 버튼
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;
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
            //clear 버튼
            textBox1.Text = "";
            bJjeom_Flag = false;
            dSutja_Stored = 0;
            sOperation_Stored = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //지우기 버튼
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
            //+더하기버튼
            sOperation_Stored = "";
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();
                dSutja_Stored = double.Parse(textBox1.Text);
                sOperation_Stored = "+";
                bJjeom_Flag = false;
                bClear_Flag = true;
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
                bClear_Flag = true;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            //X 곱하기 버튼
            sOperation_Stored = "";
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();
                dSutja_Stored = double.Parse(textBox1.Text);
                sOperation_Stored = "x";
                bJjeom_Flag = false;
                bClear_Flag = true;
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
                bClear_Flag = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // = 버튼
            if (textBox1.Text != "")
            {
                if (sOperation_Stored != "")
                    Operation_function();

                bJjeom_Flag = false;
                bClear_Flag = true;
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
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //X^2 버튼
            if (textBox1.Text != "")
            {

                double x = double.Parse(textBox1.Text);
                textBox1.Text = (x * x).ToString();
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
                bJjeom_Flag = false;
                bClear_Flag = true;
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
        private Form4 Manual;
        private void 계사니사용법ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual = new Form4();
            Manual.Owner = this;
            Manual.Show();
            this.Hide();
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
            label1.Text = "By L.S.H in Dept.Software Engeeniring of Seoil Univ.";
        }

        private void 공학계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            this.Text = "공학계산기";
            this.Width = 450;
            textBox1.Width = 410;
            일반계산기ToolStripMenuItem.Checked = false;
            공학계산기ToolStripMenuItem.Checked = true;
            label1.Text = "This calculator is maded By L.S.H in Dept.Software Engeeniring of Seoil Univ.";
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
                bClear_Flag = true;
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
                bClear_Flag = true;
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
                bClear_Flag = true;
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
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //x^3버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text),3).ToString();
                bJjeom_Flag = false;
                bClear_Flag = true;
                dSutja_Stored = 0;
                sOperation_Stored = "";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //x^y 버튼
            if (textBox1.Text == "")
                goto Exit;    
            if (sOperation_Stored != "")
                Operation_function();

            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "^";
            bClear_Flag = true;
            bJjeom_Flag = false;
        Exit:;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // |x| 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Abs(double.Parse(textBox1.Text)).ToString();
                dSutja_Stored = 0;
                sOperation_Stored = "";
                bClear_Flag = true;
                bJjeom_Flag = false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //10^x 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Pow(10, double.Parse(textBox1.Text)).ToString();
                dSutja_Stored = 0;
                sOperation_Stored = "";
                bClear_Flag = true;
                bJjeom_Flag = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //mod 버튼
            if (textBox1.Text == "")
                goto Exit;        
            if (sOperation_Stored != "")
                Operation_function();

            dSutja_Stored = double.Parse(textBox1.Text);
            sOperation_Stored = "%";
            bClear_Flag = true;
            bJjeom_Flag = false;
        Exit:;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // 1/|x| 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = (1/ Math.Abs(double.Parse(textBox1.Text))).ToString();
                dSutja_Stored = 0;
                sOperation_Stored = "";
                bClear_Flag = true;
                bJjeom_Flag = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //π버튼
            textBox1.Text = Math.PI.ToString();

            bClear_Flag = true;
            bJjeom_Flag = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //√버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                dSutja_Stored = 0;
                sOperation_Stored = "";
                bClear_Flag = true;
                bJjeom_Flag = false;
            }
        }

        private Form2 Developer_intro;
        private void 개발자소개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Developer_intro = new Form2();
            Developer_intro.Owner = this;
            Developer_intro.Show();
            this.Hide();
        }

        private Form3 To_Professor;
        private void 교수님에게하고픈말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            To_Professor = new Form3();
            To_Professor.Owner = this;
            To_Professor.Show();
            this.Hide();
        }

        private void 개발환경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("운영체제 : Windows 10 Enterprise LTSC" + "\r\n" + "개발 도구 : Microsoft Visual Studio Community" + "Professional 2019", "[ 개발 환경 ]");
        }

        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("마우스로 동작하는 계산기 : 1.0", "[ 버전 정보 ]");
        }
    }
    
}