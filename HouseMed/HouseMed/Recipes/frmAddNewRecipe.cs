using HouseMed.BAL;
using HouseMed.DAL;
using System;
using System.Windows.Forms;

namespace HouseMed.Recipes
{
    public partial class frmAddNewRecipe : Form
    {
        #region private variables
        private DjelatniciBAL _djelatniciBAL;
        #endregion

        #region constructor
        public frmAddNewRecipe()
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
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
            SetDjelatniciComboBox();
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
            // TODO: complete INSERT in DB
            recepti recepti = new recepti()
            {
                kolicina = HelpClass.GetValueOrNull<int>(txtKolicina.Text),
                nadoplata = HelpClass.GetValueOrNull<bool>(chckNadoplata.Text),
            };

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
        /// ComboBox[Djelatnici] event handler: take ID when the selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboDjelatnici_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region private methods
        /// <summary>
        /// Setting the combobox Djelatnici with values
        /// </summary>
        private void SetDjelatniciComboBox()
        {
            var lista = _djelatniciBAL.GetAllDjelatnici();
            comboDjelatnici.DataSource = lista;
            comboDjelatnici.ValueMember = "djelatniciID";
            comboDjelatnici.DisplayMember = "ImePrezime";
        }

        #endregion

        
    }
}
