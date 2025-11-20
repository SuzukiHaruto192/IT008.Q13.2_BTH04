using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_24521568_NguyenTranLeTam
{
    public partial class Bai05_ThemMoi : Form
    {
        public string MSSV;
        public string TenSV;
        public string Khoa;
        public string DiemTB;
        public Bai05_ThemMoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool invalidMSSV = MSSVTextBox.Text.Any(c => !char.IsDigit(c));
            bool invalidTenSV = TenSVTextBox.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c));
            bool invalidKhoa = KhoaTextBox.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c));
            bool invalidDiemTB = !float.TryParse(DiemTBTextBox.Text, out float Diem) || Diem < 0 || Diem > 10;

            if (string.IsNullOrEmpty(MSSVTextBox.Text) || string.IsNullOrEmpty(TenSVTextBox.Text) ||
                string.IsNullOrEmpty(KhoaTextBox.Text) || string.IsNullOrEmpty(DiemTBTextBox.Text))
                MessageBox.Show("Vui long nhap dien du thong tin!");
            else if (invalidMSSV)
                MessageBox.Show("Ma so sinh vien khong hop le!");
            else if (invalidTenSV)
                MessageBox.Show("Ten sinh vien khong hop le!");
            else if (invalidKhoa)
                MessageBox.Show("Khoa khong hop le!");
            else if (invalidDiemTB)
                MessageBox.Show("Diem trung binh khong hop le!");
            else if (invalidMSSV || invalidTenSV || invalidKhoa || invalidDiemTB)
                MessageBox.Show("Co it nhat 2 du lieu duoc nhap vao khong hop le!");
            else 
            {
                MSSV = MSSVTextBox.Text;
                TenSV = TenSVTextBox.Text;
                Khoa = KhoaTextBox.Text;
                DiemTB = DiemTBTextBox.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
