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
    
    public partial class recepti
    {
        public int receptID { get; set; }
        public string slucaj { get; set; }
        public Nullable<int> lijekoviID { get; set; }
        public Nullable<int> kolicina { get; set; }
        public string doziranje { get; set; }
        public Nullable<bool> nadoplata { get; set; }
        public Nullable<int> pacijentiID { get; set; }
        public Nullable<int> djelatniciID { get; set; }
        public Nullable<int> sifra_zdrv_ustanoveID { get; set; }
    
        public virtual lijekovi lijekovi { get; set; }
        public virtual pacijenti pacijenti { get; set; }
        public virtual sifra_zdrv_ustanove sifra_zdrv_ustanove { get; set; }
        public virtual djelatnici djelatnici { get; set; }
    }
}
