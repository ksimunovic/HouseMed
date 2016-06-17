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

namespace HouseMed.Uputnice
{

    public partial class frmAddNewUputnice : Form
    {
        #region private variables
        private DjelatniciBAL _djelatniciBAL;
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private ReceptiBAL _receptiBAL;
        private PacijentiBAL _pacijentiBAL;
        private LijekoviBAL _lijekoviBAL;
        private UputnicaBAL _uputnicaBAL;
        private int _ustanovaID;
        private int _djelatniciID;
        private int _pacijentiID;
        private uputnica _selectedUputnica;
        #endregion


        #region constructor

        public frmAddNewUputnice()
        {
            InitializeComponent();
            _lijekoviBAL = new LijekoviBAL();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _uputnicaBAL = new UputnicaBAL();
        }

        public frmAddNewUputnice(uputnica selectedUputnica)
        {
            InitializeComponent();
            _selectedUputnica = selectedUputnica;
            _lijekoviBAL = new LijekoviBAL();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _uputnicaBAL = new UputnicaBAL();
        }
        #endregion

        #region event handler

        /// <summary>
        /// Punjenje comboboxa onload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewUputnice_Load(object sender, EventArgs e)
        {
            if (_selectedUputnica != null)
            {
                LoadSelectedUputnica();
                SetComboBox();
            } else

            {
            SetComboBox();
            }
            
        }

        /// <summary>
        /// Dobivanje vrijednosti iz comboboxa UstanovaID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxUstanovaID_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxUstanovaID.SelectedItem as sifra_zdrv_ustanove;
            _ustanovaID = selectedItem.sifra_zdrv_ustanoveID;

        }
        /// <summary>
        /// Dobivanje vrijednosti iz comboboxa PacijentiID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPacijentiID_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxPacijentiID.SelectedItem as pacijenti;
            _pacijentiID = selectedItem.pacijentiID;
        }

        /// <summary>
        /// Dobivanje vrijednosti iz comobobxaDjelatniciID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDjelatniciID_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxDjelatniciID.SelectedItem as djelatnici;
            _djelatniciID = selectedItem.djelatniciID;
        }

        /// <summary>
        /// pozivanje funkcije za instanciranje novog objekta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajUputnicu_Click(object sender, EventArgs e)
        {
            if (_selectedUputnica != null)
            {
                EditUputnica();
            } else
            {
                SetNewUputniceObject();
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
            var listaDjelatnici = _djelatniciBAL.GetAllDjelatnici();
            var listaPacijenti = _pacijentiBAL.GetAllPacijenti();

            // set djelatnici
            comboBoxDjelatniciID.DataSource = listaDjelatnici;
            comboBoxDjelatniciID.DisplayMember = "ImePrezime";
            comboBoxDjelatniciID.ValueMember = "djelatniciID";

            // set ustanova
            comboBoxUstanovaID.DataSource = listaZdravUstanova;
            comboBoxUstanovaID.DisplayMember = "naziv";
            comboBoxUstanovaID.ValueMember = "sifra_zdrv_ustanoveID";

            //set pacijenti

            comboBoxPacijentiID.DataSource = listaPacijenti;
            comboBoxPacijentiID.DisplayMember = "ImePrezime";
            comboBoxPacijentiID.ValueMember = "pacijentiID";


        }

        /// <summary>
        /// Instancing a new Patient object
        /// </summary>
        private void SetNewUputniceObject()
        {
            uputnica uputnica = new uputnica()
            {
                pacijentID = _pacijentiID,
                sifra_zdrv_ustanoveID = _ustanovaID,
                upucuje_se = textBoxUpucuje_se.Text,
                dijagnoza = textBoxDijagnoza.Text,
                trazi_se = textBoxTrazi_se.Text,
                napomena = textBoxNapomena.Text,
                datum = HelpClass.GetValueOrNull<DateTime>(dateTimePickerDatum.Text),
                djelatniciID = _djelatniciID
                
            };

            _uputnicaBAL.AddNewUputnica(uputnica);
        }

        /// <summary>
        /// učitavanje u form obrazac podataka s datagrid viewa
        /// </summary>
        private void LoadSelectedUputnica()
        {
            textBoxUputnicaID.Text = _selectedUputnica.uputnicaID.ToString();
            comboBoxPacijentiID.Text = _selectedUputnica.pacijentID.ToString();
            comboBoxUstanovaID.Text = _selectedUputnica.sifra_zdrv_ustanoveID.ToString();
            textBoxUpucuje_se.Text = _selectedUputnica.upucuje_se;
            textBoxDijagnoza.Text = _selectedUputnica.dijagnoza;
            textBoxTrazi_se.Text = _selectedUputnica.trazi_se;
            textBoxNapomena.Text = _selectedUputnica.napomena;
            dateTimePickerDatum.Text = _selectedUputnica.datum.ToString();
            comboBoxDjelatniciID.Text = _selectedUputnica.djelatniciID.ToString();

        }

        /// <summary>
        /// punjenje objekta vrijednostima iz textboxa
        /// </summary>
        private void EditUputnica()
        {
            _selectedUputnica.uputnicaID = int.Parse(textBoxUputnicaID.Text);
            _selectedUputnica.pacijentID = _pacijentiID;
            _selectedUputnica.sifra_zdrv_ustanoveID = _ustanovaID;
            _selectedUputnica.upucuje_se = textBoxUpucuje_se.Text;
            _selectedUputnica.dijagnoza = textBoxDijagnoza.Text;
            _selectedUputnica.trazi_se = textBoxTrazi_se.Text;
            _selectedUputnica.napomena = textBoxNapomena.Text;
            _selectedUputnica.datum = dateTimePickerDatum.Value;
            _selectedUputnica.djelatniciID = _djelatniciID;
            _uputnicaBAL.SaveChanges();
        }



        #endregion


    }
}