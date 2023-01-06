﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TunamUnluMamuller.Branches
{
    internal class Musluoglu : Web, IBranch
    {
        public Musluoglu(DataGridView dataGridView, RichTextBox richTextBox, string order_date) : base(dataGridView) { }

        public Musluoglu(DataGridView dataGridView) : base(dataGridView) { }

        public Musluoglu(Informations informations) : base(informations.DataGridView) { }

        public static Informations Get_Informations(DataGridView dataGridView, RichTextBox richTextBox, string order_date)
        {
            return new Musluoglu.Informations
            {
                Branch = Branch.Musluoglu,
                DataGridView = dataGridView,
                RichTextBox = richTextBox,
                Login_URL = Web.WebSites.Musluoglu_Giris_Url,
                Reports_URL = Web.WebSites.Musluoglu_Raporlar_Url,

                Username = "sistem@musluoglusiparis.com",
                Password = "muslu",
                OrderDate = order_date
            };
        }
    }
}