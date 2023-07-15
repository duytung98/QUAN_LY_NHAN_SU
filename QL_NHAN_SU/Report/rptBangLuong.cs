using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Datalayer;
using System.Collections.Generic;

namespace QL_NHAN_SU.Report
{
    public partial class rptBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangLuong()
        {
            InitializeComponent();
        }

        List<T_Bang_Luong> _lst;
        int _namky;
        public rptBangLuong(List<T_Bang_Luong> _listbangluong, int namky)
        {
            InitializeComponent();
            this._lst = _listbangluong;
            this._namky = namky;
            this.DataSource = _lst;
            lblThangnam.Text = "Tháng " + _namky.ToString().Substring(4) + "  năm  " + _namky.ToString().Substring(0,4);
            loaddata();
        }
        void loaddata()
        {

            MNV.DataBindings.Add("Text", DataSource, "id_NhanVien");
            HOTEN.DataBindings.Add("Text",DataSource, "HoTen");
            NGAYCONG.DataBindings.Add("Text", DataSource, "NgayCongTrongThang");
            LUONGPHEP.DataBindings.Add("Text", DataSource, "NgayPhep");
            LUONGCN.DataBindings.Add("Text", DataSource, "NgayChuNhat");
            LUONGNGAYTHUONG.DataBindings.Add("Text", DataSource, "NgayThuong");
            LUONGNL.DataBindings.Add("Text", DataSource, "NgayLe");
            PHUCAP.DataBindings.Add("Text", DataSource, "PhuCap");
            UNGLUONG.DataBindings.Add("Text", DataSource, "UngLuong");
            THUCLANH.DataBindings.Add("Text", DataSource, "ThucLanh");
            TANGCA.DataBindings.Add("Text", DataSource, "Tangca");
        }
    }
}
