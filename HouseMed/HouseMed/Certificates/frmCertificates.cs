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
using HouseMed.Patients;
using HouseMed.Certificates;

namespace HouseMed.Utilities
{
    public partial class frmCertificates : Form
    {
        #region private variables
        private pacijenti trenutniPacijent;
        private PotvrdeBAL _potvrdeBAL;
        #endregion

        #region constructor
        public frmCertificates()
        {
            InitializeComponent();
            _potvrdeBAL = new PotvrdeBAL();
            trenutniPacijent = new pacijenti();
            OdabraniPacijentRefresh();
        }
        #endregion

        #region private methods
        private void OdabraniPacijentRefresh()
        {
            trenutniPacijent = frmMenu.trenutniPacijent;
            if (trenutniPacijent != null)
            {
                labelPacijentIspis.Text = "Pacijent: " + trenutniPacijent.ImePrezime;
                DataGridRefresh();
            }
            else
            {
                labelPacijentIspis.Text = "Pacijent: --->";
            }
        }

        private void DataGridRefresh()
        {
            if (trenutniPacijent != null)
            {
                dgvCertificates.DataSource = _potvrdeBAL.GetAllPotvrdeByID(trenutniPacijent.pacijentiID);
            }
        }

        private void DeleteSelectedPotvrda()
        {
            var selectedItem = dgvCertificates.CurrentRow.DataBoundItem as potvrdeCustom;
            if (selectedItem != null)
            {
                _potvrdeBAL.RemovePotvrdaByID(selectedItem.PotvrdaID);
            }
        }
        

        #endregion

        #region event handlers
        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.ShowDialog();
            OdabraniPacijentRefresh();
        }
        
        private void novaPotvrdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                frmAddNewCertificate frm = new frmAddNewCertificate();
                frm.ShowDialog();
                OdabraniPacijentRefresh();
            }
        }
        
        private void UrediPotvrduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                var selectedItem = dgvCertificates.CurrentRow.DataBoundItem as potvrdeCustom;
                if (selectedItem != null)
                {
                    frmAddNewCertificate frm = new frmAddNewCertificate(selectedItem);
                    frm.ShowDialog();
                    OdabraniPacijentRefresh();
                }

            }
        }

        private void izbrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedPotvrda();
            OdabraniPacijentRefresh();
        }

        #endregion
    }
}
