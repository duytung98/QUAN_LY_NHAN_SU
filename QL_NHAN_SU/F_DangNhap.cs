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


namespace QL_NHAN_SU
{

    public partial class F_DangNhap : Form
    {
        public static int tk;

        public F_DangNhap()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void link_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }

        private void link_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void cb_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_matkhau.PasswordChar == '*')
            {
                txt_matkhau.PasswordChar = '\0';
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }
        
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ConnecDaTa c = new ConnecDaTa();
            c.connect();
            string sql = "select * from T_NhanVien where id_NhanVien = '" + txt_taikhoan.Text + "' and Password = N'" + txt_matkhau.Text + "' and  PhanQuyen = N'" + cb_phanquyen.Text + "' and DATHOIVIEC is null";
            SqlCommand command = new SqlCommand(sql, c.conn);
            SqlDataReader reader = command.ExecuteReader();

            if(txt_matkhau.Text == "" || txt_taikhoan.Text == "" || cb_phanquyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else if(txt_taikhoan.Text== "Admin" && txt_matkhau.Text == "duytung98" && cb_phanquyen.Text == "Quản lý")
            //{
            //    this.Hide();
            //    FormMain f_Main = new FormMain(txt_taikhoan.Text);
            //    f_Main.ShowDialog();
            //    f_Main = null;
            //    txt_matkhau.Text = "";
            //    this.Show();
            //}
            else if (txt_taikhoan.Text.Length > 10)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng? Vui lòng nhập lại tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txt_matkhau.Text = "";
            }
            else if(reader.Read() == true)
            {
                if (cb_phanquyen.Text == "Quản lý")
                {
                    F_ThongTincaNhan f_ThongTincaNhan = new F_ThongTincaNhan(txt_taikhoan.Text);
                    this.Hide();
                    FormMain f_Main = new FormMain(txt_taikhoan.Text);
                    f_Main.ShowDialog();
                    f_Main = null;
                    txt_matkhau.Text = "";
                    this.Show();
                    tk = int.Parse(txt_taikhoan.Text);
                    
                }
                else if (cb_phanquyen.Text == "Nhân viên")
                {
                    this.Hide();
                    F_ThongTincaNhan f_ThongTincaNhan = new F_ThongTincaNhan(txt_taikhoan.Text);
                    LichLamViec.F_LichLamviecChoNV f_LichLamviecChoNV = new LichLamViec.F_LichLamviecChoNV(txt_taikhoan.Text);
                    FormMain_NhanVien f_Main = new FormMain_NhanVien(txt_taikhoan.Text);
                    f_Main.ShowDialog();
                    f_Main = null;
                    txt_matkhau.Text = "";
                    this.Show();
                    tk = int.Parse(txt_taikhoan.Text);

                }
            }
            
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng? Vui lòng nhập lại tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txt_matkhau.Text = "";
            }
            c.disconnect();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn thoát??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
