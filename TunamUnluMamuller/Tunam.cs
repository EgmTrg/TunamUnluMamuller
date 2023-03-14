using TunamUnluMamuller.Brands;
using TunamUnluMamuller.Setting;
using TunamUnluMamuller.Scripts;
using System.Windows.Forms;
using System.Diagnostics;
using System;

namespace TunamUnluMamuller {
    public partial class Tunam : Form {
        public static int DelayTime { get; private set; }

        private Brand.Informations brand_Information;
        private Web web;

        public Tunam() {
            InitializeComponent();
            if (AppSettings.Current_User == "EGEMEN") {
                istanbulBayileriniDahilEtToolStripMenuItem.Enabled = true;
                ankaraBayileriniDahilEtToolStripMenuItem.Enabled = true;
                showBrowser_ToolStripMenuItem.Enabled = true;
                testToolStripMenuItem.Enabled = true;
            }
            toolStripComboBox1.SelectedIndex = 2;
        }

        private void Tunam_Load(object sender, EventArgs e) {
            IsExistChromeDriver();
            currentUser_toolStripLabel.Text = "Geçerli Kullanıcı: " + AppSettings.Current_User;
        }

        private void Tunam_FormClosing(object sender, FormClosingEventArgs e) {
            web?.Quit();
            Application.Exit();
        }


        #region Events

        #region ButtonEvents
        private void run_button_Click(object sender, EventArgs e) {
            if (!dilimBorek_radioButton.Checked && !musluoglu_radioButton.Checked) {
                MessageBox.Show("Dilim Börek ya da Musluoğlu markalarından birini seçiniz!", "Marka Seç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ChangeStatus(true);

            clear_button.PerformClick();
            string order_date = dateTimePicker1.Value.AddDays(-1).ToShortDateString();


            if (dilimBorek_radioButton.Checked) {
                brand_Information = DilimBorek.Set_Informations(dataGridView1, richTextBox1, order_date);
            } else if (musluoglu_radioButton.Checked) {
                brand_Information = Musluoglu.Set_Informations(dataGridView1, richTextBox1, order_date, Utility.pullBranches);
                DetectPullBranches();
            }

            if (brand_Information.SelectedBrand == Brand.Brands.DilimBorek)
                web = new DilimBorek(brand_Information).StartWebProcess();
            else if (brand_Information.SelectedBrand == Brand.Brands.Musluoglu)
                web = new Musluoglu(brand_Information).StartWebProcess();

            if (web.Start(brand_Information))
                MessageBox.Show("Veri çekme işlemi başarıyla tamamlanmıştır.", "Verileri Çek!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Veri çekme işlemi bir hata sonucu tamamlanamadi.", "Verileri Çek!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ChangeStatus(false);
        }

        private void DetectPullBranches() {
            if (istanbulBayileriniDahilEtToolStripMenuItem.Checked)
                brand_Information.PullBranches = Utility.PullBranches.Istanbul;
            if (ankaraBayileriniDahilEtToolStripMenuItem.Checked)
                brand_Information.PullBranches = Utility.PullBranches.Ankara;
            if (istanbulBayileriniDahilEtToolStripMenuItem.Checked && ankaraBayileriniDahilEtToolStripMenuItem.Checked)
                brand_Information.PullBranches = Utility.PullBranches.Both;

        }

        private void clear_button_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            richTextBox1.Clear();
        }

        private void exportToExcel_button_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                "Excel'e kopyalama işlemi, Microsoft Office Excel uygulamanız lisanslı değil ise hata verme ihtimali çok yüksektir.!",
                "MS Office Excel",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK) {
                ChangeStatus(true);
                if (dilimBorek_radioButton.Checked)
                    ExcelOperations.ExportWithExcel(dataGridView1, Utility.Branches.DilimBorek);
                else
                    ExcelOperations.ExportWithExcel(dataGridView1, Utility.Branches.Musluoglu);

                MessageBox.Show("Excel aktarımı başarıyla tamamlanmıştır.", "Dışa Aktar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeStatus(false);
            }
        }
        #endregion

        #region ToolStrip Events
        private void SettingsCheckStateController_CheckStateChanged(object sender, EventArgs e) {
            var item = sender as ToolStripMenuItem;
            switch (item.AccessibleName) {
                case "Browser":
                    AppSettings.ShowBrowser = item.CheckState;
                    break;
                case "Cmd":
                    AppSettings.ShowCMD = item.CheckState;
                    break;
                case "IstanbulMuslu":
                    MessageBox.Show("Henuz aktif degil");
                    break;
                case "AnkaraMuslu":
                    MessageBox.Show("Henuz aktif degil");
                    break;
            }
        }

        private void settings_ToolStripMenuItem_Click(object sender, EventArgs e) =>
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
        #endregion

        #endregion

        #region Methods
        private void IsExistChromeDriver() {
            if (System.IO.File.Exists(@"C:\Windows\chromedriver.exe"))
                return;

            DialogResult dialog = MessageBox.Show(
                "ChromeDriver.exe dosyası bulunamadı. Uygulamayı kullanabilmek için indirmeniz gerekmekte!",
                "ChromDriver Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            if (dialog == DialogResult.OK) {
                string chromeDriver_downloadURL = ("https://chromedriver.chromium.org/downloads");
                Process.Start(chromeDriver_downloadURL);
            }
            Application.Exit();
        }

        private void ChangeStatus(bool visibleValue, string statusText = "LÜTFEN BEKLEYİN. VERİLER İŞLENİYOR...") {
            status_label.Visible = visibleValue;
            status_label.Text = statusText;
        }
        #endregion

        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
            new Settings().Show();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            DelayTime = int.Parse((sender as ToolStripComboBox).Text.ToString());
        }
    }
}
