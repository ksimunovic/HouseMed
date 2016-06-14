﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class UputnicaBAL
    {
        #region private variables
        private UputnicaDAL _uputnicaDAL;
        #endregion

        #region constructor
        public UputnicaBAL()
        {
            _uputnicaDAL = new UputnicaDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Gets all "Uputnica" from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<uputnica> GetAllUputnica()
        {
            return _uputnicaDAL.GetAllUputnica();
        }
        /// <summary>
        /// Method for getting all the Recipes from the DB with full names
        /// </summary>
        /// <returns></returns>
        public BindingList<uputnicaCustom> GetAllUputnicaPropsNameById(int pacijentId)
        {
            return _uputnicaDAL.GetAllUputnicaPropsNameById(pacijentId);
        }
        #endregion
    }
}