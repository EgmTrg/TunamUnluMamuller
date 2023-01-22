namespace TunamUnluMamuller {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.username_Label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.password_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.aboutApp_linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_Label.Location = new System.Drawing.Point(12, 43);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(122, 23);
            this.username_Label.TabIndex = 0;
            this.username_Label.Text = "Kullanıcı Adı:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(85, 79);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(52, 23);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Sifre:";
            // 
            // password_maskedTextBox
            // 
            this.password_maskedTextBox.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_maskedTextBox.Location = new System.Drawing.Point(146, 76);
            this.password_maskedTextBox.Name = "password_maskedTextBox";
            this.password_maskedTextBox.PasswordChar = '*';
            this.password_maskedTextBox.Size = new System.Drawing.Size(201, 31);
            this.password_maskedTextBox.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(249, 112);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(98, 31);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Giris";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "TUNAM - Sipariş Dosyası Yöneticisi\r\n";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(145, 112);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(98, 31);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Çıkış";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.username_textBox.Location = new System.Drawing.Point(146, 39);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(201, 31);
            this.username_textBox.TabIndex = 1;
            // 
            // aboutApp_linkLabel
            // 
            this.aboutApp_linkLabel.AutoSize = true;
            this.aboutApp_linkLabel.Location = new System.Drawing.Point(12, 130);
            this.aboutApp_linkLabel.Name = "aboutApp_linkLabel";
            this.aboutApp_linkLabel.Size = new System.Drawing.Size(95, 13);
            this.aboutApp_linkLabel.TabIndex = 6;
            this.aboutApp_linkLabel.TabStop = true;
            this.aboutApp_linkLabel.Text = "Program Hakkında";
            this.aboutApp_linkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.aboutApp_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutApp_linkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 146);
            this.ControlBox = false;
            this.Controls.Add(this.aboutApp_linkLabel);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_maskedTextBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUNAM - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.MaskedTextBox password_maskedTextBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.LinkLabel aboutApp_linkLabel;
    }
}