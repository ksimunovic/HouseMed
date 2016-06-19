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
        private hospitalizacijaCustom selectedNalog;
        private evidencija_hospitalizacije proba;/// brisi mee <-
        int _workingPatient = 0;

        #endregion

        #region constructor
        public frmAddNewHospitalDay(int workingPatient)
        {
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            labelTest.Text = _hospitalizacijaBAL.getNewID().ToString();
            _workingPatient = workingPatient;
            SetComboBox();

        }

        public frmAddNewHospitalDay(hospitalizacijaCustom selectedItem, int workingPatient)
        {
            this.selectedNalog = selectedItem;
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            _workingPatient = workingPatient;
            SetComboBox();
        }

        #endregion

        #region form methods
        /// <summary>
        /// punjenje i prikaz comboboxa
        /// </summary>
        private void SetComboBox()
        {

            // set PacijentiBoravak
            /* cbPacijentBoravak.DataSource = _pacijentiBAL.GetAllPacijenti();
             cbPacijentBoravak.DisplayMember = "ime";
             cbPacijentBoravak.ValueMember = "pacijentiID";*/

        }

        /// <summary>
        /// Instancing a new Evidencija object
        /// </summary>
        private void SetNewEvidencijaObject()
        {
            var _pacijentiID = cbPacijentBoravak.SelectedItem as pacijenti;
            evidencija_hospitalizacije nalog = new evidencija_hospitalizacije()
            {
                evidencija_hospitalizacijeID = _hospitalizacijaBAL.getNewID().ToString(),
                boravio_od_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioOd.Text),
                boravio_do_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioDo.Text),
                naziv_bolnice = tbBolnica.Text,
                razlog = tbRazlogBoravka.Text,
                pacijentiID = _workingPatient
            };

            _hospitalizacijaBAL.AddNewNalog(nalog);
        }
        #endregion

        private void btnDodajBoravak_Click(object sender, EventArgs e)
        {
            if (selectedNalog != null)
            {
                EditNalog();
            }
            else
            {
                SetNewEvidencijaObject();
            }
            
            this.Close();
        }

        private void EditNalog()
        {
            evidencija_hospitalizacije editableNalog = _hospitalizacijaBAL.GetNalogByID("11");
            editableNalog.boravio_od_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioOd.Text);
            editableNalog.boravio_do_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioDo.Text);
            editableNalog.naziv_bolnice = tbBolnica.Text;
            editableNalog.razlog = tbRazlogBoravka.Text;
            _hospitalizacijaBAL.SaveChanges();
        }

        private void frmAddNewHospitalDay_Load(object sender, EventArgs e)
        {
            if (selectedNalog != null)
            {
                //SetComboBox();
                LoadSelectedNalog();

            }
            else
            {
                SetComboBox();
            }
        }

        private void LoadSelectedNalog()
        {
            tbBolnica.Text = selectedNalog.NazivBolnice;
            dtpBoravioOd.Text = selectedNalog.BoravioOdDatuma.ToString();
            dtpBoravioOd.Text = selectedNalog.BoravioDoDatuma.ToString();
            tbRazlogBoravka.Text = selectedNalog.Razlog;
        }
    }


}
