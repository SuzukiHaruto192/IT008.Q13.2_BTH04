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
    public partial class Form2 : Form
    {
        private Random random = new Random();
        private Font font = new Font("Seogue UI", 16);
        private SolidBrush brush = new SolidBrush(Color.Red);
        private Bitmap bitmap;
        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                SizeF size = g.MeasureString("Paint Event", font);
                float maxX = this.ClientSize.Width - size.Width;
                float maxY = this.ClientSize.Height - size.Height;

                float x = random.Next(0, (int)maxX);

                float y = random.Next(0, (int)maxY);
                g.DrawString("Paint Event", font, brush, x, y);
            }
            this.Invalidate();
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            if(bitmap != null)
                bitmap.Dispose();

            bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            this.Invalidate();
        }
    }
}
