namespace HouseMed.Medication
{
    partial class frmAddNewMedication
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
            this.gbInterno = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblUstanova = new System.Windows.Forms.Label();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblDatumKontrole = new System.Windows.Forms.Label();
            this.dtpDatumKontrole = new System.Windows.Forms.DateTimePicker();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblRokTrajanja = new System.Windows.Forms.Label();
            this.dtpRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.comboUstanova = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbInterno.SuspendLayout();
            this.gbPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInterno
            // 
            this.gbInterno.Controls.Add(this.comboUstanova);
            this.gbInterno.Controls.Add(this.lblUstanova);
            this.gbInterno.Controls.Add(this.txtId);
            this.gbInterno.Controls.Add(this.lblId);
            this.gbInterno.Location = new System.Drawing.Point(18, 13);
            this.gbInterno.Name = "gbInterno";
            this.gbInterno.Size = new System.Drawing.Size(228, 85);
            this.gbInterno.TabIndex = 0;
            this.gbInterno.TabStop = false;
            this.gbInterno.Text = "Interno";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(39, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblUstanova
            // 
            this.lblUstanova.AutoSize = true;
            this.lblUstanova.Location = new System.Drawing.Point(7, 49);
            this.lblUstanova.Name = "lblUstanova";
            this.lblUstanova.Size = new System.Drawing.Size(56, 13);
            this.lblUstanova.TabIndex = 2;
            this.lblUstanova.Text = "Ustanova:";
            // 
            // gbPodaci
            // 
            this.gbPodaci.Controls.Add(this.txtCijena);
            this.gbPodaci.Controls.Add(this.lblCijena);
            this.gbPodaci.Controls.Add(this.dtpRokTrajanja);
            this.gbPodaci.Controls.Add(this.lblRokTrajanja);
            this.gbPodaci.Controls.Add(this.txtKolicina);
            this.gbPodaci.Controls.Add(this.lblKolicina);
            this.gbPodaci.Controls.Add(this.dtpDatumKontrole);
            this.gbPodaci.Controls.Add(this.lblDatumKontrole);
            this.gbPodaci.Controls.Add(this.txtNaziv);
            this.gbPodaci.Controls.Add(this.lblNaziv);
            this.gbPodaci.Location = new System.Drawing.Point(18, 118);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(228, 164);
            this.gbPodaci.TabIndex = 1;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Podaci o lijeku";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(23, 26);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(70, 23);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(135, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblDatumKontrole
            // 
            this.lblDatumKontrole.AutoSize = true;
            this.lblDatumKontrole.Location = new System.Drawing.Point(13, 55);
            this.lblDatumKontrole.Name = "lblDatumKontrole";
            this.lblDatumKontrole.Size = new System.Drawing.Size(49, 13);
            this.lblDatumKontrole.TabIndex = 2;
            this.lblDatumKontrole.Text = "Kontrola:";
            // 
            // dtpDatumKontrole
            // 
            this.dtpDatumKontrole.Location = new System.Drawing.Point(70, 49);
            this.dtpDatumKontrole.Name = "dtpDatumKontrole";
            this.dtpDatumKontrole.Size = new System.Drawing.Size(135, 20);
            this.dtpDatumKontrole.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(14, 104);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(50, 13);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina: ";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(70, 101);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(135, 20);
            this.txtKolicina.TabIndex = 5;
            // 
            // lblRokTrajanja
            // 
            this.lblRokTrajanja.AutoSize = true;
            this.lblRokTrajanja.Location = new System.Drawing.Point(19, 81);
            this.lblRokTrajanja.Name = "lblRokTrajanja";
            this.lblRokTrajanja.Size = new System.Drawing.Size(44, 13);
            this.lblRokTrajanja.TabIndex = 6;
            this.lblRokTrajanja.Text = "Rok trj.:";
            // 
            // dtpRokTrajanja
            // 
            this.dtpRokTrajanja.Location = new System.Drawing.Point(70, 75);
            this.dtpRokTrajanja.Name = "dtpRokTrajanja";
            this.dtpRokTrajanja.Size = new System.Drawing.Size(135, 20);
            this.dtpRokTrajanja.TabIndex = 7;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(23, 130);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 8;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(70, 127);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(135, 20);
            this.txtCijena.TabIndex = 9;
            // 
            // comboUstanova
            // 
            this.comboUstanova.FormattingEnabled = true;
            this.comboUstanova.Location = new System.Drawing.Point(70, 46);
            this.comboUstanova.Name = "comboUstanova";
            this.comboUstanova.Size = new System.Drawing.Size(135, 21);
            this.comboUstanova.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(99, 288);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "U redu";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmAddNewMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 319);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbPodaci);
            this.Controls.Add(this.gbInterno);
            this.Name = "frmAddNewMedication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novi lijek";
            this.gbInterno.ResumeLayout(false);
            this.gbInterno.PerformLayout();
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInterno;
        private System.Windows.Forms.Label lblUstanova;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox comboUstanova;
        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.DateTimePicker dtpRokTrajanja;
        private System.Windows.Forms.Label lblRokTrajanja;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.DateTimePicker dtpDatumKontrole;
        private System.Windows.Forms.Label lblDatumKontrole;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
    }
}