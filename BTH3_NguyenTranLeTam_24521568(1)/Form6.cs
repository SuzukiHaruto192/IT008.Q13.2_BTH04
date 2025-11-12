using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3_NguyenTranLeTam_24521568_1_
{
    public partial class Form6 : Form
    {
        private double number1, number2;
        private char calSign;
        private bool calSignCheck = false;
        private bool inputCondition() {
            if (string.IsNullOrEmpty(textBox1.Text))
                return false;
            return true;
        }
        public Form6()
        {
            InitializeComponent();
        }

        //Cac nut so
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        //Nut =
        private void button27_Click(object sender, EventArgs e)
        {
            if(calSignCheck)
                number2 = Convert.ToDouble(textBox1.Text);
            
            switch (calSign)
            {
                case '+':
                    textBox1.Text = $"{number1 + number2}"; break;
                case '-':
                    textBox1.Text = $"{number1 - number2}"; break;
                case '*':
                    textBox1.Text = $"{number1 * number2}"; break;
                case '/':
                    textBox1.Text = $"{number1 / number2}"; break;
                case '%':
                    textBox1.Text = $"{number1 % number2}"; break;
                default:
                    return;
            }
            calSignCheck = false;
            number1 = Convert.ToDouble(textBox1.Text);
        }


        //Cac nut tinh toan
        private void button24_Click(object sender, EventArgs e)
        {
            if (!inputCondition())
                return;
            number1 = Convert.ToDouble(textBox1.Text);
            calSign = '+';
            calSignCheck = true;
            textBox1.Clear();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (!inputCondition())
                return;
            number1 = Convert.ToDouble(textBox1.Text);
            calSign = '-';
            calSignCheck = true;
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!inputCondition())
                return;
            number1 = Convert.ToDouble(textBox1.Text);
            calSign = '*';
            calSignCheck = true;
            textBox1.Clear();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (!inputCondition())
                return;
            number1 = Convert.ToDouble(textBox1.Text);
            calSign = '/';
            calSignCheck = true;
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!inputCondition())
                return;
            number1 = Convert.ToDouble(textBox1.Text);
            calSign = '%';
            calSignCheck = true;
            textBox1.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!inputCondition())
                return;
            number1 = Convert.ToDouble(textBox1.Text);
            number1 = 1 / number1;
            textBox1.Text = $"{number1}";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!inputCondition())
                return;
            number1 = Convert.ToDouble(textBox1.Text);
            number1 = Math.Sqrt(number1);
            textBox1.Text = $"{number1}";
        }


        //Cac nut xoa du lieu
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            calSignCheck = false;
            calSign = ' ';
            textBox1.Clear() ;
        }
    }
}
