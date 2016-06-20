﻿using System;
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
        private DjelatniciBAL _djelatniciBAL;
        private pacijenti trenutniPacijent;
        public frmProcedures()
        {
            _postupciBAL = new PostupciBAL();
            _djelatniciBAL = new DjelatniciBAL();
            InitializeComponent();
            OdabraniPacijentRefresh();
            labelDatum.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void OdabraniPacijentRefresh()
        {
            trenutniPacijent = frmMenu.trenutniPacijent;
            if (trenutniPacijent != null)
            {
                labelPacijentIspis.Text = trenutniPacijent.ImePrezime;
                btnSpremi.Enabled = true;
            }
            else
            {
                labelPacijentIspis.Text = "----->";
                btnSpremi.Enabled = false;
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
                pacijentiID = trenutniPacijent.pacijentiID,
                datum = HelpClass.GetValueOrNull<DateTime>(labelDatum.Text),
                ljecnikID = 2,
                anamneza = tbAnamneza.Text,
                status = tbStatus.Text,
                dijagnoza = tbDijagnoza.Text,
                terapija = tbTerapija.Text,
                preporuka = tbPreporuka.Text
            };

            _postupciBAL.AddNewPostupak(postupak);
            this.Close();
            frmProceduresControl frm = new frmProceduresControl();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProceduresControl frm = new frmProceduresControl();
            frm.ShowDialog();
        }
    }
}