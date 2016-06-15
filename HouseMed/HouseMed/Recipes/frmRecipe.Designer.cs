namespace HouseMed.Recipes
{
    partial class frmRecipe
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
            this.lblNewRecipe = new System.Windows.Forms.Label();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.dgvRecipe = new System.Windows.Forms.DataGridView();
            this.receptiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slucajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doziranjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nadoplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewRecipe
            // 
            this.lblNewRecipe.AutoSize = true;
            this.lblNewRecipe.Location = new System.Drawing.Point(12, 16);
            this.lblNewRecipe.Name = "lblNewRecipe";
            this.lblNewRecipe.Size = new System.Drawing.Size(94, 13);
            this.lblNewRecipe.TabIndex = 0;
            this.lblNewRecipe.Text = "Izradi novi recept: ";
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Location = new System.Drawing.Point(112, 9);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(95, 26);
            this.btnNewRecipe.TabIndex = 1;
            this.btnNewRecipe.Text = "Novi recept";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btnNewRecipe_Click);
            // 
            // dgvRecipe
            // 
            this.dgvRecipe.AutoGenerateColumns = false;
            this.dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIDDataGridViewTextBoxColumn,
            this.slucajDataGridViewTextBoxColumn,
            this.lijekoviIDDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.doziranjeDataGridViewTextBoxColumn,
            this.nadoplataDataGridViewTextBoxColumn,
            this.pacijentiIDDataGridViewTextBoxColumn,
            this.djelatniciIDDataGridViewTextBoxColumn,
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn});
            this.dgvRecipe.DataSource = this.receptiBindingSource;
            this.dgvRecipe.Location = new System.Drawing.Point(1, 46);
            this.dgvRecipe.Name = "dgvRecipe";
            this.dgvRecipe.Size = new System.Drawing.Size(942, 320);
            this.dgvRecipe.TabIndex = 2;
            // 
            // receptiBindingSource
            // 
            this.receptiBindingSource.DataSource = typeof(HouseMed.DAL.recepti);
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            this.receptIDDataGridViewTextBoxColumn.DataPropertyName = "receptID";
            this.receptIDDataGridViewTextBoxColumn.HeaderText = "receptID";
            this.receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            // 
            // slucajDataGridViewTextBoxColumn
            // 
            this.slucajDataGridViewTextBoxColumn.DataPropertyName = "slucaj";
            this.slucajDataGridViewTextBoxColumn.HeaderText = "slucaj";
            this.slucajDataGridViewTextBoxColumn.Name = "slucajDataGridViewTextBoxColumn";
            // 
            // lijekoviIDDataGridViewTextBoxColumn
            // 
            this.lijekoviIDDataGridViewTextBoxColumn.DataPropertyName = "lijekoviID";
            this.lijekoviIDDataGridViewTextBoxColumn.HeaderText = "lijekoviID";
            this.lijekoviIDDataGridViewTextBoxColumn.Name = "lijekoviIDDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // doziranjeDataGridViewTextBoxColumn
            // 
            this.doziranjeDataGridViewTextBoxColumn.DataPropertyName = "doziranje";
            this.doziranjeDataGridViewTextBoxColumn.HeaderText = "doziranje";
            this.doziranjeDataGridViewTextBoxColumn.Name = "doziranjeDataGridViewTextBoxColumn";
            // 
            // nadoplataDataGridViewTextBoxColumn
            // 
            this.nadoplataDataGridViewTextBoxColumn.DataPropertyName = "nadoplata";
            this.nadoplataDataGridViewTextBoxColumn.HeaderText = "nadoplata";
            this.nadoplataDataGridViewTextBoxColumn.Name = "nadoplataDataGridViewTextBoxColumn";
            // 
            // pacijentiIDDataGridViewTextBoxColumn
            // 
            this.pacijentiIDDataGridViewTextBoxColumn.DataPropertyName = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.HeaderText = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.Name = "pacijentiIDDataGridViewTextBoxColumn";
            // 
            // djelatniciIDDataGridViewTextBoxColumn
            // 
            this.djelatniciIDDataGridViewTextBoxColumn.DataPropertyName = "djelatniciID";
            this.djelatniciIDDataGridViewTextBoxColumn.HeaderText = "djelatniciID";
            this.djelatniciIDDataGridViewTextBoxColumn.Name = "djelatniciIDDataGridViewTextBoxColumn";
            // 
            // sifrazdrvustanoveIDDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveIDDataGridViewTextBoxColumn";
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 367);
            this.Controls.Add(this.dgvRecipe);
            this.Controls.Add(this.lblNewRecipe);
            this.Controls.Add(this.btnNewRecipe);
            this.Name = "frmRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepti";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewRecipe;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.DataGridView dgvRecipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slucajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekoviIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doziranjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nadoplataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djelatniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazdrvustanoveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource receptiBindingSource;
    }
}