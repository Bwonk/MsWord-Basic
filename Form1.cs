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
                MessageBox.Show("Metin bulunamadý.");
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

                comboBoxFontColor.Items.Add("Kýrmýzý");
                comboBoxFontColor.Items.Add("Yeþil");
                comboBoxFontColor.Items.Add("Mavi");
                comboBoxFontColor.Items.Add("Sarý");
                comboBoxFontColor.Items.Add("Mor");
                comboBoxFontColor.Items.Add("Turuncu");
                comboBoxFontColor.Items.Add("Beyaz");


                comboBoxFontColor.SelectedItem = "Siyah";
            }
            {
                // ToolStrip içine SplitButton ekliyoruz
                ToolStripSplitButton splitButton = new ToolStripSplitButton();
                splitButton.Text = "Dosya";  // Ana buton adý "Dosya"
                                             //toolStrip.Items.Add(splitButton);  // ToolStrip'e ekliyoruz

                // SplitButton'a "Çýkýþ Yap" butonunu ekliyoruz
                splitButton.DropDownItems.Add("Çýkýþ Yap", null, çýkýþYapToolStripMenuItem_Click);
            }


            cmbBulletType.Items.Add("• Nokta");
            cmbBulletType.Items.Add("– Tire");
            cmbBulletType.Items.Add("* Yýldýz");

            cmbBulletType.SelectedIndex = 0; // Varsayýlan olarak ilkini seç

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboBoxFontColor.SelectedItem.ToString();


            Color color;
            switch (selectedColor)
            {
                case "Kýrmýzý":
                    color = Color.Red;
                    break;
                case "Yeþil":
                    color = Color.Green;
                    break;
                case "Mavi":
                    color = Color.Blue;
                    break;
                case "Sarý":
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

        private void çýkýþYapToolStripMenuItem_Click(object sender, EventArgs e)
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
                panelSearch.Visible = !panelSearch.Visible; // Aç/kapa
                txtSearch.Focus(); // Arama kutusuna odaklan
            }
        }

        private void toolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyasý|*.txt";
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
            DialogResult result = MessageBox.Show("Mevcut deðiþiklikler kaybolacak. Devam etmek istiyor musunuz?", "Yeni Dosya", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // RichTextBox içeriðini temizle
                richTextBox1.Clear();

                // Varsayýlan yazý tipi ve boyutu ayarla (isteðe baðlý)
                richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
                richTextBox1.ForeColor = Color.Black;

                // Panel, arama kutusu, vs. varsa onlarý da sýfýrlayabilirsin
                // txtSearch.Clear();
                // panelSearch.Visible = false;
            }
        }

        private void btnApplyBullet_Click(object sender, EventArgs e)
        {
            if (cmbBulletType.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir madde iþareti seçin.");
                return;
            }

            string selected = cmbBulletType.SelectedItem.ToString();

            // Seçime göre sembol belirle
            string bulletSymbol = "• ";
            switch (selected)
            {
                case "– Tire":
                    bulletSymbol = "– ";
                    break;
                case "* Yýldýz":
                    bulletSymbol = "* ";
                    break;
            }

            // Seçilen metindeki her satýra sembolü ekle
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
