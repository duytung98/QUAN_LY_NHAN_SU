using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer.DTO
{
    public class UngLuongDTO
    {
        public int id_UngLuong { get; set; }
        public Nullable<int> Nam_Ung { get; set; }
        public Nullable<int> Thang_Ung { get; set; }
        public Nullable<int> Ngay_Ung { get; set; }
        public Nullable<double> So_Tien_Ung { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> CREATEO_BY { get; set; }
        public Nullable<System.DateTime> CREATEO_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
    }
}
