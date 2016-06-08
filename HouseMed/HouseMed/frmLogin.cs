using HouseMed.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed
{
    public partial class frmLogin : Form
    {
        #region Variables
        // instance to access the methods
        DjelatniciBAL djelatniciData = new DjelatniciBAL();
        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Button methods
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var djelatniciLista = djelatniciData.GetAllDjelatnici();

            foreach (var it in djelatniciLista)
            {
                if (it.ime == txtUser.Text)
                {
                    using (frmMenu frm = new frmMenu())
                    {
                        this.Hide();
                        frm.ShowDialog();
                    }
                    this.Show();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Unijeli ste krive podatke\n");
                    sb.Append("Testni login: Ime = Ana");
                    MessageBox.Show(sb.ToString());
                }
            }
        }
        #endregion
    }
}
