using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.DTO
{
    public class DieuChuyenDTO
    {
        public string SoDieuChuyen { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<int> id_PhongBan { get; set; }
        public string Ten_PhongBan { get; set; }
        public Nullable<int> id_PhongBan2 { get; set; }
        public string Ten_PhongBan2 { get; set; }
        public string LiDo { get; set; }
        public string Ghichu { get; set; }
        public Nullable<int> CREATEO_BY { get; set; }
        public Nullable<System.DateTime> CREATEO_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
    }
}
