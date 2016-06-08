using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class ReceptiDAL
    {
        #region private variables
        // instance the context DB
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting ALL the recipes from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<recepti> GetAllRecepti()
        {
            try
            {
                var recepti = (from a in context.recepti
                               select a).ToList();
                BindingList<recepti> lista = new BindingList<recepti>(recepti);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        #endregion

    }
}
