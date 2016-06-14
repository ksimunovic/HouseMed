using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class PacijentiDAL
    {
        #region private variables
        // instance DB context
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting ALL the "pacijenti" from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<pacijenti> GetAllPacijenti()
        {
            var pacijenti = (from a in context.pacijenti
                         select a).ToList();
            BindingList<pacijenti> lista = new BindingList<pacijenti>(pacijenti);
            return lista;
        }
        #endregion
    }
}
