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
    
    public partial class СSONG
    {
        public int СSNG_ID { get; set; }
        public string СSNG_NAME { get; set; }
        public Nullable<System.DateTime> СSNG_PUBLISHING_YEAR { get; set; }
    
        public virtual SONG SONG { get; set; }
    }
}
