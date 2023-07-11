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
    public partial class F_PhongBan : DevExpress.XtraEditors.XtraForm
    {
        public F_PhongBan()
        {
            InitializeComponent();
        }
        PhongBan _phongban;
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
            txt_phongban.Enabled = !kt;
            label1.Enabled = !kt;
        }
        void loadData()
        {
            gc_phongban.DataSource = _phongban.GetList();
            gcv_phongban.OptionsBehavior.Editable = false;
        }

        private void gcv_phongban_Click(object sender, EventArgs e)
        {
            if (gcv_phongban.RowCount > 0)
            {
                _id = int.Parse(gcv_phongban.GetFocusedRowCellValue("id_PhongBan").ToString());
                txt_phongban.Text = gcv_phongban.GetFocusedRowCellValue("Ten_PhongBan").ToString();
            }
            
        }

        private void F_PhongBan_Load(object sender, EventArgs e)
        {
            _them = false;
            _phongban = new PhongBan();
            _showHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }
        void saveData()
        {
            if (_them)
            {
                T_PhongBan pb = new T_PhongBan();
                pb.Ten_PhongBan = txt_phongban.Text;
                _phongban.Add(pb);
            }
            else
            {
                var tg = _phongban.GetItem(_id);
                tg.Ten_PhongBan = txt_phongban.Text;
                _phongban.update(tg);
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }


        private void btn_them_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txt_phongban.Text = string.Empty;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_sua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_xoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _phongban.delete(_id);
                loadData();
                txt_phongban.Text = string.Empty;
            }
        }

        private void btn_luu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_phongban.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide(true);
                txt_phongban.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void btn_huy_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txt_phongban.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btn_in_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_dong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}