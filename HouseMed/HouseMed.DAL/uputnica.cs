//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseMed.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class uputnica
    {
        public int uputnicaID { get; set; }
        public Nullable<int> pacijentID { get; set; }
        public Nullable<int> sifra_zdrv_ustanoveID { get; set; }
        public string upucuje_se { get; set; }
        public string dijagnoza { get; set; }
        public string trazi_se { get; set; }
        public string napomena { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public Nullable<int> djelatniciID { get; set; }
    
        public virtual pacijenti pacijenti { get; set; }
        public virtual sifra_zdrv_ustanove sifra_zdrv_ustanove { get; set; }
        public virtual djelatnici djelatnici { get; set; }
    }
}
