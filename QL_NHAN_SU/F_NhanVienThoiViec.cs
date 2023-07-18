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
    public partial class F_NhanVienThoiViec : DevExpress.XtraEditors.XtraForm
    {
        public F_NhanVienThoiViec()
        {
            InitializeComponent();
        }
        NhanVienThoiViec _NVTV;
        bool _them;
        string _soQD;
        NhanVien _nhanvien;
        List<NhanvienThoiViecDTO> _lstTVDTO;

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
            txt_lido.Enabled = !kt;
            date_NgayND.Enabled = !kt;
            date_NgayNghi.Enabled = !kt;


            sl_NhanVien.Enabled = !kt;

            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
            label6.Enabled = !kt;
            label7.Enabled = !kt;


        }
        void _reset()
        {
            txt_SQD.Text = string.Empty;

            txt_lido.Text = string.Empty;
            txt_ghichu.Text = string.Empty;

            date_NgayND.Value = DateTime.Now;
            date_NgayNghi.Value = date_NgayND.Value.AddMonths(1);
            //sp_lanky.Text = "1";
            //sp_hesoluong.Text = "1";
        }
        private void saveData()
        {
            T_THOIVIEC kt;
            if (_them)
            {
                //sohd có dang: 00001/2023/HDLĐ
                var maxSoQD = _NVTV.MaxSoQD();
                kt = new T_THOIVIEC();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                kt.SOQDTV = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐĐC";
                kt.NGAYNOPDON = date_NgayND.Value;
                kt.NGAYNGHI = date_NgayNghi.Value;
                kt.LYDO = txt_lido.Text;
                kt.GHICHU = txt_ghichu.Text;
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());

                kt.CREATEO_BY = 2000000000;
                kt.CREATEO_DATE = DateTime.Now;
                _NVTV.add(kt);
            }
            else
            {
                kt = _NVTV.getitem(_soQD);

                kt.NGAYNGHI = date_NgayNghi.Value;
                kt.NGAYNOPDON = date_NgayND.Value;
                kt.LYDO = txt_lido.Text;
                kt.GHICHU = txt_ghichu.Text;
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());

                kt.UPDATEO_BY = 2000000000;
                kt.UPDATEO_DATE = DateTime.Now;
                _NVTV.update(kt);
            }
            var nv = _nhanvien.GetItem(kt.id_NhanVien.Value);
            nv.DATHOIVIEC = true;
            _nhanvien.update(nv);
        }
        void loadNhanVien()
        {
            sl_NhanVien.Properties.DataSource = _nhanvien.GetList();
            sl_NhanVien.Properties.ValueMember = "id_NhanVien";
            sl_NhanVien.Properties.DisplayMember = "HoTen";
        }
        void loadData()
        {
            gv_dieuchuyen.DataSource = _NVTV.getlistFull();
            gcv_dieuchuyen.OptionsBehavior.Editable = false;

        }

        private void F_NhanVienThoiViec_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _NVTV = new NhanVienThoiViec();
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
                _NVTV.delete(_soQD, 1);
                loadData();
                txt_SQD.Text = string.Empty;
                sl_NhanVien.Text = string.Empty;
                txt_lido.Text = string.Empty;
                txt_ghichu.Text = string.Empty;


            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_NhanVien.Text == "" || txt_lido.Text == "")
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
            _lstTVDTO = _NVTV.getitemFull(_soQD);
            rptThoiViec rpt_thoiviec = new rptThoiViec(_lstTVDTO);
            rpt_thoiviec.ShowPreviewDialog();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_dieuchuyen_Click(object sender, EventArgs e)
        {
            if (gcv_dieuchuyen.RowCount > 0)
            {
                _soQD = gcv_dieuchuyen.GetFocusedRowCellValue("SOQDTV").ToString();
                var kt = _NVTV.getitem(_soQD);
                txt_SQD.Text = _soQD;
                txt_ghichu.Text = kt.GHICHU;
                sl_NhanVien.EditValue = kt.id_NhanVien;
                txt_lido.Text = kt.LYDO;

                date_NgayND.Value = kt.NGAYNOPDON.Value;
                date_NgayNghi.Value = kt.NGAYNGHI.Value;
                _lstTVDTO = _NVTV.getitemFull(_soQD);

            }
        }

        private void gcv_dieuchuyen_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETEO_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.delete1;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}