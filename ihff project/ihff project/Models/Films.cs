//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ihff_project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Films
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Films()
        {
            this.Voorstellingen = new HashSet<Voorstellingen>();
        }
    
        public int Film_ID { get; set; }
        public string Genre { get; set; }
        public string Beschrijving { get; set; }
        public Nullable<double> IMDb_rating { get; set; }
        public string Image_path { get; set; }
        public string Acteurs { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voorstellingen> Voorstellingen { get; set; }
    }
}
