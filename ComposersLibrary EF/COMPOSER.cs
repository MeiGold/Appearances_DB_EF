//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComposersLibrary_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPOSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPOSER()
        {
            this.SONGs = new HashSet<SONG>();
        }
    
        public int CMP_ID { get; set; }
        public string CMP_FULL_NAME { get; set; }
        public string CMP_NATIONALITY { get; set; }
        public Nullable<System.DateTime> CMP_BIRTH_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SONG> SONGs { get; set; }
    }
}