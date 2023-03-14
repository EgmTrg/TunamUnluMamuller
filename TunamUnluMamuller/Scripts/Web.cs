using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using TunamUnluMamuller.Setting;
using TunamUnluMamuller.Scripts;
using TunamUnluMamuller.Brands;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace TunamUnluMamuller {
    public class Web {
        public Web(DataGridView dataGridView) {
            SetupWebDriver(dataGridView);
        }

        #region Properties

        private IWebDriver driver;
        private ChromeOptions arguments;
        private ChromeDriverService service;
        private DataGridView dataGridView;

        public ChromeDriverService Service {
            get { return service; }
            private set { service = value; }
        }

        public ChromeOptions Options {
            get { return arguments; }
            private set { arguments = value; }
        }

        public IWebDriver Driver {
            get { return driver; }
            private set { driver = value; }
        }

        public DataGridView Output_DataGridView {
            get { return dataGridView; }
            set { dataGridView = value; }
        }
        #endregion

        public struct WebSitesURLs {
            public static string DilimBorek_Login_Url {
                get { return "https://dilimboreksiparis.com/giris.php"; }
            }

            public static string DilimBorek_Reports_Url {
                get { return "https://dilimboreksiparis.com/raporlar"; }
            }

            public static string Musluoglu_Giris_Url {
                get { return "https://musluoglusiparis.com/giris.php"; }
            }

            public static string Musluoglu_Raporlar_Url {
                get { return "https://musluoglusiparis.com/raporlar"; }
            }
        }

        #region SetupField
        private void SetupWebDriver(DataGridView data) {
            Output_DataGridView = data;

            arguments = new ChromeOptions();
            service = ChromeDriverService.CreateDefaultService();

            if (AppSettings.ShowBrowser == CheckState.Unchecked)
                arguments.AddArgument("--headless");
            if (AppSettings.ShowCMD == CheckState.Unchecked)
                service.HideCommandPromptWindow = true;

            if (driver == null) {
                driver = new ChromeDriver(service, arguments);
            }
        }

        #endregion
        #region WebMethods

        public const string TABLE_XPATH = "//*[@id=\"example\"]";

        public bool Start(Brand.Informations info) {
            driver.Navigate().GoToUrl(info.Login_URL);
            Login(info.Username, info.Password);
            Utility.Sleep(Tunam.DelayTime);
            driver.Navigate().GoToUrl(info.Reports_URL);
            Utility.Sleep(Tunam.DelayTime);
            bool result = DropDown_Operations("//*[@id=\"getir\"]/div[1]/div[2]/select", info.NoOrderTextArea, info.OrderDate);
            return result;
        }

        private void Login(string username, string password) {
            //WebDriverWait
            Utility.Sleep(Tunam.DelayTime);
            Driver.FindElement(By.Name("kadi")).SendKeys(username);
            Driver.FindElement(By.Name("sifre")).SendKeys(password);
            Driver.FindElement(By.XPath("//*[@id=\"validate-form\"]/div[3]/div/button")).Click();
        }

        public bool DropDown_Operations(string dropDown_xPath, RichTextBox richTextBox, string orderDate) {
            try {
                string lastSelectedBranch = "";
                SelectElement dropDown = new SelectElement(Driver.FindElement(By.XPath(dropDown_xPath)));
                IWebElement bringData_Button = Driver.FindElement(By.XPath("//*[@id=\"getir\"]/div[4]/button"));
                Driver.FindElement(By.Name("tarih")).SendKeys(orderDate);
                Driver.FindElement(By.Name("tarih2")).SendKeys(orderDate);

                for (int branch_index = 1; branch_index <= dropDown.Options.Count; branch_index++) {
                    // check selected utility.pullbranches value in dropdown.selectedoption.text
                    try {
                        lastSelectedBranch = dropDown.SelectedOption.Text;
                        dropDown.SelectByIndex(branch_index);
                        bringData_Button.Click();
                        Utility.Sleep(Tunam.DelayTime);
                        IWebElement no_Order_Button = Driver.FindElement(By.XPath("/html/body/div[6]/div[7]/div/button"));
                        Utility.Sleep(500);
                        if (no_Order_Button.Displayed) {
                            richTextBox.Text += dropDown.SelectedOption.Text + "\n\n";
                            no_Order_Button.Click();
                        }
                        no_Order_Button.Click();
                    } catch (System.Exception) {
                        Utility.Sleep(Tunam.DelayTime);
                        if (lastSelectedBranch != dropDown.SelectedOption.Text) {
                            Table_Operations(TABLE_XPATH, dropDown.SelectedOption.Text);
                        }
                    }
                    Utility.Sleep(Tunam.DelayTime);
                }
            } catch (System.Exception e) {
                MessageBox.Show(e.Message.ToString());
                return false;
            } finally {
                driver.Quit();
            }
            return true;
        }
        #endregion

        #region Virtual Fields
        public virtual void Table_Operations(string XPath, string branch_Name) {
            IWebElement table = driver.FindElement(By.XPath(XPath));
            List<IWebElement> tr_Elements = new List<IWebElement>(table.FindElements(By.TagName("tr")));
            List<string> data = new List<string>();

            foreach (IWebElement tr_single in tr_Elements) {
                List<IWebElement> td_Elements = new List<IWebElement>(tr_single.FindElements(By.TagName("td")));
                if (td_Elements.Count > 0) {
                    // satir bazli datalari çekiyor
                    foreach (IWebElement cell_single in td_Elements) {
                        if (cell_single.Text == "")
                            data.Add(branch_Name);
                        else
                            data.Add(cell_single.Text);
                    }
                } else {
                    /* HEADER FIELD */
                    /* çekilen datalar header ise bölümünde ise datagridview'da da header bölümüne ekliyor. */
                    if (Output_DataGridView.Columns.Count < 4) {
                        string[] header = tr_Elements[0].Text.Split(' ');
                        Output_DataGridView.Columns.Add("bayiAdı_Column", "BAYİ ADI");
                        for (int i = 0; i < header.Length; i++) {
                            if (header[i] == "SİPARİŞ" || header[i] == "ONAY") {
                                Output_DataGridView.Columns.Add(header[i] + header[++i] + "_Column", header[--i] + " " + header[++i]);
                            }
                        }
                    }
                }

                /* ROWS FIELD */
                /* Eğer veri çektiyse ve bu header değil ise satır olarak datagridview'e ekliyor.*/
                if (data.Count > 0) {
                    int rowIndex = Output_DataGridView.Rows.Add();
                    for (int i = 0; i < data.Count; i++) {
                        Output_DataGridView.Rows[rowIndex].Cells[i].Value = data[i];
                    }
                }

                // ilerleyen zamanlarda written_datas adli iki boyutlu dizi yaparsin.
                // Eklenen datalari bu diziye kaydedersin. [satir][sutun]
                data.Clear();
            }
        }

        internal void Quit() {
            Driver.Quit();
        }
        #endregion
    }
}
