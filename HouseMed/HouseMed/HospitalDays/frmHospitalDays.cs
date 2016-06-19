using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HouseMed.BAL;
using HouseMed.DAL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed.HospitalDays 
{
    public partial class frmHospitalDays : Form
    {
        #region private variables
        private PacijentiBAL _pacijentiBAL;
        private ReceptiBAL _receptiBAL;
        private UputnicaBAL _uputnicaBAL;
        private CijepljenjeBAL _cijepljenjeBAL;
        private PostupciBAL _postupciBAL;
        private HospitalizacijaBAL _hospitalizacijaBAL;
        private RasporedBAL _rasporedBAL;
        int _workingPatient = 1;
        #endregion


        #region constructor
        public frmHospitalDays()
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

        #region private methods
        private void frmHospitalDays_Load(object sender, EventArgs e)
        {
            DataGridRefresh();
            btnBrisiBoravak.Enabled = false;// TODO: ne radi iz nekog razloga?
            btnUrediBoravak.Enabled = false;
            cbPacijenti.DataSource = _pacijentiBAL.GetAllPacijenti();
            cbPacijenti.DisplayMember = "ime";
            cbPacijenti.ValueMember = "pacijentID";
        }

        private void cbPacijenti_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = cbPacijenti.SelectedValue as pacijenti;
            lblTest.Text =  selectedItem.pacijentiID.ToString();
            _workingPatient = selectedItem.pacijentiID;
            dgvHospitalDays.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(_workingPatient);
        }

        /// <summary>
        /// Otvara formu za dodavanje novog naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviNalog_Click(object sender, EventArgs e)
        {
            frmAddNewHospitalDay frm = new frmAddNewHospitalDay(_workingPatient);
            frm.ShowDialog();
            DataGridRefresh();
        }

        /// <summary>
        /// dobivanje naloga po selected id-u
        /// </summary>
        private void DeleteSelectedNalog()
        {
            var selectedItem = dgvHospitalDays.CurrentRow.DataBoundItem as hospitalizacijaCustom;

            if (selectedItem != null)
            {
                _hospitalizacijaBAL.RemoveNalogByID(selectedItem.HospitalizacijaId);
            }
        }

        /// <summary>
        /// Na klik gumba Brisi se poziva funkcija za brisanje selektiranog naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrisiBoravak_Click(object sender, EventArgs e)
        {
            DeleteSelectedNalog();
            DataGridRefresh();
        }


        private void DataGridRefresh()
        {
            // TODO: Stavit da učitava selektiranog pacijenta umjesto "fiksne" 1 jedinice
            dgvHospitalDays.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(_workingPatient);
        }

        /// <summary>
        /// Otkljucava gumbe za kontrolu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHospitalDays_SelectionChanged(object sender, EventArgs e)
        {
            btnBrisiBoravak.Enabled = true;
            btnUrediBoravak.Enabled = true;
        }

        #endregion

        private void btnUrediBoravak_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvHospitalDays.CurrentRow.DataBoundItem as hospitalizacijaCustom;
            frmAddNewHospitalDay frm = new frmAddNewHospitalDay(selectedItem, _workingPatient);
            frm.ShowDialog();
            DataGridRefresh();
        }
    }
}
