using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class LijekoviBAL
    {
        #region private variables
        private LijekoviDAL _lijekoviDAL;
        #endregion

        #region constructor
        public LijekoviBAL()
        {
            _lijekoviDAL = new LijekoviDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Getting all the medications from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<lijekovi> GetAllLijekovi()
        {
            return _lijekoviDAL.GetAllLijekovi();
        }

        /// <summary>
        /// Getting medication from DB by name for filtering purposes 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BindingList<lijekovi> GetLijekoviByName(string name)
        {
            return _lijekoviDAL.GetLijekoviByName(name);
        }

        /// <summary>
        /// Adds "lijek" object into the DB
        /// </summary>
        /// <param name="lijek"></param>
        public void AddNewLijekoviObject(lijekovi lijek)
        {
            _lijekoviDAL.AddNewLijekoviObject(lijek);
        }
        #endregion
    }
}

