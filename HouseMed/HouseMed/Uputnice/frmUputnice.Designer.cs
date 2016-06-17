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
            this.dgvUputnice = new System.Windows.Forms.DataGridView();
            this.btnNovaUputnica = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUputnice
            // 
            this.dgvUputnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUputnice.Location = new System.Drawing.Point(12, 93);
            this.dgvUputnice.Name = "dgvUputnice";
            this.dgvUputnice.RowTemplate.Height = 24;
            this.dgvUputnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUputnice.Size = new System.Drawing.Size(941, 289);
            this.dgvUputnice.TabIndex = 0;
            this.dgvUputnice.SelectionChanged += new System.EventHandler(this.dgvUputnice_SelectionChanged);
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
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(800, 413);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 29);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(676, 413);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(88, 29);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // frmUputnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 489);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNovaUputnica);
            this.Controls.Add(this.dgvUputnice);
            this.Name = "frmUputnice";
            this.Text = "Uputnice";
            this.Load += new System.EventHandler(this.frmUputnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUputnice;
        private System.Windows.Forms.Button btnNovaUputnica;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
    }
}