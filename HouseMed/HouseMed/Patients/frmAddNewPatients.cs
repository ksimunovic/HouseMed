using System;
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
        #region constructor
        public frmAddNewPatients()
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _receptiBAL = new ReceptiBAL();
        }

        #endregion

        #region private variables
        private DjelatniciBAL _djelatniciBAL;
                private ZdravUstanovaBAL _zdravUstanovaBAL;
                private ReceptiBAL _receptiBAL;
                private int _djelatniciID;
                private int _ustanovaID;
        #endregion





        #region form methods
        private void SetComboBox()
        {
            var listaZdravUstanova = _zdravUstanovaBAL.GetAllUstanove();
            comboBoxUstanova.DataSource = listaZdravUstanova;
            comboBoxUstanova.DisplayMember = "naziv";
            comboBoxUstanova.ValueMember = "sifra_zdrv_ustanoveID";
        }
        #endregion




        private void frmAddNewPatients_Load(object sender, EventArgs e)
        {
            SetComboBox();

        }
    }
}
