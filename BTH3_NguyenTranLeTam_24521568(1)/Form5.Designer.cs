namespace BTH3_NguyenTranLeTam_24521568_1_
{
    partial class Form5
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
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.Location = new Point(199, 54);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.Location = new Point(199, 96);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 1;
            label2.Text = "Number 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(300, 233);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(257, 27);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(216, 237);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 5;
            label3.Text = "Answer";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(216, 155);
            button1.Name = "button1";
            button1.Size = new Size(63, 51);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.Location = new Point(300, 155);
            button2.Name = "button2";
            button2.Size = new Size(63, 51);
            button2.TabIndex = 7;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Arial", 12F, FontStyle.Bold);
            button3.Location = new Point(387, 155);
            button3.Name = "button3";
            button3.Size = new Size(63, 51);
            button3.TabIndex = 8;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.Font = new Font("Arial", 12F, FontStyle.Bold);
            button4.Location = new Point(473, 155);
            button4.Name = "button4";
            button4.Size = new Size(63, 51);
            button4.TabIndex = 9;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}