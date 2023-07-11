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
    public partial class F_LopDay : DevExpress.XtraEditors.XtraForm
    {
        public F_LopDay()
        {
            InitializeComponent();
        }
        LopDay _LopDay;
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
            txt_lop.Enabled = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_lopday.DataSource = _LopDay.GetList();
            gcv_lopday.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_LopDay lop = new T_LopDay();
                lop.Ten_LopDay = txt_lop.Text;
                _LopDay.Add(lop);
            }
            else
            {
                var tg = _LopDay.GetItem(_id);
                tg.Ten_LopDay = txt_lop.Text;
                _LopDay.update(tg);
            }
        }

        private void F_LopDay_Load(object sender, EventArgs e)
        {
            _them = false;
            _LopDay = new LopDay();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_lop.Text = string.Empty;
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
                _LopDay.delete(_id);
                loadData();
                txt_lop.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_lop.Text == "")
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
            txt_lop.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_lopday_Click(object sender, EventArgs e)
        {
            if (gcv_lopday.RowCount > 0)
            {
                _id = int.Parse(gcv_lopday.GetFocusedRowCellValue("id_LopDay").ToString());
                txt_lop.Text = gcv_lopday.GetFocusedRowCellValue("Ten_LopDay").ToString();
            }
        }

        private void gcv_lopday_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }
    }
}