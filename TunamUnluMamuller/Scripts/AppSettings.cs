using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TunamUnluMamuller.Settings {
    internal static class AppSettings {
        public static string Current_User { get; set; }

        public static readonly Dictionary<string, string> Users = new Dictionary<string, string>() {
            {"admin","1793" },
            {"egemen","789" },
            {"ugur","123" },
        };

        public static CheckState ShowBrowser { get; set; }
        public static CheckState ShowCMD { get; set; }
    }
}
