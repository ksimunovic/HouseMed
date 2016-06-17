namespace HouseMed.HospitalDays
{
    partial class frmAddNewHospitalDay
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
            this.labelBoravioOd = new System.Windows.Forms.Label();
            this.dtpBoravioOd = new System.Windows.Forms.DateTimePicker();
            this.labelBoravioDo = new System.Windows.Forms.Label();
            this.dtpBoravioDo = new System.Windows.Forms.DateTimePicker();
            this.labelBolnica = new System.Windows.Forms.Label();
            this.tbRazlogBoravka = new System.Windows.Forms.TextBox();
            this.labelRazlogBoravka = new System.Windows.Forms.Label();
            this.labelPacijentBoravak = new System.Windows.Forms.Label();
            this.cbPacijentBoravak = new System.Windows.Forms.ComboBox();
            this.tbBolnica = new System.Windows.Forms.TextBox();
            this.btnDodajBoravak = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBoravioOd
            // 
            this.labelBoravioOd.AutoSize = true;
            this.labelBoravioOd.Location = new System.Drawing.Point(30, 47);
            this.labelBoravioOd.Name = "labelBoravioOd";
            this.labelBoravioOd.Size = new System.Drawing.Size(61, 13);
            this.labelBoravioOd.TabIndex = 2;
            this.labelBoravioOd.Text = "Boravio od:";
            // 
            // dtpBoravioOd
            // 
            this.dtpBoravioOd.Location = new System.Drawing.Point(108, 44);
            this.dtpBoravioOd.Name = "dtpBoravioOd";
            this.dtpBoravioOd.Size = new System.Drawing.Size(166, 20);
            this.dtpBoravioOd.TabIndex = 3;
            // 
            // labelBoravioDo
            // 
            this.labelBoravioDo.AutoSize = true;
            this.labelBoravioDo.Location = new System.Drawing.Point(30, 78);
            this.labelBoravioDo.Name = "labelBoravioDo";
            this.labelBoravioDo.Size = new System.Drawing.Size(64, 13);
            this.labelBoravioDo.TabIndex = 4;
            this.labelBoravioDo.Text = "Boravio do: ";
            // 
            // dtpBoravioDo
            // 
            this.dtpBoravioDo.Location = new System.Drawing.Point(108, 76);
            this.dtpBoravioDo.Name = "dtpBoravioDo";
            this.dtpBoravioDo.Size = new System.Drawing.Size(166, 20);
            this.dtpBoravioDo.TabIndex = 5;
            // 
            // labelBolnica
            // 
            this.labelBolnica.AutoSize = true;
            this.labelBolnica.Location = new System.Drawing.Point(43, 114);
            this.labelBolnica.Name = "labelBolnica";
            this.labelBolnica.Size = new System.Drawing.Size(48, 13);
            this.labelBolnica.TabIndex = 6;
            this.labelBolnica.Text = "Bolnica: ";
            // 
            // tbRazlogBoravka
            // 
            this.tbRazlogBoravka.Location = new System.Drawing.Point(108, 147);
            this.tbRazlogBoravka.Multiline = true;
            this.tbRazlogBoravka.Name = "tbRazlogBoravka";
            this.tbRazlogBoravka.Size = new System.Drawing.Size(166, 106);
            this.tbRazlogBoravka.TabIndex = 8;
            // 
            // labelRazlogBoravka
            // 
            this.labelRazlogBoravka.AutoSize = true;
            this.labelRazlogBoravka.Location = new System.Drawing.Point(9, 150);
            this.labelRazlogBoravka.Name = "labelRazlogBoravka";
            this.labelRazlogBoravka.Size = new System.Drawing.Size(85, 13);
            this.labelRazlogBoravka.TabIndex = 9;
            this.labelRazlogBoravka.Text = "Razlog boravka:";
            // 
            // labelPacijentBoravak
            // 
            this.labelPacijentBoravak.AutoSize = true;
            this.labelPacijentBoravak.Location = new System.Drawing.Point(43, 271);
            this.labelPacijentBoravak.Name = "labelPacijentBoravak";
            this.labelPacijentBoravak.Size = new System.Drawing.Size(48, 13);
            this.labelPacijentBoravak.TabIndex = 10;
            this.labelPacijentBoravak.Text = "Pacijent:";
            // 
            // cbPacijentBoravak
            // 
            this.cbPacijentBoravak.FormattingEnabled = true;
            this.cbPacijentBoravak.Location = new System.Drawing.Point(108, 268);
            this.cbPacijentBoravak.Name = "cbPacijentBoravak";
            this.cbPacijentBoravak.Size = new System.Drawing.Size(166, 21);
            this.cbPacijentBoravak.TabIndex = 11;
            // 
            // tbBolnica
            // 
            this.tbBolnica.Location = new System.Drawing.Point(108, 111);
            this.tbBolnica.Name = "tbBolnica";
            this.tbBolnica.Size = new System.Drawing.Size(166, 20);
            this.tbBolnica.TabIndex = 12;
            // 
            // btnDodajBoravak
            // 
            this.btnDodajBoravak.Location = new System.Drawing.Point(33, 297);
            this.btnDodajBoravak.Name = "btnDodajBoravak";
            this.btnDodajBoravak.Size = new System.Drawing.Size(241, 23);
            this.btnDodajBoravak.TabIndex = 13;
            this.btnDodajBoravak.Text = "Dodaj";
            this.btnDodajBoravak.UseVisualStyleBackColor = true;
            this.btnDodajBoravak.Click += new System.EventHandler(this.btnDodajBoravak_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(55, 13);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(35, 13);
            this.labelTest.TabIndex = 14;
            this.labelTest.Text = "label1";
            // 
            // frmAddNewHospitalDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 337);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.btnDodajBoravak);
            this.Controls.Add(this.tbBolnica);
            this.Controls.Add(this.cbPacijentBoravak);
            this.Controls.Add(this.labelPacijentBoravak);
            this.Controls.Add(this.labelRazlogBoravka);
            this.Controls.Add(this.tbRazlogBoravka);
            this.Controls.Add(this.labelBolnica);
            this.Controls.Add(this.dtpBoravioDo);
            this.Controls.Add(this.labelBoravioDo);
            this.Controls.Add(this.dtpBoravioOd);
            this.Controls.Add(this.labelBoravioOd);
            this.Name = "frmAddNewHospitalDay";
            this.Text = "frmAddNewHospitalDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBoravioOd;
        private System.Windows.Forms.DateTimePicker dtpBoravioOd;
        private System.Windows.Forms.Label labelBoravioDo;
        private System.Windows.Forms.DateTimePicker dtpBoravioDo;
        private System.Windows.Forms.Label labelBolnica;
        private System.Windows.Forms.TextBox tbRazlogBoravka;
        private System.Windows.Forms.Label labelRazlogBoravka;
        private System.Windows.Forms.Label labelPacijentBoravak;
        private System.Windows.Forms.ComboBox cbPacijentBoravak;
        private System.Windows.Forms.TextBox tbBolnica;
        private System.Windows.Forms.Button btnDodajBoravak;
        private System.Windows.Forms.Label labelTest;
    }
}