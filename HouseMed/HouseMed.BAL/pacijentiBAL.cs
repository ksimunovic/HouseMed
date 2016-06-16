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
        /// <summary>
        /// method for getting the "pacijenti" by Id from the DB
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        /*public BindingList<pacijentiCustom> GetAllPacijentiById(int pacijentId)
        {
            return _pacijentiDAL.GetAllPacijentiById(pacijentId);
        }*/


        public void AddNewPacijent(pacijenti pacijent)
        {
            _pacijentiDAL.AddNewPacijent(pacijent);
        }

        /// <summary>
        /// Remove patient by id
        /// </summary>
        /// <param name="pacijentiID"></param>
        public void RemovePatientById(int pacijentiID)
        {
            _pacijentiDAL.RemovePatientById(pacijentiID);
        }

        /// <summary>
        /// update pacijenta
        /// </summary>
        public void SaveChanges()
        {
            _pacijentiDAL.SaveChanges();
        }
        #endregion
    }
}
