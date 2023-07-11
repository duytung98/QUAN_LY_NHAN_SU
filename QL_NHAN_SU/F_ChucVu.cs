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
    public partial class F_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        public F_ChucVu()
        {
            InitializeComponent();
        }
        ChucVu _chucvu;
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
            txt_chucvu.Enabled = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_chucvu.DataSource = _chucvu.GetList();
            gcv_chucvu.OptionsBehavior.Editable = false;
        }

        private void F_ChucVu_Load(object sender, EventArgs e)
        {
            _them = false;
            _chucvu = new ChucVu();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }
        void saveData()
        {
            if (_them)
            {
                T_ChucVu td = new T_ChucVu();
                td.Ten_ChucVu = txt_chucvu.Text;
                _chucvu.Add(td);
            }
            else
            {
                var tg = _chucvu.GetItem(_id);
                tg.Ten_ChucVu = txt_chucvu.Text;
                _chucvu.update(tg);
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_chucvu.Text = string.Empty;
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
                _chucvu.delete(_id);
                loadData();
                txt_chucvu.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_chucvu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                txt_chucvu.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }

        }

        private void btn_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txt_chucvu.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_chucvu_Click(object sender, EventArgs e)
        {
            if (gcv_chucvu.RowCount > 0)
            {
                _id = int.Parse(gcv_chucvu.GetFocusedRowCellValue("id_ChucVu").ToString());
                txt_chucvu.Text = gcv_chucvu.GetFocusedRowCellValue("Ten_ChucVu").ToString();
            }
        }
    }
}