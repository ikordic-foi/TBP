//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_IvaKordic
{
    using System;
    using System.Collections.Generic;
    
    public partial class doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doktor()
        {
            this.doktor_pacijent = new HashSet<doktor_pacijent>();
            this.pregled = new HashSet<pregled>();
        }
    
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public int uloga { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doktor_pacijent> doktor_pacijent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pregled> pregled { get; set; }
    }
}
