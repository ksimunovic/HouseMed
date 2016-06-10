using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;

namespace HouseMed.BAL
{
    public class ZdravUstanovaBAL
    {
        #region private variables
        private ZdravUstanovaDAL _zdravUstanova;
        #endregion

        #region public methods
        public IEnumerable<sifra_zdrv_ustanove> GetAllUstanove()
        {
            _zdravUstanova = new ZdravUstanovaDAL();
            return _zdravUstanova.GetAllUstanove();
        }
        #endregion
    }
}
