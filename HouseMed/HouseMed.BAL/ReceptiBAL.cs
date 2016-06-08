using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.BAL
{
    public class ReceptiBAL
    {
        #region private variables
        private ReceptiDAL _receptiDal;
        #endregion

        #region consturctor
        public ReceptiBAL()
        {
            _receptiDal = new ReceptiDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Returns all the "Recepti" from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<recepti> GetALLRecepti()
        {
            return _receptiDal.GetAllRecepti();
        }
        #endregion

    }
}
