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
    public partial class Bai06 : Form
    {
        private string SouFolderPath;
        private string DesFolderPath;
        public Bai06()
        {
            InitializeComponent();
        }

        private void openFile1Button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SourceFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void openFile2Button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DesFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SaoChepButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            if (string.IsNullOrEmpty(SourceFolderTextBox.Text) && string.IsNullOrEmpty(DesFolderTextBox.Text))
            {
                MessageBox.Show("Vui long nhap duong dan thu muc nguon va thu muc dich");
                return;
            }
            else if (string.IsNullOrEmpty(SourceFolderTextBox.Text))
            {
                MessageBox.Show("Vui long nhap duong dan thu muc nguon");
                return;
            }
            else if (string.IsNullOrEmpty(DesFolderTextBox.Text))
            {
                MessageBox.Show("Vui long nhap duong dan thu muc dich");
                return;
            }
                
            SouFolderPath = SourceFolderTextBox.Text;
            DesFolderPath = DesFolderTextBox.Text;

            if (!Directory.Exists(SouFolderPath) && !Directory.Exists(DesFolderPath))
            {
                MessageBox.Show("Khong tim thay thu muc nguon va thu muc dich");
                return;
            }
            else if (!Directory.Exists(SouFolderPath))
            {
                MessageBox.Show("Khong tim thay thu muc nguon");
                return;
            }
            else if (!Directory.Exists(DesFolderPath))
            {
                MessageBox.Show("Khong tim thay thu muc nguon");
                return;
            }
            else if (!Directory.Exists(SouFolderPath) && !Directory.Exists(DesFolderPath))
            {
                MessageBox.Show("Khong tim thay thu muc nguon va thu muc dich");
                return;
            }

            string[] files = Directory.GetFiles(SouFolderPath);
            progressBar1.Maximum = files.Length;
            foreach (string file in files)
            { 
                string desFile = Path.Combine(DesFolderPath, Path.GetFileName(file));
                File.Copy(file, desFile, true);
                progressBar1.PerformStep();

                toolStripStatusLabel1.Text = "Đang Sao Chép: " + Path.GetFileName(file);
                if(progressBar1.Value == progressBar1.Maximum)
                    toolStripStatusLabel1.Text = "Đã Sao Chép Xong ";
                toolStripStatusLabel1.ToolTipText = toolStripStatusLabel1.Text;

                Delay(1000);
            }
        }

        //Ham delay de hien thi qua trinh sao chep cham lai cho de quan sat
        private void Delay(int millisecond)
        {
            long tick = Environment.TickCount;
            while (Environment.TickCount - tick < millisecond)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
