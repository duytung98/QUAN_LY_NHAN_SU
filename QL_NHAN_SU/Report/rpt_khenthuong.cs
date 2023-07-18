using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Businesslayer.DTO;
using System.Collections.Generic;

namespace QL_NHAN_SU.Report
{
    public partial class rpt_khenthuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_khenthuong()
        {
            InitializeComponent();
        }
        public rpt_khenthuong(List<KhenThuongDTO> lstnlDTO)
        {
            InitializeComponent();
            this._nl = lstnlDTO;
            this.DataSource = _nl;
            loatdata();
        }
        List<KhenThuongDTO> _nl;
        void loatdata()
        {
            lbl_soQD.DataBindings.Add("Text", _nl, "SoQuyetDinh");

        }
    }
}
