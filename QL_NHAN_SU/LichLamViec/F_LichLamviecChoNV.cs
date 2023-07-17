using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QL_NHAN_SU.LichLamViec
{
    public partial class F_LichLamviecChoNV : Form
    {
        public F_LichLamviecChoNV()
        {
            InitializeComponent();
            
        }

        public F_LichLamviecChoNV(string user)
        {
            InitializeComponent();
            lblnhanvien.Text = user;
        }
        

        ConnecDaTa c = new ConnecDaTa();
        void loaddata()
        {
            dgv_lichlamviec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            c.connect();
            DataSet data = new DataSet();
            string query = "select /*T_LichLV.id_NhanVien as N'MÃ NHÂN VIÊN',HoTen as N'HỌ VÀ TÊN',*/Ten_NoiLV AS N'NƠI DẠY',Ten_Khoa AS N'KHOA',Ten_KhoaDay AS N'KHÓA DẠY',Ten_LopDay AS N'LỚP DẠY',Ten_MonDay AS N'MÔN DẠY',Ten_PhongHoc AS N'PHÒNG HỌC',SoTin AS N'SỐ TÍN',CONVERT(varchar, ThoiGianBD, 103) AS N'THỜI GIAN BẮT ĐẦU',CONVERT(varchar, ThoiGianKT, 103)AS N'THỜI GIAN KẾT THÚC',TenLoaiCa AS N'CA DẠY' from T_LichLV,T_NhanVien,T_NoiLamViec,T_Khoa,T_KhoaDay,T_LopDay,T_MonDay,T_PhongHoc,T_LoaiCa where T_LichLV.id_NhanVien = T_NhanVien.id_NhanVien and T_LichLV.id_NoiLV = T_NoiLamViec.id_NoiLV and T_Khoa.id_Khoa = T_LichLV.id_Khoa and T_KhoaDay.id_KhoaDay = T_LichLV.id_KhoaDay and T_LopDay.id_LopDay = T_LichLV.id_LopDay and T_MonDay.id_MonDay = T_LichLV.id_MonDay and T_PhongHoc.id_PhongHoc = T_LichLV.id_PhongHoc and T_LoaiCa.id_LoaiCa = T_LichLV.id_LoaiCa and T_LichLV.id_NhanVien = '" + lblnhanvien.Text + "' and T_LichLV.DELETEO_BY is null and T_NhanVien.DATHOIVIEC is null and MONTH(ThoiGianBD) = '" + cb_thang.Text + "' and YEAR(ThoiGianBD) = '" + cb_nam.Text + "'";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, c.conn);
            sqlData.Fill(data);
            dgv_lichlamviec.DataSource = data.Tables[0];
        }
        
        private void F_LichLamviecChoNV_Load(object sender, EventArgs e)
        {
            cb_thang.Text = DateTime.Now.Month.ToString();
            cb_nam.Text = DateTime.Now.Year.ToString();
            loaddata();
            
        }

        private void cb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
