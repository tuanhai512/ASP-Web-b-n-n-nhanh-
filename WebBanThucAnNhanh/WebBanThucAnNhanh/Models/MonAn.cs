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
    using System.Web;

    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            HINHANH = "~/Assets/admin/img/photo-1.jpg";
            this.CT_MONAN_DATHANG = new HashSet<CT_MONAN_DATHANG>();
        }
        [Required(ErrorMessage = "Vui lòng nhập lại Mã món ăn")]
        public string MAMONAN { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập lại Tên Món Ăn")]
        public string TENMONAN { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn Hình Ảnh")]
        public string HINHANH { get; set; }
        [Required(ErrorMessage = "Vui lòng Chọn Đơn Vị Tính")]
        public int MADONVITINH { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập lại Giá Bán")]
        public double GIABAN { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập lại Mô Tả")]
        public string MOTA { get; set; }
        [Required(ErrorMessage = "Vui lòng Chọn lại Loại")]
        public string MALOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MONAN_DATHANG> CT_MONAN_DATHANG { get; set; }
        public virtual DONVITINH DONVITINH { get; set; }
        public virtual LOAI LOAI { get; set; }
        [NotMapped]
        public HttpPostedFileBase UploadImage { get; set; }

        [NotMapped]
        public string ErrorLogin { get; set; }
    }
}
