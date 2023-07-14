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

namespace QL_NHAN_SU.ChamCong
{
    public partial class F_Phucap : DevExpress.XtraEditors.XtraForm
    {
        public F_Phucap()
        {
            InitializeComponent();
        }
        PhuCap _PHUCAP;
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
            cb_phucap.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
        }
        void loadData()
        {
            gc_phucap.DataSource = _PHUCAP.getlistFull();
            gv_phucap.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            sl_nhanvien.Properties.DataSource = _NhanVien.getlistFull();
            sl_nhanvien.Properties.DisplayMember = "HoTen";
            sl_nhanvien.Properties.ValueMember = "id_NhanVien";

        }
        void loadcombo()
        {
            cb_phucap.DataSource = _PHUCAP.getlistPC();
            cb_phucap.DisplayMember = "Ten_PhuCap";
            cb_phucap.ValueMember = "id_PhuCap";
        }
        void saveData()
        {
            if (_them)
            {
                T_NhanVienPhuCap nvpc = new T_NhanVienPhuCap();
                nvpc.id_PhuCap = int.Parse(cb_phucap.SelectedValue.ToString());
                nvpc.SoTien = int.Parse(sp_sotien.EditValue.ToString());
                nvpc.id_NhanVien = int.Parse(sl_nhanvien.EditValue.ToString());
                nvpc.NoiDungPhuCap = txt_ghichu.Text;
                nvpc.NgayPhuCap = DateTime.Now;
                nvpc.CREATEO_BY = 2000000000;
                nvpc.CREATEO_DATE = DateTime.Now;
                _PHUCAP.Add(nvpc);
            }
            else
            {
                var nvpc = _PHUCAP.GetItem(_id);
                nvpc.id_PhuCap = int.Parse(cb_phucap.SelectedValue.ToString());
                nvpc.SoTien = int.Parse(sp_sotien.EditValue.ToString());
                nvpc.id_NhanVien = int.Parse(sl_nhanvien.EditValue.ToString());
                nvpc.NoiDungPhuCap = txt_ghichu.Text;
                nvpc.UPDATEO_BY = 2000000000;
                nvpc.UPDATEO_DATE = DateTime.Now;
                _PHUCAP.update(nvpc);
            }
        }

        private void F_Phucap_Load(object sender, EventArgs e)
        {
            _NhanVien = new NhanVien();
            _them = false;
            _PHUCAP = new PhuCap();
            _showHide(true);
            loadData();
            loadcombo();
            loadNhanVien();
            cb_phucap.SelectedIndexChanged += Cb_phucap_SelectedIndexChanged;
            splitContainer1.Panel1Collapsed = true;
            
        }

        private void Cb_phucap_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pc = _PHUCAP.getitemPC(int.Parse(cb_phucap.SelectedValue.ToString()));
            if(pc != null)
            {
                sp_sotien.EditValue = pc.Sotien;
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            sl_nhanvien.Text = string.Empty;
            sp_sotien.Text = string.Empty;
            txt_ghichu.Text = string.Empty;
            cb_phucap.Text = string.Empty;
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
                _PHUCAP.delete(_id,2000000000);
                loadData();
                txt_ghichu.Text = string.Empty;
                sp_sotien.Text = "0";
                sl_nhanvien.Text = string.Empty;
                cb_phucap.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_nhanvien.Text == "" || sp_sotien.Text == ""||cb_phucap.Text == "")
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
            sp_sotien.Text = "0";
            sl_nhanvien.Text = string.Empty;
            cb_phucap.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gv_phucap_Click(object sender, EventArgs e)
        {
            if (gv_phucap.RowCount > 0)
            {
                _id = int.Parse(gv_phucap.GetFocusedRowCellValue("id_NhanVienPhuCap").ToString());
                txt_ghichu.Text = gv_phucap.GetFocusedRowCellValue("NoiDungPhuCap").ToString();
                sp_sotien.EditValue = gv_phucap.GetFocusedRowCellValue("SoTien");
                sl_nhanvien.EditValue = gv_phucap.GetFocusedRowCellValue("id_NhanVien");
                cb_phucap.SelectedValue = gv_phucap.GetFocusedRowCellValue("id_PhuCap");
            }
        }

        private void gv_phucap_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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