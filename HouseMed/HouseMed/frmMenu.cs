using System;
using System.Windows.Forms;
using HouseMed.Recipes;
using HouseMed.HospitalDays;
using HouseMed.E_Carton;

namespace HouseMed
{
    public partial class frmMenu : Form
    {
        #region constructor
        public frmMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Button[E-Karton] event handler: opent the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkarton_Click(object sender, EventArgs e)
        {
            frmECarton frm = new frmECarton();
            frm.ShowDialog();
        }
        /// <summary>
        /// Buttton[Recepti] event handler: open the "frmRecipe" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecept_Click(object sender, EventArgs e)
        {
            Recipes.frmRecipe frm = new frmRecipe();
            frm.ShowDialog();
        }

        /// <summary>
        /// Button[Lijekovi] event handler: open the "frmMedicationSelect" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLijekovi_Click(object sender, EventArgs e)
        {
            Recipes.frmMedicationSelect frm = new frmMedicationSelect();
            frm.ShowDialog();
        }



        /// <summary>
        /// Buttton[Bolnica] event handler: open the "frmHospitalDays" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBolnica_Click(object sender, EventArgs e)
        {
            HospitalDays.frmHospitalDays frm = new frmHospitalDays();
            frm.ShowDialog();
        }
        #endregion
    }
}
