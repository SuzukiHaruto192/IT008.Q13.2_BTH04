namespace BTH4_24521568_NguyenTranLeTam
{
    partial class Bai06
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            toolTip1 = new ToolTip(components);
            SaoChepGroupBox = new GroupBox();
            SaoChepButton = new Button();
            openFile2Button = new Button();
            DesFolderTextBox = new TextBox();
            label2 = new Label();
            openFile1Button = new Button();
            SourceFolderTextBox = new TextBox();
            label1 = new Label();
            TienTrinhGroupBox = new GroupBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SaoChepGroupBox.SuspendLayout();
            TienTrinhGroupBox.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Green;
            progressBar1.Location = new Point(32, 29);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(765, 29);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // SaoChepGroupBox
            // 
            SaoChepGroupBox.Controls.Add(SaoChepButton);
            SaoChepGroupBox.Controls.Add(openFile2Button);
            SaoChepGroupBox.Controls.Add(DesFolderTextBox);
            SaoChepGroupBox.Controls.Add(label2);
            SaoChepGroupBox.Controls.Add(openFile1Button);
            SaoChepGroupBox.Controls.Add(SourceFolderTextBox);
            SaoChepGroupBox.Controls.Add(label1);
            SaoChepGroupBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaoChepGroupBox.ForeColor = Color.Blue;
            SaoChepGroupBox.Location = new Point(39, 36);
            SaoChepGroupBox.Name = "SaoChepGroupBox";
            SaoChepGroupBox.Size = new Size(814, 190);
            SaoChepGroupBox.TabIndex = 1;
            SaoChepGroupBox.TabStop = false;
            SaoChepGroupBox.Text = "Sao chép tập tin";
            // 
            // SaoChepButton
            // 
            SaoChepButton.BackColor = Color.Gainsboro;
            SaoChepButton.FlatAppearance.BorderColor = Color.Black;
            SaoChepButton.FlatStyle = FlatStyle.Flat;
            SaoChepButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaoChepButton.ForeColor = Color.Black;
            SaoChepButton.Location = new Point(278, 140);
            SaoChepButton.Name = "SaoChepButton";
            SaoChepButton.Size = new Size(222, 35);
            SaoChepButton.TabIndex = 6;
            SaoChepButton.Text = "Sao Chép";
            SaoChepButton.UseVisualStyleBackColor = false;
            SaoChepButton.Click += SaoChepButton_Click;
            // 
            // openFile2Button
            // 
            openFile2Button.BackColor = Color.Gainsboro;
            openFile2Button.FlatAppearance.BorderColor = Color.Black;
            openFile2Button.FlatStyle = FlatStyle.Flat;
            openFile2Button.Location = new Point(738, 92);
            openFile2Button.Name = "openFile2Button";
            openFile2Button.Size = new Size(59, 29);
            openFile2Button.TabIndex = 5;
            openFile2Button.Text = "...";
            openFile2Button.UseVisualStyleBackColor = false;
            openFile2Button.Click += openFile2Button_Click;
            // 
            // DesFolderTextBox
            // 
            DesFolderTextBox.BorderStyle = BorderStyle.FixedSingle;
            DesFolderTextBox.Location = new Point(278, 93);
            DesFolderTextBox.Name = "DesFolderTextBox";
            DesFolderTextBox.Size = new Size(454, 30);
            DesFolderTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(212, 23);
            label2.TabIndex = 3;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // openFile1Button
            // 
            openFile1Button.BackColor = Color.Gainsboro;
            openFile1Button.FlatAppearance.BorderColor = Color.Black;
            openFile1Button.FlatStyle = FlatStyle.Flat;
            openFile1Button.Location = new Point(738, 37);
            openFile1Button.Name = "openFile1Button";
            openFile1Button.Size = new Size(59, 29);
            openFile1Button.TabIndex = 2;
            openFile1Button.Text = "...";
            openFile1Button.UseVisualStyleBackColor = false;
            openFile1Button.Click += openFile1Button_Click;
            // 
            // SourceFolderTextBox
            // 
            SourceFolderTextBox.BorderStyle = BorderStyle.FixedSingle;
            SourceFolderTextBox.Location = new Point(278, 38);
            SourceFolderTextBox.Name = "SourceFolderTextBox";
            SourceFolderTextBox.Size = new Size(454, 30);
            SourceFolderTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(231, 23);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // TienTrinhGroupBox
            // 
            TienTrinhGroupBox.Controls.Add(progressBar1);
            TienTrinhGroupBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TienTrinhGroupBox.ForeColor = Color.Blue;
            TienTrinhGroupBox.Location = new Point(39, 269);
            TienTrinhGroupBox.Name = "TienTrinhGroupBox";
            TienTrinhGroupBox.Size = new Size(814, 87);
            TienTrinhGroupBox.TabIndex = 2;
            TienTrinhGroupBox.TabStop = false;
            TienTrinhGroupBox.Text = "Tiến trình sao chép";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.ShowItemToolTips = true;
            statusStrip1.Size = new Size(865, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoToolTip = true;
            toolStripStatusLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 20);
            toolStripStatusLabel1.Text = "Đang Sao Chép:";
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 450);
            Controls.Add(statusStrip1);
            Controls.Add(SaoChepGroupBox);
            Controls.Add(TienTrinhGroupBox);
            Name = "Bai06";
            Text = "Bai06";
            SaoChepGroupBox.ResumeLayout(false);
            SaoChepGroupBox.PerformLayout();
            TienTrinhGroupBox.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private ToolTip toolTip1;
        private GroupBox SaoChepGroupBox;
        private TextBox SourceFolderTextBox;
        private Label label1;
        private Button openFile1Button;
        private Button openFile2Button;
        private TextBox DesFolderTextBox;
        private Label label2;
        private Button SaoChepButton;
        private GroupBox TienTrinhGroupBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}