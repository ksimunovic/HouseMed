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
    
    public partial class djelatnici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public djelatnici()
        {
            this.cijepljenje = new HashSet<cijepljenje>();
            this.postupci = new HashSet<postupci>();
            this.postupci1 = new HashSet<postupci>();
            this.uputnica = new HashSet<uputnica>();
            this.recepti = new HashSet<recepti>();
        }
    
        public int djelatniciID { get; set; }
        public Nullable<int> sifra_zdrv_ustanoveID { get; set; }
        public Nullable<int> OIB { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string mjesto { get; set; }
        public string ulica { get; set; }
        public string titula { get; set; }
        public string telefon { get; set; }
        public string mobitel { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cijepljenje> cijepljenje { get; set; }
        public virtual sifra_zdrv_ustanove sifra_zdrv_ustanove { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<postupci> postupci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<postupci> postupci1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uputnica> uputnica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recepti> recepti { get; set; }
    }
}
