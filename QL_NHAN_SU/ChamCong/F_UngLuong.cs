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
using Businesslayer.DTO;

namespace QL_NHAN_SU.ChamCong
{
    public partial class F_UngLuong : DevExpress.XtraEditors.XtraForm
    {
        public F_UngLuong()
        {
            InitializeComponent();
        }
        UngLuong _UngLuong;
        UngLuongDTO _UngLuongDTO;
        NhanVien _NhanVien;
        bool _them;
        int _id;
        void _showHide(bool kt)
        {
            btn_luu.Enabled = !kt;
            btn_huy.Enabled = !kt;
            btn_them.Enabled = kt;
            btn_sua.Enabled = kt;
            btn_xoa.Enabled = kt;
            btn_dong.Enabled = kt;
            btn_in.Enabled = kt;
            sl_nhanvien.Enabled = !kt;
            sp_sotien.Enabled = !kt;
            txt_ghichu.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label4.Enabled = !kt;
        }
        void loadData()
        {
            gc_ungluong.DataSource = _UngLuong.getlistFull();
            gv_ungluong.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            sl_nhanvien.Properties.DataSource = _NhanVien.getlistFull();
            sl_nhanvien.Properties.DisplayMember = "HoTen";
            sl_nhanvien.Properties.ValueMember = "id_NhanVien";

        }
        void saveData()
        {
            if (_them)
            {
                T_UngLuong nvpc = new T_UngLuong();
                nvpc.So_Tien_Ung = int.Parse(sp_sotien.EditValue.ToString());
                nvpc.id_NhanVien = int.Parse(sl_nhanvien.EditValue.ToString());
                nvpc.GhiChu = txt_ghichu.Text;
                nvpc.Ngay_Ung = DateTime.Now.Day;
                nvpc.Thang_Ung = DateTime.Now.Month;
                nvpc.Nam_Ung = DateTime.Now.Year;
                nvpc.CREATEO_BY = 2000000000;
                nvpc.CREATEO_DATE = DateTime.Now;
                _UngLuong.Add(nvpc);
            }
            else
            {
                var nvpc = _UngLuong.GetItem(_id);
                nvpc.So_Tien_Ung = int.Parse(sp_sotien.EditValue.ToString());
                nvpc.id_NhanVien = int.Parse(sl_nhanvien.EditValue.ToString());
                nvpc.GhiChu = txt_ghichu.Text;
                nvpc.Ngay_Ung = DateTime.Now.Day;
                nvpc.Thang_Ung = DateTime.Now.Month;
                nvpc.Nam_Ung = DateTime.Now.Year;
                nvpc.UPDATEO_BY = 2000000000;
                nvpc.UPDATEO_DATE = DateTime.Now;
                _UngLuong.update(nvpc);
            }
        }

        private void F_UngLuong_Load(object sender, EventArgs e)
        {
            _UngLuong = new UngLuong();
            _UngLuongDTO = new UngLuongDTO();
            _NhanVien = new NhanVien();
            _them = false;
            _showHide(true);
            loadData();
            loadNhanVien();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            sl_nhanvien.Text = string.Empty;
            sp_sotien.Text = string.Empty;
            txt_ghichu.Text = string.Empty;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _UngLuong.delete(_id, 2000000000);
                loadData();
                txt_ghichu.Text = string.Empty;
                sp_sotien.Text = "100000";
                sl_nhanvien.Text = string.Empty;
             
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_nhanvien.Text == "" || sp_sotien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txt_ghichu.Text = string.Empty;
            sp_sotien.Text = "100000";
            sl_nhanvien.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gv_ungluong_Click(object sender, EventArgs e)
        {
            if (gv_ungluong.RowCount > 0)
            {
                _id = int.Parse(gv_ungluong.GetFocusedRowCellValue("id_UngLuong").ToString());
                txt_ghichu.Text = gv_ungluong.GetFocusedRowCellValue("GhiChu").ToString();
                sp_sotien.EditValue = gv_ungluong.GetFocusedRowCellValue("So_Tien_Ung");
                sl_nhanvien.EditValue = gv_ungluong.GetFocusedRowCellValue("id_NhanVien");
            }
        }

        private void gv_ungluong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DEL" && e.CellValue != null)
            {
                Image img = Properties.Resources.delete1;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}