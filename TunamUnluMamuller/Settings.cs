using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using TunamUnluMamuller.Properties;

namespace TunamUnluMamuller.Setting {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();

            if (AppSettings.Istanbul_Musluoglu == null)
                AppSettings.List_Istanbul();
            if (AppSettings.Ankara_Musluoglu == null)
                AppSettings.List_Ankara();
        }

        private void Settings_Load(object sender, System.EventArgs e) {
            ListToListview();
        }

        private void ListToListview() {
            foreach (string branch in AppSettings.Istanbul_Musluoglu)
                listView1.Items.Add(branch + "\n\n");

            foreach (string branch in AppSettings.Ankara_Musluoglu) {
                listView2.Items.Add(branch + "\n\n");
            }
        }
    }
}
