namespace BTH3_NguyenTranLeTam_24521568_1_
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label6 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(985, 68);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(156, 91);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(294, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(568, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(294, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(568, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(294, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(568, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(294, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(568, 27);
            textBox4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(131, 138);
            label3.Name = "label3";
            label3.Size = new Size(146, 28);
            label3.TabIndex = 6;
            label3.Text = "Tên khách hàng";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(101, 184);
            label4.Name = "label4";
            label4.Size = new Size(176, 28);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ khách hàng";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(64, 230);
            label5.Name = "label5";
            label5.Size = new Size(213, 28);
            label5.TabIndex = 8;
            label5.Text = "Số tiền trong tài khoản";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(445, 273);
            button1.Name = "button1";
            button1.Size = new Size(155, 36);
            button1.TabIndex = 9;
            button1.Text = "Thêm / Cập Nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(628, 273);
            button2.Name = "button2";
            button2.Size = new Size(105, 36);
            button2.TabIndex = 10;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(760, 273);
            button3.Name = "button3";
            button3.Size = new Size(102, 36);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader3, columnHeader4, columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 329);
            listView1.Name = "listView1";
            listView1.Size = new Size(960, 214);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "STT";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã tài khoản";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên khách hàng";
            columnHeader4.Width = 260;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Địa chỉ";
            columnHeader1.Width = 275;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số tiền";
            columnHeader2.Width = 250;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(535, 557);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 13;
            label6.Text = "Tổng tiền:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(658, 557);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(314, 27);
            textBox5.TabIndex = 14;
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 593);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListView listView1;
        private Label label6;
        private TextBox textBox5;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}