//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok3.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_urunler()
        {
            this.tbl_satislar = new HashSet<tbl_satislar>();
        }
    
        public int urunid { get; set; }
        public string urunad { get; set; }
        public string marka { get; set; }
        public Nullable<short> urunkat { get; set; }
        public Nullable<decimal> fiyat { get; set; }
        public Nullable<int> stok { get; set; }
    
        public virtual tbl_kat tbl_kat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_satislar> tbl_satislar { get; set; }
    }
}