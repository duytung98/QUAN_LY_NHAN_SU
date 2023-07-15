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
    public partial class F_HopDongLD : DevExpress.XtraEditors.XtraForm
    {
        public F_HopDongLD()
        {
            InitializeComponent();
        }
        HopDongLaoDong _hdld;
        NhanVien _nhanVien;
        List<HopDongDTO> _lstHopDong;

        bool _them;
        string _soHD;
        string _maxSoHD;
        private void _showHide1(bool kt)
        {
            btn_luu.Enabled = !kt;
            btn_huy.Enabled = !kt;
            btn_them.Enabled = kt;
            btn_sua.Enabled = kt;
            btn_xoa.Enabled = kt;
            btn_dong.Enabled = kt;
            btn_in.Enabled = kt;
            txt_SHD.Enabled = !kt;
            sp_luongcoban.Enabled = !kt;
            date_NBD.Enabled = !kt;
            date_NKT.Enabled = !kt;
            date_NKy.Enabled = !kt;
            sl_NhanVien.Enabled = !kt;
            sp_hesoluong.Enabled = !kt;
            sp_lanky.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
            label5.Enabled = !kt;
            label6.Enabled = !kt;
            label7.Enabled = !kt;
            label8.Enabled = !kt;
            label9.Enabled = !kt;
            

        }
        void _reset()
        {
            txt_SHD.Text = string.Empty;
            date_NBD.Value = DateTime.Now;
            date_NKT.Value = date_NBD.Value.AddMonths(6); 
            date_NKy.Value = DateTime.Now;
            sp_lanky.Text = "1";
            sp_hesoluong.Text = "1";
            sp_luongcoban.Text = "1000000";
        }
        private void saveData()
        {
            if (_them)
            {
                //sohd có dang: 00001/2023/HDLĐ
                var maxSoHD = _hdld.MaxSoHopDong();
                T_HopDong hd = new T_HopDong();
                int so = int.Parse(maxSoHD.Substring(0, 5)) + 1;
                //so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+@"/QĐĐC"
                hd.So_HopDong = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/HĐLĐ";
                hd.NgayBatDau = date_NBD.Value;
                hd.NgayKetThuc = date_NKT.Value;
                hd.ThoiHan = cb_thoihan.Text;
                hd.NgayKy = date_NKy.Value;
                hd.LuongCB = int.Parse(sp_luongcoban.EditValue.ToString());
                hd.HeSoLuong = double.Parse(sp_hesoluong.EditValue.ToString());
                hd.Lanky = int.Parse(sp_lanky.EditValue.ToString());
                hd.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                hd.id_NoiLV = 1;
                hd.CREATEO_BY = 2000000000;
                hd.CREATEO_DATE = DateTime.Now;
                _hdld.add(hd);
            }
            else
            {
                var hd1 = _hdld.getItem(_soHD);
                hd1.NgayBatDau = date_NBD.Value;
                hd1.NgayKetThuc = date_NKT.Value;
                hd1.NgayKy = date_NKy.Value;
                hd1.ThoiHan = cb_thoihan.Text;
                hd1.HeSoLuong = double.Parse(sp_hesoluong.EditValue.ToString());
                hd1.LuongCB = int.Parse(sp_luongcoban.EditValue.ToString());
                hd1.Lanky = int.Parse(sp_lanky.EditValue.ToString());
                hd1.id_NhanVien = int.Parse(sl_NhanVien.EditValue.ToString());
                hd1.id_NoiLV = 1;
                
                hd1.CREATEO_BY = 2000000000;
                hd1.CREATEO_DATE = DateTime.Now;
                _hdld.Update(hd1);
            }
        }
        void loadData()
        {
            gv_hopdong.DataSource = _hdld.getListfull();
            gcv_hopdong.OptionsBehavior.Editable = false;
            
        }
        void loadNhanVien()
        {
            sl_NhanVien.Properties.DataSource = _nhanVien.GetList();
            sl_NhanVien.Properties.ValueMember = "id_NhanVien";
            sl_NhanVien.Properties.DisplayMember = "HoTen";
        }

        private void F_HopDongLD_Load(object sender, EventArgs e)
        {
            _hdld = new HopDongLaoDong();
            _nhanVien = new NhanVien();
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
                _hdld.Delete(_soHD, 2000000000);
                loadData();
                txt_SHD.Text = string.Empty;
                sl_NhanVien.Text = string.Empty;
                sp_hesoluong.Text = string.Empty;
                sp_lanky.Text = string.Empty;
                sp_luongcoban.Text = string.Empty;


            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_NhanVien.Text == "" || cb_thoihan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide1(true);
                txt_SHD.Text = string.Empty;
                sp_hesoluong.Text = string.Empty;
                sp_lanky.Text = string.Empty;
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
            _lstHopDong = _hdld.getItemFull(_soHD);
            rptHopDongLaoDong rptHopDong = new rptHopDongLaoDong(_lstHopDong);
            rptHopDong.ShowPreviewDialog();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_hopdong_Click(object sender, EventArgs e)
        {
            if (gcv_hopdong.RowCount > 0)
            {
                _soHD = gcv_hopdong.GetFocusedRowCellValue("So_HopDong").ToString();
                var hd = _hdld.getItem(_soHD);
                txt_SHD.Text = _soHD;
                date_NBD.Value = hd.NgayBatDau.Value;
                date_NKT.Value = hd.NgayKetThuc.Value;
                date_NKy.Value = hd.NgayKy.Value;
                cb_thoihan.Text = hd.ThoiHan;
                sp_luongcoban.EditValue = hd.LuongCB;
                sp_hesoluong.EditValue = hd.HeSoLuong;
                sp_lanky.Text = hd.Lanky.ToString();
                sl_NhanVien.EditValue = hd.id_NhanVien;
                _lstHopDong = _hdld.getItemFull(_soHD);

            }
        }

        private void gcv_hopdong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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