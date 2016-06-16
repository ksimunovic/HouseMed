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
            this.dgvUputnice.Size = new System.Drawing.Size(941, 351);
            this.dgvUputnice.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUputnice;
        private System.Windows.Forms.Button btnNovaUputnica;
    }
}