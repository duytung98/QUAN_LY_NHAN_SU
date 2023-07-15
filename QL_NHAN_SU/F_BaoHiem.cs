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

namespace QL_NHAN_SU
{
    public partial class F_BaoHiem : DevExpress.XtraEditors.XtraForm
    {
        public F_BaoHiem()
        {
            InitializeComponent();
        }
        BaoHiem _BaoHiem;
        bool _them;
        int _id;
        NhanVien _nhanvien;
        private void _showHide1(bool kt)
        {
            btn_luu.Enabled = !kt;
            btn_huy.Enabled = !kt;
            btn_them.Enabled = kt;
            btn_sua.Enabled = kt;
            btn_xoa.Enabled = kt;
            btn_dong.Enabled = kt;
           
            txt_ghichu.Enabled = !kt;
            txt_baohiem.Enabled = !kt;
            date_cap.Enabled = !kt;
            sl_NhanVien.Enabled = !kt;
            txt_noicap.Enabled = !kt;
            txt_noikham.Enabled = !kt;
            
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
            label5.Enabled = !kt;
            label7.Enabled = !kt;
            

        }
        void _reset()
        {
            sl_NhanVien.Text = string.Empty;
            txt_noikham.Text = string.Empty;
            txt_noicap.Text = string.Empty;
            txt_ghichu.Text = string.Empty;
            txt_baohiem.Text = string.Empty;
        }
        private void saveData()
        {

            if (_them)
            {

                T_BaoHiem kt = new T_BaoHiem();
                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                kt.NoiCap = txt_noicap.Text;
                kt.So_BaoHiem = txt_baohiem.Text;
                kt.Noi_DK_Kham_Benh = txt_noikham.Text;
                kt.GhiChu = txt_ghichu.Text;
                kt.NgayCap = date_cap.Value;
                kt.CREATEO_BY = 2000000000;
                kt.CREATEO_DATE = DateTime.Now;
                _BaoHiem.add(kt);
            }
            else
            {
                var kt = _BaoHiem.getItem(_id);

                kt.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                kt.NoiCap = txt_noicap.Text;
                kt.So_BaoHiem = txt_baohiem.Text;
                kt.Noi_DK_Kham_Benh = txt_noikham.Text;
                kt.GhiChu = txt_ghichu.Text;
                kt.NgayCap = date_cap.Value;
                kt.UPDATE_BY = 2000000000;
                kt.UPDATE_DATE = DateTime.Now;
                _BaoHiem.update(kt);
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
            gv_baohiem.DataSource = _BaoHiem.getlistFull();
            gcv_baohiem.OptionsBehavior.Editable = false;
            

        }

        private void F_BaoHiem_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _BaoHiem = new BaoHiem();
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
                _BaoHiem.delete(_id,1);
                loadData();
                sl_NhanVien.Text = string.Empty;
                txt_noikham.Text = string.Empty;
                txt_noicap.Text = string.Empty;
                txt_ghichu.Text = string.Empty;
                txt_baohiem.Text = string.Empty;


            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide1(true);

            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_NhanVien.Text == "" || txt_baohiem.Text == "" || txt_noicap.Text == "" || txt_noikham.Text == "" )
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

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_baohiem_Click(object sender, EventArgs e)
        {
            if(gcv_baohiem.RowCount > 0)
            {
                _id = int.Parse(gcv_baohiem.GetFocusedRowCellValue("id_BaoHiem").ToString());
                var kt = _BaoHiem.getItem(_id);

                sl_NhanVien.EditValue = kt.id_NhanVien;
                txt_baohiem.Text = kt.So_BaoHiem.ToString();
                txt_ghichu.Text = kt.GhiChu.ToString();
                txt_noicap.Text = kt.NoiCap.ToString();
                txt_noikham.Text = kt.Noi_DK_Kham_Benh.ToString();
                date_cap.Value = kt.NgayCap.Value;

            }
        }

        private void gcv_baohiem_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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