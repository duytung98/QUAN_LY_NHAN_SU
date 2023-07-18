using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.DTO
{
    public class NhanvienThoiViecDTO
    {
        public string SOQDTV { get; set; }
        public string NGAYNOPDON { get; set; }
        public string NGAYNGHI { get; set; }
        public string LYDO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<int> CREATEO_BY { get; set; }
        public Nullable<System.DateTime> CREATEO_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
    }
}
