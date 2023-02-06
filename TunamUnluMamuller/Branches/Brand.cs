using System.Collections.Generic;
using TunamUnluMamuller.Scripts;
using System.Windows.Forms;

namespace TunamUnluMamuller.Brands {
    public class Brand : IBrand {

        #region Instantiate Propertie
        private Informations information;

        public Informations GetInformations {
            get { return information; }
        }

        public Informations SetInformation {
            set { information = value; }
        }
        #endregion

        public Brand(Informations informations) {
            SetInformation = information;
        }

        public Web StartWebProcess() {
            return new Web(information.Data);
        }

        public enum Brands { DilimBorek, Musluoglu }

        public struct Informations {
            internal List<string> Istanbul_List;
            internal List<string> Ankara_List;

            private Brands selectedBrand;
            private DataGridView dataGrid;
            private RichTextBox richTextBox;

            #region PrivateProps
            private string username;
            private string password;
            private string login_url;
            private string reports_url;
            private string order_Date;
            private Utility.PullBranches pullBranches;
            #endregion

            #region PublicProps
            public string OrderDate {
                get { return order_Date; }
                set { order_Date = value; }
            }

            public string Username {
                get { return username; }
                set { username = value; }
            }

            public string Password {
                get { return password; }
                set { password = value; }
            }

            public string Login_URL {
                get { return login_url; }
                set { login_url = value; }
            }

            public string Reports_URL {
                get { return reports_url; }
                set { reports_url = value; }
            }

            public DataGridView Data {
                get { return dataGrid; }
                set { dataGrid = value; }
            }

            public RichTextBox NoOrderTextArea {
                get { return richTextBox; }
                set { richTextBox = value; }
            }

            public Brands SelectedBrand {
                get { return selectedBrand; }
                set { selectedBrand = value; }
            }

            public Utility.PullBranches PullBranches {
                get { return pullBranches; }
                set { pullBranches = value; }
            }
            #endregion
        }
    }
}
