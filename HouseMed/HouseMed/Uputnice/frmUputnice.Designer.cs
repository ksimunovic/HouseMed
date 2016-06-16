namespace HouseMed.Uputnice
{
    partial class frmUputnice
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
            this.dgvUputnice = new System.Windows.Forms.DataGridView();
            this.uputnicaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upucujeseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra_zdrv_ustanoveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijagnozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traziseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uputnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovaUputnica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uputnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUputnice
            // 
            this.dgvUputnice.AutoGenerateColumns = false;
            this.dgvUputnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUputnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uputnicaIDDataGridViewTextBoxColumn,
            this.pacijentIDDataGridViewTextBoxColumn,
            this.upucujeseDataGridViewTextBoxColumn,
            this.djelatniciID,
            this.sifra_zdrv_ustanoveID,
            this.dijagnozaDataGridViewTextBoxColumn,
            this.traziseDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dgvUputnice.DataSource = this.uputnicaBindingSource;
            this.dgvUputnice.Location = new System.Drawing.Point(-3, 101);
            this.dgvUputnice.Name = "dgvUputnice";
            this.dgvUputnice.RowTemplate.Height = 24;
            this.dgvUputnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUputnice.Size = new System.Drawing.Size(941, 351);
            this.dgvUputnice.TabIndex = 0;
            // 
            // uputnicaIDDataGridViewTextBoxColumn
            // 
            this.uputnicaIDDataGridViewTextBoxColumn.DataPropertyName = "uputnicaID";
            this.uputnicaIDDataGridViewTextBoxColumn.HeaderText = "uputnicaID";
            this.uputnicaIDDataGridViewTextBoxColumn.Name = "uputnicaIDDataGridViewTextBoxColumn";
            this.uputnicaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pacijentIDDataGridViewTextBoxColumn
            // 
            this.pacijentIDDataGridViewTextBoxColumn.DataPropertyName = "pacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.HeaderText = "Pacijent";
            this.pacijentIDDataGridViewTextBoxColumn.Name = "pacijentIDDataGridViewTextBoxColumn";
            this.pacijentIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // upucujeseDataGridViewTextBoxColumn
            // 
            this.upucujeseDataGridViewTextBoxColumn.DataPropertyName = "upucuje_se";
            this.upucujeseDataGridViewTextBoxColumn.HeaderText = "upucuje_se";
            this.upucujeseDataGridViewTextBoxColumn.Name = "upucujeseDataGridViewTextBoxColumn";
            // 
            // djelatniciID
            // 
            this.djelatniciID.DataPropertyName = "djelatniciID";
            this.djelatniciID.HeaderText = "djelatniciID";
            this.djelatniciID.Name = "djelatniciID";
            // 
            // sifra_zdrv_ustanoveID
            // 
            this.sifra_zdrv_ustanoveID.DataPropertyName = "sifra_zdrv_ustanoveID";
            this.sifra_zdrv_ustanoveID.HeaderText = "sifra_zdrv_ustanoveID";
            this.sifra_zdrv_ustanoveID.Name = "sifra_zdrv_ustanoveID";
            // 
            // dijagnozaDataGridViewTextBoxColumn
            // 
            this.dijagnozaDataGridViewTextBoxColumn.DataPropertyName = "dijagnoza";
            this.dijagnozaDataGridViewTextBoxColumn.HeaderText = "dijagnoza";
            this.dijagnozaDataGridViewTextBoxColumn.Name = "dijagnozaDataGridViewTextBoxColumn";
            // 
            // traziseDataGridViewTextBoxColumn
            // 
            this.traziseDataGridViewTextBoxColumn.DataPropertyName = "trazi_se";
            this.traziseDataGridViewTextBoxColumn.HeaderText = "trazi_se";
            this.traziseDataGridViewTextBoxColumn.Name = "traziseDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // uputnicaBindingSource
            // 
            this.uputnicaBindingSource.DataSource = typeof(HouseMed.DAL.uputnica);
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(HouseMed.DAL.pacijenti);
            // 
            // btnNovaUputnica
            // 
            this.btnNovaUputnica.Location = new System.Drawing.Point(12, 33);
            this.btnNovaUputnica.Name = "btnNovaUputnica";
            this.btnNovaUputnica.Size = new System.Drawing.Size(119, 34);
            this.btnNovaUputnica.TabIndex = 1;
            this.btnNovaUputnica.Text = "Nova uputnica";
            this.btnNovaUputnica.UseVisualStyleBackColor = true;
            this.btnNovaUputnica.Click += new System.EventHandler(this.btnNovaUputnica_Click);
            // 
            // frmUputnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 489);
            this.Controls.Add(this.btnNovaUputnica);
            this.Controls.Add(this.dgvUputnice);
            this.Name = "frmUputnice";
            this.Text = "Uputnice";
            this.Load += new System.EventHandler(this.frmUputnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uputnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUputnice;
        private System.Windows.Forms.BindingSource uputnicaBindingSource;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uputnicaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upucujeseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djelatniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra_zdrv_ustanoveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijagnozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traziseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNovaUputnica;
    }
}