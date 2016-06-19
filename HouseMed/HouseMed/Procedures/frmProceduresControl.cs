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
using HouseMed.Raspored;

namespace HouseMed.Procedures
{
    public partial class frmProceduresControl : Form
    {
        private PostupciBAL _postupciBAL;
        private DjelatniciBAL _djelatniciBAL;
        private pacijenti trenutniPacijent = frmMenu.trenutniPacijent;

        public frmProceduresControl()
        {
            _postupciBAL = new PostupciBAL();
            _djelatniciBAL = new DjelatniciBAL();
            
            InitializeComponent();
            dgvPostupciPacijenta.DataSource = _postupciBAL.GetAllPostupciPropNamesById(trenutniPacijent.pacijentiID);
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            frmAddNewPregled frm = new frmAddNewPregled(trenutniPacijent); //TODO: Proslijediti i ustanovu za koju se radi raspored
            frm.Show();
        }
    }
}
