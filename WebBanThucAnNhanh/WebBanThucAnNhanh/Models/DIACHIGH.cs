//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanThucAnNhanh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIACHIGH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIACHIGH()
        {
            this.DATHANGs = new HashSet<DATHANG>();
        }
    
        public int MADIACHI { get; set; }
        public Nullable<int> MAKHACHHANG { get; set; }
        public string HOTEN { get; set; }
        public int SDT { get; set; }
        public string SONHA { get; set; }
        public string PHUONG { get; set; }
        public string QUAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATHANG> DATHANGs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
