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
using System.IO;
using QL_NHAN_SU.Report;
using Businesslayer.DTO;
using DevExpress.XtraReports.UI;
using System.Text.RegularExpressions;

namespace QL_NHAN_SU
{
    public partial class F_Nhan_Vien : DevExpress.XtraEditors.XtraForm
    {
        public F_Nhan_Vien()
        {
            InitializeComponent();
        }
        NhanVien _NhanVien;
        DanToc _dantoc;
        TonGiao _tongiao;
        ChucVu _chuvu;
        Trinhdo _trinhdo;
        PhongBan _phongban;
        BoPhan _boPhan;
        NoiLamViec _noilamviec;
        List<NhanVienDTO> _lstNVDTO;
        bool _them;
        int _id;
        void _showHide1(bool kt)
        {
            btn_luu3.Enabled = !kt;
            btn_huy3.Enabled = !kt;
            bnt_them.Enabled = kt;
            btn_sua2.Enabled = kt;
            btn_xoa3.Enabled = kt;
            bnt_dong.Enabled = kt;
            bnt_in.Enabled = kt;
            txt_hoten.Enabled = !kt;
            txt_cccd.Enabled = !kt;
            cb_bophan.Enabled = !kt;
            cb_chucvu.Enabled = !kt;
            cb_dantoc.Enabled = !kt;
            cb_goitinh.Enabled = !kt;
            cb_phanQuyen.Enabled = !kt;
            cb_tongao.Enabled = !kt;
            cb_trinhdo.Enabled = !kt;
            Cb_phongban.Enabled = !kt;
            cb_noilv.Enabled = !kt;
            txt_email.Enabled = !kt;
            txt_dienthoai.Enabled = !kt;
            txt_diachi.Enabled = !kt;
            txt_Password.Enabled = !kt;

            btn_chonHA.Enabled = !kt;
            date_ngaySinh.Enabled = !kt;
            label1.Enabled = !kt;
            label2.Enabled = !kt;
            label3.Enabled = !kt;
            label4.Enabled = !kt;
            label5.Enabled = !kt;
            label6.Enabled = !kt;
            label7.Enabled = !kt;
            label8.Enabled = !kt;
            label9.Enabled = !kt;
            label10.Enabled = !kt;
            label11.Enabled = !kt;
            label12.Enabled = !kt;
            label13.Enabled = !kt;
            label14.Enabled = !kt;
            label15.Enabled = !kt;
            label16.Enabled = !kt;

        }
        void loadData()
        {
            gc_nhanvien.DataSource = _NhanVien.getlistFull();
            gcv_nhanvien.OptionsBehavior.Editable = false;
            _lstNVDTO = _NhanVien.getlistFull();
        }
        void loadCombo()
        {
            cb_bophan.DataSource = _boPhan.GetList();
            cb_bophan.DisplayMember = "Ten_BoPhan";
            cb_bophan.ValueMember = "id_BoPhan";

            cb_chucvu.DataSource = _chuvu.GetList();
            cb_chucvu.DisplayMember = "Ten_ChucVu";
            cb_chucvu.ValueMember = "id_ChucVu";

            cb_bophan.DisplayMember = "Ten_PhongBan";
            cb_bophan.ValueMember = "id_BoPhan";

            cb_noilv.DataSource = _noilamviec.GetList();
            cb_noilv.DisplayMember = "Ten_NoiLV";
            cb_noilv.ValueMember = "id_NoiLV";

            cb_dantoc.DataSource = _dantoc.GetList();
            cb_dantoc.DisplayMember = "DanToc";
            cb_dantoc.ValueMember = "id_DanToc";

            cb_tongao.DataSource = _tongiao.GetList();
            cb_tongao.DisplayMember = "TonGiao";
            cb_tongao.ValueMember = "id_TonGiao";

            cb_trinhdo.DataSource = _trinhdo.GetList();
            cb_trinhdo.DisplayMember = "Ten_TrinhDo";
            cb_trinhdo.ValueMember = "id_TrinhDo";

            Cb_phongban.DataSource = _phongban.GetList();
            Cb_phongban.DisplayMember = "Ten_PhongBan";
            Cb_phongban.ValueMember = "id_PhongBan";
        }
        void saveData()
        {
            if (_them)
            {
                T_NhanVien pb = new T_NhanVien();
                pb.HoTen = txt_hoten.Text;
                pb.GioiTinh = cb_goitinh.Text;
                pb.NgaySinh = date_ngaySinh.Value;
                pb.DienThoai = txt_dienthoai.Text;
                pb.Email = txt_email.Text;
                pb.CCCD = txt_cccd.Text;
                pb.DienThoai = txt_dienthoai.Text;
                pb.DiaChi = txt_diachi.Text;
                pb.PhanQuyen = cb_phanQuyen.Text;
                pb.Password = txt_Password.Text;
                pb.HinhAnh = ImageBase64(pcb_hinhanh.Image, pcb_hinhanh.Image.RawFormat);
                pb.id_BoPhan = int.Parse(cb_bophan.SelectedValue.ToString());
                pb.id_ChucVu = int.Parse(cb_chucvu.SelectedValue.ToString());
                pb.id_DanToc = int.Parse(cb_dantoc.SelectedValue.ToString());
                pb.id_NoiLV = int.Parse(cb_noilv.SelectedValue.ToString());
                pb.id_PhongBan = int.Parse(Cb_phongban.SelectedValue.ToString());
                pb.id_TonGiao = int.Parse(cb_tongao.SelectedValue.ToString());
                pb.id_TrinhDo = int.Parse(cb_trinhdo.SelectedValue.ToString());
                _NhanVien.Add(pb);
            }
            else
            {
                var nv = _NhanVien.GetItem(_id);
                nv.HoTen = txt_hoten.Text;
                nv.GioiTinh = cb_goitinh.Text;
                nv.NgaySinh = date_ngaySinh.Value;
                nv.DienThoai = txt_dienthoai.Text;
                nv.Email = txt_email.Text;
                nv.CCCD = txt_cccd.Text;
                nv.DienThoai = txt_dienthoai.Text;
                nv.DiaChi = txt_diachi.Text;
                nv.PhanQuyen = cb_phanQuyen.Text;
                nv.Password = txt_Password.Text;
                nv.HinhAnh = ImageBase64(pcb_hinhanh.Image, pcb_hinhanh.Image.RawFormat);
                nv.id_BoPhan = int.Parse(cb_bophan.SelectedValue.ToString());
                nv.id_ChucVu = int.Parse(cb_chucvu.SelectedValue.ToString());
                nv.id_DanToc = int.Parse(cb_dantoc.SelectedValue.ToString());
                nv.id_NoiLV = int.Parse(cb_noilv.SelectedValue.ToString());
                nv.id_PhongBan = int.Parse(Cb_phongban.SelectedValue.ToString());
                nv.id_TonGiao = int.Parse(cb_tongao.SelectedValue.ToString());
                nv.id_TrinhDo = int.Parse(cb_trinhdo.SelectedValue.ToString());
                _NhanVien.update(nv);
            }
        }
        void _reset()
        {
            txt_hoten.Text = string.Empty;
            txt_cccd.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_dienthoai.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_Password.Text = string.Empty;

        }

        private void F_Nhan_Vien_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide1(true);
            _NhanVien = new NhanVien();
            _dantoc = new DanToc();
            _tongiao = new TonGiao();
            _chuvu = new ChucVu();
            _trinhdo = new Trinhdo();
            _phongban = new PhongBan();
            _boPhan = new BoPhan();
            _noilamviec = new NoiLamViec();
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true;
        }

        private void bnt_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide1(false);
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_sua2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide1(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btn_xoa3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _NhanVien.delete(_id);
                loadData();
                txt_hoten.Text = string.Empty;
                txt_cccd.Text = string.Empty;
                cb_bophan.Text = string.Empty;
                cb_chucvu.Text = string.Empty;
                cb_dantoc.Text = string.Empty;
                cb_goitinh.Text = string.Empty;
                cb_phanQuyen.Text = string.Empty;
                cb_tongao.Text = string.Empty;
                cb_trinhdo.Text = string.Empty;
                Cb_phongban.Text = string.Empty;
                cb_noilv.Text = string.Empty;
                txt_email.Text = string.Empty;
                txt_dienthoai.Text = string.Empty;
                txt_diachi.Text = string.Empty;
                txt_Password.Text = string.Empty;

            }
        }
        public bool checkcout(string ac)//check tk và mk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkout(string em)//check email
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9]{6,50}@gmail.com(.vn|)");
        }

        private void btn_luu3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            double a, b;
            if (cb_noilv.Text == "" || txt_email.Text == "" || txt_dienthoai.Text == "" || txt_diachi.Text == "" || txt_hoten.Text == "" || txt_cccd.Text == ""
                || cb_goitinh.Text == "" || cb_phanQuyen.Text == "" || cb_dantoc.Text == "" || cb_bophan.Text == "" || cb_chucvu.Text == "" || cb_tongao.Text == "" || cb_trinhdo.Text == "" || Cb_phongban.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (!checkcout(txt_Password.Text))
            {
                MessageBox.Show("Mật khẩu phải từ 6 - 24 ký tự, gồm chữ và số");
                return;
            }
            else if (!checkout(txt_email.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email đúng định dạng!!");
                return;
            }
            else if (!double.TryParse(this.txt_dienthoai.Text, out a))
            {
                MessageBox.Show("Số điện thoại phải là số,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (!double.TryParse(this.txt_cccd.Text, out b))
            {
                MessageBox.Show("Số căn cước công dân phải là số,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                _showHide1(true);
                txt_hoten.Text = string.Empty;
                txt_cccd.Text = string.Empty;
                cb_bophan.Text = string.Empty;
                cb_chucvu.Text = string.Empty;
                cb_dantoc.Text = string.Empty;
                cb_goitinh.Text = string.Empty;
                cb_phanQuyen.Text = string.Empty;
                cb_tongao.Text = string.Empty;
                cb_trinhdo.Text = string.Empty;
                Cb_phongban.Text = string.Empty;
                cb_noilv.Text = string.Empty;
                txt_email.Text = string.Empty;
                txt_dienthoai.Text = string.Empty;
                txt_diachi.Text = string.Empty;
                txt_Password.Text = string.Empty;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void btn_huy3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide1(true);

            splitContainer1.Panel1Collapsed = true;
        }

        private void bnt_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_lstNVDTO);
            rpt.ShowRibbonPreview();
        }

        private void bnt_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_conglam_Click(object sender, EventArgs e)
        {
            if (gcv_nhanvien.RowCount > 0)
            {
                _id = int.Parse(gcv_nhanvien.GetFocusedRowCellValue("id_NhanVien").ToString());
                var nv = _NhanVien.GetItem(_id);
                txt_hoten.Text = nv.HoTen;
                date_ngaySinh.Value = nv.NgaySinh.Value;
                txt_cccd.Text = nv.CCCD;
                cb_bophan.SelectedValue = nv.id_BoPhan;
                cb_chucvu.SelectedValue = nv.id_ChucVu;
                cb_dantoc.SelectedValue = nv.id_DanToc;
                cb_goitinh.Text = nv.GioiTinh;
                cb_phanQuyen.Text = nv.PhanQuyen;
                txt_Password.Text = nv.Password;

                cb_tongao.SelectedValue = nv.id_TonGiao;
                cb_trinhdo.SelectedValue = nv.id_TrinhDo;
                Cb_phongban.SelectedValue = nv.id_PhongBan;
                cb_noilv.SelectedValue = nv.id_NoiLV;
                txt_email.Text = nv.Email;
                txt_dienthoai.Text = nv.DienThoai;
                txt_diachi.Text = nv.DiaChi;
                pcb_hinhanh.Image = Base64ToImage(nv.HinhAnh);
            }
        }
        public byte[] ImageBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                Byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }

        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void btn_chonHA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictufile (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcb_hinhanh.Image = Image.FromFile(openFile.FileName);
                pcb_hinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void gcv_nhanvien_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.Name == "DEL" && e.CellValue != null)
            //{
            //    Image img = Properties.Resources.delete1;
            //    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
            //    e.Handled = true;
            //}
        }
    }
    }