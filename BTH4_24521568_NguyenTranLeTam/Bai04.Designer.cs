namespace BTH4_24521568_NguyenTranLeTam
{
    partial class Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04));
            toolStrip1 = new ToolStrip();
            NewFileButton = new ToolStripButton();
            SaveFileButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            FontComboBox = new ToolStripComboBox();
            SizeComboBox = new ToolStripComboBox();
            BoldButton = new ToolStripButton();
            ItalicButton = new ToolStripButton();
            UnderlineButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            menuStrip1 = new MenuStrip();
            heeToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            lưuNộiDungVănBảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.GradientInactiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { NewFileButton, SaveFileButton, toolStripSeparator1, FontComboBox, SizeComboBox, BoldButton, ItalicButton, UnderlineButton, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // NewFileButton
            // 
            NewFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewFileButton.Image = (Image)resources.GetObject("NewFileButton.Image");
            NewFileButton.ImageTransparentColor = Color.Magenta;
            NewFileButton.Name = "NewFileButton";
            NewFileButton.Size = new Size(29, 25);
            NewFileButton.Text = "toolStripButton1";
            NewFileButton.Click += NewFileButton_Click;
            // 
            // SaveFileButton
            // 
            SaveFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveFileButton.Image = (Image)resources.GetObject("SaveFileButton.Image");
            SaveFileButton.ImageTransparentColor = Color.Magenta;
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(29, 25);
            SaveFileButton.Text = "toolStripButton2";
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // FontComboBox
            // 
            FontComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FontComboBox.Name = "FontComboBox";
            FontComboBox.Size = new Size(200, 28);
            FontComboBox.SelectedIndexChanged += FontComboBox_SelectedIndexChanged;
            // 
            // SizeComboBox
            // 
            SizeComboBox.Name = "SizeComboBox";
            SizeComboBox.Size = new Size(121, 28);
            SizeComboBox.TextChanged += SizeComboBox_TextChanged;
            // 
            // BoldButton
            // 
            BoldButton.CheckOnClick = true;
            BoldButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BoldButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BoldButton.Image = (Image)resources.GetObject("BoldButton.Image");
            BoldButton.ImageTransparentColor = Color.Magenta;
            BoldButton.Name = "BoldButton";
            BoldButton.Size = new Size(29, 25);
            BoldButton.Text = "B";
            BoldButton.Click += BoldButton_Click;
            // 
            // ItalicButton
            // 
            ItalicButton.CheckOnClick = true;
            ItalicButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ItalicButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            ItalicButton.Image = (Image)resources.GetObject("ItalicButton.Image");
            ItalicButton.ImageTransparentColor = Color.Magenta;
            ItalicButton.Name = "ItalicButton";
            ItalicButton.Size = new Size(29, 25);
            ItalicButton.Text = "I";
            ItalicButton.Click += ItalicButton_Click;
            // 
            // UnderlineButton
            // 
            UnderlineButton.CheckOnClick = true;
            UnderlineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            UnderlineButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            UnderlineButton.Image = (Image)resources.GetObject("UnderlineButton.Image");
            UnderlineButton.ImageTransparentColor = Color.Magenta;
            UnderlineButton.Name = "UnderlineButton";
            UnderlineButton.Size = new Size(29, 25);
            UnderlineButton.Text = "U";
            UnderlineButton.Click += UnderlineButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heeToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // heeToolStripMenuItem
            // 
            heeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTậpTinToolStripMenuItem, toolStripSeparator3, lưuNộiDungVănBảnToolStripMenuItem, thoátToolStripMenuItem });
            heeToolStripMenuItem.Name = "heeToolStripMenuItem";
            heeToolStripMenuItem.Size = new Size(85, 24);
            heeToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.BackColor = SystemColors.Control;
            tạoVănBảnMớiToolStripMenuItem.Image = (Image)resources.GetObject("tạoVănBảnMớiToolStripMenuItem.Image");
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(285, 26);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoVănBảnMớiToolStripMenuItem.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Image = (Image)resources.GetObject("mởTậpTinToolStripMenuItem.Image");
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(285, 26);
            mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            mởTậpTinToolStripMenuItem.Click += mởTậpTinToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(282, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            lưuNộiDungVănBảnToolStripMenuItem.Image = (Image)resources.GetObject("lưuNộiDungVănBảnToolStripMenuItem.Image");
            lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuNộiDungVănBảnToolStripMenuItem.Size = new Size(285, 26);
            lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            lưuNộiDungVănBảnToolStripMenuItem.Click += lưuNộiDungVănBảnToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(285, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(92, 24);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 391);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Bai04";
            Text = "Soạn văn bản";
            Load += Bai04_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripComboBox FontComboBox;
        private ToolStripButton NewFileButton;
        private ToolStripButton SaveFileButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox SizeComboBox;
        private ToolStripButton BoldButton;
        private ToolStripButton ItalicButton;
        private ToolStripButton UnderlineButton;
        private ToolStripSeparator toolStripSeparator2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem heeToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}