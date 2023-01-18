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
            if (username_textBox.Text.ToLower() == "admin" && password_maskedTextBox.Text.ToLower() == "1234") {
                AppSettings.Current_User = "admin".ToUpper();
                new Tunam().Show();
                Hide();
            } else {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                login_button.PerformClick();
            }
        }
    }
}
