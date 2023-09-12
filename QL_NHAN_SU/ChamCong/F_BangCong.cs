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
using Businesslayer;

namespace QL_NHAN_SU.ChamCong
{
    public partial class F_BangCong : DevExpress.XtraEditors.XtraForm
    {
        public F_BangCong()
        {
            InitializeComponent();
        }
        KyCong _Kycong;
        bool _them;
        int _makycong;
        void _showHide(bool kt)
        {
            btn_luu.Enabled = !kt;
            btn_huy.Enabled = !kt;
            btn_them.Enabled = kt;
            btn_sua.Enabled = kt;
            btn_xoa.Enabled = kt;
            btn_dong.Enabled = kt;
            btn_in.Enabled = kt;
            cb_Nam.Enabled = !kt;
            cb_Thang.Enabled = !kt;
            cb_Khoa.Enabled = !kt;
            cb_trangthai.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;

        }
        void loadData()
        {
            gc_chamcong.DataSource = _Kycong.getlist();
            gcv_chamcong.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_Ky_Cong kc = new T_Ky_Cong();
                kc.MaKyCong = int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text);
                kc.Nam = int.Parse(cb_Nam.Text);
                kc.Thang = int.Parse(cb_Thang.Text);
                kc.Khoa = cb_Khoa.Checked;
                kc.TrangThai = cb_trangthai.Checked;
                kc.NgayCongTrongThang = ChamCong_Function.demngaycongtrongthang(int.Parse(cb_Thang.Text), int.Parse(cb_Nam.Text));
                kc.NgayTinhCong = DateTime.Now;
                kc.id_NoiLV = 1;
                kc.CREATEO_BY = 2000000000;
                kc.CREATEO_DATE = DateTime.Now;
                _Kycong.add(kc);
            }
            else
            {
                var kc = _Kycong.getItem(_makycong);
                //kc.MaKyCong = int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text);
                kc.Nam = int.Parse(cb_Nam.Text);
                kc.Thang = int.Parse(cb_Thang.Text);
                kc.Khoa = cb_Khoa.Checked;
                kc.TrangThai = cb_trangthai.Checked;
                kc.NgayCongTrongThang = ChamCong_Function.demngaycongtrongthang(int.Parse(cb_Thang.Text), int.Parse(cb_Nam.Text));
                kc.NgayTinhCong = DateTime.Now;
                kc.UPDATEO_BY = 2000000000;
                kc.UPDATEO_DATE = DateTime.Now;
                _Kycong.update(kc);
            }
        }

        private void F_BangCong_Load(object sender, EventArgs e)
        {
            _them = false;
            _Kycong = new KyCong();
            _showHide(true);
            loadData();
            cb_Nam.Text = DateTime.Now.Year.ToString();
            cb_Thang.Text = DateTime.Now.Month.ToString();
            
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            cb_Nam.Text = DateTime.Now.Year.ToString();
            cb_Thang.Text = DateTime.Now.Month.ToString();
            cb_Khoa.Checked = false;
            cb_trangthai.Checked = false;
            
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _Kycong.Delete(_makycong,1);
                loadData();
                cb_Nam.Text = DateTime.Now.Year.ToString();
                cb_Thang.Text = DateTime.Now.Month.ToString();
                cb_Khoa.Checked = false;
                cb_trangthai.Checked = false;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_Nam.Text != DateTime.Now.Year.ToString())
            {
                MessageBox.Show("Bạn vui lòng nhập đúng năm hiện tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            cb_Nam.Text = DateTime.Now.Year.ToString();
            cb_Thang.Text = DateTime.Now.Month.ToString();
            cb_Khoa.Checked = false;
            cb_trangthai.Checked = false;
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_BangCongChiTiet f_BangCongChiTiet = new F_BangCongChiTiet();
            f_BangCongChiTiet._makycong = _makycong;
            f_BangCongChiTiet._thang = int.Parse(cb_Thang.Text);
            f_BangCongChiTiet._nam = int.Parse(cb_Nam.Text);
            f_BangCongChiTiet._macty = 1;
            f_BangCongChiTiet.ShowDialog();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_chamcong_Click(object sender, EventArgs e)
        {
            if (gcv_chamcong.RowCount > 0)
            {
                _makycong = int.Parse(gcv_chamcong.GetFocusedRowCellValue("MaKyCong").ToString());
                cb_Nam.Text = gcv_chamcong.GetFocusedRowCellValue("Nam").ToString();
                cb_Thang.Text = gcv_chamcong.GetFocusedRowCellValue("Thang").ToString();
                cb_Khoa.Checked = bool.Parse(gcv_chamcong.GetFocusedRowCellValue("Khoa").ToString());
                cb_trangthai.Checked = bool.Parse(gcv_chamcong.GetFocusedRowCellValue("TrangThai").ToString());
            }
        }

        private void gcv_chamcong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DEL" && e.CellValue != null)
            {
                Image img = Properties.Resources.delete1;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void cb_Khoa_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}