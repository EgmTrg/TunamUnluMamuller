using System.Windows.Forms;

namespace TunamUnluMamuller.Brands {
    internal class DilimBorek : Brand, IBrand {

        public DilimBorek(Informations info) : base(info) {
            SetInformation = info;
        }

        public static Informations Set_Informations(DataGridView dataGridView, RichTextBox richTextBox, string order_date) {
            return new Informations {
                SelectedBrand = Brands.DilimBorek,
                Data = dataGridView,
                NoOrderTextArea = richTextBox,
                Login_URL = Web.WebSitesURLs.DilimBorek_Login_Url,
                Reports_URL = Web.WebSitesURLs.DilimBorek_Reports_Url,

                Username = "admin",
                Password = "dilim2016",
                OrderDate = order_date
            };
        }

        /*public override bool Start(Informations information) => base.Start(information);*/
    }
}
