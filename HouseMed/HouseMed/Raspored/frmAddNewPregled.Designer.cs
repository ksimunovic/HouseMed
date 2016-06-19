namespace HouseMed.Raspored
{
    partial class frmAddNewPregled
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
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPacijent = new System.Windows.Forms.ComboBox();
            this.textBoxVrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUstanova = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(80, 71);
            this.dateTimePickerDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDatum.TabIndex = 0;
            // 
            // comboBoxPacijent
            // 
            this.comboBoxPacijent.FormattingEnabled = true;
            this.comboBoxPacijent.Location = new System.Drawing.Point(80, 26);
            this.comboBoxPacijent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPacijent.Name = "comboBoxPacijent";
            this.comboBoxPacijent.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPacijent.TabIndex = 1;
            this.comboBoxPacijent.SelectedValueChanged += new System.EventHandler(this.comboBoxPacijent_SelectedValueChanged);
            // 
            // textBoxVrijeme
            // 
            this.textBoxVrijeme.Location = new System.Drawing.Point(80, 114);
            this.textBoxVrijeme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVrijeme.Name = "textBoxVrijeme";
            this.textBoxVrijeme.Size = new System.Drawing.Size(76, 20);
            this.textBoxVrijeme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pacijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrijeme";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(80, 155);
            this.textBoxOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(76, 20);
            this.textBoxOpis.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ustanova";
            // 
            // comboBoxUstanova
            // 
            this.comboBoxUstanova.FormattingEnabled = true;
            this.comboBoxUstanova.Location = new System.Drawing.Point(80, 202);
            this.comboBoxUstanova.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxUstanova.Name = "comboBoxUstanova";
            this.comboBoxUstanova.Size = new System.Drawing.Size(92, 21);
            this.comboBoxUstanova.TabIndex = 9;
            this.comboBoxUstanova.SelectedValueChanged += new System.EventHandler(this.comboBoxUstanova_SelectedValueChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(176, 240);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(81, 34);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj Pregled";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmAddNewPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 291);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.comboBoxUstanova);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVrijeme);
            this.Controls.Add(this.comboBoxPacijent);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddNewPregled";
            this.Text = "Novi Pregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.ComboBox comboBoxPacijent;
        private System.Windows.Forms.TextBox textBoxVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUstanova;
        private System.Windows.Forms.Button btnDodaj;
    }
}