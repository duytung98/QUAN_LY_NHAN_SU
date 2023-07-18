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
    public partial class F_NhanVien_DieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public F_NhanVien_DieuChuyen()
        {
            InitializeComponent();
        }
        NhanVien_DieuChuyen _NVDC;
        bool _them;
        string _soQD;
        NhanVien _nhanvien;
        PhongBan _PhongBan;
        List<DieuChuyenDTO> _listDC;


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
            date_Ngay.Enabled = !kt;
            cb_DVDen.Enabled = !kt;
            //date_NBD.Enabled = !kt;
            //date_NKT.Enabled = !kt;

            sl_NhanVien.Enabled = !kt;

            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
            label5.Enabled = !kt;
            label7.Enabled = !kt;


        }
        void _reset()
        {
            txt_SQD.Text = string.Empty;

            txt_lido.Text = string.Empty;
            txt_ghichu.Text = string.Empty;

            //date_NKy.Value = DateTime.Now;
            //sp_lanky.Text = "1";
            //sp_hesoluong.Text = "1";
        }
        private void saveData()
        {
            T_DieuChuyen kt;
            if (_them)
            {
                //sohd có dang: 00001/2023/HDLĐ
                var maxSoQD = _NVDC.MaxSoQD();
                kt = new T_DieuChuyen();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                kt.SoDieuChuyen = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+@"/QĐĐC";
                kt.Ngay = date_Ngay.Value;
                kt.LiDo = txt_lido.Text;
                kt.Ghichu = txt_ghichu.Text;
                kt.id_PhongBan = _nhanvien.GetItem(int.Parse(sl_NhanVien.EditValue.ToString())).id_PhongBan;
                kt.id_PhongBan2 = int.Parse(cb_DVDen.SelectedValue.ToString());
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());

                kt.CREATEO_BY = 2000000000;
                kt.CREATEO_DATE = DateTime.Now;
                _NVDC.add(kt);
            }
            else
            {
                kt = _NVDC.getItem(_soQD);
                
                kt.Ngay = date_Ngay.Value;
                kt.LiDo = txt_lido.Text;
                kt.Ghichu = txt_ghichu.Text;
                
                kt.id_PhongBan2 = int.Parse(cb_DVDen.SelectedValue.ToString());
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());

                kt.UPDATEO_BY = 2000000000;
                kt.UPDATEO_DATE = DateTime.Now;
                _NVDC.update(kt);
            }
            var nv = _nhanvien.GetItem(kt.id_NhanVien.Value);
            nv.id_PhongBan = kt.id_PhongBan2;
            _nhanvien.update(nv);
        }
        void loadNhanVien()
        {
            sl_NhanVien.Properties.DataSource = _nhanvien.GetList();
            sl_NhanVien.Properties.ValueMember = "id_NhanVien";
            sl_NhanVien.Properties.DisplayMember = "HoTen";
        }
        void loađonViDen()
        {
            cb_DVDen.DataSource = _PhongBan.GetList();
            cb_DVDen.ValueMember = "id_PhongBan";
            cb_DVDen.DisplayMember = "Ten_PhongBan";
        }
        void loadData()
        {
            gv_dieuchuyen.DataSource = _NVDC.getlistFull();
            gcv_dieuchuyen.OptionsBehavior.Editable = false;

        }


        private void F_NhanVien_DieuChuyen_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _NVDC = new NhanVien_DieuChuyen();
            _PhongBan = new PhongBan();
            _them = false;
            _showHide1(true);
            loađonViDen();
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
                _NVDC.delete(_soQD, 1);
                loadData();
                txt_SQD.Text = string.Empty;
                sl_NhanVien.Text = string.Empty;
                txt_lido.Text = string.Empty;
                txt_ghichu.Text = string.Empty;


            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_NhanVien.Text == "" || txt_lido.Text == "" || txt_ghichu.Text == "")
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
            _listDC = _NVDC.getitemFull(_soQD);
            rptDieuChuyen rptdieuchuye = new rptDieuChuyen(_listDC);
            rptdieuchuye.ShowPreviewDialog();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_dieuchuyen_Click(object sender, EventArgs e)
        {
            if (gcv_dieuchuyen.RowCount > 0)
            {
                _soQD = gcv_dieuchuyen.GetFocusedRowCellValue("SoDieuChuyen").ToString();
                var kt = _NVDC.getItem(_soQD);
                txt_SQD.Text = _soQD;
                txt_ghichu.Text = kt.Ghichu;
                sl_NhanVien.EditValue = kt.id_NhanVien;
                txt_lido.Text = kt.LiDo;
                cb_DVDen.SelectedValue = kt.id_PhongBan2;
                date_Ngay.Value = kt.Ngay.Value;
                _listDC = _NVDC.getitemFull(_soQD);

            }
        }

        private void gcv_dieuchuyen_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.Name == "DELETEO_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.delete1;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}