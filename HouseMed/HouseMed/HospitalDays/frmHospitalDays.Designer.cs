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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPacijenti = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnNoviNalog = new System.Windows.Forms.Button();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.djelatniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dgvHospitalDays.Size = new System.Drawing.Size(646, 150);
            this.dgvHospitalDays.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacijenti:";
            // 
            // cbPacijenti
            // 
            this.cbPacijenti.FormattingEnabled = true;
            this.cbPacijenti.Location = new System.Drawing.Point(72, 24);
            this.cbPacijenti.Name = "cbPacijenti";
            this.cbPacijenti.Size = new System.Drawing.Size(121, 21);
            this.cbPacijenti.TabIndex = 2;
            this.cbPacijenti.SelectedValueChanged += new System.EventHandler(this.cbPacijenti_SelectedValueChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(220, 27);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "label2";
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
            // frmHospitalDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 262);
            this.Controls.Add(this.btnNoviNalog);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.cbPacijenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHospitalDays);
            this.Name = "frmHospitalDays";
            this.Text = "frmHospitalDays";
            this.Load += new System.EventHandler(this.frmHospitalDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHospitalDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPacijenti;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.BindingSource djelatniciBindingSource;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnNoviNalog;
    }
}