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
using HouseMed.Patients;

namespace HouseMed.Procedures
{
    public partial class frmProcedures : Form
    {
        private PostupciBAL _postupciBAL;
        public frmProcedures()
        {
            _postupciBAL = new PostupciBAL();
            InitializeComponent();
            OdabraniPacijentRefresh();
            labelDatum.Text = DateTime.Today.ToString("dd/MM/yyyy");

        }

        private void OdabraniPacijentRefresh()
        {
            pacijenti trenutniPacijent = frmMenu.trenutniPacijent;
            if (trenutniPacijent != null)
            {
                labelPacijentIspis.Text = trenutniPacijent.ImePrezime;
            }
            else
            {
                labelPacijentIspis.Text = "----->";
            }
        }
        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.ShowDialog();
            OdabraniPacijentRefresh();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SetNewProcedureObject();
        }

        /// <summary>
        /// Instancira se novi postupak
        /// </summary>
        private void SetNewProcedureObject()
        {
            postupci postupak = new postupci()
            {
                datum = HelpClass.GetValueOrNull<DateTime>(labelDatum.Text),
                ljecnikID = 1,
                anamneza = tbAnamneza.Text,
                status = tbStatus.Text,
                dijagnoza = tbDijagnoza.Text,
                terapija = tbTerapija.Text,
                preporuka = tbPreporuka.Text
            };

            _postupciBAL.AddNewPostupak(postupak);
        }
    }
}
