using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Businesslayer;
using QL_NHAN_SU.Report;

namespace QL_NHAN_SU
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(string tk)
        {
            InitializeComponent();
            label1.Text = tk;
        }
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren) 
            {
                if(frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();

        }
        NhanVien _nhanvien;
        HopDongLaoDong _HDLD;


        private void btn_phucap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(ChamCong.F_Phucap));
        }

        private void btn_DanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_DanToc));
        }

        private void btn_tongiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_TonGiao));
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _HDLD = new HopDongLaoDong();
            ribbonControl1.SelectedPage = NhanSu;
            loadSinhNhat();
            loattangLuong();
        }
        void loadSinhNhat()
        {
            list_SinhNhat.DataSource = _nhanvien.getSinhNhat();
            list_SinhNhat.DisplayMember = "HoTen";
            list_SinhNhat.ValueMember = "id_NhanVien";
        }
        void loattangLuong()
        {
            list_Lenluong.DataSource = _HDLD.getTangLuong();
            list_Lenluong.DisplayMember = "HoTen";
            list_Lenluong.ValueMember = "id_NhanVien";
        }

        private void btn_trinhdo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_TrinhDo));
        }

        private void btn_chucvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_ChucVu));
        }

        private void btn_phongban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_PhongBan));
        }

        private void btn_boPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_BoPhan));
        }

        private void btn_NoiLV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_NoiLamViec));
        }

        private void NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_Nhan_Vien));
        }

        private void HopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_HopDongLD));
        }

        private void KhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_KhenThuong_KL));
        }

        private void DieuChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_NhanVien_DieuChuyen));
        }

        private void ThoiViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_NhanVienThoiViec));
        }

        private void list_SinhNhat_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if(e.TemplatedItem.Elements[1].Text.Substring(0,2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }

        private void list_Lenluong_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            //if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Day.ToString())
            //{
            //    e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            //}
        }

        private void Nangluong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_NangLuong));
        }

        private void list_SinhNhat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_khoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(LichLamViec.F_Khoa));
        }

        private void btn_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(LichLamViec.F_LopDay));
        }

        private void btn_MonD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(LichLamViec.F_MonDay));
        }

        private void btn_KhoaHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(LichLamViec.F_KhoaHoc));
        }

        private void btn_PhongHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(LichLamViec.F_PhongHoc));
        }

        private void btn_lich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(LichLamViec.F_LichDay));
        }

        private void btn_loaica_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(ChamCong.F_CaLam));
        }

        private void btn_loaicong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(ChamCong.F_LoaiCong));
        }

        private void btn_BangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(ChamCong.F_BangCong));
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_DangNhap f_DangNhap = new F_DangNhap();

            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                //this.Hide();
                //f_DangNhap.ShowDialog();
                //f_DangNhap = null;
                this.Close();

            }
        }

        private void btn_BangCongchitiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_bangcongnhanvienchitiet frm = new F_bangcongnhanvienchitiet();
            frm.ShowDialog();
        }

        private void btn_tangca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(ChamCong.F_TangCa));
        }

        private void btn_ungluong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(ChamCong.F_UngLuong));
        }

        private void btn_BangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(TinhLuong.F_BangLuong));
        }

        private void btn_BaoHiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(F_BaoHiem));
        }

        private void DoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_DoiMat_Khau f_DoiMatKhau = new F_DoiMat_Khau();
            f_DoiMatKhau.ShowDialog();
        }

        private void ThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_ThongTincaNhan f_ThongTincaNhan = new F_ThongTincaNhan(label1.Text);
            f_ThongTincaNhan.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
