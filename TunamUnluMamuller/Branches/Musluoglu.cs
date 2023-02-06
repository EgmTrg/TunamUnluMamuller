using System.Windows.Forms;
using TunamUnluMamuller.Scripts;
using TunamUnluMamuller.Setting;
using static TunamUnluMamuller.Scripts.Utility;

namespace TunamUnluMamuller.Brands {
    internal class Musluoglu : Brand, IBrand {
        
        public Musluoglu(Informations info) : base(info) {
            SetInformation = info;
        }

        public static Informations Set_Informations(DataGridView dataGridView, RichTextBox richTextBox, string order_date, Utility.PullBranches pullBranches) {
            return new Informations {
                SelectedBrand = Brands.Musluoglu,
                Data = dataGridView,
                NoOrderTextArea = richTextBox,
                Login_URL = Web.WebSitesURLs.Musluoglu_Giris_Url,
                Reports_URL = Web.WebSitesURLs.Musluoglu_Raporlar_Url,
                PullBranches = pullBranches,

                Username = "sistem@musluoglusiparis.com",
                Password = "muslu",
                OrderDate = order_date,

                Istanbul_List = AppSettings.Istanbul_Musluoglu,
                Ankara_List = AppSettings.Ankara_Musluoglu
            };
        }
    }
}
