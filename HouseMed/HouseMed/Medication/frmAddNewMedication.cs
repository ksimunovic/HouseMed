using HouseMed.BAL;
using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed.Medication
{
    public partial class frmAddNewMedication : Form
    {
        #region private variables
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private LijekoviBAL _lijekoviBAL;
        private int _ustanovaId;
        #endregion

        #region constructor
        public frmAddNewMedication()
        {
            InitializeComponent();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _lijekoviBAL = new LijekoviBAL();
        }
        #endregion

        #region form methods
        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewMedication_Load(object sender, EventArgs e)
        {
            SetComboBox();
            this.ActiveControl = txtNaziv;
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Button[Odustani] event handler: closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ComboBox[Ustanove] event handler: take "ustanovaID" when selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboUstanova_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboUstanova.SelectedItem as sifra_zdrv_ustanove;
            _ustanovaId = selectedItem.sifra_zdrv_ustanoveID;
        }
        /// <summary>
        /// Button[U redu] event handler: instance new object to add in the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            SetNewLijekoviObject();
        }
        #endregion

        #region private methods
        /// <summary>
        /// Setting the combobox Djelatnici and Ustanova with values
        /// </summary>
        private void SetComboBox()
        {
            var listaZdravUstanova = _zdravUstanovaBAL.GetAllUstanove();

            // set ustanove
            comboUstanova.DataSource = listaZdravUstanova;
            comboUstanova.DisplayMember = "naziv";
            comboUstanova.ValueMember = "sifra_zdrv_ustanoveID";

        }
        /// <summary>
        /// Instancing a new "lijekovi" object
        /// </summary>
        private void SetNewLijekoviObject()
        {
            lijekovi lijekovi = new lijekovi()
            {
                sifra_zdrv_ustanoveID = _ustanovaId,
                naziv = txtNaziv.Text,
                datum_vrijeme_kontrole = HelpClass.GetValueOrNull<DateTime>(dtpDatumKontrole.Text),
                rok_trajanja = HelpClass.GetValueOrNull<DateTime>(dtpRokTrajanja.Text),
                kolicina = HelpClass.GetValueOrNull<int>(txtKolicina.Text),
                cijena = HelpClass.GetValueOrNull<decimal>(txtCijena.Text)
            };
            _lijekoviBAL.AddNewLijekoviObject(lijekovi);
        }
        #endregion
    }
}
