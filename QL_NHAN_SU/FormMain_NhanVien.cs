using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAN_SU
{
    public partial class FormMain_NhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                //this.Hide();
                //f_DangNhap.ShowDialog();
                //f_DangNhap = null;
                this.Close();

            }
        }

        private void btn_DoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            F_DoiMat_Khau f_DoiMatKhau = new F_DoiMat_Khau();
            f_DoiMatKhau.ShowDialog();
        }
    }
}