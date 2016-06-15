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
using HouseMed.Patients;

namespace HouseMed.Patients
{
    public partial class frmPatients : Form
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
        public frmPatients()
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

        #region event handlers

        /// <summary>
        /// event za load forme puni datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPatients_Load(object sender, EventArgs e)
        {
            RefreshDatagrid();
        }
        /// <summary>
        /// klikom na novi pacijent se  otvara nova form i refresh datagrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviPacijent_Click(object sender, EventArgs e)
        {
            frmAddNewPatients frm = new frmAddNewPatients();
            frm.ShowDialog();
            RefreshDatagrid();

        }
        /// <summary>
        /// event za označavanje retka u datagridu zove funkciju
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
        /// funkcija za refresh podataka u datagridu
        /// </summary>
        private void RefreshDatagrid()
        {
            dgvPatients.DataSource = _pacijentiBAL.GetAllPacijenti();

        }

        private void GetSelectedPatient()
        {
            var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;
            if (selectedItem != null)
            {
               //todo

            }
        }
        #endregion


    }
}
