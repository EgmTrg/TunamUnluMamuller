using System;
using System.Diagnostics;
using System.Windows.Forms;
using TunamUnluMamuller.Branches;
using TunamUnluMamuller.Settings;

namespace TunamUnluMamuller {
    public partial class Tunam : Form {
        private Web.Informations webInfo;
        private Web web;

        public Tunam() {
            InitializeComponent();
        }

        private void Tunam_Load(object sender, EventArgs e) {
            IsExistChromeDriver();
            currentUser_toolStripLabel.Text = "Geçerli Kullanıcı: " + AppSettings.Current_User;
            AppSettings.ShowBrowser = CheckState.Checked;
            AppSettings.ShowCMD = CheckState.Unchecked;
        }

        private void Tunam_FormClosing(object sender, FormClosingEventArgs e) {
            web?.Quit();
            Application.Exit();
        }

        #region ButtonEvents
        private void run_button_Click(object sender, EventArgs e) {
            if (!dilimBorek_radioButton.Checked && !musluoglu_radioButton.Checked) {
                MessageBox.Show("Dilim Börek ya da Musluoğlu markalarından birini seçiniz!", "Marka Seç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clear_button.PerformClick();
            string order_date = dateTimePicker1.Value.AddDays(-1).ToShortDateString();

            if (dilimBorek_radioButton.Checked)
                webInfo = DilimBorek.Get_Informations(dataGridView1, richTextBox1, order_date);
            else if (musluoglu_radioButton.Checked)
                webInfo = Musluoglu.Get_Informations(dataGridView1, richTextBox1, order_date);


            if (webInfo.Branch == Web.Branch.DilimBorek)
                web = new DilimBorek(webInfo);
            else if (webInfo.Branch == Web.Branch.Musluoglu)
                web = new Musluoglu(webInfo);

            web.ORDER_DATE = order_date;

            if (web.Start(webInfo))
                MessageBox.Show("Veri çekme işlemi başarıyla tamamlanmıştır.", "Verileri Çek!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Veri çekme işlemi bir hata sonucu tamamlanamadi.", "Verileri Çek!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clear_button_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            richTextBox1.Clear();
        }

        private void exportToExcel_button_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "Excel'e kopyalama işlemi, Microsoft Office Excel uygulamanız lisanslı değil ise hata verme ihtimali çok yüksektir.!",
                "MS Office Excel",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExcelOperations.ExportWithExcel(dataGridView1);
            MessageBox.Show("Excel aktarımı başarıyla tamamlanmıştır.", "Dışa Aktar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SettingsCheckStateController_CheckStateChanged(object sender, EventArgs e) {
            var item = sender as ToolStripMenuItem;
            switch (item.AccessibleName) {
                case "Browser":
                    AppSettings.ShowBrowser = item.CheckState;
                    break;
                case "Cmd":
                    AppSettings.ShowCMD = item.CheckState;
                    break;
            }
        }
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
        #endregion

        private void settings_ToolStripMenuItem_Click(object sender, EventArgs e) {
            var item = sender as ToolStripMenuItem;
            if (item.CheckState == CheckState.Unchecked) {
                item.CheckState = CheckState.Checked;
            } else {
                item.CheckState = CheckState.Unchecked;
            }
        }
    }
}
