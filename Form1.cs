using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormWord : Form
    {
        public FormWord()
        {
            InitializeComponent();
        }

        private void btn_ara_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            int index = richTextBox1.Text.IndexOf(keyword, StringComparison.OrdinalIgnoreCase);

            if (index >= 0)
            {
                richTextBox1.Select(index, keyword.Length);
                richTextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Metin bulunamad�.");
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedFont = comboBox1.SelectedItem.ToString();
                float fontSize = 12f;
                richTextBox1.SelectionFont = new Font(selectedFont, fontSize);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
            }
            {

                comboBoxFontSize.Items.AddRange(new object[] { 8, 10, 12, 14, 16, 18, 20, 24, 28, 32, 36, 38, 40, 42,
                44, 46, 48, 50, 52, 54, 56, 58, 60});
                comboBoxFontSize.SelectedItem = 12;
            }
            {

                comboBoxFontColor.Items.Add("K�rm�z�");
                comboBoxFontColor.Items.Add("Ye�il");
                comboBoxFontColor.Items.Add("Mavi");
                comboBoxFontColor.Items.Add("Sar�");
                comboBoxFontColor.Items.Add("Mor");
                comboBoxFontColor.Items.Add("Turuncu");
                comboBoxFontColor.Items.Add("Beyaz");


                comboBoxFontColor.SelectedItem = "Siyah";
            }
            {
                // ToolStrip i�ine SplitButton ekliyoruz
                ToolStripSplitButton splitButton = new ToolStripSplitButton();
                splitButton.Text = "Dosya";  // Ana buton ad� "Dosya"
                                             //toolStrip.Items.Add(splitButton);  // ToolStrip'e ekliyoruz

                // SplitButton'a "��k�� Yap" butonunu ekliyoruz
                splitButton.DropDownItems.Add("��k�� Yap", null, ��k��YapToolStripMenuItem_Click);
            }


            cmbBulletType.Items.Add("� Nokta");
            cmbBulletType.Items.Add("� Tire");
            cmbBulletType.Items.Add("* Y�ld�z");

            cmbBulletType.SelectedIndex = 0; // Varsay�lan olarak ilkini se�

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboBoxFontColor.SelectedItem.ToString();


            Color color;
            switch (selectedColor)
            {
                case "K�rm�z�":
                    color = Color.Red;
                    break;
                case "Ye�il":
                    color = Color.Green;
                    break;
                case "Mavi":
                    color = Color.Blue;
                    break;
                case "Sar�":
                    color = Color.Yellow;
                    break;
                case "Mor":
                    color = Color.Purple;
                    break;
                case "Turuncu":
                    color = Color.Orange;
                    break;
                case "Beyaz":
                    color = Color.White;
                    break;
                default:
                    color = Color.Black;
                    break;
            }


            richTextBox1.SelectionColor = color;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ��k��YapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                panelSearch.Visible = !panelSearch.Visible; // A�/kapa
                txtSearch.Focus(); // Arama kutusuna odaklan
            }
        }

        private void toolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyas�|*.txt";
            saveFileDialog.Title = "Metin Belgesi Kaydet";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "Belge";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Dosya .txt olarak kaydedildi.");
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mevcut de�i�iklikler kaybolacak. Devam etmek istiyor musunuz?", "Yeni Dosya", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // RichTextBox i�eri�ini temizle
                richTextBox1.Clear();

                // Varsay�lan yaz� tipi ve boyutu ayarla (iste�e ba�l�)
                richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
                richTextBox1.ForeColor = Color.Black;

                // Panel, arama kutusu, vs. varsa onlar� da s�f�rlayabilirsin
                // txtSearch.Clear();
                // panelSearch.Visible = false;
            }
        }

        private void btnApplyBullet_Click(object sender, EventArgs e)
        {
            if (cmbBulletType.SelectedItem == null)
            {
                MessageBox.Show("L�tfen bir madde i�areti se�in.");
                return;
            }

            string selected = cmbBulletType.SelectedItem.ToString();

            // Se�ime g�re sembol belirle
            string bulletSymbol = "� ";
            switch (selected)
            {
                case "� Tire":
                    bulletSymbol = "� ";
                    break;
                case "* Y�ld�z":
                    bulletSymbol = "* ";
                    break;
            }

            // Se�ilen metindeki her sat�ra sembol� ekle
            string[] lines = richTextBox1.SelectedText.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                    lines[i] = bulletSymbol + lines[i].Trim();
            }

            // Yeni metni geri yaz
            richTextBox1.SelectedText = string.Join("\n", lines);

        }

        private void cmbBulletType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBulletType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
