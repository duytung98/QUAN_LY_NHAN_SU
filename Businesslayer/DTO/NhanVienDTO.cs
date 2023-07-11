using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer.DTO
{
    public class NhanVienDTO
    {
        public int id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public byte[] HinhAnh { get; set; }
        public string PhanQuyen { get; set; }
        public bool? THOIVIEC { get; set; }
        public Nullable<int> id_NoiLV { get; set; }
        public string Ten_NoiLV { get; set; }
        public Nullable<int> id_PhongBan { get; set; }
        public string Ten_PhongBan { get; set; }
        public Nullable<int> id_BoPhan { get; set; }
        public string Ten_BoPhan { get; set; }
        public Nullable<int> id_ChucVu { get; set; }
        public string Ten_ChucVu { get; set; }
        public Nullable<int> id_TrinhDo { get; set; }
        public string Ten_TrinhDo { get; set; }
        public Nullable<int> id_DanToc { get; set; }
        public string DanToc { get; set; }
        public Nullable<int> id_TonGiao { get; set; }
        public string TonGiao { get; set; }
        public string Password { get; set; }
    }
}
