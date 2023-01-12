using System;
using System.Windows.Forms;

namespace TunamUnluMamuller.Settings {
    internal static class AppSettings {
        public static string Current_User { get; set; }

        public struct Users {
            public static string[] Usernames = { "EGEMEN", "UGUR", "KERIM" };
            public static string[] Passwords = { "123", "456", "789" };
        }

        public static CheckState ShowBrowser { get; set; }
        public static CheckState ShowCMD { get; set; }
    }
}
