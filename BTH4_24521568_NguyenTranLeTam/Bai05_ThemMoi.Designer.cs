namespace BTH4_24521568_NguyenTranLeTam
{
    partial class Bai05_ThemMoi
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
            label1 = new Label();
            MSSVTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TenSVTextBox = new TextBox();
            DiemTBTextBox = new TextBox();
            KhoaTextBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(60, 64);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Số Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MSSVTextBox
            // 
            MSSVTextBox.BorderStyle = BorderStyle.FixedSingle;
            MSSVTextBox.Location = new Point(235, 64);
            MSSVTextBox.Name = "MSSVTextBox";
            MSSVTextBox.Size = new Size(319, 27);
            MSSVTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(60, 116);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên Sinh Viên";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(60, 172);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 3;
            label3.Text = "Khoa";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(60, 222);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 4;
            label4.Text = "Điểm TB";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TenSVTextBox
            // 
            TenSVTextBox.BorderStyle = BorderStyle.FixedSingle;
            TenSVTextBox.Location = new Point(235, 116);
            TenSVTextBox.Name = "TenSVTextBox";
            TenSVTextBox.Size = new Size(379, 27);
            TenSVTextBox.TabIndex = 5;
            // 
            // DiemTBTextBox
            // 
            DiemTBTextBox.BorderStyle = BorderStyle.FixedSingle;
            DiemTBTextBox.Location = new Point(235, 222);
            DiemTBTextBox.Name = "DiemTBTextBox";
            DiemTBTextBox.Size = new Size(133, 27);
            DiemTBTextBox.TabIndex = 6;
            // 
            // KhoaTextBox
            // 
            KhoaTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            KhoaTextBox.FormattingEnabled = true;
            KhoaTextBox.Items.AddRange(new object[] { "Công nghệ thông tin", "Công nghệ phần mềm", "Khoa học máy tính", "Hệ thống thông tin", "Mạng máy tính và truyền thông", "Kỹ thuật máy tính" });
            KhoaTextBox.Location = new Point(235, 171);
            KhoaTextBox.Name = "KhoaTextBox";
            KhoaTextBox.Size = new Size(379, 28);
            KhoaTextBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(363, 286);
            button1.Name = "button1";
            button1.Size = new Size(124, 41);
            button1.TabIndex = 8;
            button1.Text = "Thêm Mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(493, 286);
            button2.Name = "button2";
            button2.Size = new Size(121, 41);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Bai05_ThemMoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 345);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(KhoaTextBox);
            Controls.Add(DiemTBTextBox);
            Controls.Add(TenSVTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MSSVTextBox);
            Controls.Add(label1);
            Name = "Bai05_ThemMoi";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MSSVTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TenSVTextBox;
        private TextBox DiemTBTextBox;
        private ComboBox KhoaTextBox;
        private Button button1;
        private Button button2;
    }
}