using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.BAL
{
    public class PacijentiBAL
    {
        #region private variables
        private PacijentiDAL _pacijentiDAL;
        #endregion

        #region constructor
        public PacijentiBAL()
        {
            _pacijentiDAL = new PacijentiDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// method for getting all the "pacijenti" from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<pacijenti> GetAllPacijenti()
        {
            return _pacijentiDAL.GetAllPacijenti();
        }
        #endregion
    }
}
