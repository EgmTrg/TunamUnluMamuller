using System;
using System.Windows.Forms;
using TunamUnluMamuller.Settings;

namespace TunamUnluMamuller {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            string username = username_textBox.Text.ToLower(),
                    password = password_maskedTextBox.Text.ToLower(),
                    validPassword;

            if (AppSettings.Users.ContainsKey(username)) {
                AppSettings.Users.TryGetValue(username, out validPassword);
                if (password == validPassword) {
                    AppSettings.Current_User = username.ToUpper();
                    new Tunam().Show();
                    Hide();
                } else
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
                MessageBox.Show("Kullanıcı sisteme kayıtlı değil!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void aboutApp_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new AboutBox().Show();
        }

        private void password_maskedTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                login_button.PerformClick();
            }
        }
    }
}
