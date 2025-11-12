using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTH3_NguyenTranLeTam_24521568_1_
{
    public partial class Form5 : Form
    {
        private float number1, number2;
        public Form5()
        {
            InitializeComponent();
        }

        private bool checkNumber()
        {
            bool dk1 = !float.TryParse(textBox1.Text, out number1);
            bool dk2 = !float.TryParse(textBox2.Text, out number2);
            if (dk1 && dk2)
            {
                MessageBox.Show("Du lieu number1 va number2 khong hop le!");
                return false;
            }
            else if (dk1)
            {
                MessageBox.Show("Du lieu number1 khong hop le!");
                return false;
            }
            else if (dk2)
            {
                MessageBox.Show("Du lieu number2 khong hop le!");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkNumber())
                textBox3.Text = $"{number1 + number2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkNumber())
                textBox3.Text = $"{number1 - number2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkNumber())
                textBox3.Text = $"{number1 * number2}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkNumber())
            {
                if (number2 == 0)
                    MessageBox.Show("Phep chia khong thuc hien duoc!");
                else
                    textBox3.Text = $"{number1 / number2}";
            }
        }
    }
}
