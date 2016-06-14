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
            dgvHospitalDays.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(1);
            cbPacijenti.DataSource = _pacijentiBAL.GetAllPacijenti();
            cbPacijenti.DisplayMember = "ImePrezime";
            cbPacijenti.ValueMember = "pacijentID";
        }

        private void cbPacijenti_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = cbPacijenti.SelectedValue as pacijenti;
            lblTest.Text = selectedItem.pacijentiID.ToString();
            dgvHospitalDays.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(selectedItem.pacijentiID);
        }
        #endregion  

    }
}
