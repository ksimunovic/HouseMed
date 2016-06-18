namespace HouseMed.Raspored
{
    partial class frmRaspored
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
            this.dateTimePickerRaspored = new System.Windows.Forms.DateTimePicker();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.labelPacijenti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCijepljenje = new System.Windows.Forms.DataGridView();
            this.btnNoviPregled = new System.Windows.Forms.Button();
            this.btnUnosCijepljanja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijepljenje)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerRaspored
            // 
            this.dateTimePickerRaspored.Location = new System.Drawing.Point(59, 26);
            this.dateTimePickerRaspored.Name = "dateTimePickerRaspored";
            this.dateTimePickerRaspored.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRaspored.TabIndex = 0;
            this.dateTimePickerRaspored.ValueChanged += new System.EventHandler(this.dateTimePickerRaspored_ValueChanged);
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(59, 134);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.RowTemplate.Height = 24;
            this.dgvRaspored.Size = new System.Drawing.Size(741, 169);
            this.dgvRaspored.TabIndex = 1;
            // 
            // labelPacijenti
            // 
            this.labelPacijenti.AutoSize = true;
            this.labelPacijenti.Location = new System.Drawing.Point(56, 96);
            this.labelPacijenti.Name = "labelPacijenti";
            this.labelPacijenti.Size = new System.Drawing.Size(189, 17);
            this.labelPacijenti.TabIndex = 2;
            this.labelPacijenti.Text = "Pregled naručenih pacijenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pregled kalendara cijepljenja:";
            // 
            // dgvCijepljenje
            // 
            this.dgvCijepljenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCijepljenje.Location = new System.Drawing.Point(59, 375);
            this.dgvCijepljenje.Name = "dgvCijepljenje";
            this.dgvCijepljenje.RowTemplate.Height = 24;
            this.dgvCijepljenje.Size = new System.Drawing.Size(741, 159);
            this.dgvCijepljenje.TabIndex = 4;
            // 
            // btnNoviPregled
            // 
            this.btnNoviPregled.Location = new System.Drawing.Point(695, 80);
            this.btnNoviPregled.Name = "btnNoviPregled";
            this.btnNoviPregled.Size = new System.Drawing.Size(105, 33);
            this.btnNoviPregled.TabIndex = 5;
            this.btnNoviPregled.Text = "Novi pregled";
            this.btnNoviPregled.UseVisualStyleBackColor = true;
            this.btnNoviPregled.Click += new System.EventHandler(this.btnNoviPregled_Click);
            // 
            // btnUnosCijepljanja
            // 
            this.btnUnosCijepljanja.Location = new System.Drawing.Point(682, 326);
            this.btnUnosCijepljanja.Name = "btnUnosCijepljanja";
            this.btnUnosCijepljanja.Size = new System.Drawing.Size(118, 33);
            this.btnUnosCijepljanja.TabIndex = 6;
            this.btnUnosCijepljanja.Text = "Unos cijepljenja";
            this.btnUnosCijepljanja.UseVisualStyleBackColor = true;
            this.btnUnosCijepljanja.Click += new System.EventHandler(this.btnUnosCijepljanja_Click);
            // 
            // frmRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 556);
            this.Controls.Add(this.btnUnosCijepljanja);
            this.Controls.Add(this.btnNoviPregled);
            this.Controls.Add(this.dgvCijepljenje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPacijenti);
            this.Controls.Add(this.dgvRaspored);
            this.Controls.Add(this.dateTimePickerRaspored);
            this.Name = "frmRaspored";
            this.Text = "Raspored";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijepljenje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerRaspored;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label labelPacijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCijepljenje;
        private System.Windows.Forms.Button btnNoviPregled;
        private System.Windows.Forms.Button btnUnosCijepljanja;
    }
}