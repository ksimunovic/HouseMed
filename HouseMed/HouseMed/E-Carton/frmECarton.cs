using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseMed.BAL;
using HouseMed.DAL;
using HouseMed.Recipes;

namespace HouseMed.E_Carton
{
    public partial class frmECarton : Form
    {
        #region private variables
        private PacijentiBAL _pacijentiBAL;
        private ReceptiBAL _receptiBAL;
        private UputnicaBAL _uputnicaBAL;
        private CijepljenjeBAL _cijepljenjeBAL;
        private PostupciBAL _postupciBAL;
        private HospitalizacijaBAL _hospitalizacijaBAL;
        private RasporedBAL _rasporedBAL;
        #endregion

        #region constructor
        public frmECarton()
        {
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _uputnicaBAL = new UputnicaBAL();
            _cijepljenjeBAL = new CijepljenjeBAL();
            _postupciBAL = new PostupciBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            _rasporedBAL = new RasporedBAL();
        }
        #endregion

        #region form methods
        /// <summary>
        /// Event for loadind the data in the datagrids
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmECarton_Load(object sender, EventArgs e)
        {
            dgvPatients.DataSource = _pacijentiBAL.GetAllPacijenti();
            SetCoulumnHeaders();
            GetSelectedPatient();
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Button[Odaberi] event handler: pass the chosen object to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;
            if (selectedItem != null)
            {
                frmAddNewRecipe.ObjectProps.pacijenti = selectedItem;
            }
            this.Close();
        }
        /// <summary>
        /// DataGrid[Pacijent] event handler: get the selected patient and execute query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            GetSelectedPatient();
        }
        #endregion


        #region private methods
        /// <summary>
        /// Method for getting the selected patient in Patient data grid
        /// </summary>
        private void GetSelectedPatient()
        {
            var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;
            if (selectedItem != null)
            {
                dgvRecipe.DataSource = _receptiBAL.GetAllReceptiNamedPropsById(selectedItem.pacijentiID);
                dgvUputnica.DataSource = _uputnicaBAL.GetAllUputnicaPropsNameById(selectedItem.pacijentiID);
                dgvCijepljenje.DataSource = _cijepljenjeBAL.GetAllCijepPropNamesById(selectedItem.pacijentiID);
                dgvPostupci.DataSource = _postupciBAL.GetAllPostupciPropNamesById(selectedItem.pacijentiID);
                dgvHostpitalizacija.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(selectedItem.pacijentiID);
                dgvRaspored.DataSource = _rasporedBAL.GetAllRasporedPropNamesById(selectedItem.pacijentiID);
                
            }
        }
        /// <summary>
        /// Method for setting the Column Headers in data grid views
        /// </summary>
        private void SetCoulumnHeaders()
        {
            // "Uputnica"
            dgvUputnica.Columns[0].HeaderCell.Value = "Br. Uputnice";
            dgvUputnica.Columns[3].HeaderCell.Value = "Upućuje se";
            dgvUputnica.Columns[5].HeaderCell.Value = "Traži se";

            // "Recept"
            dgvRecipe.Columns[0].HeaderCell.Value = "Br. Recepta";
            dgvRecipe.Columns[1].HeaderCell.Value = "Slučaj";
            dgvRecipe.Columns[2].HeaderCell.Value = "Količina";
            dgvRecipe.Columns[5].HeaderCell.Value = "Lijek";
            dgvRecipe.Columns[6].HeaderCell.Value = "Pacijent";
            dgvRecipe.Columns[7].HeaderCell.Value = "Djelatnik";
            dgvRecipe.Columns[8].HeaderCell.Value = "Ustanova";

            // "Cijepljenje"
            dgvCijepljenje.Columns[0].HeaderCell.Value = "Br. Cijepljenja";
            dgvCijepljenje.Columns[1].HeaderCell.Value = "Slučaj";
            dgvCijepljenje.Columns[3].HeaderCell.Value = "Vrsta cijepljenja";
            dgvCijepljenje.Columns[4].HeaderCell.Value = "Priprava cjepiva";
            dgvCijepljenje.Columns[5].HeaderCell.Value = "Broj doze";
            dgvCijepljenje.Columns[6].HeaderCell.Value = "Količina";

            // "Hospitalizacija"
            dgvHostpitalizacija.Columns[0].HeaderCell.Value = "Br. Hospitalizacije";
            dgvHostpitalizacija.Columns[1].HeaderCell.Value = "Boravio od datuma";
            dgvHostpitalizacija.Columns[2].HeaderCell.Value = "Boravio do datuma";
            dgvHostpitalizacija.Columns[3].HeaderCell.Value = "Naziv bolnice";

            // "Postupci"
            dgvPostupci.Columns[0].HeaderCell.Value = "Br. Postupaka";

            // "Raspored
            dgvRaspored.Columns[0].HeaderCell.Value = "Br. Raporeda";

        }
        #endregion

    }
}
