using HouseMed.BAL;
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
    public partial class frmRecipe : Form
    {
        #region private variables
        private ReceptiBAL _receptiBAL;
        #endregion

        #region constructor
        public frmRecipe()
        {
            InitializeComponent();
            _receptiBAL = new ReceptiBAL();
        }
        #endregion

        #region form methods
        private void frmRecipe_Load(object sender, EventArgs e)
        {
            RefreshRecipeDatagrid();
        }
        #endregion

        #region button event handlers
        /// <summary>
        /// ButtonEvent open "Izradi novi recept" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            frmAddNewRecipe frm = new frmAddNewRecipe();
            frm.ShowDialog();
            RefreshRecipeDatagrid();
        }
        #endregion

        #region private methods
        /// <summary>
        /// Setting the datagrid datasource
        /// </summary>
        private void RefreshRecipeDatagrid()
        {
            dgvRecipe.DataSource = _receptiBAL.GetALLRecepti();
        }
        #endregion
    }
}
