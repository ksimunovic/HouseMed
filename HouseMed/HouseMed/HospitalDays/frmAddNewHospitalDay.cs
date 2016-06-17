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

namespace HouseMed.HospitalDays
{
    public partial class frmAddNewHospitalDay : Form
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
        public frmAddNewHospitalDay(int newID)
        {
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _uputnicaBAL = new UputnicaBAL();
            _cijepljenjeBAL = new CijepljenjeBAL();
            _postupciBAL = new PostupciBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            _rasporedBAL = new RasporedBAL();
            SetComboBox();
            labelTest.Text = newID.ToString();
        }

        #endregion

        #region form methods
        /// <summary>
        /// punjenje i prikaz comboboxa
        /// </summary>
        private void SetComboBox()
        {
            
            // set pacijenti
            cbPacijentBoravak.DataSource = _pacijentiBAL.GetAllPacijenti();
            cbPacijentBoravak.DisplayMember = "ime";
            cbPacijentBoravak.ValueMember = "pacijentiID";

        }

        /// <summary>
        /// Instancing a new Evidencija object
        /// </summary>
        private void SetNewEvidencijaObject()
        {
            var _pacijentiID = cbPacijentBoravak.SelectedItem as pacijenti;
            evidencija_hospitalizacije nalog = new evidencija_hospitalizacije()
            {
                evidencija_hospitalizacijeID = labelTest.Text,
                boravio_od_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioOd.Text),
                boravio_do_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioDo.Text),
                naziv_bolnice = tbBolnica.Text,
                razlog = tbRazlogBoravka.Text,
                pacijentiID = _pacijentiID.pacijentiID
            };

            _hospitalizacijaBAL.AddNewNalog(nalog);
        }
        #endregion

        private void btnDodajBoravak_Click(object sender, EventArgs e)
        {
            SetNewEvidencijaObject();
            this.Close();
        }
    }
}
