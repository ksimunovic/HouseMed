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
    public partial class frmUputnice : Form 
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
            btnObrisi.Enabled = false;
            btnUredi.Enabled = false;
        }
        /// <summary>
        /// Click Event za gumb te otvaranje nove forme i osvjezavanje podataka na datagridu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovaUputnica_Click(object sender, EventArgs e)
        {
            frmAddNewUputnice frm = new frmAddNewUputnice();
            frm.ShowDialog();
            RefreshDatagrid();
        }

        /// <summary>
        /// event handler za btnObrisi te pozivanje funkcije za brisanje i osvjezavanje podataka u datagridu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            deleteUputnica();
            RefreshDatagrid();
        }

        /// <summary>
        /// event handler za klik reda na datagridu koji dopusta guma uredi i obrisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUputnice_SelectionChanged(object sender, EventArgs e)
        {
            btnObrisi.Enabled = true;
            btnUredi.Enabled = true;
        }


        #endregion
        /// <summary>
        /// funkcija za punjenje datagrida s podacima
        /// </summary>
        #region private methods
        private void RefreshDatagrid()
        {
            dgvUputnice.DataSource = _uputnicaBAL.GetAllUputnicaPropsName();    


        }


        /// <summary>
        /// dobivanje uputnice po selected id i poziv funkcije za brisanje odabranog reda
        /// </summary>
        private void deleteUputnica()
        {
            var selectedItem = dgvUputnice.CurrentRow.DataBoundItem as uputnicaCustom;

            if (selectedItem != null)
            {

               _uputnicaBAL.RemoveUputnicaById(selectedItem.UputnicaId);


            }
        }



        #endregion

        private void btnUredi_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvUputnice.CurrentRow.DataBoundItem as uputnicaCustom;
            frmAddNewUputnice frm = new frmAddNewUputnice(selectedItem);
            frm.ShowDialog();
            RefreshDatagrid();
        }
    }
}
