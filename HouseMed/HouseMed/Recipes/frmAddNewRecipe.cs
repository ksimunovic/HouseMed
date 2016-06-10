using HouseMed.BAL;
using HouseMed.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace HouseMed.Recipes
{
    public partial class frmAddNewRecipe : Form
    {
        public static class GetObjects
        {
            public static pacijenti pacijenti { get; set; }
            public static lijekovi lijekovi { get; set; }
        }
        #region private variables
        private DjelatniciBAL _djelatniciBAL;
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private int _djelatniciID;
        private int _ustanovaID;
        #endregion

        #region constructor
        public frmAddNewRecipe()
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
        }
        #endregion

        #region form methods
        /// <summary>
        /// form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewRecipe_Load(object sender, EventArgs e)
        {
            SetComboBox();
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Button[OK] event handler: Insert new recipe in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            SetNewRecipeObject();
        }
        /// <summary>
        /// Button[Odustani] event handler: Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Button[Odaberi] "Lijekovi" event handler: Open new form to select the medication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseMedicine_Click(object sender, EventArgs e)
        {
            frmMedicationSelect frm = new frmMedicationSelect();
            frm.ShowDialog();
            if(GetObjects.lijekovi != null)
            {
                txtLijekovi.Text = GetObjects.lijekovi.naziv;
            }
            
        }
        /// <summary>
        /// ComboBox[Djelatnici] event handler: take djelatnici ID when the selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboDjelatnici_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboDjelatnici.SelectedItem as djelatnici;
            _djelatniciID = selectedItem.djelatniciID;
        }
        /// <summary>
        /// ComboBox[Ustanove] event handler: take ustanova ID when selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboUstanova_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboUstanova.SelectedItem as sifra_zdrv_ustanove;
            _ustanovaID = selectedItem.sifra_zdrv_ustanoveID;
        }
        #endregion

        #region private methods
        /// <summary>
        /// Setting the combobox Djelatnici and Ustanova with values
        /// </summary>
        private void SetComboBox()
        {
            var listaDjelatnici = _djelatniciBAL.GetAllDjelatnici();
            var listaZdravUstanova = _zdravUstanovaBAL.GetAllUstanove();

            // set djelatnici
            comboDjelatnici.DataSource = listaDjelatnici;
            comboDjelatnici.DisplayMember = "ImePrezime";
            comboDjelatnici.ValueMember = "djelatniciID";

            // set ustanove
            comboUstanova.DataSource = listaZdravUstanova;
            comboUstanova.DisplayMember = "naziv";
            comboUstanova.ValueMember = "sifra_zdrv_ustanoveID";

        }
        /// <summary>
        /// Instancing a new recipe object
        /// </summary>
        private void SetNewRecipeObject()
        {
            // TODO: complete INSERT in DB and in OK button
            recepti recepti = new recepti()
            {
                kolicina = HelpClass.GetValueOrNull<int>(txtKolicina.Text),
                nadoplata = HelpClass.GetValueOrNull<bool>(chckNadoplata.Text),
                djelatniciID = _djelatniciID,
                sifra_zdrv_ustanoveID = _ustanovaID,
                pacijentiID = GetObjects.pacijenti.pacijentiID,
                lijekoviID = GetObjects.lijekovi.lijekoviID,
                doziranje = txtDoziranje.Text,
                slucaj = txtSlucaj.Text
            };
        }
        #endregion
        
    }
}
