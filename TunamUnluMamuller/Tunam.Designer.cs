namespace TunamUnluMamuller
{
    partial class Tunam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_panel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musluoglu_radioButton = new System.Windows.Forms.RadioButton();
            this.dilimBorek_radioButton = new System.Windows.Forms.RadioButton();
            this.clear_button = new System.Windows.Forms.Button();
            this.exportToExcel_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.run_button = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.Controls.Add(this.richTextBox1);
            this.main_panel.Controls.Add(this.dateTimePicker1);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.musluoglu_radioButton);
            this.main_panel.Controls.Add(this.dilimBorek_radioButton);
            this.main_panel.Controls.Add(this.clear_button);
            this.main_panel.Controls.Add(this.exportToExcel_button);
            this.main_panel.Controls.Add(this.dataGridView1);
            this.main_panel.Controls.Add(this.run_button);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(811, 405);
            this.main_panel.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 204);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(306, 193);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 26);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "SİPARİŞİ OLMAYAN BAYİLER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bugünün tarihini seçerseniz, dünün sipariş verileri çekilir.\r\n";
            // 
            // musluoglu_radioButton
            // 
            this.musluoglu_radioButton.AutoSize = true;
            this.musluoglu_radioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musluoglu_radioButton.Location = new System.Drawing.Point(174, 47);
            this.musluoglu_radioButton.Name = "musluoglu_radioButton";
            this.musluoglu_radioButton.Size = new System.Drawing.Size(100, 27);
            this.musluoglu_radioButton.TabIndex = 26;
            this.musluoglu_radioButton.TabStop = true;
            this.musluoglu_radioButton.Text = "Musluoglu";
            this.musluoglu_radioButton.UseVisualStyleBackColor = true;
            // 
            // dilimBorek_radioButton
            // 
            this.dilimBorek_radioButton.AutoSize = true;
            this.dilimBorek_radioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dilimBorek_radioButton.Location = new System.Drawing.Point(54, 47);
            this.dilimBorek_radioButton.Name = "dilimBorek_radioButton";
            this.dilimBorek_radioButton.Size = new System.Drawing.Size(114, 27);
            this.dilimBorek_radioButton.TabIndex = 25;
            this.dilimBorek_radioButton.TabStop = true;
            this.dilimBorek_radioButton.Text = "Dilim Börek";
            this.dilimBorek_radioButton.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(18, 128);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(152, 32);
            this.clear_button.TabIndex = 24;
            this.clear_button.Text = "Datalari Temizle";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exportToExcel_button
            // 
            this.exportToExcel_button.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToExcel_button.Location = new System.Drawing.Point(176, 128);
            this.exportToExcel_button.Name = "exportToExcel_button";
            this.exportToExcel_button.Size = new System.Drawing.Size(129, 32);
            this.exportToExcel_button.TabIndex = 23;
            this.exportToExcel_button.Text = "Excel\'e Aktar";
            this.exportToExcel_button.UseVisualStyleBackColor = true;
            this.exportToExcel_button.Click += new System.EventHandler(this.exportToExcel_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 382);
            this.dataGridView1.TabIndex = 22;
            // 
            // run_button
            // 
            this.run_button.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button.Location = new System.Drawing.Point(54, 75);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(220, 32);
            this.run_button.TabIndex = 21;
            this.run_button.Text = "Verileri Getir";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // Tunam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 411);
            this.Controls.Add(this.main_panel);
            this.MinimumSize = new System.Drawing.Size(835, 450);
            this.Name = "Tunam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tunam-Unlu-Mamuller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tunam_FormClosing);
            this.Load += new System.EventHandler(this.Tunam_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton musluoglu_radioButton;
        private System.Windows.Forms.RadioButton dilimBorek_radioButton;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exportToExcel_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button run_button;
    }
}

