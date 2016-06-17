using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class HospitalizacijaBAL
    {
        #region private varibales
        private HospitalizacijaDAL _hospitalizacijaDAL;
        #endregion

        #region constructor
        public HospitalizacijaBAL()
        {
            _hospitalizacijaDAL = new HospitalizacijaDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Getting ALL the "Hospitalizacija" from DB with custom prop names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<hospitalizacijaCustom> GetAllHospitalizacijaPropNamesById(int pacijentId)
        {
            return _hospitalizacijaDAL.GetAllHospitalizacijaPropNamesById(pacijentId);
        }

        /// <summary>
        /// dodavanje nove uputnice
        /// </summary>
        /// <param name="nalog"></param>
        public void AddNewNalog(evidencija_hospitalizacije nalog)
        {
            _hospitalizacijaDAL.AddNewNalog(nalog);
        }
        #endregion
    }
}
