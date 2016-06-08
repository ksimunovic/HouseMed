using System;
using System.Windows.Forms;
using HouseMed.Recipes;

namespace HouseMed
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ButtonEvent open "Recepti" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecept_Click(object sender, EventArgs e)
        {
            Recipes.frmRecipe frm = new frmRecipe();
            frm.ShowDialog();
        }
    }
}
