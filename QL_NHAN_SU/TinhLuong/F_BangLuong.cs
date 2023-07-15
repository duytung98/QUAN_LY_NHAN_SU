using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Businesslayer;
using Datalayer;
using QL_NHAN_SU.Report;
using DevExpress.XtraReports.UI;

namespace QL_NHAN_SU.TinhLuong
{
    public partial class F_BangLuong : DevExpress.XtraEditors.XtraForm
    {
        public F_BangLuong()
        {
            InitializeComponent();
        }
        BangLuong _bangluong;
        List<T_Bang_Luong> _lstBangLuong;
        int _namky;

        private void F_BangLuong_Load(object sender, EventArgs e)
        {
            _bangluong = new BangLuong();
            cb_Nam.Text = DateTime.Now.Year.ToString();
            cb_Thang.Text = DateTime.Now.Month.ToString();

        }

        private void bnt_tinhluong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangluong.TinhLuongnhanvien(int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text));
            loaddata();
        }
        void loaddata()
        {
            gc_bangluong.DataSource = _bangluong.getList(int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text));
            gcv_bangluong.OptionsBehavior.Editable = false;
            _lstBangLuong = _bangluong.getList(int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text));
            _namky = int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text);
        }

        private void bnt_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBangLuong rpt = new rptBangLuong(_lstBangLuong,_namky);
            rpt.ShowPreviewDialog();
        }

        private void bnt_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btb_xembangluong_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}