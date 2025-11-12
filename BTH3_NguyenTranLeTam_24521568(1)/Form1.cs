using System;
using System.Drawing;
using System.Windows.Forms;
namespace BTH3_NguyenTranLeTam_24521568_1_
{
    public partial class Form1 : Form
    {
        private ListBox lstEvent;
        public Form1()
        {
            InitializeComponent();
            lstEvent = new ListBox();
            lstEvent.Dock = DockStyle.Fill;
            this.Controls.Add(lstEvent);

            LogEvent("1.Constructor");

            //this.Load += Form1_Load;
        }

        private void LogEvent(string eventName)
        {
            string logEntry = $"{DateTime.Now} - {eventName}";
            lstEvent.Items.Add(logEntry);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent("2.Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LogEvent("3.Shown");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LogEvent("4.Activated");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            LogEvent("5.Deactivated");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogEvent("6.FormClosed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent("7.FormClosing");
            var result = MessageBox.Show("Are you sure to close form?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lose focus");
        }

    }
}
