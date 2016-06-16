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
            this.btnBolnica = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnUputnice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkarton
            // 
            this.btnEkarton.Location = new System.Drawing.Point(452, 364);
            this.btnEkarton.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkarton.Name = "btnEkarton";
            this.btnEkarton.Size = new System.Drawing.Size(111, 46);
            this.btnEkarton.TabIndex = 0;
            this.btnEkarton.Text = "E - karton";
            this.btnEkarton.UseVisualStyleBackColor = true;
            this.btnEkarton.Click += new System.EventHandler(this.btnEkarton_Click);
            // 
            // btnLijekovi
            // 
            this.btnLijekovi.Location = new System.Drawing.Point(590, 364);
            this.btnLijekovi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLijekovi.Name = "btnLijekovi";
            this.btnLijekovi.Size = new System.Drawing.Size(111, 46);
            this.btnLijekovi.TabIndex = 1;
            this.btnLijekovi.Text = "Lijekovi";
            this.btnLijekovi.UseVisualStyleBackColor = true;
            this.btnLijekovi.Click += new System.EventHandler(this.btnLijekovi_Click);
            // 
            // btnRecept
            // 
            this.btnRecept.Location = new System.Drawing.Point(172, 364);
            this.btnRecept.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(111, 46);
            this.btnRecept.TabIndex = 2;
            this.btnRecept.Text = "Recepti";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);
            // 
            // btnBolnica
            // 
            this.btnBolnica.Location = new System.Drawing.Point(728, 364);
            this.btnBolnica.Margin = new System.Windows.Forms.Padding(4);
            this.btnBolnica.Name = "btnBolnica";
            this.btnBolnica.Size = new System.Drawing.Size(111, 46);
            this.btnBolnica.TabIndex = 3;
            this.btnBolnica.Text = "Boravak u bolnici";
            this.btnBolnica.UseVisualStyleBackColor = true;
            this.btnBolnica.Click += new System.EventHandler(this.btnBolnica_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(31, 364);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(111, 46);
            this.btnPatients.TabIndex = 4;
            this.btnPatients.Text = "Pacijenti";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnUputnice
            // 
            this.btnUputnice.Location = new System.Drawing.Point(312, 364);
            this.btnUputnice.Margin = new System.Windows.Forms.Padding(4);
            this.btnUputnice.Name = "btnUputnice";
            this.btnUputnice.Size = new System.Drawing.Size(111, 46);
            this.btnUputnice.TabIndex = 5;
            this.btnUputnice.Text = "Uputnice";
            this.btnUputnice.UseVisualStyleBackColor = true;
            this.btnUputnice.Click += new System.EventHandler(this.btnUputnice_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 480);
            this.Controls.Add(this.btnUputnice);
            this.Controls.Add(this.btnPatients);
            this.Controls.Add(this.btnBolnica);
            this.Controls.Add(this.btnRecept);
            this.Controls.Add(this.btnLijekovi);
            this.Controls.Add(this.btnEkarton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funkcionalnosti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkarton;
        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnBolnica;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnUputnice;
    }
}