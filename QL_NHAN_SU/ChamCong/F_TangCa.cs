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
    public partial class F_TangCa : DevExpress.XtraEditors.XtraForm
    {
        public F_TangCa()
        {
            InitializeComponent();
        }
        TangCa _Tangca;
        TangCaDTO _TangcaDTO;
        NhanVien _NhanVien;
        SYS_Confix _config;
        CaLam _calam;
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
            sp_sogio.Enabled = !kt;
            txt_ghichu.Enabled = !kt;
            cb_loaica.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
        }
        void loadData()
        {
            gc_tangca.DataSource = _Tangca.getlistFull();
            gv_tangca.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            sl_nhanvien.Properties.DataSource = _NhanVien.getlistFull();
            sl_nhanvien.Properties.DisplayMember = "HoTen";
            sl_nhanvien.Properties.ValueMember = "id_NhanVien";

        }
        void loadcombo()
        {
            cb_loaica.DataSource = _calam.GetList();
            cb_loaica.DisplayMember = "TenLoaiCa";
            cb_loaica.ValueMember = "id_LoaiCa";
        }
        void saveData()
        {
            if (_them)
            {
                T_TangCa nvpc = new T_TangCa();
                nvpc.id_LoaiCa = int.Parse(cb_loaica.SelectedValue.ToString());
                nvpc.SoGioTangCa = int.Parse(sp_sogio.EditValue.ToString());
                nvpc.id_NhanVien = int.Parse(sl_nhanvien.EditValue.ToString());
                nvpc.GhiChu = txt_ghichu.Text;
                var lc = _calam.GetItem(int.Parse(cb_loaica.SelectedValue.ToString()));
                var cg = _config.getItem("TangCa");
                nvpc.SoTien = nvpc.SoGioTangCa * lc.HeSo * int.Parse(cg.value);
                nvpc.Ngay = DateTime.Now.Day;
                nvpc.Thang = DateTime.Now.Month;
                nvpc.Nam = DateTime.Now.Year;
                nvpc.CREATE0_BY = 2000000000;
                nvpc.CREATE0_DATE = DateTime.Now;
                _Tangca.Add(nvpc);
            }
            else
            {
                var nvpc = _Tangca.GetItem(_id);
                nvpc.id_LoaiCa = int.Parse(cb_loaica.SelectedValue.ToString());
                nvpc.SoGioTangCa = int.Parse(sp_sogio.EditValue.ToString());
                nvpc.id_NhanVien = int.Parse(sl_nhanvien.EditValue.ToString());
                nvpc.GhiChu = txt_ghichu.Text;
                var lc = _calam.GetItem(int.Parse(cb_loaica.SelectedValue.ToString()));
                var cg = _config.getItem("TangCa");
                nvpc.SoTien = nvpc.SoGioTangCa * lc.HeSo * int.Parse(cg.value);
                nvpc.Ngay = DateTime.Now.Day;
                nvpc.Thang = DateTime.Now.Month;
                nvpc.Nam = DateTime.Now.Year;
                nvpc.UPDATEO_BY = 2000000000;
                nvpc.UPDATEO_DATE = DateTime.Now;
                _Tangca.update(nvpc);
            }
        }
        private void F_TangCa_Load(object sender, EventArgs e)
        {
            _Tangca = new TangCa();
            _TangcaDTO = new TangCaDTO();
            _NhanVien = new NhanVien();
            _them = false;
            _calam = new CaLam();
            _config = new SYS_Confix();
            _showHide(true);
            loadData();
            loadcombo();
            loadNhanVien();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            sl_nhanvien.Text = string.Empty;
            sp_sogio.Text = string.Empty;
            txt_ghichu.Text = string.Empty;
            cb_loaica.Text = string.Empty;
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
                _Tangca.delete(_id, 2000000000);
                loadData();
                txt_ghichu.Text = string.Empty;
                sp_sogio.Text = "1.";
                sl_nhanvien.Text = string.Empty;
                cb_loaica.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_nhanvien.Text == "" || sp_sogio.Text == "" || cb_loaica.Text == "")
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
            sp_sogio.Text = "1.";
            sl_nhanvien.Text = string.Empty;
            cb_loaica.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gv_tangca_Click(object sender, EventArgs e)
        {
            if (gv_tangca.RowCount > 0)
            {
                _id = int.Parse(gv_tangca.GetFocusedRowCellValue("id_TangCa").ToString());
                txt_ghichu.Text = gv_tangca.GetFocusedRowCellValue("GhiChu").ToString();
                sp_sogio.EditValue = gv_tangca.GetFocusedRowCellValue("SoGioTangCa");
                sl_nhanvien.EditValue = gv_tangca.GetFocusedRowCellValue("id_NhanVien");
                cb_loaica.SelectedValue = gv_tangca.GetFocusedRowCellValue("id_LoaiCa");
            }
        }

        private void gv_tangca_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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