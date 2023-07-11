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
    public partial class F_TrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public F_TrinhDo()
        {
            InitializeComponent();
        }
        Trinhdo _trinhdo;
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
            txt_trinhdo.Enabled = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_trinhdo.DataSource = _trinhdo.GetList();
            gcv_trinhdo.OptionsBehavior.Editable = false;
        }
        private void F_TrinhDo_Load(object sender, EventArgs e)
        {
            _them = false;
            _trinhdo = new Trinhdo();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }
        void saveData()
        {
            if (_them)
            {
                T_TrinhDo td = new T_TrinhDo();
                td.Ten_TrinhDo = txt_trinhdo.Text;
                _trinhdo.Add(td);
            }
            else
            {
                var tg = _trinhdo.GetItem(_id);
                tg.Ten_TrinhDo = txt_trinhdo.Text;
                _trinhdo.update(tg);
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            _them = true;
            _showHide(false);
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
                _trinhdo.delete(_id);
                loadData();
                txt_trinhdo.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (txt_trinhdo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                txt_trinhdo.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }
            
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txt_trinhdo.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_trinhdo_Click(object sender, EventArgs e)
        {
            if (gcv_trinhdo.RowCount > 0)
            {
                _id = int.Parse(gcv_trinhdo.GetFocusedRowCellValue("id_TrinhDo").ToString());
                txt_trinhdo.Text = gcv_trinhdo.GetFocusedRowCellValue("Ten_TrinhDo").ToString();
            }
           
        }
    }
}