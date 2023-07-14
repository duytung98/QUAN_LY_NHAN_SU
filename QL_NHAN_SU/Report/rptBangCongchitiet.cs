using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Datalayer;
using System.Collections.Generic;

namespace QL_NHAN_SU.Report
{
    public partial class rptBangCongchitiet : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangCongchitiet()
        {
            InitializeComponent();
        }
        public List<T_BangCong_NVien_ChiTiet> _bcct;
        public rptBangCongchitiet(List<T_BangCong_NVien_ChiTiet> bcct)
        {
            InitializeComponent();
            this._bcct = bcct;
            this.DataSource = _bcct;
            bidingData();
        }
        void bidingData()
        {
            lblmakycong.DataBindings.Add("Text", DataSource, "MaKyCong");
            lbl_idnv.DataBindings.Add("Text", DataSource, "id_NhanVien");
            lbl_ten.DataBindings.Add("Text", DataSource, "HoTen");
            NGAY.DataBindings.Add("Text", DataSource, "Ngay");
            THU.DataBindings.Add("Text", DataSource, "Thu");
            GIOvAO.DataBindings.Add("Text", DataSource, "GioVao");
            GIORA.DataBindings.Add("Text", DataSource, "GioRa");
            NGAYLE.DataBindings.Add("Text", DataSource, "CongNgayLe");
            NGAYPHEP.DataBindings.Add("Text", DataSource, "NgayPhep");
            CHUNHAT.DataBindings.Add("Text", DataSource, "CongChuNhat");
            NGAYCONG.DataBindings.Add("Text", DataSource, "NgayCong");
            KyHieu.DataBindings.Add("Text", DataSource, "KyHieu");
            
        }
    }
}
