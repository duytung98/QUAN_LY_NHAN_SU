using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer.DTO
{
    public class LichLamViecDTO
    {
        public int id_LichLamViec { get; set; }
        public Nullable<int> id_NhanVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<int> id_NoiLV { get; set; }
        public string Ten_NoiLV { get; set; }
        public Nullable<int> id_Khoa { get; set; }
        public string Ten_Khoa { get; set; }
        public Nullable<int> id_KhoaDay { get; set; }
        public string Ten_KhoaDay { get; set; }
        public Nullable<int> id_LopDay { get; set; }
        public string Ten_LopDay { get; set; }
        public Nullable<int> id_MonDay { get; set; }
        public string Ten_MonDay { get; set; }
        public Nullable<int> id_PhongHoc { get; set; }
        public string Ten_PhongHoc { get; set; }
        public Nullable<int> SoTin { get; set; }
        public Nullable<System.DateTime> ThoiGianBD { get; set; }
        public Nullable<System.DateTime> ThoiGianKT { get; set; }
        public Nullable<int> id_LoaiCa { get; set; }
        public string TenLoaiCa { get; set; }
        public Nullable<int> CREATEO_BY { get; set; }
        public Nullable<System.DateTime> CREATEO_DATE { get; set; }
        public Nullable<int> UPDATEO_BY { get; set; }
        public Nullable<System.DateTime> UPDATEO_DATE { get; set; }
        public Nullable<int> DELETEO_BY { get; set; }
        public Nullable<System.DateTime> DELETEO_DATE { get; set; }
    }
}
