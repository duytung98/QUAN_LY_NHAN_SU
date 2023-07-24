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

namespace QL_NHAN_SU
{
    public partial class F_DoiMat_Khau : Form
    {
        public F_DoiMat_Khau()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QUAN_LY_NHAN_SU;Integrated Security=True");
        private void btb_dongy_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count (*) from T_NhanVien where id_NhanVien = '" + txt_taikhoan.Text + "' and Password = N'" + txt_mkcu.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txt_xnmk.Text == txt_mkmoi.Text)
                {
                    if (txt_mkmoi.Text.Length > 8)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update T_NhanVien set Password = '" + txt_mkmoi.Text + "' where id_NhanVien = '" + txt_taikhoan.Text + "' and Password = N'" + txt_mkcu.Text + "'", con);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_mkcu.Text = "";
                        txt_mkmoi.Text = "";
                        txt_xnmk.Text = "";
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu phải từ 8 - 24 ký tự, gồm chữ và số");
                        return;
                    }

                }
                else
                {
                    errorProvider1.SetError(txt_mkmoi, "Bạn chưa điền mật khẩu");
                    errorProvider1.SetError(txt_xnmk, "Xác nhận mật khẩu chưa đúng");
                }
            }
            else
            {
                errorProvider1.SetError(txt_taikhoan, "Tài khoản không đúng !!");
                errorProvider1.SetError(txt_mkcu, "Mật khẩu cũ không đúng !!");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mat1_Click(object sender, EventArgs e)
        {
            if (txt_mkcu.PasswordChar == '*')
            {
                txt_mkcu.PasswordChar = '\0';
            }
            else
            {
                txt_mkcu.PasswordChar = '*';
            }
        }

        private void btn_mat2_Click(object sender, EventArgs e)
        {
            if (txt_mkmoi.PasswordChar == '*')
            {
                txt_mkmoi.PasswordChar = '\0';
            }
            else
            {
                txt_mkmoi.PasswordChar = '*';
            }
        }

        private void btn_mat3_Click(object sender, EventArgs e)
        {
            if (txt_xnmk.PasswordChar == '*')
            {
                txt_xnmk.PasswordChar = '\0';
            }
            else
            {
                txt_xnmk.PasswordChar = '*';
            }
        }
    }
}
