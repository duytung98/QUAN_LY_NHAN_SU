//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datalayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_LoaiCong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_LoaiCong()
        {
            this.T_BangCong = new HashSet<T_BangCong>();
        }
    
        public int id_LoaiCong { get; set; }
        public string Ten_LoaiCong { get; set; }
        public Nullable<double> HeSo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_BangCong> T_BangCong { get; set; }
    }
}
