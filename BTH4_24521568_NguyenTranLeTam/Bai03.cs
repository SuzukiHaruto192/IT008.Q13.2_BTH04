namespace BTH4_24521568_NguyenTranLeTam
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tệp Media (*.avi, *.mpeg, *.wav, *.midi, *.mp4, *.mp3 ) | *.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string duongDanFile = openFileDialog1.FileName;
                Wmplayer.URL = duongDanFile;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime thoiGianHienTai = DateTime.Now;
            string ngay = thoiGianHienTai.ToString("dd/MM/yyyy");
            string gio = thoiGianHienTai.ToString("hh:mm:ss tt");

            toolStripStatusLabel1.Text = $"Hôm nay là ngày {ngay} - Bây giờ là {gio}";
        }
    }
}
