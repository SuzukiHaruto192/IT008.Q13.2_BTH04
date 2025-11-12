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
    public partial class Form3 : Form
    {
        private Random rnd = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private Color GetRandomColor() 
        {
            int r = rnd.Next(0, 256);
            int g = rnd.Next(0, 256);
            int b = rnd.Next(0, 256);

            return Color.FromArgb(r, g, b);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Color Background = GetRandomColor();

            this.BackColor = Background;
        }
    }
}
