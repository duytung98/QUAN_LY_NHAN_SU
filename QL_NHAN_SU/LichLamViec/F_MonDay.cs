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
    public partial class F_MonDay : DevExpress.XtraEditors.XtraForm
    {
        public F_MonDay()
        {
            InitializeComponent();
        }
        MonDay _monday;
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
            txt_MonDay.Enabled = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_monday.DataSource = _monday.GetList();
            gcv_monday.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_MonDay monday = new T_MonDay();
                monday.Ten_MonDay = txt_MonDay.Text;
                _monday.Add(monday);
            }
            else
            {
                var tg = _monday.GetItem(_id);
                tg.Ten_MonDay = txt_MonDay.Text;
                _monday.update(tg);
            }
        }
        private void F_MonDay_Load(object sender, EventArgs e)
        {
            _them = false;
            _monday = new MonDay();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_MonDay.Text = string.Empty;
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
                _monday.delete(_id);
                loadData();
                txt_MonDay.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MonDay.Text == "")
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
            txt_MonDay.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_monday_Click(object sender, EventArgs e)
        {
            if (gcv_monday.RowCount > 0)
            {
                _id = int.Parse(gcv_monday.GetFocusedRowCellValue("id_MonDay").ToString());
                txt_MonDay.Text = gcv_monday.GetFocusedRowCellValue("Ten_MonDay").ToString();
            }
        }
    }
}