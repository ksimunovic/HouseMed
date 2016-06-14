using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class RasporedDAL
    {
        #region private variables
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting ALL "Raspored" from DB with custom prop names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<rasporedCustom> GetAllRasporedPropNamesById(int pacijentId)
        {
            var raspored = (from a in context.raspored
                            join b in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals b.sifra_zdrv_ustanoveID
                            join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                            where a.pacijentiID == pacijentId
                            select new rasporedCustom()
                            {
                                RaposredId = a.rasporedID,
                                Datum = a.datum,
                                Vrijeme = a.vrijeme,
                                Ustanova = b.naziv,
                                Pacijent = string.Concat(c.ime," ", c.prezime),
                                Opis = a.opis
                            }).ToList();
            BindingList<rasporedCustom> lista = new BindingList<rasporedCustom>(raspored);
            return lista;
        }
        #endregion
    }
}
