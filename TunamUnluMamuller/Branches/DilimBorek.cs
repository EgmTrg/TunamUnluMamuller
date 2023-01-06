using System.Windows.Forms;

namespace TunamUnluMamuller.Branches
{
    internal class DilimBorek : Web, IBranch
    {
        public DilimBorek(Informations informations) : base(informations.DataGridView) { }

        public static Informations Get_Informations(DataGridView dataGridView, RichTextBox richTextBox, string order_date)
        {
            return new DilimBorek.Informations
            {
                Branch = Branch.DilimBorek,
                DataGridView = dataGridView,
                RichTextBox = richTextBox,
                Login_URL = Web.WebSites.DilimBorek_Giris_Url,
                Reports_URL = Web.WebSites.DilimBorek_Reports_Url,

                Username = "admin",
                Password = "dilim2016",
                OrderDate = order_date
            };
        }

        public override bool Start(Informations information) => base.Start(information);
    }
}
