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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLThucAnNhanhEntities : DbContext
    {
        public QLThucAnNhanhEntities()
            : base("name=QLThucAnNhanhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
<<<<<<< HEAD:WebBanThucAnNhanh/WebBanThucAnNhanh/Models/Model1.Context.cs
        public virtual DbSet<ADMIN> ADMIN { get; set; }
        public virtual DbSet<CT_MONAN_DATHANG> CT_MONAN_DATHANG { get; set; }
        public virtual DbSet<CTHOADON> CTHOADON { get; set; }
        public virtual DbSet<DATHANG> DATHANG { get; set; }
        public virtual DbSet<FEEDBACK> FEEDBACK { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAI { get; set; }
        public virtual DbSet<MONAN> MONAN { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TINHTRANGDON> TINHTRANGDON { get; set; }
        public virtual DbSet<THONGKEBAOCAO> THONGKEBAOCAO { get; set; }
=======
        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<CT_MONAN_DATHANG> CT_MONAN_DATHANG { get; set; }
        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<DATHANG> DATHANGs { get; set; }
        public virtual DbSet<FEEDBACK> FEEDBACKs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<MONAN> MONANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THONGKEBAOCAO> THONGKEBAOCAOs { get; set; }
        public virtual DbSet<TINHTRANGDON> TINHTRANGDONs { get; set; }
>>>>>>> teammate:WebBanThucAnNhanh/WebBanThucAnNhanh/Models/Model.Context.cs
    }
}
