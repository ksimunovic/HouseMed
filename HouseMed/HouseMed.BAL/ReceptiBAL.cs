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
        private ReceptiDAL _receptiDAL;
        #endregion

        #region consturctor
        public ReceptiBAL()
        {
            _receptiDAL = new ReceptiDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Returns all the "Recepti" from the DB to bind the bindingsource
        /// </summary>
        /// <returns></returns>
        public BindingList<recepti> GetALLRecepti()
        {
            return _receptiDAL.GetAllRecepti();
        }
        /// <summary>
        /// Returns all the "Recepti" from the DB with ID names not values
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BindingList<receptiCustom> GetAllReceptiNamedPropsById(int PacijentId)
        {
            return _receptiDAL.GetAllReceptiNamedPropsById(PacijentId);
        }
        #endregion

    }
}
