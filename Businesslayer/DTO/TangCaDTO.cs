using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer.DTO
{
    
   public class TangCaDTO
    {
        public int id_TangCa { get; set; }
        public Nullable<int> Nam { get; set; }
        public Nullable<int> Thang { get; set; }
        public Nullable<int> Ngay { get; set; }
        public Nullable<double> SoGioTangCa { get; set; }
        public Nullable<int> id_LoaiCa { get; set; }
        public string TenLoaiCa { get; set; }
        public double? HeSo { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
        public Nullable<int> CREATE0_BY { get; set; }
        public Nullable<System.DateTime> CREATE0_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
    }
}
