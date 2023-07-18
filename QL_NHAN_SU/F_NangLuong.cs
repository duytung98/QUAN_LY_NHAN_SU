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
using QL_NHAN_SU.Report;
using DevExpress.XtraReports.UI;
using Businesslayer.DTO;

namespace QL_NHAN_SU
{
    public partial class F_NangLuong : DevExpress.XtraEditors.XtraForm
    {
        public F_NangLuong()
        {
            InitializeComponent();
        }
        NhanVien_NangLuong _NVNL;
        bool _them;
        string _soQD;
        NhanVien _nhanvien;
        HopDongLaoDong _HDLD;
        List<NhanVien_NangLuongDTO> _lstNL;

        private void _showHide1(bool kt)
        {
            btn_luu.Enabled = !kt;
            btn_huy.Enabled = !kt;
            btn_them.Enabled = kt;
            btn_sua.Enabled = kt;
            btn_xoa.Enabled = kt;
            btn_dong.Enabled = kt;
            btn_in.Enabled = kt;
            txt_SQD.Enabled = !kt;
            txt_ghichu.Enabled = !kt;
            sp_HSLCU.Enabled = !kt;
            sp_HSLMoi.Enabled = !kt;
            date_Ngayky.Enabled = !kt;
            date_NgaylenLuong.Enabled = !kt;
            txt_nhanvien.Enabled = !kt;


            sl_HopDong.Enabled = !kt;

            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
            label6.Enabled = !kt;
            label8.Enabled = !kt;
            label7.Enabled = !kt;


        }
        void _reset()
        {
            txt_SQD.Text = string.Empty;
            txt_nhanvien.Text = string.Empty;
            sl_HopDong.Text = string.Empty;
            txt_ghichu.Text = string.Empty;
            date_Ngayky.Value = DateTime.Now;
            date_NgaylenLuong.Value = date_Ngayky.Value.AddMonths(1);
            sp_HSLCU.Text = "1.";
            sp_HSLMoi.Text = "1.";
        }
        private void saveData()
        {
            T_NhanVien_NangLuong nl;
            if (_them)
            {
                //sohd có dang: 00001/2023/HDLĐ
                var maxSoQD = _NVNL.MaxSoQD();
                nl = new T_NhanVien_NangLuong();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                nl.SQDNL = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐNL";
                nl.NgayKy = date_Ngayky.Value;
                nl.So_HopDong = sl_HopDong.EditValue.ToString();
                nl.NgayLenLuong = date_NgaylenLuong.Value;
                nl.GhiChu = txt_ghichu.Text;
                nl.id_NhanVien = _HDLD.getItem(sl_HopDong.EditValue.ToString()).id_NhanVien;
                nl.HeSoLuongHT = _HDLD.getItem(sl_HopDong.EditValue.ToString()).HeSoLuong;
                nl.HSLuongMoi = double.Parse(sp_HSLMoi.EditValue.ToString());
                nl.CREATEO_BY = 2000000000;
                nl.CREATEO_DATE = DateTime.Now;
                _NVNL.add(nl);
            }
            else
            {
                nl = _NVNL.getItem(_soQD);
                nl.So_HopDong = sl_HopDong.EditValue.ToString();
                nl.NgayLenLuong = date_NgaylenLuong.Value;
                nl.NgayKy = date_Ngayky.Value;
                nl.GhiChu = txt_ghichu.Text;
                nl.id_NhanVien = _HDLD.getItem(sl_HopDong.EditValue.ToString()).id_NhanVien;
                nl.HeSoLuongHT = _HDLD.getItem(sl_HopDong.EditValue.ToString()).HeSoLuong;
                nl.HSLuongMoi = double.Parse(sp_HSLMoi.EditValue.ToString());
                nl.UPDATEO_BY = 2000000000;
                nl.UPDATEO_DATE = DateTime.Now;
                _NVNL.update(nl);
            }
            //var hd = _HDLD.getItem(sl_HopDong.EditValue.ToString());
            //hd.HeSoLuong = double.Parse(sp_HSLMoi.EditValue.ToString());
            //_HDLD.Update(hd);
        }
        void loadHopDong()
        {
            sl_HopDong.Properties.DataSource = _HDLD.getListfull();
            sl_HopDong.Properties.ValueMember = "So_HopDong";
            sl_HopDong.Properties.DisplayMember = "So_HopDong";
        }
        void loadData()
        {
            gv_NangLuong.DataSource = _NVNL.getlistFull();
            gcv_NangLuong.OptionsBehavior.Editable = false;

        }

        private void F_NangLuong_Load(object sender, EventArgs e)
        {
            _HDLD = new HopDongLaoDong();
            _nhanvien = new NhanVien();
            _NVNL = new NhanVien_NangLuong();
            _them = false;
            _showHide1(true);
            loadData();
            loadHopDong();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide1(false);
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide1(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _NVNL.delete(_soQD, 2000000000);
                //var hd = _HDLD.getItem(sl_HopDong.EditValue.ToString());
                //hd.HeSoLuong = double.Parse(sp_HSLCU.EditValue.ToString());
                //_HDLD.Update(hd);
                loadData();
                txt_SQD.Text = string.Empty;
                sl_HopDong.Text = string.Empty;
                txt_nhanvien.Text = string.Empty;
                txt_ghichu.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_HopDong.Text == "" || sp_HSLCU.Text == ""||sp_HSLMoi.Text == "" || txt_ghichu.Text == "")
            {
                MessageBox.Show("Bạn chưa đủ nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide1(true);
                txt_SQD.Text = string.Empty;
                sl_HopDong.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide1(true);

            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lstNL = _NVNL.getItemFull(_soQD);
            rptNangLuong rptNangLuong = new rptNangLuong(_lstNL);
            rptNangLuong.ShowPreviewDialog();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_NangLuong_Click(object sender, EventArgs e)
        {
            if (gcv_NangLuong.RowCount > 0)
            {
                _soQD = gcv_NangLuong.GetFocusedRowCellValue("SQDNL").ToString();
                var kt = _NVNL.getItem(_soQD);
                txt_SQD.Text = _soQD;
                txt_ghichu.Text = kt.GhiChu;
                sl_HopDong.EditValue = kt.So_HopDong;
                sp_HSLCU.Text = kt.HeSoLuongHT.ToString();
                sp_HSLMoi.Text = kt.HSLuongMoi.ToString();
                txt_nhanvien.Text = gcv_NangLuong.GetFocusedRowCellValue("HoTen").ToString();
                date_Ngayky.Value = kt.NgayKy.Value;
                date_NgaylenLuong.Value = kt.NgayLenLuong.Value;
                _lstNL = _NVNL.getItemFull(_soQD);

            }
        }

        private void gcv_NangLuong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETEO_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.delete1;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void sl_HopDong_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _HDLD.getItemFull(sl_HopDong.EditValue.ToString());
            if (hd.Count != 0){
                txt_nhanvien.Text = hd[0].id_NhanVien +" - "+ hd[0].HoTen;
                sp_HSLCU.EditValue = hd[0].HeSoLuong;
            }
        }
    }
}