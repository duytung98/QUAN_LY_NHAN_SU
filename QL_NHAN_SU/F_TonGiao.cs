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

namespace QL_NHAN_SU
{
    public partial class F_TonGiao : DevExpress.XtraEditors.XtraForm
    {
        public F_TonGiao()
        {
            InitializeComponent();
        }
        TonGiao _tongiao;
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
            txt_tongiao.Enabled = !kt;
            label1.Enabled = !kt;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadData()
        {
            gc_tongiao.DataSource = _tongiao.GetList();
            gcv_tongiao.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                 T_TonGiao tg = new T_TonGiao();
                tg.TonGiao = txt_tongiao.Text;
                _tongiao.Add(tg);
            }
            else
            {
                var tg = _tongiao.GetItem(_id);
                tg.TonGiao = txt_tongiao.Text;
                _tongiao.update(tg);
            }
        }

        private void F_TonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _tongiao = new TonGiao();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_tongiao.Text = string.Empty;
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
                _tongiao.delete(_id);
                loadData();
                txt_tongiao.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_tongiao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                txt_tongiao.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txt_tongiao.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_tongiao_Click(object sender, EventArgs e)
        {
            if (gcv_tongiao.RowCount > 0)
            {
                _id = int.Parse(gcv_tongiao.GetFocusedRowCellValue("id_TonGiao").ToString());
                txt_tongiao.Text = gcv_tongiao.GetFocusedRowCellValue("TonGiao").ToString();
            }
           
        }
    }
}