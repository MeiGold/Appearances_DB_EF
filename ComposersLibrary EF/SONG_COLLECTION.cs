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
    
    public partial class SONG_COLLECTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SONG_COLLECTION()
        {
            this.SONGs = new HashSet<SONG>();
        }
    
        public int SNGC_ID { get; set; }
        public string SNGC_NAME { get; set; }
        public string SNGC_COLLECTOR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SONG> SONGs { get; set; }
    }
}