using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer.DTO
{
    public class PhuCapDTo
    {
        public int id_NhanVienPhuCap { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<int> id_PhuCap { get; set; }
        public string Ten_PhuCap { get; set; }
        public Nullable<System.DateTime> NgayPhuCap { get; set; }
        public string NoiDungPhuCap { get; set; }
        public Nullable<double> SoTien { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
        public Nullable<int> CREATEO_BY { get; set; }
        public Nullable<System.DateTime> CREATEO_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
    }
}
