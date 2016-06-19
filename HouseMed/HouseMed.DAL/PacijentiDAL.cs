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
        /// Remove patient by id
        /// </summary>
        /// <param name="pacijentiID"></param>
        public void RemovePatientById(int pacijentiID)
        {
            var pacijent = (from a in context.pacijenti
                            where a.pacijentiID == pacijentiID
                            select a).FirstOrDefault();

            context.pacijenti.Remove(pacijent);
            context.SaveChanges();
        }

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
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// funkcija za update pacijenta u bazi
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            #endregion
        }
        /// <summary>
        /// dobivanje pacijenata po trazenom textu
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BindingList<pacijenti> GetAllPacijentiBy(string name)
        {
            try
            {
                var pacijenti = (from a in context.pacijenti
                                where a.OIB.ToString().Contains(name) || a.ime.Contains(name) || a.prezime.Contains(name) || a.mjesto.Contains(name) || a.adresa.Contains(name) || a.drzava.Contains(name) || a.email.Contains(name) || a.mobitel.Contains(name) || a.spol.Contains(name)
                                select a).ToList();
                BindingList<pacijenti> lista = new BindingList<DAL.pacijenti>(pacijenti);
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
