﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUAN_LY_NHAN_SUEntities : DbContext
    {
        public QUAN_LY_NHAN_SUEntities()
            : base("name=QUAN_LY_NHAN_SUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KhenThuong_KyLuat> KhenThuong_KyLuat { get; set; }
        public virtual DbSet<T_Bang_Luong> T_Bang_Luong { get; set; }
        public virtual DbSet<T_BangCong> T_BangCong { get; set; }
        public virtual DbSet<T_BangCong_NVien_ChiTiet> T_BangCong_NVien_ChiTiet { get; set; }
        public virtual DbSet<T_BaoHiem> T_BaoHiem { get; set; }
        public virtual DbSet<T_BoPhan> T_BoPhan { get; set; }
        public virtual DbSet<T_ChucVu> T_ChucVu { get; set; }
        public virtual DbSet<T_confix> T_confix { get; set; }
        public virtual DbSet<T_DanToc> T_DanToc { get; set; }
        public virtual DbSet<T_DieuChuyen> T_DieuChuyen { get; set; }
        public virtual DbSet<T_HopDong> T_HopDong { get; set; }
        public virtual DbSet<T_Khoa> T_Khoa { get; set; }
        public virtual DbSet<T_KhoaDay> T_KhoaDay { get; set; }
        public virtual DbSet<T_Ky_Cong> T_Ky_Cong { get; set; }
        public virtual DbSet<T_KyCong_ChiTiet> T_KyCong_ChiTiet { get; set; }
        public virtual DbSet<T_LichLV> T_LichLV { get; set; }
        public virtual DbSet<T_LoaiCa> T_LoaiCa { get; set; }
        public virtual DbSet<T_LoaiCong> T_LoaiCong { get; set; }
        public virtual DbSet<T_LopDay> T_LopDay { get; set; }
        public virtual DbSet<T_MonDay> T_MonDay { get; set; }
        public virtual DbSet<T_NhanVien> T_NhanVien { get; set; }
        public virtual DbSet<T_NhanVien_NangLuong> T_NhanVien_NangLuong { get; set; }
        public virtual DbSet<T_NhanVienPhuCap> T_NhanVienPhuCap { get; set; }
        public virtual DbSet<T_NoiLamViec> T_NoiLamViec { get; set; }
        public virtual DbSet<T_PhongBan> T_PhongBan { get; set; }
        public virtual DbSet<T_PhongHoc> T_PhongHoc { get; set; }
        public virtual DbSet<T_PhuCap> T_PhuCap { get; set; }
        public virtual DbSet<T_TangCa> T_TangCa { get; set; }
        public virtual DbSet<T_THOIVIEC> T_THOIVIEC { get; set; }
        public virtual DbSet<T_TonGiao> T_TonGiao { get; set; }
        public virtual DbSet<T_TrinhDo> T_TrinhDo { get; set; }
        public virtual DbSet<T_UngLuong> T_UngLuong { get; set; }
    }
}
