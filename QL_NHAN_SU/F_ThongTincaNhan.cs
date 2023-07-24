using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ZXing;
using System.Windows.Media.Imaging;

namespace QL_NHAN_SU
{
    public partial class F_ThongTincaNhan : Form
    {
        public F_ThongTincaNhan()
        {
            InitializeComponent();
        }
        public F_ThongTincaNhan(string manv)
        {
            InitializeComponent();
            txt_manv.Text = manv;
            lbl_manv.Text = manv;
        }
        ConnecDaTa c = new ConnecDaTa();
        private void F_ThongTincaNhan_Load(object sender, EventArgs e)
        {
            
            c.connect();
            SqlCommand cmd = new SqlCommand("select * from T_NhanVien,T_TonGiao,T_DanToc,T_NoiLamViec,T_TrinhDo,T_PhongBan,T_BoPhan,T_ChucVu where T_NhanVien.id_TonGiao = T_TonGiao.id_TonGiao and T_NhanVien.id_DanToc = T_DanToc.id_DanToc and T_NhanVien.id_NoiLV = T_NoiLamViec.id_NoiLV and T_NhanVien.id_TrinhDo = T_TrinhDo.id_TrinhDo and T_NhanVien.id_PhongBan = T_PhongBan.id_PhongBan and T_NhanVien.id_BoPhan = T_BoPhan.id_BoPhan and T_NhanVien.id_ChucVu =T_ChucVu.id_ChucVu and id_NhanVien = '"+txt_manv.Text+"'  ", c.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    lbl_hoten.Text = reader["HoTen"].ToString();
                    txt_hoten.Text = reader["HoTen"].ToString();
                    date_ngaysinh.Text = reader["NgaySinh"].ToString();
                    lbl_NgaySinh.Text = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy");
                    lbl_dienthoai.Text = reader["DienThoai"].ToString();
                    txt_dienthoai.Text = reader["DienThoai"].ToString();
                    txt_gioitinh.Text = reader["GioiTinh"].ToString();
                    txt_dantoc.Text = reader["DanToc"].ToString();
                    txt_tongiao.Text = reader["TonGiao"].ToString();
                    txt_cccd.Text = reader["CCCD"].ToString();
                    txt_diachi.Text = reader["DiaChi"].ToString();
                    txt_email.Text = reader["Email"].ToString();
                    txt_trinhdo.Text = reader["Ten_TrinhDo"].ToString();
                    txt_phongban.Text = reader["Ten_PhongBan"].ToString();
                    txt_bophan.Text = reader["Ten_BoPhan"].ToString();
                    txt_chucvu.Text = reader["Ten_ChucVu"].ToString();
                    txt_noilv.Text = reader["Ten_NoiLV"].ToString();
                    loadimg();
                    loadingBarcode();
                    txt_chucvu.Focus();

                }
            }
            finally
            {
                reader.Close();
            }

        }
        void loadimg()
        {
            
            c.connect();
            SqlCommand cmd = new SqlCommand("select HinhAnh from T_NhanVien where id_NhanVien = '" + txt_manv.Text + "'  ", c.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if(reader["HinhAnh"] != DBNull.Value)
                {
                    byte[] imData = (byte[])reader["HinhAnh"];
                    using (MemoryStream ms = new MemoryStream(imData))
                    {
                        pic_hinhanh.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        void loadingBarcode()
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_93 };
            writer.Options.Height = 50;
            writer.Options.Width = 200;
            pic_barQR.Image = writer.Write(lbl_manv.Text);

            //Image image = null;
            //BitmapImage bimg = new BitmapImage();
            //using (var ms = new MemoryStream())
            //{
            //    BarcodeWriter writer;
            //    writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_93 };
            //    writer.Options.Height = 50;
            //    writer.Options.Width = 200;
            //    writer.Options.PureBarcode = true;
            //    image = writer.Write(lbl_manv.Text);
            //    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    ms.Position = 0;
            //    bimg.BeginInit();
            //    bimg.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
            //    bimg.CacheOption = BitmapCacheOption.OnLoad;
            //    bimg.UriSource = null;
            //    bimg.StreamSource = ms;
            //    bimg.EndInit();


            //    pic_barQR.source = bimg;
            
        }

        private void F_ThongTincaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            c.disconnect();
        }
    }
}
