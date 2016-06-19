using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HouseMed.DAL
{
    public class LijekoviDAL
    {
        #region private variables
        // instance the context
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Getting ALL the medication from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<lijekovi> GetAllLijekovi()
        {
            try
            {
                var lijekovi = (from a in context.lijekovi
                                select a).ToList();
                BindingList<lijekovi> lista = new BindingList<DAL.lijekovi>(lijekovi);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Getting the medication by name for filtering purposes
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BindingList<lijekovi> GetLijekoviByName(string name)
        {
            try
            {
                var lijekovi = (from a in context.lijekovi
                                where a.naziv.Contains(name) || a.kolicina.ToString().Contains(name) 
                                select a).ToList();
                BindingList<lijekovi> lista = new BindingList<DAL.lijekovi>(lijekovi);
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Deleting the lijekovi object from the DB
        /// </summary>
        /// <param name="selectedLijek"></param>
        /// <returns></returns>
        public bool DeleteLijek(lijekovi selectedLijek)
        {
            try
            {
                context.lijekovi.Remove(selectedLijek);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Adds "lijek" object into the DB
        /// </summary>
        /// <param name="lijek"></param>
        public void AddNewLijekoviObject(lijekovi lijek)
        {
            context.lijekovi.Add(lijek);
            context.SaveChanges();
        }
        /// <summary>
        /// Saving the changes in the database
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
        }
        #endregion
    }
}
