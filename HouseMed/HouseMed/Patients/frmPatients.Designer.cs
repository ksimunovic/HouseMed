namespace HouseMed.Patients
{
    partial class frmPatients
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
            this.components = new System.ComponentModel.Container();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.btnNoviPacijent = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.pacijentiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijepljenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazdrvustanoveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postupciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasporedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uputnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoGenerateColumns = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacijentiIDDataGridViewTextBoxColumn,
            this.mBODataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mobitelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn,
            this.cijepljenjeDataGridViewTextBoxColumn,
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn,
            this.sifrazdrvustanoveDataGridViewTextBoxColumn,
            this.postupciDataGridViewTextBoxColumn,
            this.rasporedDataGridViewTextBoxColumn,
            this.uputnicaDataGridViewTextBoxColumn,
            this.receptiDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn});
            this.dgvPatients.DataSource = this.pacijentiBindingSource;
            this.dgvPatients.Location = new System.Drawing.Point(3, 74);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1009, 216);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // btnNoviPacijent
            // 
            this.btnNoviPacijent.Location = new System.Drawing.Point(12, 12);
            this.btnNoviPacijent.Name = "btnNoviPacijent";
            this.btnNoviPacijent.Size = new System.Drawing.Size(109, 36);
            this.btnNoviPacijent.TabIndex = 1;
            this.btnNoviPacijent.Text = "Novi pacijent";
            this.btnNoviPacijent.UseVisualStyleBackColor = true;
            this.btnNoviPacijent.Click += new System.EventHandler(this.btnNoviPacijent_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(789, 313);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // pacijentiIDDataGridViewTextBoxColumn
            // 
            this.pacijentiIDDataGridViewTextBoxColumn.DataPropertyName = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.HeaderText = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.Name = "pacijentiIDDataGridViewTextBoxColumn";
            // 
            // mBODataGridViewTextBoxColumn
            // 
            this.mBODataGridViewTextBoxColumn.DataPropertyName = "MBO";
            this.mBODataGridViewTextBoxColumn.HeaderText = "MBO";
            this.mBODataGridViewTextBoxColumn.Name = "mBODataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // mobitelDataGridViewTextBoxColumn
            // 
            this.mobitelDataGridViewTextBoxColumn.DataPropertyName = "mobitel";
            this.mobitelDataGridViewTextBoxColumn.HeaderText = "mobitel";
            this.mobitelDataGridViewTextBoxColumn.Name = "mobitelDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sifrazdrvustanoveIDDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveIDDataGridViewTextBoxColumn";
            // 
            // cijepljenjeDataGridViewTextBoxColumn
            // 
            this.cijepljenjeDataGridViewTextBoxColumn.DataPropertyName = "cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.HeaderText = "cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.Name = "cijepljenjeDataGridViewTextBoxColumn";
            this.cijepljenjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // evidencijahospitalizacijeDataGridViewTextBoxColumn
            // 
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.DataPropertyName = "evidencija_hospitalizacije";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.HeaderText = "evidencija_hospitalizacije";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.Name = "evidencijahospitalizacijeDataGridViewTextBoxColumn";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sifrazdrvustanoveDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Visible = false;
            // 
            // postupciDataGridViewTextBoxColumn
            // 
            this.postupciDataGridViewTextBoxColumn.DataPropertyName = "postupci";
            this.postupciDataGridViewTextBoxColumn.HeaderText = "postupci";
            this.postupciDataGridViewTextBoxColumn.Name = "postupciDataGridViewTextBoxColumn";
            this.postupciDataGridViewTextBoxColumn.Visible = false;
            // 
            // rasporedDataGridViewTextBoxColumn
            // 
            this.rasporedDataGridViewTextBoxColumn.DataPropertyName = "raspored";
            this.rasporedDataGridViewTextBoxColumn.HeaderText = "raspored";
            this.rasporedDataGridViewTextBoxColumn.Name = "rasporedDataGridViewTextBoxColumn";
            this.rasporedDataGridViewTextBoxColumn.Visible = false;
            // 
            // uputnicaDataGridViewTextBoxColumn
            // 
            this.uputnicaDataGridViewTextBoxColumn.DataPropertyName = "uputnica";
            this.uputnicaDataGridViewTextBoxColumn.HeaderText = "uputnica";
            this.uputnicaDataGridViewTextBoxColumn.Name = "uputnicaDataGridViewTextBoxColumn";
            this.uputnicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptiDataGridViewTextBoxColumn
            // 
            this.receptiDataGridViewTextBoxColumn.DataPropertyName = "recepti";
            this.receptiDataGridViewTextBoxColumn.HeaderText = "recepti";
            this.receptiDataGridViewTextBoxColumn.Name = "receptiDataGridViewTextBoxColumn";
            this.receptiDataGridViewTextBoxColumn.Visible = false;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(HouseMed.DAL.pacijenti);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(898, 312);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 377);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNoviPacijent);
            this.Controls.Add(this.dgvPatients);
            this.Name = "frmPatients";
            this.Text = "frmPatients";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mBODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazdrvustanoveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijepljenjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidencijahospitalizacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazdrvustanoveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postupciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasporedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uputnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNoviPacijent;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
    }
}