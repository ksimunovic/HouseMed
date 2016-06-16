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
using HouseMed.Uputnice;

namespace HouseMed.Uputnice
{
    public partial class frmUputnice : Form //temp komentar
    {
        #region private variables
        private PacijentiBAL _pacijentiBAL;
        private ReceptiBAL _receptiBAL;
        private UputnicaBAL _uputnicaBAL;
        private CijepljenjeBAL _cijepljenjeBAL;
        private PostupciBAL _postupciBAL;
        private HospitalizacijaBAL _hospitalizacijaBAL;
        private RasporedBAL _rasporedBAL;
        #endregion

        #region constructor
        public frmUputnice()
        {
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _uputnicaBAL = new UputnicaBAL();
            _cijepljenjeBAL = new CijepljenjeBAL();
            _postupciBAL = new PostupciBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            _rasporedBAL = new RasporedBAL();
        }
        #endregion

        #region event handler


        /// <summary>
        /// lodanje forme poziva funkciju za punjenje datagrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUputnice_Load(object sender, EventArgs e)
        {
            RefreshDatagrid();
        }

        private void btnNovaUputnica_Click(object sender, EventArgs e)
        {
            frmAddNewUputnice frm = new frmAddNewUputnice();
           //afasfsa
            frm.ShowDialog();
            int a;
            int b;
            int c;
            RefreshDatagrid();
        }

        #endregion

        #region private methods
        private void RefreshDatagrid()
        {
            dgvUputnice.DataSource = _uputnicaBAL.GetAllUputnica();

        }

        #endregion

      
    }
}
