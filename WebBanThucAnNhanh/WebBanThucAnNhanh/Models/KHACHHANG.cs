﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
<<<<<<< HEAD
            this.HOADON = new HashSet<HOADON>();
        }
    
        public int MAKHACHHANG { get; set; }
=======
            this.HOADONs = new HashSet<HOADON>();
        }

        [Required(ErrorMessage = "ID not emty")]
        public int MAKHACHHANG { get; set; }

        [Required(ErrorMessage = "Name not emty")]
>>>>>>> teammate
        public string TENKHACHHANG { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }

        [Display(Name = "Địa chỉ ")]
        [Required(ErrorMessage = "Address not emty")]
        public string DIACHI { get; set; }
        public Nullable<int> SDT { get; set; }
        [Display(Name = "Email ")]
        [Required(ErrorMessage = "Email not emty")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EMAIL { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Pass not emty")]
        public string PASSWORD { get; set; }
        public string LOAI { get; set; }
<<<<<<< HEAD
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }
=======

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [NotMapped]
        [Compare("PASSWORD")]
        [Display(Name = "Nhập lại mật khẩu")]
        public string ComfirmPass { get; set; }

        [NotMapped]
        public string ErrorLogin { get; set; }
>>>>>>> teammate
    }
}
