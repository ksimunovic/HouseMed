using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class HospitalizacijaDAL
    {
        #region private variables
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Getting ALL the "Hospitalizacija" from DB with custom prop names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<hospitalizacijaCustom> GetAllHospitalizacijaPropNamesById(int pacijentId)
        {
            var hospitalizacija = (from a in context.evidencija_hospitalizacije
                                   join b in context.pacijenti on a.pacijentiID equals b.pacijentiID
                                   where a.pacijentiID == pacijentId
                                   select new hospitalizacijaCustom()
                                   {
                                       HospitalizacijaId = a.evidencija_hospitalizacijeID,
                                       BoravioOdDatuma = a.boravio_od_datuma,
                                       BoravioDoDatuma = a.boravio_do_datuma,
                                       NazivBolnice = a.naziv_bolnice,
                                       Razlog = a.razlog,
                                       Pacijent = string.Concat(b.ime, " ", b.prezime)
                                   }).ToList();
            BindingList<hospitalizacijaCustom> lista = new BindingList<hospitalizacijaCustom>(hospitalizacija);
            return lista;
        }

        public void RemoveNalogByID(string evidencija_hospitalizacijeID)
        {
            var nalog = (from a in context.evidencija_hospitalizacije
                         where a.evidencija_hospitalizacijeID == evidencija_hospitalizacijeID
                         select a).FirstOrDefault();
            context.evidencija_hospitalizacije.Remove(nalog);
            context.SaveChanges();
        }

        public evidencija_hospitalizacije GetNalogByID(string IDnaloga)
        {
            var nalog = (from a in context.evidencija_hospitalizacije
                         where a.evidencija_hospitalizacijeID == IDnaloga
                         select a).FirstOrDefault();
            return nalog;
        }

        /// <summary>
        /// funkcija za update naloga u bazi
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch
            {
                throw;
            }

        }
        /// <summary>
        /// Adds new "Nalog" u bazu
        /// </summary>
        public void AddNewNalog(evidencija_hospitalizacije nalog)
        {
            try
            {
                context.evidencija_hospitalizacije.Add(nalog);
                context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Funkcija koja vraća novi id naloga
        /// </summary>
        /// <returns></returns>
        public int getNewID()
        {
            return (from u in context.evidencija_hospitalizacije select u).Count();
        }
        #endregion
    }
}
