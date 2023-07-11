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
    public partial class F_CaLam : DevExpress.XtraEditors.XtraForm
    {
        public F_CaLam()
        {
            InitializeComponent();
        }
        CaLam _calam;
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
            txt_calam.Enabled = !kt;
            sp_hesoca.EditValue = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_calam.DataSource = _calam.GetList();
            gcv_calam.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                T_LoaiCa ca = new T_LoaiCa();
                ca.TenLoaiCa = txt_calam.Text;
                ca.HeSo = double.Parse(sp_hesoca.EditValue.ToString());
                _calam.Add(ca);
            }
            else
            {
                var tg = _calam.GetItem(_id);
                tg.TenLoaiCa = txt_calam.Text;
                tg.HeSo = double.Parse(sp_hesoca.EditValue.ToString());
                _calam.update(tg);
            }
        }

        private void F_CaLam_Load(object sender, EventArgs e)
        {
            _them = false;
            _calam = new CaLam();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_calam.Text = string.Empty;
            txt_calam.Text = string.Empty;
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
                _calam.delete(_id);
                loadData();
                txt_calam.Text = string.Empty;
                sp_hesoca.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_calam.Text == ""||sp_hesoca.Text =="")
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
            txt_calam.Text = string.Empty;
            sp_hesoca.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_calam_Click(object sender, EventArgs e)
        {
            if (gcv_calam.RowCount > 0)
            {
                _id = int.Parse(gcv_calam.GetFocusedRowCellValue("id_LoaiCa").ToString());
                txt_calam.Text = gcv_calam.GetFocusedRowCellValue("TenLoaiCa").ToString();
                sp_hesoca.Text = gcv_calam.GetFocusedRowCellValue("HeSo").ToString();
            }
        }
    }
}