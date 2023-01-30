using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TunamUnluMamuller.Properties;

namespace TunamUnluMamuller.Settings {
    internal static class AppSettings {
        public static string Current_User { get; set; }
        public static CheckState ShowBrowser { get; set; }
        public static CheckState ShowCMD { get; set; }
        public static List<string> Istanbul_Musluoglu { get; set; }
        public static List<string> Ankara_Musluoglu { get; set; }

        public static readonly Dictionary<string, string> Users = new Dictionary<string, string>() {
            {"admin","1234" },
            {"egemen","789" },
        };

        public static class SettingsFromResources {
            //public static string Settings_TXTPath { get { return "..\\..\\settings.txt"; } }
            public enum Setting_Type { Username, Password }
            public static Setting_Type setting_Type { get; set; }

            public static void IstanbulAnkaraBranches() {
                Istanbul_Musluoglu = Resources.Istanbul.Split(' ').ToList();
                Istanbul_Musluoglu = Resources.Ankara.Split(' ').ToList();
            }


            /*internal static List<string> DetectIstanbulMusluoglu() {
                string[] rows = IstanbulAnkaraBranches();
                List<string> istanbul = new List<string>();

                // ISTANBUL
                foreach (var row in rows) {
                    if (row.StartsWith("ISTANBUL=")) {
                        istanbul = row.Split(' ').ToList();
                    }
                }

                return istanbul;
            }

            internal static List<string> DetectAnkaraMusluoglu() {
                string[] rows = IstanbulAnkaraBranches();
                List<string> ankara = new List<string>();

                // ANKARA
                foreach (var row in rows) {
                    if (row.StartsWith("ANKARA=")) {
                        ankara = row.Split(' ').ToList();
                    }
                }

                //ankara.AddRange(ankara);

                return ankara;
            }

            public static void ChangeSettingValue(string oldValue, string newValue) {
                try {
                    string data = File.ReadAllText(Settings_TXTPath);
                    string value = data.Replace(oldValue, newValue);
                    File.WriteAllText(Settings_TXTPath, value);
                } catch (Exception e) {
                    MessageBox.Show(e.Message);
                    throw;
                }
            }*/
        }
    }
}