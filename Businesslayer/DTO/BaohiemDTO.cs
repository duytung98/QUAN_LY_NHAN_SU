using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer.DTO
{
    public class BaohiemDTO
    {
        public int id_BaoHiem { get; set; }
        public string So_BaoHiem { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string Noi_DK_Kham_Benh { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> DELETE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> CREATEO_BY { get; set; }
        public Nullable<System.DateTime> CREATEO_DATE { get; set; }
    }
}
