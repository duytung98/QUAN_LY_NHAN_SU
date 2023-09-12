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

namespace QL_NHAN_SU.ChamCong
{
    public partial class F_CongChoTungNhanVien : Form
    {
        public F_CongChoTungNhanVien()
        {
            InitializeComponent();
        }
        public F_CongChoTungNhanVien(string user)
        {
            InitializeComponent();
            lblnhanvien.Text = user;
        }

        private void lblnhanvien_Click(object sender, EventArgs e)
        {

        }
        ConnecDaTa c = new ConnecDaTa();
        void loaddata()
        {
            
            dgv_ngaycong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            c.connect();
            DataSet data = new DataSet();
            string query = "select Ngay as N'Ngày đi làm',Thu as N'Thứ',/*GioVao as N'Giờ Vào',GioRa as'Giờ ra',*/NgayPhep as N'Ngày phép',CongNgayLe as N'Ngày lễ',CongChuNhat as N'Chủ nhật',NghiKhongPhep as N'Nghỉ không phép',NgayCong as N'Ngày công',KyHieu as N'Ký hiệu' from T_BangCong_NVien_ChiTiet where MaKyCong = '"+MaKC.Text+"' and id_NhanVien = '"+lblnhanvien.Text+ "'and day(Ngay) between 1 and DAY(GETDATE()) and month(Ngay) between 1 and month(GETDATE()) and year(Ngay) between 1 and year(GETDATE())";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, c.conn);
            sqlData.Fill(data);
            dgv_ngaycong.DataSource = data.Tables[0];
        }
        void loadkycong()
        {
            int makycong = int.Parse(cb_nam.Text) * 100 + int.Parse(cb_thang.Text);
            MaKC.Text = makycong.ToString();
        }

        private void F_CongChoTungNhanVien_Load(object sender, EventArgs e)
        {
            cb_thang.Text = DateTime.Now.Month.ToString();
            cb_nam.Text = DateTime.Now.Year.ToString();
            loadkycong();
            
            loaddata();
        }

        private void F_CongChoTungNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            c.disconnect();
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
