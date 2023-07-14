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
using Datalayer;
using DevExpress.XtraReports.UI;
using Businesslayer;

namespace QL_NHAN_SU.Report
{
    public partial class F_bangcongnhanvienchitiet : DevExpress.XtraEditors.XtraForm
    {
        public F_bangcongnhanvienchitiet()
        {
            InitializeComponent();
        }
        NhanVien _nhanVien;
        BangCong_NV_ChiTiet _NV_ChiTiet;
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_bangcongnhanvienchitiet_Load(object sender, EventArgs e)
        {
            _nhanVien = new NhanVien();
            _NV_ChiTiet = new BangCong_NV_ChiTiet();
            loadnhanvien();
            cb_kycong.SelectedIndex = DateTime.Now.Month;
        }
        void loadnhanvien()
        {
            cb_nhanvien.DataSource = _nhanVien.GetList();
            cb_nhanvien.DisplayMember = "HoTen";
            cb_nhanvien.ValueMember = "id_NhanVien";
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            var lst = _NV_ChiTiet.getBangcongchitiet(DateTime.Now.Year * 100 + int.Parse(cb_kycong.Text),int.Parse(cb_nhanvien.SelectedValue.ToString()));
            rptBangCongchitiet rpt = new rptBangCongchitiet(lst);
            rpt.ShowPreviewDialog();

        }
    }
}