using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class djelatniciDAL
    {
        // instance the DB entities so we can use it as a context for queries
        DAL.HouseMedDBEntities context = new HouseMedDBEntities();


        /// <summary>
        /// Method for getting all the workers in the hospital
        /// </summary>
        /// <returns></returns>
        public IEnumerable<djelatnici> ReadDjelatnici()
        {
            try
            {
                return (from a in context.djelatnici
                           select a).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
