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
    public partial class F_BoPhan : DevExpress.XtraEditors.XtraForm
    {
        public F_BoPhan()
        {
            InitializeComponent();
        }
        BoPhan _bophan;
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
            txt_bophan.Enabled = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_bophan.DataSource = _bophan.GetList();
            gcv_bophan.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_BoPhan pb = new T_BoPhan();
                pb.Ten_BoPhan = txt_bophan.Text;
                _bophan.Add(pb);
            }
            else
            {
                var tg = _bophan.GetItem(_id);
                tg.Ten_BoPhan = txt_bophan.Text;
                _bophan.update(tg);
            }
        }

        private void F_BoPhan_Load(object sender, EventArgs e)
        {
            _them = false;
            _bophan = new BoPhan();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_bophan.Text = string.Empty;
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
                _bophan.delete(_id);
                loadData();
                txt_bophan.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_bophan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                txt_bophan.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txt_bophan.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_bophan_Click(object sender, EventArgs e)
        {
            if (gcv_bophan.RowCount > 0)
            {
                _id = int.Parse(gcv_bophan.GetFocusedRowCellValue("id_BoPhan").ToString());
                txt_bophan.Text = gcv_bophan.GetFocusedRowCellValue("Ten_BoPhan").ToString();
            }
        }
    }
}