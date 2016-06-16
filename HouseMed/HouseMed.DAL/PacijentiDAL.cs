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


        /// <summary>
        /// Method for getting the "pacijenti" by ID patient from the DB
        /// </summary>
        /// <returns></returns>
       /* public BindingList<pacijentiCustom> GetAllPacijentiById(int pacijentId)
        {
            var pacijenti = (from a in context.pacijenti
                             where a.pacijentiID == pacijentId
                             select a).ToList();
            BindingList<pacijentiCustom> lista = new BindingList<pacijentiCustom>(pacijenti);
           return lista;
        }*/

        /// <summary>
        /// Adds new "Pacijent" u bazu
        /// </summary>
        public void AddNewPacijent(pacijenti pacijent)
        {
            try
            {
                context.pacijenti.Add(pacijent);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion
    }
}
