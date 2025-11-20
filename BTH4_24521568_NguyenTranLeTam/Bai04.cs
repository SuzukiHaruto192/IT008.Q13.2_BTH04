using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_24521568_NguyenTranLeTam
{
    public partial class Bai04 : Form
    {
        private bool isUpdating = false;
        private string currentFilePath;
        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            //Khoi tao khung soan van ban
            richTextBox1.Width = this.ClientSize.Width;
            richTextBox1.Height = this.ClientSize.Height;

            //Khoi tao FontCombobox
            foreach (FontFamily font in FontFamily.Families)
            {
                FontComboBox.Items.Add(font.Name);
            }
            FontComboBox.SelectedItem = "Tahoma";

            //Khoi tao SizeCombobox
            for (int i = 8; i <= 12; i++)
            {
                SizeComboBox.Items.Add(i.ToString());
            }
            for (int i = 14; i <= 28; i += 2)
            {
                SizeComboBox.Items.Add(i.ToString());
            }
            SizeComboBox.Items.Add("36");
            SizeComboBox.Items.Add("48");
            SizeComboBox.Items.Add("72");
            SizeComboBox.SelectedItem = "14";

            //Khoi tao font cho richtextbox
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        //Bam nut dinh dang tren thanh menu
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Reset();

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                FontComboBox.Text = fontDialog1.Font.Name;
                SizeComboBox.Text = fontDialog1.Font.Size.ToString();

                richTextBox1.SelectionFont = fontDialog1.Font;

                BoldButton.Checked = fontDialog1.Font.Bold;
                ItalicButton.Checked = fontDialog1.Font.Italic;
                UnderlineButton.Checked = fontDialog1.Font.Underline;
            }
        }

        //Chon van ban trong richtextbox
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            isUpdating = true;

            try
            {
                Font selectionFont = richTextBox1.SelectionFont;

                if (selectionFont != null)
                {
                    BoldButton.Checked = selectionFont.Bold;
                    ItalicButton.Checked = selectionFont.Italic;
                    UnderlineButton.Checked = selectionFont.Underline;

                    FontComboBox.Text = selectionFont.FontFamily.Name;
                    SizeComboBox.Text = Math.Round(selectionFont.Size).ToString();
                }
                else
                {
                    BoldButton.Checked = false;
                    ItalicButton.Checked = false;
                    UnderlineButton.Checked = false;
                    FontComboBox.Text = "";
                    SizeComboBox.Text = "";
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                isUpdating = false;
            }
        }

        //Tao file moi
        private void newFile()
        {
            richTextBox1.Clear();
            FontComboBox.SelectedItem = "Tahoma";
            SizeComboBox.SelectedItem = "14";
        }
        private void NewFileButton_Click(object sender, EventArgs e)
        {
            newFile();
        }
        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        //Luu file
        private void saveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                saveFileDialog1.Filter = "Rich text format (*.rtf) | *.rtf";
                saveFileDialog1.DefaultExt = "rtf";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.Title = "Lưu văn bản";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Đã lưu thành công!", "Thông báo");
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Đã lưu thành công!", "Thông báo");
            }
        }
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        //Mo file co san
        private void openFile()
        {
            openFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.AddExtension = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog1.FileName;
                if (currentFilePath.EndsWith(".txt"))
                    richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
            }
        }
        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        //Thao tac doi font cho van ban soan thao
        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont == null) { currentFont = richTextBox1.Font; }

            Font newFont = new Font(FontComboBox.Text, currentFont.Size, currentFont.Style);
            richTextBox1.SelectionFont = newFont;
        }
        private void SizeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont == null) { currentFont = richTextBox1.Font; }

            float newSize;
            if (float.TryParse(SizeComboBox.Text, out newSize))
            {
                if (newSize > 0)
                {
                    Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }
        }

        //Cac nut chinh style cho font chu
        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (isUpdating) return;

            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont == null) { currentFont = richTextBox1.Font; }

            FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            richTextBox1.SelectionFont = newFont;
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if (isUpdating) return;

            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont == null) { currentFont = richTextBox1.Font; }

            FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            richTextBox1.SelectionFont = newFont;
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            if (isUpdating) return;

            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont == null) { currentFont = richTextBox1.Font; }

            FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            richTextBox1.SelectionFont = newFont;
        }

        //Nut thoat
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
