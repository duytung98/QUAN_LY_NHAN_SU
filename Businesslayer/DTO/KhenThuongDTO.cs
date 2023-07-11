using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Businesslayer.DTO
{
    public class KhenThuongDTO
    {
        public string SoQuyetDinh { get; set; }
        public string LyDo { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> Loai { get; set; }
        public Nullable<System.DateTime> TuNgay { get; set; }
        public Nullable<System.DateTime> DenNgay { get; set; }
        public Nullable<int> CREATE0_BY { get; set; }
        public Nullable<System.DateTime> CREATE0_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
    }
}
