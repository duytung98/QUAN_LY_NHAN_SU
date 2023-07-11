using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.DTO
{
    public class NhanVien_NangLuongDTO
    {
        public string SQDNL { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public string So_HopDong { get; set; }
        public Nullable<double> HeSoLuongHT { get; set; }
        public Nullable<double> HSLuongMoi { get; set; }
        public Nullable<System.DateTime> NgayLenLuong { get; set; }
        public Nullable<System.DateTime> NgayKy { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> CREATEO_BY { get; set; }
        public Nullable<System.DateTime> CREATEO_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
    }
}
