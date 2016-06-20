namespace HouseMed.HospitalDays
{
    partial class frmHospitalDays
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
            this.dgvHospitalDays = new System.Windows.Forms.DataGridView();
            this.btnNoviNalog = new System.Windows.Forms.Button();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.djelatniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrisiBoravak = new System.Windows.Forms.Button();
            this.btnUrediBoravak = new System.Windows.Forms.Button();
            this.labelPretrazi = new System.Windows.Forms.Label();
            this.tbPretrazi = new System.Windows.Forms.TextBox();
            this.labelPacijentText = new System.Windows.Forms.Label();
            this.labelPacijentIspis = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHospitalDays
            // 
            this.dgvHospitalDays.AllowUserToAddRows = false;
            this.dgvHospitalDays.AllowUserToDeleteRows = false;
            this.dgvHospitalDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalDays.Location = new System.Drawing.Point(22, 69);
            this.dgvHospitalDays.Name = "dgvHospitalDays";
            this.dgvHospitalDays.ReadOnly = true;
            this.dgvHospitalDays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitalDays.Size = new System.Drawing.Size(646, 150);
            this.dgvHospitalDays.TabIndex = 0;
            // 
            // btnNoviNalog
            // 
            this.btnNoviNalog.Location = new System.Drawing.Point(593, 22);
            this.btnNoviNalog.Name = "btnNoviNalog";
            this.btnNoviNalog.Size = new System.Drawing.Size(75, 23);
            this.btnNoviNalog.TabIndex = 4;
            this.btnNoviNalog.Text = "Novi nalog";
            this.btnNoviNalog.UseVisualStyleBackColor = true;
            this.btnNoviNalog.Click += new System.EventHandler(this.btnNoviNalog_Click);
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(HouseMed.DAL.pacijenti);
            // 
            // djelatniciBindingSource
            // 
            this.djelatniciBindingSource.DataSource = typeof(HouseMed.DAL.djelatnici);
            // 
            // btnBrisiBoravak
            // 
            this.btnBrisiBoravak.Location = new System.Drawing.Point(593, 227);
            this.btnBrisiBoravak.Name = "btnBrisiBoravak";
            this.btnBrisiBoravak.Size = new System.Drawing.Size(75, 23);
            this.btnBrisiBoravak.TabIndex = 5;
            this.btnBrisiBoravak.Text = "Brisi";
            this.btnBrisiBoravak.UseVisualStyleBackColor = true;
            this.btnBrisiBoravak.Click += new System.EventHandler(this.btnBrisiBoravak_Click);
            // 
            // btnUrediBoravak
            // 
            this.btnUrediBoravak.Location = new System.Drawing.Point(512, 227);
            this.btnUrediBoravak.Name = "btnUrediBoravak";
            this.btnUrediBoravak.Size = new System.Drawing.Size(75, 23);
            this.btnUrediBoravak.TabIndex = 6;
            this.btnUrediBoravak.Text = "Uredi";
            this.btnUrediBoravak.UseVisualStyleBackColor = true;
            this.btnUrediBoravak.Click += new System.EventHandler(this.btnUrediBoravak_Click);
            // 
            // labelPretrazi
            // 
            this.labelPretrazi.AutoSize = true;
            this.labelPretrazi.Location = new System.Drawing.Point(412, 27);
            this.labelPretrazi.Name = "labelPretrazi";
            this.labelPretrazi.Size = new System.Drawing.Size(48, 13);
            this.labelPretrazi.TabIndex = 7;
            this.labelPretrazi.Text = "Pretraži: ";
            // 
            // tbPretrazi
            // 
            this.tbPretrazi.Location = new System.Drawing.Point(466, 24);
            this.tbPretrazi.Name = "tbPretrazi";
            this.tbPretrazi.Size = new System.Drawing.Size(100, 20);
            this.tbPretrazi.TabIndex = 8;
            this.tbPretrazi.TextChanged += new System.EventHandler(this.tbPretrazi_TextChanged);
            // 
            // labelPacijentText
            // 
            this.labelPacijentText.AutoSize = true;
            this.labelPacijentText.Location = new System.Drawing.Point(19, 27);
            this.labelPacijentText.Name = "labelPacijentText";
            this.labelPacijentText.Size = new System.Drawing.Size(104, 13);
            this.labelPacijentText.TabIndex = 9;
            this.labelPacijentText.Text = "Pacijent u postupku:";
            // 
            // labelPacijentIspis
            // 
            this.labelPacijentIspis.AutoSize = true;
            this.labelPacijentIspis.Location = new System.Drawing.Point(129, 27);
            this.labelPacijentIspis.Name = "labelPacijentIspis";
            this.labelPacijentIspis.Size = new System.Drawing.Size(35, 13);
            this.labelPacijentIspis.TabIndex = 10;
            this.labelPacijentIspis.Text = "label1";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(239, 22);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 11;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // frmHospitalDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 262);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.labelPacijentIspis);
            this.Controls.Add(this.labelPacijentText);
            this.Controls.Add(this.tbPretrazi);
            this.Controls.Add(this.labelPretrazi);
            this.Controls.Add(this.btnUrediBoravak);
            this.Controls.Add(this.btnBrisiBoravak);
            this.Controls.Add(this.btnNoviNalog);
            this.Controls.Add(this.dgvHospitalDays);
            this.Name = "frmHospitalDays";
            this.Text = "frmHospitalDays";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHospitalDays;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.BindingSource djelatniciBindingSource;
        private System.Windows.Forms.Button btnNoviNalog;
        private System.Windows.Forms.Button btnBrisiBoravak;
        private System.Windows.Forms.Button btnUrediBoravak;
        private System.Windows.Forms.Label labelPretrazi;
        private System.Windows.Forms.TextBox tbPretrazi;
        private System.Windows.Forms.Label labelPacijentText;
        private System.Windows.Forms.Label labelPacijentIspis;
        private System.Windows.Forms.Button btnOdaberi;
    }
}