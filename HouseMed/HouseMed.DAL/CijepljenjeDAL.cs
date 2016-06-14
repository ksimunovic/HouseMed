using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class CijepljenjeDAL
    {
        #region private variables
        // instance the context
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting "Cijepljenje" from DB with Full prop names for data grid views
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<cijepljenjeCustom> GetAllCijepPropNamesById(int pacijentId)
        {
            try
            {
                var cijepljenje = (from a in context.cijepljenje
                                   join b in context.djelatnici on a.djelatniciID equals b.djelatniciID
                                   join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                                   where a.pacijentiID == pacijentId
                                   select new cijepljenjeCustom()
                                   {
                                       BrojDoze = a.broj_doze,
                                       CijepljenjeId = a.cijepljenjeID,
                                       Slucaj = a.slucaj,
                                       Datum = a.datume,
                                       VrstaCijepljenja = a.vrsta_cijepljenja,
                                       PripravaCjepiva = a.prirava_cjepiva,
                                       Kolicina = a.kolicina,
                                       Djelatnik = string.Concat(b.ime," ", b.prezime),
                                       Pacijent = string.Concat(c.ime, " ", c.prezime)
                                   }).ToList();
                BindingList<cijepljenjeCustom> lista = new BindingList<cijepljenjeCustom>(cijepljenje);
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
