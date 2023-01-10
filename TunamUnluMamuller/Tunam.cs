using TunamUnluMamuller.Branches;
using System.Windows.Forms;
using System;
using System.Runtime.ConstrainedExecution;
using System.Reflection;

namespace TunamUnluMamuller
{
    public partial class Tunam : Form
    {
        private Web.Informations webInfo;
        private Web web;

        public Tunam()
        {
            InitializeComponent();
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            if (!dilimBorek_radioButton.Checked && !musluoglu_radioButton.Checked)
            {
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

        private void clear_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            richTextBox1.Clear();
        }

        private void exportToExcel_button_Click(object sender, EventArgs e)
        {
            ExcelOperations.ExportWithExcel(dataGridView1);
            MessageBox.Show("Excel aktarımı başarıyla tamamlanmıştır.", "Dışa Aktar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Tunam_FormClosing(object sender, FormClosingEventArgs e)
        {
            web?.Quit();
        }
    }
}
