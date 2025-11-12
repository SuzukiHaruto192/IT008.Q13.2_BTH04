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
    public partial class Form8 : Form
    {
        private long totalMoney = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
                return;
            }

            bool checkSTK = textBox1.Text.Any(c => !char.IsNumber(c));
            bool checkHoten = textBox2.Text.Any(c => (!char.IsLetter(c) && !char.IsWhiteSpace(c)));
            bool checkMoney = textBox4.Text.Any(c => !char.IsNumber(c));

            if (checkSTK && checkMoney)
                MessageBox.Show("So tai khoan va so tien khong hop le!");
            else if (checkSTK)
                MessageBox.Show("So tai khoan khong hop le!");
            else if (checkMoney)
                MessageBox.Show("So tien khong hop le!");
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (textBox1.Text == item.SubItems[1].Text)
                    {
                        item.SubItems[2].Text = textBox2.Text;
                        item.SubItems[3].Text = textBox3.Text;
                        item.SubItems[4].Text = textBox4.Text;

                        totalMoney += Convert.ToInt64(item.SubItems[4].Text);
                        textBox5.Text = totalMoney.ToString();

                        MessageBox.Show("Cap nhat du lieu thanh cong!");
                        return;
                    }
                }

                ListViewItem newItem = new ListViewItem((listView1.Items.Count + 1).ToString());
                newItem.SubItems.Add(textBox1.Text);
                newItem.SubItems.Add(textBox2.Text);
                newItem.SubItems.Add(textBox3.Text);
                newItem.SubItems.Add(textBox4.Text);

                listView1.Items.Add(newItem);
                totalMoney += Convert.ToInt64(newItem.SubItems[4].Text);
                textBox5.Text = totalMoney.ToString();

                MessageBox.Show("Them moi du lieu thanh cong!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (textBox1.Text == item.SubItems[1].Text)
                {
                    DialogResult result = MessageBox.Show(
                        "Ban co chac muon xoa khong?",
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        listView1.Items.RemoveAt(listView1.Items.Count - 1);
                        MessageBox.Show("Xoa tai khoan thanh cong");
                    }
                    return;
                }
            }

            MessageBox.Show("Khong tim thay so tai khoan can xoa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                textBox1.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[2].Text;
                textBox3.Text = item.SubItems[3].Text;
                textBox4.Text = item.SubItems[4].Text;
            }
        }
    }
}
