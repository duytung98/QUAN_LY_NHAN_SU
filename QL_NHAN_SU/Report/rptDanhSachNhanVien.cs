using Businesslayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Datalayer;

namespace QL_NHAN_SU.Report
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NhanVienDTO> _listNV;
        public rptDanhSachNhanVien(List<NhanVienDTO> lstNV)
        {
            InitializeComponent();
            this._listNV = lstNV;
            this.DataSource = _listNV;
            loadData();
        }
        void loadData()
        {
            lbl_id1.DataBindings.Add("Text", _listNV, "id_NhanVien");
            lbl_HT1.DataBindings.Add("Text", _listNV, "HoTen");
            lb_NS1.DataBindings.Add("Text", _listNV, "NgaySinh");
            lb_GT1.DataBindings.Add("Text", _listNV, "GioiTinh");
            lb_DT1.DataBindings.Add("Text", _listNV, "DienThoai");
            lb_em2.DataBindings.Add("Text", _listNV, "Email");
            lb_CC2.DataBindings.Add("Text", _listNV, "CCCD");
            lb_dc2.DataBindings.Add("Text", _listNV, "DiaChi");
            lb_pb2.DataBindings.Add("Text", _listNV, "Ten_PhongBan");
            lb_BP2.DataBindings.Add("Text", _listNV, "Ten_BoPhan");
            lb_CV2.DataBindings.Add("Text", _listNV, "Ten_ChucVu");
            lb_TD2.DataBindings.Add("Text", _listNV, "Ten_TrinhDo");
            lb_DT2.DataBindings.Add("Text", _listNV, "DanToc");
            lb_tG2.DataBindings.Add("Text", _listNV, "TonGiao");
        }
    }
}
