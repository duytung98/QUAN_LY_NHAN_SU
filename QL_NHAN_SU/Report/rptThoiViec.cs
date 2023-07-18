using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Businesslayer.DTO;
using System.Collections.Generic;

namespace QL_NHAN_SU.Report
{
    public partial class rptThoiViec : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThoiViec()
        {
            InitializeComponent();
        }
        public rptThoiViec(List<NhanvienThoiViecDTO> lstnlDTO)
        {
            InitializeComponent();
            this._nl = lstnlDTO;
            this.DataSource = _nl;
            loatdata();
        }
        List<NhanvienThoiViecDTO> _nl;
        void loatdata()
        {
            SoQD.DataBindings.Add("Text", _nl, "SOQDTV");

        }

    }
}
