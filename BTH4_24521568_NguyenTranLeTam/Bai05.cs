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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        //Mo form de them moi du lieu
        private void ThemMoi()
        {
            Bai05_ThemMoi FormThemMoi = new Bai05_ThemMoi();
            FormThemMoi.ShowDialog();

            if (FormThemMoi.DialogResult == DialogResult.OK)
            {
                string mssv = FormThemMoi.MSSV;
                string tensv = FormThemMoi.TenSV;
                string khoa = FormThemMoi.Khoa;
                string diemtb = FormThemMoi.DiemTB;

                dataGridView1.Rows.Add(dataGridView1.RowCount + 1, mssv, tensv, khoa, diemtb);
            }
        }
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemMoi();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThemMoi();
        }

        //Thoat
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Tim kiem theo ten
        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.SuspendLayout();

            string keywords = TimKiemTextBox.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string tenSV = row.Cells["Column3"].Value.ToString().ToLower();
                if (tenSV.Contains(keywords))
                    row.Visible = true;
                else
                    row.Visible = false;
            }

            dataGridView1.ResumeLayout();
        }
    }
}
