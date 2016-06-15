using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class CijepljenjeBAL
    {
        #region private variables
        private CijepljenjeDAL _cijepljenjeDAL;
        #endregion

        #region constructor
        public CijepljenjeBAL()
        {
            _cijepljenjeDAL = new CijepljenjeDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting "Cijepljenje" from DB with Full prop names for data grid views
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<cijepljenjeCustom> GetAllCijepPropNamesById(int pacijentId)
        {
            return _cijepljenjeDAL.GetAllCijepPropNamesById(pacijentId);
        }
        #endregion
    }
}
