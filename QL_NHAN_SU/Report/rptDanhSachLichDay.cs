using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Businesslayer.DTO;

namespace QL_NHAN_SU.Report
{
    public partial class rptDanhSachLichDay : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachLichDay()
        {
            InitializeComponent();
        }
        List<LichLamViecDTO> _lstLichLV;
        public rptDanhSachLichDay(List<LichLamViecDTO> lstLichLV)
        {
            InitializeComponent();
            this._lstLichLV = lstLichLV;
            this.DataSource = _lstLichLV;
            loaddata();
        }
        void loaddata()
        {
            ID_STT.DataBindings.Add("Text", _lstLichLV, "id_LichLamViec");
            HOTEN.DataBindings.Add("Text", _lstLichLV, "HoTen");
            noiday.DataBindings.Add("Text", _lstLichLV, "Ten_NoiLV");
            KHOA.DataBindings.Add("Text", _lstLichLV, "Ten_Khoa");
            KHOAHOC.DataBindings.Add("Text", _lstLichLV, "Ten_KhoaDay");
            LOP.DataBindings.Add("Text", _lstLichLV, "Ten_LopDay");
            MONDAY.DataBindings.Add("Text", _lstLichLV, "Ten_MonDay");
            PHONGHOC.DataBindings.Add("Text", _lstLichLV, "Ten_PhongHoc");
            SOTIN.DataBindings.Add("Text", _lstLichLV, "SoTin");
            TGBD.DataBindings.Add("Text", _lstLichLV, "ThoiGianBD");
            TGKT.DataBindings.Add("Text", _lstLichLV, "ThoiGianKT");
            CA.DataBindings.Add("Text", _lstLichLV, "TenLoaiCa");
        }

    }
}
