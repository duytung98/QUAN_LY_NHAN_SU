using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAN_SU
{
    public partial class FormMain_NhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        public FormMain_NhanVien(string tk)
        {
            InitializeComponent();
            lbl_nhanvien.Text = tk;
        }

        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();

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

        private void btn_lichlamviec_ItemClick(object sender, ItemClickEventArgs e)
        {
            LichLamViec.F_LichLamviecChoNV f_LichLamVicChoTungNV = new LichLamViec.F_LichLamviecChoNV(lbl_nhanvien.Text);
            f_LichLamVicChoTungNV.ShowDialog();
        }

        private void FormMain_NhanVien_Load(object sender, EventArgs e)
        {
            ribbon.SelectedPage = btbThongTin;
            loadphanhoi();
        }
        void loadphanhoi()
        {
            ConnecDaTa c = new ConnecDaTa();
            c.connect();
            DataSet data = new DataSet();
            string query = "select T_PhanhoiQL1.id_NhanVien,HoTen,NoiDung,ThoiGianGui  from T_PhanhoiQL1,T_NhanVien  where T_PhanhoiQL1.id_NhanVien = T_NhanVien.id_NhanVien and id_Nguoinhan = '"+lbl_nhanvien.Text+"' and DAY(ThoiGianGui) =DAY(GETDATE())and month(ThoiGianGui) =month(GETDATE())and year(ThoiGianGui) =year(GETDATE())";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, c.conn);
            sqlData.Fill(data);
            list_phanhoi.DataSource = data.Tables[0];
            c.disconnect();
        }

        private void txt_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thongtinnv_ItemClick(object sender, ItemClickEventArgs e)
        {
            F_ThongTincaNhan f_ThongTincaNhan = new F_ThongTincaNhan(lbl_nhanvien.Text);
            f_ThongTincaNhan.ShowDialog();
        }

        private void FormMain_NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChamCong.F_CongChoTungNhanVien f_CongChoTungNhan = new ChamCong.F_CongChoTungNhanVien(lbl_nhanvien.Text);
            f_CongChoTungNhan.ShowDialog();
        }

        private void btn_phanhoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            F_PhanHoi f_PhanHoi = new F_PhanHoi(lbl_nhanvien.Text);
            f_PhanHoi.ShowDialog();
        }

        private void list_phanhoi_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }
    }
}