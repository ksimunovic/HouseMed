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
//using LoadingScreen;

namespace HouseMed
{
    public partial class frmLogin : Form
    {
        #region Variables
        // instance to access the methods
        DjelatniciBAL djelatniciData = new DjelatniciBAL();
        //SlideShow _image;
        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
            //_image = new SlideShow();
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Timer event for swithching the images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureTimer_Tick(object sender, EventArgs e)
        {
            SetImagesLoadingScreen();
        }
        /// <summary>
        /// Form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            SetImagesLoadingScreen();
            pictureTimer.Start();
        }
        /// <summary>
        /// TODO: make good login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        #region private methods
        /// <summary>
        /// Method for setting images in the loading screen
        /// </summary>
        private void SetImagesLoadingScreen()
        {
           // Image imgTemp = (Image)_image.GetImage();
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.StretchImage;
           // pictureBoxLoading.Image = imgTemp;
        }
        #endregion

    }
}
