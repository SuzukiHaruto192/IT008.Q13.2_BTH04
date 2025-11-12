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
    public partial class Form9 : Form
    {
        private List<Object> dsMonHoc = new List<Object>();
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                object selectedItem = listBox1.SelectedItem;
                listBox2.Items.Add(selectedItem);
                listBox1.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui long chon mot mon hoc de them!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                object selectedItem = listBox2.SelectedItem;
                listBox1.Items.Add(selectedItem);
                listBox2.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui long chon mot mon hoc de xoa!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                textBox1.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[2].Text;
                comboBox1.Text = item.SubItems[3].Text;
                if (item.SubItems[4].Text == "Nam")
                    checkBox1.Checked = true;
                else
                    checkBox2.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || comboBox1.SelectedIndex == -1 || (checkBox1.Checked == false && checkBox2.Checked == false))
            {
                MessageBox.Show("Vui long nhap du thong tin!");
                return;
            }

            bool checkHoTen = textBox2.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c));
            bool checkMSSV = textBox1.Text.Any(c => !char.IsLetter(c) && !char.IsNumber(c));

            if (checkHoTen && checkMSSV)
                MessageBox.Show("Ma so sinh vien va Ho ten khong hop le!");
            else if (checkHoTen)
                MessageBox.Show("Ho ten khong hop le!");
            else if (checkMSSV)
                MessageBox.Show("Ma so sinh vien khong hop le!");
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[1].Text == textBox1.Text)
                    {
                        item.SubItems[2].Text = textBox2.Text;
                        item.SubItems[3].Text = comboBox1.Text;
                        if (checkBox1.Checked == true)
                            item.SubItems[4].Text = "Nam";
                        else
                            item.SubItems[4].Text = "Nữ";
                        return;
                    }
                }

                ListViewItem newItem = new ListViewItem("*");
                newItem.SubItems.Add(textBox1.Text);
                newItem.SubItems.Add(textBox2.Text);
                newItem.SubItems.Add((string)comboBox1.SelectedItem);
                if (checkBox1.Checked == true)
                    newItem.SubItems.Add("Nam");
                else
                    newItem.SubItems.Add("Nữ");
                newItem.SubItems.Add(listBox2.Items.Count.ToString());

                listView1.Items.Add(newItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedItem = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            foreach (var item in dsMonHoc)
            {
                listBox1.Items.Add(item);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            foreach(var item in listBox1.Items)
                dsMonHoc.Add(item);
        }
    }
}
