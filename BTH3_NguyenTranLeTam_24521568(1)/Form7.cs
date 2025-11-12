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
    public partial class Form7 : Form
    {
        private int totalMoney = 0;
        private int numOfChair;
        public Form7()
        {
            InitializeComponent();
        }

        private int CalculateTicketFare(Button x)
        {
            int.TryParse(x.Text, out numOfChair);
            if (numOfChair >= 1 && numOfChair <= 5)
                return 5000;
            else if (numOfChair <= 10)
                return 6500;
            else
                return 8000;
        }
        private void Reservation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vi tri nay da duoc ban!");
                return;
            }

            if (btn.BackColor == Color.Transparent)
                btn.BackColor = Color.Blue;
            else
                btn.BackColor = Color.Transparent;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.BackColor == Color.Blue)
                {
                    Button btn = (Button)x;
                    btn.BackColor = Color.Yellow;
                    totalMoney += CalculateTicketFare(btn);
                }
            }
            textBox1.Text = totalMoney.ToString();
            totalMoney = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.BackColor == Color.Blue)
                {
                    Button btn = (Button)x;
                    btn.BackColor = Color.Transparent;
                }
            }
            textBox1.Text = totalMoney.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
