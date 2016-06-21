using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseMed.DAL;
using HouseMed.BAL;

namespace HouseMed.Certificates
{
    public partial class frmAddNewCertificate : Form
    {

        #region private variables
        private PotvrdeBAL _potvrdeBAL;
        private potvrdeCustom _selectedItem;
        #endregion

        #region constuructor
        public frmAddNewCertificate()
        {
            InitializeComponent();
            _potvrdeBAL = new PotvrdeBAL();
            labelIspisPacijenta.Text = "Za pacijenta: " + frmMenu.trenutniPacijent.ImePrezime;
        }
        public frmAddNewCertificate(potvrdeCustom selectedItem)
        {
            InitializeComponent();
            _potvrdeBAL = new PotvrdeBAL();
            _selectedItem = selectedItem;
            labelIspisPacijenta.Text = "Za pacijenta: " + frmMenu.trenutniPacijent.ImePrezime;
            tbSvrha.Text = _selectedItem.Svrha;
            tbOpis.Text = _selectedItem.Opis;
        }
        #endregion

        #region event handlers
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                EditPotvrda();
            }
            else
            {
                SetNewPotvrdaObject();
            }

        }
        #endregion

        #region private methods

        private void EditPotvrda()
        {
            potvrde editablePotvrda = _potvrdeBAL.GetPotvrdaByID(_selectedItem.PotvrdaID);
            editablePotvrda.opis = tbOpis.Text;
            editablePotvrda.svrha = tbSvrha.Text;
            _potvrdeBAL.SaveChanges();
            this.Close();
        }

        private void SetNewPotvrdaObject()
        {
            potvrde potvrda = new potvrde()
            {
                pacijentiID = frmMenu.trenutniPacijent.pacijentiID,
                opis = tbOpis.Text,
                svrha = tbSvrha.Text,
                datum = DateTime.Today,
                djelatniciID = frmMenu.trenutniDjelatnik.djelatniciID
            };
            _potvrdeBAL.AddNewPotvrda(potvrda);
            this.Close();
        }
        #endregion
    }
}
