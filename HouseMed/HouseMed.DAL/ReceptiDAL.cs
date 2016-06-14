using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// <summary>
        /// Method for getting all the Recipes from the DB with full names
        /// </summary>
        /// <returns></returns>
        public BindingList<receptiCustom> GetAllReceptiNamedPropsById(int PacijentId)
        {
            try
            {
                var recepti = (from a in context.recepti
                               join b in context.lijekovi on a.lijekoviID equals b.lijekoviID
                               join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                               join d in context.djelatnici on a.djelatniciID equals d.djelatniciID
                               join e in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals e.sifra_zdrv_ustanoveID
                               where a.pacijentiID == PacijentId
                               select new receptiCustom()
                               {
                                   ReceptID = a.receptID,
                                   Slucaj = a.slucaj,
                                   LijekoviIDName = b.naziv,
                                   Kolicina = a.kolicina,
                                   Doziranje = a.doziranje,
                                   Nadoplata = a.nadoplata,
                                   PacijentiIDName = string.Concat(c.ime, " ", c.prezime),
                                   DjelatniciIDName = string.Concat(d.ime, " ", d.prezime),
                                   SifraZdrvUstanoveIDName = e.naziv
                               }).ToList();
                BindingList<receptiCustom> lista = new BindingList<receptiCustom>(recepti);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Adds new "Recept" into the DB
        /// </summary>
        public void AddNewRecept(recepti recept)
        {
            try
            {
                context.recepti.Add(recept);
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
