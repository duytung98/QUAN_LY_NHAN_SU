using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Businesslayer.DTO;
using System.Collections.Generic;

namespace QL_NHAN_SU.Report
{
    public partial class rptNangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptNangLuong()
        {
            InitializeComponent();
        }
        public rptNangLuong(List<NhanVien_NangLuongDTO> lstnlDTO)
        {
            InitializeComponent();
            this._nl = lstnlDTO;
            this.DataSource = _nl;
            loatdata();
        }
        List<NhanVien_NangLuongDTO> _nl;
        void loatdata()
        {
            SoNL.DataBindings.Add("Text", _nl, "SQDNL");
            
        }
    }
}
