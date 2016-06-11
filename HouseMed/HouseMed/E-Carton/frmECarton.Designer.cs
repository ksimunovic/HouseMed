using System.Drawing;

namespace HouseMed.E_Carton
{
    partial class frmECarton
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
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnChoosePatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.dgvUputnica = new System.Windows.Forms.DataGridView();
            this.dgvRecipe = new System.Windows.Forms.DataGridView();
            this.btnEditUputnica = new System.Windows.Forms.Button();
            this.btnEditRecept = new System.Windows.Forms.Button();
            this.dgvCijepljenje = new System.Windows.Forms.DataGridView();
            this.dgvHostpitalizacija = new System.Windows.Forms.DataGridView();
            this.dgvPostupci = new System.Windows.Forms.DataGridView();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblUputnica = new System.Windows.Forms.Label();
            this.lblCijepljenje = new System.Windows.Forms.Label();
            this.btnEditCijepljenje = new System.Windows.Forms.Button();
            this.lblHospitalizacija = new System.Windows.Forms.Label();
            this.btnEditHospitalizacija = new System.Windows.Forms.Button();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.lblPostupci = new System.Windows.Forms.Label();
            this.btnEditPostupci = new System.Windows.Forms.Button();
            this.lblRaspored = new System.Windows.Forms.Label();
            this.btnEditRaspored = new System.Windows.Forms.Button();
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
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijepljenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostpitalizacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
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
            this.receptiDataGridViewTextBoxColumn});
            this.dgvPatients.DataSource = this.pacijentiBindingSource;
            this.dgvPatients.Location = new System.Drawing.Point(3, 58);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1021, 217);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblPatient.Location = new System.Drawing.Point(5, 6);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(184, 24);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Pregled pacijenata";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Pretraži:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(66, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(128, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnChoosePatient
            // 
            this.btnChoosePatient.Location = new System.Drawing.Point(856, 281);
            this.btnChoosePatient.Name = "btnChoosePatient";
            this.btnChoosePatient.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePatient.TabIndex = 4;
            this.btnChoosePatient.Text = "Odaberi";
            this.btnChoosePatient.UseVisualStyleBackColor = true;
            this.btnChoosePatient.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Location = new System.Drawing.Point(937, 281);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(75, 23);
            this.btnEditPatient.TabIndex = 5;
            this.btnEditPatient.Text = "Uredi";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            // 
            // dgvUputnica
            // 
            this.dgvUputnica.AllowUserToAddRows = false;
            this.dgvUputnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUputnica.Location = new System.Drawing.Point(3, 330);
            this.dgvUputnica.Name = "dgvUputnica";
            this.dgvUputnica.ReadOnly = true;
            this.dgvUputnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUputnica.Size = new System.Drawing.Size(1021, 204);
            this.dgvUputnica.TabIndex = 6;
            // 
            // dgvRecipe
            // 
            this.dgvRecipe.AllowUserToAddRows = false;
            this.dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipe.Location = new System.Drawing.Point(3, 589);
            this.dgvRecipe.Name = "dgvRecipe";
            this.dgvRecipe.ReadOnly = true;
            this.dgvRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipe.Size = new System.Drawing.Size(1021, 204);
            this.dgvRecipe.TabIndex = 7;
            // 
            // btnEditUputnica
            // 
            this.btnEditUputnica.Location = new System.Drawing.Point(937, 540);
            this.btnEditUputnica.Name = "btnEditUputnica";
            this.btnEditUputnica.Size = new System.Drawing.Size(75, 23);
            this.btnEditUputnica.TabIndex = 8;
            this.btnEditUputnica.Text = "Uredi";
            this.btnEditUputnica.UseVisualStyleBackColor = true;
            // 
            // btnEditRecept
            // 
            this.btnEditRecept.Location = new System.Drawing.Point(937, 799);
            this.btnEditRecept.Name = "btnEditRecept";
            this.btnEditRecept.Size = new System.Drawing.Size(75, 23);
            this.btnEditRecept.TabIndex = 9;
            this.btnEditRecept.Text = "Uredi";
            this.btnEditRecept.UseVisualStyleBackColor = true;
            // 
            // dgvCijepljenje
            // 
            this.dgvCijepljenje.AllowUserToAddRows = false;
            this.dgvCijepljenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCijepljenje.Location = new System.Drawing.Point(3, 849);
            this.dgvCijepljenje.Name = "dgvCijepljenje";
            this.dgvCijepljenje.ReadOnly = true;
            this.dgvCijepljenje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCijepljenje.Size = new System.Drawing.Size(1021, 204);
            this.dgvCijepljenje.TabIndex = 10;
            // 
            // dgvHostpitalizacija
            // 
            this.dgvHostpitalizacija.AllowUserToAddRows = false;
            this.dgvHostpitalizacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHostpitalizacija.Location = new System.Drawing.Point(3, 1124);
            this.dgvHostpitalizacija.Name = "dgvHostpitalizacija";
            this.dgvHostpitalizacija.ReadOnly = true;
            this.dgvHostpitalizacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHostpitalizacija.Size = new System.Drawing.Size(1021, 204);
            this.dgvHostpitalizacija.TabIndex = 11;
            // 
            // dgvPostupci
            // 
            this.dgvPostupci.AllowUserToAddRows = false;
            this.dgvPostupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostupci.Location = new System.Drawing.Point(3, 1404);
            this.dgvPostupci.Name = "dgvPostupci";
            this.dgvPostupci.ReadOnly = true;
            this.dgvPostupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostupci.Size = new System.Drawing.Size(1021, 240);
            this.dgvPostupci.TabIndex = 12;
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblRecipe.Location = new System.Drawing.Point(5, 558);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(81, 24);
            this.lblRecipe.TabIndex = 13;
            this.lblRecipe.Text = "Recepti";
            // 
            // lblUputnica
            // 
            this.lblUputnica.AutoSize = true;
            this.lblUputnica.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblUputnica.Location = new System.Drawing.Point(9, 300);
            this.lblUputnica.Name = "lblUputnica";
            this.lblUputnica.Size = new System.Drawing.Size(94, 24);
            this.lblUputnica.TabIndex = 14;
            this.lblUputnica.Text = "Uputnice";
            // 
            // lblCijepljenje
            // 
            this.lblCijepljenje.AutoSize = true;
            this.lblCijepljenje.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblCijepljenje.Location = new System.Drawing.Point(5, 820);
            this.lblCijepljenje.Name = "lblCijepljenje";
            this.lblCijepljenje.Size = new System.Drawing.Size(106, 24);
            this.lblCijepljenje.TabIndex = 15;
            this.lblCijepljenje.Text = "Cijepljenje";
            // 
            // btnEditCijepljenje
            // 
            this.btnEditCijepljenje.Location = new System.Drawing.Point(937, 1059);
            this.btnEditCijepljenje.Name = "btnEditCijepljenje";
            this.btnEditCijepljenje.Size = new System.Drawing.Size(75, 23);
            this.btnEditCijepljenje.TabIndex = 16;
            this.btnEditCijepljenje.Text = "Uredi";
            this.btnEditCijepljenje.UseVisualStyleBackColor = true;
            // 
            // lblHospitalizacija
            // 
            this.lblHospitalizacija.AutoSize = true;
            this.lblHospitalizacija.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblHospitalizacija.Location = new System.Drawing.Point(9, 1090);
            this.lblHospitalizacija.Name = "lblHospitalizacija";
            this.lblHospitalizacija.Size = new System.Drawing.Size(145, 24);
            this.lblHospitalizacija.TabIndex = 17;
            this.lblHospitalizacija.Text = "Hospitalizacija";
            // 
            // btnEditHospitalizacija
            // 
            this.btnEditHospitalizacija.Location = new System.Drawing.Point(937, 1334);
            this.btnEditHospitalizacija.Name = "btnEditHospitalizacija";
            this.btnEditHospitalizacija.Size = new System.Drawing.Size(75, 23);
            this.btnEditHospitalizacija.TabIndex = 18;
            this.btnEditHospitalizacija.Text = "Uredi";
            this.btnEditHospitalizacija.UseVisualStyleBackColor = true;
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(3, 1730);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(1021, 229);
            this.dgvRaspored.TabIndex = 19;
            // 
            // lblPostupci
            // 
            this.lblPostupci.AutoSize = true;
            this.lblPostupci.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblPostupci.Location = new System.Drawing.Point(9, 1372);
            this.lblPostupci.Name = "lblPostupci";
            this.lblPostupci.Size = new System.Drawing.Size(93, 24);
            this.lblPostupci.TabIndex = 20;
            this.lblPostupci.Text = "Postupci";
            // 
            // btnEditPostupci
            // 
            this.btnEditPostupci.Location = new System.Drawing.Point(937, 1651);
            this.btnEditPostupci.Name = "btnEditPostupci";
            this.btnEditPostupci.Size = new System.Drawing.Size(75, 23);
            this.btnEditPostupci.TabIndex = 21;
            this.btnEditPostupci.Text = "Uredi";
            this.btnEditPostupci.UseVisualStyleBackColor = true;
            // 
            // lblRaspored
            // 
            this.lblRaspored.AutoSize = true;
            this.lblRaspored.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblRaspored.Location = new System.Drawing.Point(1, 1703);
            this.lblRaspored.Name = "lblRaspored";
            this.lblRaspored.Size = new System.Drawing.Size(101, 24);
            this.lblRaspored.TabIndex = 22;
            this.lblRaspored.Text = "Raspored";
            // 
            // btnEditRaspored
            // 
            this.btnEditRaspored.Location = new System.Drawing.Point(937, 1965);
            this.btnEditRaspored.Name = "btnEditRaspored";
            this.btnEditRaspored.Size = new System.Drawing.Size(75, 23);
            this.btnEditRaspored.TabIndex = 23;
            this.btnEditRaspored.Text = "Uredi";
            this.btnEditRaspored.UseVisualStyleBackColor = true;
            // 
            // pacijentiIDDataGridViewTextBoxColumn
            // 
            this.pacijentiIDDataGridViewTextBoxColumn.DataPropertyName = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.HeaderText = "Br. Pacijenta";
            this.pacijentiIDDataGridViewTextBoxColumn.Name = "pacijentiIDDataGridViewTextBoxColumn";
            this.pacijentiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mBODataGridViewTextBoxColumn
            // 
            this.mBODataGridViewTextBoxColumn.DataPropertyName = "MBO";
            this.mBODataGridViewTextBoxColumn.HeaderText = "MBO";
            this.mBODataGridViewTextBoxColumn.Name = "mBODataGridViewTextBoxColumn";
            this.mBODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            this.mjestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Država";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobitelDataGridViewTextBoxColumn
            // 
            this.mobitelDataGridViewTextBoxColumn.DataPropertyName = "mobitel";
            this.mobitelDataGridViewTextBoxColumn.HeaderText = "Mobitel";
            this.mobitelDataGridViewTextBoxColumn.Name = "mobitelDataGridViewTextBoxColumn";
            this.mobitelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifrazdrvustanoveIDDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.HeaderText = "Br. Ustanove";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveIDDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijepljenjeDataGridViewTextBoxColumn
            // 
            this.cijepljenjeDataGridViewTextBoxColumn.DataPropertyName = "cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.HeaderText = "Cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.Name = "cijepljenjeDataGridViewTextBoxColumn";
            this.cijepljenjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijepljenjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // evidencijahospitalizacijeDataGridViewTextBoxColumn
            // 
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.DataPropertyName = "evidencija_hospitalizacije";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.HeaderText = "Hospitalizacija";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.Name = "evidencijahospitalizacijeDataGridViewTextBoxColumn";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sifrazdrvustanoveDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Visible = false;
            // 
            // postupciDataGridViewTextBoxColumn
            // 
            this.postupciDataGridViewTextBoxColumn.DataPropertyName = "postupci";
            this.postupciDataGridViewTextBoxColumn.HeaderText = "postupci";
            this.postupciDataGridViewTextBoxColumn.Name = "postupciDataGridViewTextBoxColumn";
            this.postupciDataGridViewTextBoxColumn.ReadOnly = true;
            this.postupciDataGridViewTextBoxColumn.Visible = false;
            // 
            // rasporedDataGridViewTextBoxColumn
            // 
            this.rasporedDataGridViewTextBoxColumn.DataPropertyName = "raspored";
            this.rasporedDataGridViewTextBoxColumn.HeaderText = "raspored";
            this.rasporedDataGridViewTextBoxColumn.Name = "rasporedDataGridViewTextBoxColumn";
            this.rasporedDataGridViewTextBoxColumn.ReadOnly = true;
            this.rasporedDataGridViewTextBoxColumn.Visible = false;
            // 
            // uputnicaDataGridViewTextBoxColumn
            // 
            this.uputnicaDataGridViewTextBoxColumn.DataPropertyName = "uputnica";
            this.uputnicaDataGridViewTextBoxColumn.HeaderText = "uputnica";
            this.uputnicaDataGridViewTextBoxColumn.Name = "uputnicaDataGridViewTextBoxColumn";
            this.uputnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.uputnicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptiDataGridViewTextBoxColumn
            // 
            this.receptiDataGridViewTextBoxColumn.DataPropertyName = "recepti";
            this.receptiDataGridViewTextBoxColumn.HeaderText = "recepti";
            this.receptiDataGridViewTextBoxColumn.Name = "receptiDataGridViewTextBoxColumn";
            this.receptiDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptiDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(HouseMed.DAL.pacijenti);
            // 
            // frmECarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1026, 991);
            this.Controls.Add(this.btnEditRaspored);
            this.Controls.Add(this.lblRaspored);
            this.Controls.Add(this.btnEditPostupci);
            this.Controls.Add(this.lblPostupci);
            this.Controls.Add(this.dgvRaspored);
            this.Controls.Add(this.btnEditHospitalizacija);
            this.Controls.Add(this.lblHospitalizacija);
            this.Controls.Add(this.btnEditCijepljenje);
            this.Controls.Add(this.lblCijepljenje);
            this.Controls.Add(this.lblUputnica);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.dgvPostupci);
            this.Controls.Add(this.dgvHostpitalizacija);
            this.Controls.Add(this.dgvCijepljenje);
            this.Controls.Add(this.btnEditRecept);
            this.Controls.Add(this.btnEditUputnica);
            this.Controls.Add(this.dgvRecipe);
            this.Controls.Add(this.dgvUputnica);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnChoosePatient);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dgvPatients);
            this.Name = "frmECarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Karton";
            this.Load += new System.EventHandler(this.frmECarton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijepljenje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostpitalizacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnChoosePatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.DataGridView dgvUputnica;
        private System.Windows.Forms.DataGridView dgvRecipe;
        private System.Windows.Forms.Button btnEditUputnica;
        private System.Windows.Forms.Button btnEditRecept;
        private System.Windows.Forms.DataGridView dgvCijepljenje;
        private System.Windows.Forms.DataGridView dgvHostpitalizacija;
        private System.Windows.Forms.DataGridView dgvPostupci;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblUputnica;
        private System.Windows.Forms.Label lblCijepljenje;
        private System.Windows.Forms.Button btnEditCijepljenje;
        private System.Windows.Forms.Label lblHospitalizacija;
        private System.Windows.Forms.Button btnEditHospitalizacija;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label lblPostupci;
        private System.Windows.Forms.Button btnEditPostupci;
        private System.Windows.Forms.Label lblRaspored;
        private System.Windows.Forms.Button btnEditRaspored;
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
    }
}