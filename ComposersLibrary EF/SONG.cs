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
    
    public partial class SONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SONG()
        {
            this.PERFORMANCEs = new HashSet<PERFORMANCE>();
            this.COMPOSERs = new HashSet<COMPOSER>();
        }
    
        public int SNG_ID { get; set; }
        public string SNG_CMP_ID { get; set; }
        public string SNG_NAME { get; set; }
        public string SNG_GENRE { get; set; }
        public Nullable<System.TimeSpan> SNG_DURATION { get; set; }
        public Nullable<int> SNG_PPS_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFORMANCE> PERFORMANCEs { get; set; }
        public virtual SONG_COLLECTION SONG_COLLECTION { get; set; }
        public virtual СSONG СSONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPOSER> COMPOSERs { get; set; }
    }
}
