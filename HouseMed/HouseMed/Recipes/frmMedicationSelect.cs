using HouseMed.BAL;
using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed.Recipes
{
    public partial class frmMedicationSelect : Form
    {
        #region private variables
        private LijekoviBAL _lijekoviBAL;
        #endregion

        #region constructor
        public frmMedicationSelect()
        {
            InitializeComponent();
            _lijekoviBAL = new LijekoviBAL();
        }
        #endregion

        #region form methods
        /// <summary>
        /// Event handler for form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMedicationSelect_Load(object sender, EventArgs e)
        {
            dgvMedication.DataSource = _lijekoviBAL.GetAllLijekovi();
            lijekoviBindingSource.DataSource = _lijekoviBAL.GetAllLijekovi();
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Search event handler for filtering the medication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMedication.DataSource = _lijekoviBAL.GetLijekoviByName(txtSearch.Text);
            lijekoviBindingSource.DataSource = _lijekoviBAL.GetLijekoviByName(txtSearch.Text);
        }
        /// <summary>
        /// Button[Odustani] event handler: closes this form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Button[Odaberi] event handler: closes the form and passes the selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvMedication.CurrentRow.DataBoundItem as lijekovi;
            if (selectedItem != null)
            {
                frmAddNewRecipe.ObjectProps.lijekovi = selectedItem;
            }
            this.Close();
        }
        /// <summary>
        /// Button[Dodaj] event handler: opens the new form for adding a new "lijekovi" object into the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewLijek_Click(object sender, EventArgs e)
        {
            HouseMed.Medication.frmAddNewMedication frm = new Medication.frmAddNewMedication();
            frm.ShowDialog();
        }
    }
    #endregion
}
