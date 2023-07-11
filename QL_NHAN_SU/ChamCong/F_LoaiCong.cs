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
    public partial class F_LoaiCong : DevExpress.XtraEditors.XtraForm
    {
        public F_LoaiCong()
        {
            InitializeComponent();
        }
        LoaiCong _loaicong;
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
            txt_loaicong.Enabled = !kt;
            sp_hesocong.EditValue = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
        }
        void loadData()
        {
            gc_conglam.DataSource = _loaicong.GetList();
            gcv_conglam.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_LoaiCong cong = new T_LoaiCong();
                cong.Ten_LoaiCong = txt_loaicong.Text;
                cong.HeSo = double.Parse(sp_hesocong.EditValue.ToString());
                _loaicong.Add(cong);
            }
            else
            {
                var tg = _loaicong.GetItem(_id);
                tg.Ten_LoaiCong = txt_loaicong.Text;
                tg.HeSo = double.Parse(sp_hesocong.EditValue.ToString());
                _loaicong.update(tg);
            }
        }

        private void F_LoaiCong_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaicong = new LoaiCong();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_loaicong.Text = string.Empty;
            sp_hesocong.Text = "1.";
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
                _loaicong.delete(_id);
                loadData();
                txt_loaicong.Text = string.Empty;
                sp_hesocong.Text = "1.";
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_loaicong.Text == "" || sp_hesocong.Text == "")
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
            txt_loaicong.Text = string.Empty;
            sp_hesocong.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_conglam_Click(object sender, EventArgs e)
        {
            if (gcv_conglam.RowCount > 0)
            {
                _id = int.Parse(gcv_conglam.GetFocusedRowCellValue("id_LoaiCong").ToString());
                txt_loaicong.Text = gcv_conglam.GetFocusedRowCellValue("Ten_LoaiCong").ToString();
                sp_hesocong.Text = gcv_conglam.GetFocusedRowCellValue("HeSo").ToString();
            }
        }
    }
}