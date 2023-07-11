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

namespace QL_NHAN_SU.LichLamViec
{
    public partial class F_Khoa : DevExpress.XtraEditors.XtraForm
    {
        public F_Khoa()
        {
            InitializeComponent();
        }
        Khoa _khoa;
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
            txt_khoa.Enabled = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_khoa.DataSource = _khoa.GetList();
            gcv_khoa.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_Khoa khoa = new T_Khoa();
                khoa.Ten_Khoa = txt_khoa.Text;
                _khoa.Add(khoa);
            }
            else
            {
                var tg = _khoa.GetItem(_id);
                tg.Ten_Khoa = txt_khoa.Text;
                _khoa.update(tg);
            }
        }
        private void F_Khoa_Load(object sender, EventArgs e)
        {
            _them = false;
            _khoa = new Khoa();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_khoa.Text = string.Empty;
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
                _khoa.delete(_id);
                loadData();
                txt_khoa.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txt_khoa.Text == "")
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
            txt_khoa.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_khoa_Click(object sender, EventArgs e)
        {
            if (gcv_khoa.RowCount > 0)
            {
                _id = int.Parse(gcv_khoa.GetFocusedRowCellValue("id_Khoa").ToString());
                txt_khoa.Text = gcv_khoa.GetFocusedRowCellValue("Ten_Khoa").ToString();
            }
        }
    }

}