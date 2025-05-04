namespace WinFormsApp1
{
    partial class FormWord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWord));
            toolStrip1 = new ToolStrip();
            toolStripSplitButton = new ToolStripSplitButton();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBoxFontColor = new ComboBox();
            comboBoxFontSize = new ComboBox();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelSearch = new Panel();
            btn_ara = new Button();
            txtSearch = new TextBox();
            richTextBox1 = new RichTextBox();
            btnApplyBullet = new Button();
            label2 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            cmbBulletType = new ComboBox();
            toolStrip1.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1090, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton
            // 
            toolStripSplitButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton.DropDownItems.AddRange(new ToolStripItem[] { kaydetToolStripMenuItem, çıkışYapToolStripMenuItem, yeniToolStripMenuItem });
            toolStripSplitButton.Image = (Image)resources.GetObject("toolStripSplitButton.Image");
            toolStripSplitButton.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton.Name = "toolStripSplitButton";
            toolStripSplitButton.Size = new Size(69, 24);
            toolStripSplitButton.Text = "Dosya";
            toolStripSplitButton.ButtonClick += toolStripSplitButton_ButtonClick;
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.Size = new Size(150, 26);
            kaydetToolStripMenuItem.Text = "Kaydet";
            kaydetToolStripMenuItem.Click += kaydetToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(150, 26);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(150, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Font Seçiniz:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 57);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxFontColor
            // 
            comboBoxFontColor.FormattingEnabled = true;
            comboBoxFontColor.Location = new Point(86, 96);
            comboBoxFontColor.Margin = new Padding(3, 4, 3, 4);
            comboBoxFontColor.Name = "comboBoxFontColor";
            comboBoxFontColor.Size = new Size(63, 28);
            comboBoxFontColor.TabIndex = 3;
            comboBoxFontColor.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBoxFontSize
            // 
            comboBoxFontSize.FormattingEnabled = true;
            comboBoxFontSize.Location = new Point(14, 96);
            comboBoxFontSize.Margin = new Padding(3, 4, 3, 4);
            comboBoxFontSize.Name = "comboBoxFontSize";
            comboBoxFontSize.Size = new Size(65, 28);
            comboBoxFontSize.TabIndex = 4;
            // 
            // btn_1
            // 
            btn_1.BackColor = SystemColors.ControlLight;
            btn_1.Location = new Point(177, 57);
            btn_1.Margin = new Padding(3, 4, 3, 4);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(30, 31);
            btn_1.TabIndex = 5;
            btn_1.Text = "B";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = SystemColors.ControlLight;
            btn_2.Location = new Point(214, 56);
            btn_2.Margin = new Padding(3, 4, 3, 4);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(30, 31);
            btn_2.TabIndex = 6;
            btn_2.Text = "I";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = SystemColors.ControlLight;
            btn_3.Location = new Point(250, 57);
            btn_3.Margin = new Padding(3, 4, 3, 4);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(30, 31);
            btn_3.TabIndex = 7;
            btn_3.Text = "U";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = SystemColors.ControlLight;
            btn_4.Location = new Point(177, 96);
            btn_4.Margin = new Padding(3, 4, 3, 4);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(30, 31);
            btn_4.TabIndex = 8;
            btn_4.Text = "⭠";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = SystemColors.ControlLight;
            btn_5.Location = new Point(214, 96);
            btn_5.Margin = new Padding(3, 4, 3, 4);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(30, 31);
            btn_5.TabIndex = 9;
            btn_5.Text = "=";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = SystemColors.ControlLight;
            btn_6.Location = new Point(250, 96);
            btn_6.Margin = new Padding(3, 4, 3, 4);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(30, 31);
            btn_6.TabIndex = 10;
            btn_6.Text = "⭢";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_7
            // 
            btn_7.BackgroundImage = (Image)resources.GetObject("btn_7.BackgroundImage");
            btn_7.BackgroundImageLayout = ImageLayout.Zoom;
            btn_7.Location = new Point(295, 57);
            btn_7.Margin = new Padding(3, 4, 3, 4);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(35, 69);
            btn_7.TabIndex = 11;
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.BackgroundImage = (Image)resources.GetObject("btn_8.BackgroundImage");
            btn_8.BackgroundImageLayout = ImageLayout.Zoom;
            btn_8.Location = new Point(337, 56);
            btn_8.Margin = new Padding(3, 4, 3, 4);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(35, 71);
            btn_8.TabIndex = 12;
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.BackgroundImage = (Image)resources.GetObject("btn_9.BackgroundImage");
            btn_9.BackgroundImageLayout = ImageLayout.Zoom;
            btn_9.Location = new Point(379, 56);
            btn_9.Margin = new Padding(3, 4, 3, 4);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(35, 71);
            btn_9.TabIndex = 13;
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(287, 37);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 92);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Location = new Point(422, 37);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 92);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Location = new Point(169, 33);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 92);
            panel3.TabIndex = 16;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(btn_ara);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Location = new Point(642, 56);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(211, 45);
            panelSearch.TabIndex = 17;
            // 
            // btn_ara
            // 
            btn_ara.Location = new Point(160, 5);
            btn_ara.Margin = new Padding(3, 4, 3, 4);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(43, 27);
            btn_ara.TabIndex = 1;
            btn_ara.Text = "Ara";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 5);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 137);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1050, 347);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // btnApplyBullet
            // 
            btnApplyBullet.Location = new Point(569, 63);
            btnApplyBullet.Margin = new Padding(3, 4, 3, 4);
            btnApplyBullet.Name = "btnApplyBullet";
            btnApplyBullet.Size = new Size(63, 28);
            btnApplyBullet.TabIndex = 20;
            btnApplyBullet.Text = "Uygula";
            btnApplyBullet.UseVisualStyleBackColor = true;
            btnApplyBullet.Click += btnApplyBullet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 39);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 21;
            label2.Text = "Madde İşaretleri:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Location = new Point(639, 37);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 92);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Location = new Point(855, 37);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 92);
            panel5.TabIndex = 17;
            // 
            // cmbBulletType
            // 
            cmbBulletType.FormattingEnabled = true;
            cmbBulletType.Location = new Point(430, 63);
            cmbBulletType.Margin = new Padding(3, 4, 3, 4);
            cmbBulletType.Name = "cmbBulletType";
            cmbBulletType.Size = new Size(135, 28);
            cmbBulletType.TabIndex = 22;
            // 
            // FormWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 499);
            Controls.Add(cmbBulletType);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(btnApplyBullet);
            Controls.Add(richTextBox1);
            Controls.Add(panelSearch);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(comboBoxFontSize);
            Controls.Add(comboBoxFontColor);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormWord";
            Text = "Basic MsWord";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown_1;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBoxFontColor;
        private ComboBox comboBoxFontSize;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelSearch;
        private Button btn_ara;
        private TextBox txtSearch;
        private RichTextBox richTextBox1;
        private Button btnApplyBullet;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private ComboBox cmbBulletType;
    }
}
