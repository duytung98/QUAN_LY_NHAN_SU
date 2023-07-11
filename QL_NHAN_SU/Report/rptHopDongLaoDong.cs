using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Businesslayer.DTO;
using System.Collections.Generic;

namespace QL_NHAN_SU.Report
{
    public partial class rptHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongLaoDong()
        {
            InitializeComponent();
        }
        public rptHopDongLaoDong(List<HopDongDTO>  listhd)
        {
            InitializeComponent();
            this._listhd = listhd;
            this.DataSource = _listhd;
            loatData();
        }
        List<HopDongDTO> _listhd;
        void loatData()
        {
            SoHD.DataBindings.Add("Text", _listhd, "So_HopDong");
        }
    }
}
