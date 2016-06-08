namespace HouseMed
{
    partial class frmMenu
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
            this.btnEkarton = new System.Windows.Forms.Button();
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.btnRecept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkarton
            // 
            this.btnEkarton.Location = new System.Drawing.Point(145, 304);
            this.btnEkarton.Name = "btnEkarton";
            this.btnEkarton.Size = new System.Drawing.Size(83, 37);
            this.btnEkarton.TabIndex = 0;
            this.btnEkarton.Text = "E - karton";
            this.btnEkarton.UseVisualStyleBackColor = true;
            // 
            // btnLijekovi
            // 
            this.btnLijekovi.Location = new System.Drawing.Point(248, 304);
            this.btnLijekovi.Name = "btnLijekovi";
            this.btnLijekovi.Size = new System.Drawing.Size(83, 37);
            this.btnLijekovi.TabIndex = 1;
            this.btnLijekovi.Text = "Lijekovi";
            this.btnLijekovi.UseVisualStyleBackColor = true;
            // 
            // btnRecept
            // 
            this.btnRecept.Location = new System.Drawing.Point(38, 304);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(83, 37);
            this.btnRecept.TabIndex = 2;
            this.btnRecept.Text = "Izrada recepata";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 390);
            this.Controls.Add(this.btnRecept);
            this.Controls.Add(this.btnLijekovi);
            this.Controls.Add(this.btnEkarton);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funkcionalnosti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkarton;
        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnRecept;
    }
}