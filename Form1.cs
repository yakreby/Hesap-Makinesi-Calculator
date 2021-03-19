using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Hesap Makinesi";//For Eng Calculator
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        //Numbers

        //Number 7
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "7";
                }
                else
                {
                    textBox1.Text += "7";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "7";
                }
                else
                {
                    textBox3.Text += "7";
                }
            }
        }

        //Number 8
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "8";
                }
                else
                {
                    textBox1.Text += "8";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "8";
                }
                else
                {
                    textBox3.Text += "8";
                }
            }
        }

        //Number 9
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "9";
                }
                else
                {
                    textBox1.Text += "9";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "9";
                }
                else
                {
                    textBox3.Text += "9";
                }
            }
        }

        //Number 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "4";
                }
                else
                {
                    textBox1.Text += "4";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "4";
                }
                else
                {
                    textBox3.Text += "4";
                }
            }
        }

        //Number 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "5";
                }
                else
                {
                    textBox1.Text += "5";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "5";
                }
                else
                {
                    textBox3.Text += "5";
                }
            }
        }

        //Number 6
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "6";
                }
                else
                {
                    textBox1.Text += "6";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "6";
                }
                else
                {
                    textBox3.Text += "6";
                }
            }
        }

        //Number 1
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "1";
                }
                else
                {
                    textBox1.Text += "1";
                }
            }
            else if(textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "1";
                }
                else
                {
                    textBox3.Text += "1";
                }
            }
        }

        //Number 2
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "2";
                }
                else
                {
                    textBox1.Text += "2";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "2";
                }
                else
                {
                    textBox3.Text += "2";
                }
            }
        }

        //Number 3
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "3";
                }
                else
                {
                    textBox1.Text += "3";
                }
            }
            else if(textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "3";
                }
                else
                {
                    textBox3.Text += "3";
                }
            }
        }

        //Number 0
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text += "0";
                }
            }
            else if (textBox4.Text != "")
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "0";
                }
                else
                {
                    textBox3.Text += "0";
                }
            }
        }
        //Mathematical Buttons

        //Multiplication Button
        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text = "X";
        }

        //Division Button
        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Text = "/";
        }


        //Subtraction Button
        private void button13_Click(object sender, EventArgs e)
        {
            textBox4.Text = "-";
        }

        //Addition Button
        private void button14_Click(object sender, EventArgs e)
        {
            textBox4.Text = "+";
        }

        //Clear Button
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "";
        }

        //EqualTo Button
        private void button16_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        //Calculating Operations
        public void Calculate()
        {
            var islem = textBox4.Text;//For Eng Getting Operation
            var birinciSayi = Convert.ToDouble(textBox1.Text);//numberOne
            var ikinciSayi = Convert.ToDouble(textBox3.Text);//numberTwo

            if(islem == "+")
            {
                double sonuc = birinciSayi + ikinciSayi;//Result
                textBox2.Text = Convert.ToString(sonuc);
            }
            else if(islem == "-")
            {
                double sonuc = birinciSayi - ikinciSayi;//Result
                textBox2.Text = Convert.ToString(sonuc);
            }
            else if(islem == "X")
            {
                double sonuc = birinciSayi * ikinciSayi;//Result
                textBox2.Text = Convert.ToString(sonuc);
            }
            else if(islem == "/")
            {
                double sonuc = birinciSayi / ikinciSayi;//Result
                //Divison By Zero Control
                if (ikinciSayi == 0)
                {
                    textBox2.Text = "ERR";
                }
                else
                {
                    textBox2.Text = Convert.ToString(sonuc);
                }
            }
            else
            {
                textBox2.Text = "ERR";
            }
        }

        //Copy to Clipboard
        private void button17_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }
    }
}