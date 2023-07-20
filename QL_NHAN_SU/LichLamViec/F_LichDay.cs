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
using Businesslayer.DTO;
using QL_NHAN_SU.Report;
using DevExpress.XtraReports.UI;

namespace QL_NHAN_SU.LichLamViec
{
    public partial class F_LichDay : DevExpress.XtraEditors.XtraForm
    {
        public F_LichDay()
        {
            InitializeComponent();
        }

        LichLamViec1 _LichLV;
        bool _them;
        int _stt;
        NhanVien _nhanvien;
        PhongHoc _phonghoc;
        MonDay _monday;
        NoiLamViec _NoiLV;
        Khoa _khoa;
        KhoaDay _khoaday;
        LopDay _lopday;
        CaLam _calam;
        List<LichLamViecDTO> _lstLichLV_DTO;

        private void _showHide1(bool kt)
        {
            btn_luu.Enabled = !kt;
            btn_huy.Enabled = !kt;
            btn_them.Enabled = kt;
            btn_sua.Enabled = kt;
            btn_xoa.Enabled = kt;
            btn_dong.Enabled = kt;
            btn_in.Enabled = kt;
            sp_SoTin.Enabled = !kt;
            date_BatDau.Enabled = !kt;
            date_ketthuc.Enabled = !kt;
            sl_NhanVien.Enabled = !kt;
            sl_caday.Enabled = !kt;
            sl_khoa.Enabled = !kt;
            sl_KhoaHoc.Enabled = !kt;
            sl_lophoc.Enabled = !kt;
            sl_MonDay.Enabled = !kt;
            sl_NoiLv.Enabled = !kt;
            sl_phonghoc.Enabled = !kt;
            sl_caday.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
            label5.Enabled = !kt;
            label7.Enabled = !kt;
            label6.Enabled = !kt;
            label8.Enabled = !kt;
            label9.Enabled = !kt;
            label10.Enabled = !kt;
            label11.Enabled = !kt;

        }
        void _reset()
        {
            sl_NhanVien.Text = string.Empty;
            sl_caday.Text =  string.Empty;
            sl_khoa.Text = string.Empty;
            sl_KhoaHoc.Text = string.Empty;
            sl_lophoc.Text = string.Empty;
            sl_MonDay.Text = string.Empty;
            sl_NoiLv.Text =  string.Empty;
            sl_phonghoc.Text = string.Empty;
            sl_caday.Text = string.Empty;
            sp_SoTin.Text = "1";
            //date_NKy.Value = DateTime.Now;
            //sp_lanky.Text = "1";
            //sp_hesoluong.Text = "1";
        }
        private void saveData()
        {
            
            if (_them)
            {

                T_LichLV kt = new T_LichLV();
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                kt.id_Khoa = int.Parse(sl_khoa.EditValue.ToString());
                kt.id_KhoaDay = int.Parse(sl_KhoaHoc.EditValue.ToString());
                kt.id_LoaiCa = int.Parse(sl_caday.EditValue.ToString());
                kt.id_LopDay = int.Parse(sl_lophoc.EditValue.ToString());
                kt.id_MonDay = int.Parse(sl_MonDay.EditValue.ToString());
                kt.id_NoiLV = int.Parse(sl_NoiLv.EditValue.ToString());
                kt.id_PhongHoc = int.Parse(sl_phonghoc.EditValue.ToString());
                kt.ThoiGianBD = date_BatDau.Value;
                kt.ThoiGianKT = date_ketthuc.Value;
                kt.SoTin = int.Parse(sp_SoTin.EditValue.ToString());
                kt.CREATEO_BY = 2000000000;
                kt.CREATEO_DATE = DateTime.Now;
                _LichLV.add(kt);
            }
            else
            {
                var lv1 = _LichLV.getItem(_stt);
                
                lv1.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                lv1.id_Khoa = int.Parse(sl_khoa.EditValue.ToString());
                lv1.id_KhoaDay = int.Parse(sl_KhoaHoc.EditValue.ToString());
                lv1.id_LoaiCa = int.Parse(sl_caday.EditValue.ToString());
                lv1.id_LopDay = int.Parse(sl_lophoc.EditValue.ToString());
                lv1.id_MonDay = int.Parse(sl_MonDay.EditValue.ToString());
                lv1.id_NoiLV = int.Parse(sl_NoiLv.EditValue.ToString());
                lv1.id_PhongHoc = int.Parse(sl_phonghoc.EditValue.ToString());
                lv1.ThoiGianBD = date_BatDau.Value;
                lv1.ThoiGianKT = date_ketthuc.Value;
                lv1.SoTin = int.Parse(sp_SoTin.EditValue.ToString());
                lv1.UPDATEO_BY = 2000000000;
                lv1.UPDATEO_DATE = DateTime.Now;
                _LichLV.update(lv1);
            }
        }
        void loadNhanVien()
        {
            sl_NhanVien.Properties.DataSource = _nhanvien.GetList();
            sl_NhanVien.Properties.ValueMember = "id_NhanVien";
            sl_NhanVien.Properties.DisplayMember = "HoTen";
        }
        void loadnoiLV()
        {
            sl_NoiLv.Properties.DataSource = _NoiLV.GetList();
            sl_NoiLv.Properties.ValueMember = "id_NoiLV";
            sl_NoiLv.Properties.DisplayMember = "Ten_NoiLV";
        }
        void loadCa()
        {
            sl_caday.Properties.DataSource = _calam.GetList();
            sl_caday.Properties.ValueMember = "id_LoaiCa";
            sl_caday.Properties.DisplayMember = "TenLoaiCa";
        }
        void loadmonhoc()
        {
            sl_MonDay.Properties.DataSource = _monday.GetList();
            sl_MonDay.Properties.ValueMember = "id_MonDay";
            sl_MonDay.Properties.DisplayMember = "Ten_MonDay";
        }
        void loadkhoa()
        {
            sl_khoa.Properties.DataSource = _khoa.GetList();
            sl_khoa.Properties.ValueMember = "id_Khoa";
            sl_khoa.Properties.DisplayMember = "Ten_Khoa";
        }
        void loadLop()
        {
            sl_lophoc.Properties.DataSource = _lopday.GetList();
            sl_lophoc.Properties.ValueMember = "id_LopDay";
            sl_lophoc.Properties.DisplayMember = "Ten_LopDay";
        }
        void loadphong()
        {
            sl_phonghoc.Properties.DataSource = _phonghoc.GetList();
            sl_phonghoc.Properties.ValueMember = "id_PhongHoc";
            sl_phonghoc.Properties.DisplayMember = "Ten_PhongHoc";
        }
        void loadKhoaday()
        {
            sl_KhoaHoc.Properties.DataSource = _khoaday.GetList();
            sl_KhoaHoc.Properties.ValueMember = "id_KhoaDay";
            sl_KhoaHoc.Properties.DisplayMember = "Ten_KhoaDay";
        }

        void loadData()
        {
            gv_lichday.DataSource = _LichLV.getlistFull();
            gcv_lichday.OptionsBehavior.Editable = false;
            _lstLichLV_DTO = _LichLV.getlistFull();

        }
        private void F_LichDay_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _LichLV = new LichLamViec1();
            _phonghoc = new PhongHoc();
            _monday = new MonDay();
            _NoiLV = new NoiLamViec();
           _khoa = new Khoa();
            _khoaday = new KhoaDay();
            _lopday = new LopDay();
            _calam = new CaLam();
            _them = false;
            _showHide1(true);
            loadCa();
            loadkhoa();
            loadKhoaday();
            loadLop();
            loadmonhoc();
            loadnoiLV();
            loadphong();
            loadData();
            loadNhanVien();
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
                _LichLV.delete(_stt, 1);
                loadData();
                sl_NhanVien.Text = string.Empty;
                sl_caday.Text = string.Empty;
                sl_khoa.Text = string.Empty;
                sl_KhoaHoc.Text = string.Empty;
                sl_lophoc.Text = string.Empty;
                sl_MonDay.Text = string.Empty;
                sl_NoiLv.Text = string.Empty;
                sl_phonghoc.Text = string.Empty;
                sl_caday.Text = string.Empty;
                sp_SoTin.Text = "1";


            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_NhanVien.Text == "" || sl_caday.Text == "" || sl_khoa.Text == "" || sl_KhoaHoc.Text == "" || sl_lophoc.Text == "" || sl_MonDay.Text == "" || sl_NoiLv.Text == "" || sl_phonghoc.Text == "" || sp_SoTin.Text == "") 
            {
                MessageBox.Show("Bạn chưa đủ nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide1(true);
                _reset();
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
            rptDanhSachLichDay rpt = new rptDanhSachLichDay(_lstLichLV_DTO);
            rpt.ShowRibbonPreview();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_lichday_Click(object sender, EventArgs e)
        {
            if (gcv_lichday.RowCount > 0)
            {
                _stt = int.Parse(gcv_lichday.GetFocusedRowCellValue("id_LichLamViec").ToString());
                var kt = _LichLV.getItem(_stt);
               
                sl_NhanVien.EditValue = kt.id_NhanVien;
                sl_caday.EditValue = kt.id_LoaiCa;
                sl_khoa.EditValue = kt.id_Khoa;
                sl_KhoaHoc.EditValue = kt.id_KhoaDay;
                sl_lophoc.EditValue = kt.id_LopDay;
                sl_MonDay.EditValue = kt.id_MonDay;
                sl_NoiLv.EditValue = kt.id_NoiLV;
                sl_phonghoc.EditValue = kt.id_PhongHoc;
                date_BatDau.Value = kt.ThoiGianBD.Value;
                date_BatDau.Value = kt.ThoiGianBD.Value;
                sp_SoTin.Text = kt.SoTin.ToString();

            }
        }

        private void gcv_lichday_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DEL" && e.CellValue != null)
            {
                Image img = Properties.Resources.delete1;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void sl_MonDay_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}