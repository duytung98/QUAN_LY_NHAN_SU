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

namespace QL_NHAN_SU
{
    public partial class F_NoiLamViec : DevExpress.XtraEditors.XtraForm
    {
        public F_NoiLamViec()
        {
            InitializeComponent();
        }
        NoiLamViec _NoiLV;
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
            cb_noilv.Enabled = !kt;
            txt_email.Enabled = !kt;
            txt_dienthoai.Enabled = !kt;
            txt_diachi.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;

        }
        void loadData()
        {
            gridControl1.DataSource = _NoiLV.GetList();
            gv_noilv.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_NoiLamViec pb = new T_NoiLamViec();
                pb.Ten_NoiLV = cb_noilv.Text;
                pb.Email = txt_email.Text;
                pb.DienThoai = txt_dienthoai.Text;
                pb.DiaChi = txt_diachi.Text;
                _NoiLV.Add(pb);
            }
            else
            {
                var tg = _NoiLV.GetItem(_id);
                tg.Ten_NoiLV = cb_noilv.Text;
                tg.Email = txt_email.Text;
                tg.DienThoai = txt_dienthoai.Text;
                tg.DiaChi = txt_diachi.Text;
                _NoiLV.update(tg);
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            cb_noilv.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_dienthoai.Text = string.Empty;
            txt_diachi.Text = string.Empty;
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
                _NoiLV.delete(_id);
                loadData();
                cb_noilv.Text = string.Empty;
                txt_email.Text = string.Empty;
                txt_dienthoai.Text = string.Empty;
                txt_diachi.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            double a;
            if (cb_noilv.Text == ""||txt_email.Text==""||txt_dienthoai.Text==""||txt_diachi.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (!double.TryParse(this.txt_dienthoai.Text, out a))
            {
                MessageBox.Show("Số điện thoại phải là số,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                cb_noilv.Text = string.Empty;
                txt_email.Text = string.Empty;
                txt_dienthoai.Text = string.Empty;
                txt_diachi.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            cb_noilv.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_dienthoai.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_noilv_Click(object sender, EventArgs e)
        {
           
        }

        private void F_NoiLamViec_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _NoiLV = new NoiLamViec();
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        private void gv_noilv_Click(object sender, EventArgs e)
        {
            if (gv_noilv.RowCount > 0)
            {
                _id = int.Parse(gv_noilv.GetFocusedRowCellValue("id_NoiLV").ToString());
                cb_noilv.Text = gv_noilv.GetFocusedRowCellValue("Ten_NoiLV").ToString();
                txt_email.Text = gv_noilv.GetFocusedRowCellValue("Email").ToString();
                txt_dienthoai.Text = gv_noilv.GetFocusedRowCellValue("DienThoai").ToString();
                txt_diachi.Text = gv_noilv.GetFocusedRowCellValue("DiaChi").ToString();
            }
        }
    }
}