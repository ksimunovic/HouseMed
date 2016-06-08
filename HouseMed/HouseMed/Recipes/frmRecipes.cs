using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed.Utilities
{
    /// <summary>
    /// Forma recepti
    /// </summary>
    public partial class frmRecipes : Form
    {
        public frmRecipes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 354);
            this.Name = "frmRecipes";
            this.Text = "Recepti";
            this.ResumeLayout(false);

        }
    }
}
