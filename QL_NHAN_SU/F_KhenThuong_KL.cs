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
using QL_NHAN_SU.Report;
using DevExpress.XtraReports.UI;

namespace QL_NHAN_SU
{
    public partial class F_KhenThuong_KL : DevExpress.XtraEditors.XtraForm
    {
        public F_KhenThuong_KL()
        {
            InitializeComponent();
        }
        KhenThuong _khenthuong;
        bool _them;
        string _soQD;
        NhanVien _nhanvien;
        List<KhenThuongDTO> _lstNL;


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
            txt_NoiDung.Enabled = !kt;
            txt_lido.Enabled = !kt;
            //date_NBD.Enabled = !kt;
            //date_NKT.Enabled = !kt;

            sl_NhanVien.Enabled = !kt;

            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;

            label7.Enabled = !kt;


        }
        void _reset()
        {
            txt_SQD.Text = string.Empty;

            txt_lido.Text = string.Empty;
            txt_NoiDung.Text = string.Empty;

            //date_NKy.Value = DateTime.Now;
            //sp_lanky.Text = "1";
            //sp_hesoluong.Text = "1";
        }
        private void saveData()
        {
            if (_them)
            {
                //sohd có dang: 00001/2023/HDLĐ
                var maxSoQD = _khenthuong.MaxSoQD(1);
                KhenThuong_KyLuat kt = new KhenThuong_KyLuat();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                kt.SoQuyetDinh = so.ToString("00000") + @"/2023/QĐKT";
                //hd.NgayBatDau = date_NBD.Value;
                //hd.NgayKetThuc = date_NKT.Value;
                kt.NgayTao = date_Ngay.Value;
                kt.LyDo = txt_lido.Text;
                kt.NoiDung = txt_NoiDung.Text;
                kt.Loai = 1;
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                kt.CREATE0_BY = 1;
                kt.CREATE0_DATE = DateTime.Now;
                _khenthuong.add(kt);
            }
            else
            {
                var kt = _khenthuong.getItem(_soQD);
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                kt.NgayTao = date_Ngay.Value;
                kt.LyDo = txt_lido.Text;
                kt.NoiDung = txt_NoiDung.Text;
                kt.UPDATEO_BY = 1;

                kt.UPDATEO_DATE = DateTime.Now;
                _khenthuong.update(kt);
            }
        }
        void loadNhanVien()
        {
            sl_NhanVien.Properties.DataSource = _nhanvien.GetList();
            sl_NhanVien.Properties.ValueMember = "id_NhanVien";
            sl_NhanVien.Properties.DisplayMember = "HoTen";
        }
        void loadData()
        {
            gv_khenthuong.DataSource = _khenthuong.getlistFull(1);
            gcv_khenthuong.OptionsBehavior.Editable = false;

        }

        private void F_KhenThuong_KL_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _khenthuong = new KhenThuong();
            _them = false;
            _showHide1(true);
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
                _khenthuong.Delete(_soQD, 2000000000);
                loadData();
                txt_SQD.Text = string.Empty;
                sl_NhanVien.Text = string.Empty;
                txt_lido.Text = string.Empty;
                txt_NoiDung.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_NhanVien.Text == "" || txt_lido.Text == "" || txt_NoiDung.Text == "")
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
                sl_NhanVien.Text = string.Empty;
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
            _lstNL = _khenthuong.getItemFull(_soQD);
            rpt_khenthuong rptKhenthuong = new rpt_khenthuong(_lstNL);
            rptKhenthuong.ShowPreviewDialog();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_khenthuong_Click(object sender, EventArgs e)
        {
            if (gcv_khenthuong.RowCount > 0)
            {
                _soQD = gcv_khenthuong.GetFocusedRowCellValue("SoQuyetDinh").ToString();
                var kt = _khenthuong.getItem(_soQD);
                txt_SQD.Text = _soQD;
                txt_NoiDung.Text = kt.NoiDung;
                sl_NhanVien.EditValue = kt.id_NhanVien;
                txt_lido.Text = kt.LyDo;
                date_Ngay.Value = kt.NgayTao.Value;
                _lstNL = _khenthuong.getItemFull(_soQD);

            }
        }

        private void gcv_khenthuong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DEL" && e.CellValue != null)
            {
                Image img = Properties.Resources.delete1;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}