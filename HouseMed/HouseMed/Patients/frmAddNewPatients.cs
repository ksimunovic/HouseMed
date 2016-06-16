﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.BAL;
using HouseMed.DAL;
using System.Windows.Forms;

namespace HouseMed.Patients
{
    public partial class frmAddNewPatients : Form
    {

        #region private variables
        private DjelatniciBAL _djelatniciBAL;
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private ReceptiBAL _receptiBAL;
        private PacijentiBAL _pacijentiBAL;
        private int _ustanovaID;
        private pacijenti _selectedPacijent;
        #endregion

        #region constructor
        public frmAddNewPatients()
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
        }

        public frmAddNewPatients(pacijenti selectedPacijent)
        {
            InitializeComponent();
            _selectedPacijent = selectedPacijent;
            _pacijentiBAL = new PacijentiBAL();
        }

        #endregion




        #region event handler
        /// <summary>
        /// Dobivanje vrijednosti iz Comboboxa Ustanove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxUstanova_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxUstanova.SelectedItem as sifra_zdrv_ustanove;
            _ustanovaID = selectedItem.sifra_zdrv_ustanoveID;

        }

        /// <summary>
        /// punjenjeComboboxa Ustanove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void frmAddNewPatients_Load(object sender, EventArgs e)
        {
            if(_selectedPacijent != null)
            {
                LoadSelectedPatient();
                SetComboBox();
            }
            else
            {
                SetComboBox();
            }
        }
        /// <summary>
        /// Dodavanje novog pacijenta u bazu brzo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            if(_selectedPacijent != null)
            {
                EditPatient();
            }
            else
            {
                SetNewPatientsObject();
            }
            

            this.Close();
        }



        #endregion


        #region form methods
        /// <summary>
        /// punjenje i prikaz comboboxa
        /// </summary>
        private void SetComboBox()
        {
            var listaZdravUstanova = _zdravUstanovaBAL.GetAllUstanove();
            comboBoxUstanova.DataSource = listaZdravUstanova;
            comboBoxUstanova.DisplayMember = "naziv";
            comboBoxUstanova.ValueMember = "sifra_zdrv_ustanoveID";
        }


        /// <summary>
        /// Instancing a new Patient object
        /// </summary>
        private void SetNewPatientsObject()
        {
            pacijenti pacijenti = new pacijenti()
            {

                MBO = HelpClass.GetValueOrNull<int>(textBoxMbo.Text),
                OIB = HelpClass.GetValueOrNull<int>(textBoxOib.Text),
                ime = textBoxIme.Text,
                prezime = textBoxPrezime.Text,
                spol = comboBoxSpol.Text,
                mjesto = textBoxMjesto.Text,
                adresa = textBoxAdresa.Text,
                drzava = textBoxDrzava.Text,
                telefon = textBoxTelefon.Text,
                mobitel = textBoxMobitel.Text,
                email = textBoxEmail.Text,
                sifra_zdrv_ustanoveID = _ustanovaID

            };
            
            _pacijentiBAL.AddNewPacijent(pacijenti);
        }

        private void LoadSelectedPatient()
        {
            textBoxAdresa.Text = _selectedPacijent.adresa;
            textBoxDrzava.Text = _selectedPacijent.drzava;
        }

        private void EditPatient()
        {
            _selectedPacijent.adresa = textBoxAdresa.Text;
            _selectedPacijent.drzava = textBoxDrzava.Text;
            _pacijentiBAL.SaveChanges();
        }







        #endregion

        
    }
}
