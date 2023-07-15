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
    public partial class F_DanToc : DevExpress.XtraEditors.XtraForm
    {
        public F_DanToc()
        {
            InitializeComponent();
        }
        DanToc _dantoc;
        bool _them;
        int _id;
        private void F_DanToc_Load(object sender, EventArgs e)
        {
            _them = false;
            _dantoc = new DanToc();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }
        void loadData()
        {
            gc_DanhSach.DataSource = _dantoc.GetList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void _showHide(bool kt)
        {
            btn_luu.Enabled = !kt;
            btn_huy.Enabled = !kt;
            btn_them.Enabled = kt;
            btn_sua.Enabled = kt;
            btn_xoa.Enabled = kt;
            btn_dong.Enabled = kt;
            btn_in.Enabled = kt;
            txt_dantoc.Enabled = !kt;
            label1.Enabled = !kt;
        }



        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            _them = true;
            _showHide(false);
            txt_dantoc.Text = string.Empty;
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
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không??","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dantoc.delete(_id);
                loadData();
                txt_dantoc.Text = string.Empty;
            }
            
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_dantoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                txt_dantoc.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }

        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txt_dantoc.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void saveData()
        {
            if (_them)
            {
                T_DanToc dt = new T_DanToc();
                dt.DanToc = txt_dantoc.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.GetItem(_id);
                dt.DanToc = txt_dantoc.Text;
                _dantoc.update(dt);
            }
        }

        private void gc_DanhSach_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("id_DanToc").ToString());
                txt_dantoc.Text = gvDanhSach.GetFocusedRowCellValue("DanToc").ToString();
            }
           
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }   
}