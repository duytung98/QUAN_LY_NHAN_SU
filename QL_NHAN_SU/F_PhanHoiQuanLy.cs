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
    public partial class F_PhanHoiQuanLy : Form
    {
        public F_PhanHoiQuanLy()
        {
            InitializeComponent();
        }
        public F_PhanHoiQuanLy(string tk)
        {
            InitializeComponent();
            lblnhanvien.Text = tk;
        }

        private void F_PhanHoiQuanLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_NHAN_SUDataSet.T_NhanVien' table. You can move, or remove it, as needed.
            this.t_NhanVienTableAdapter.Fill(this.qUAN_LY_NHAN_SUDataSet.T_NhanVien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnecDaTa c = new ConnecDaTa();
            c.connect();

            if (txt_phanhoi.Text == ""||cb_ngnhan.Text=="")
            {
                MessageBox.Show("Vui lòng nhập phản hồi!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string query = "insert into T_PhanhoiQL1 values('" + lblnhanvien.Text + "','"+cb_ngnhan.Text+"',N'" + txt_phanhoi.Text + "',GETDATE())";
                bool kq = c.exeSQL(query);
                MessageBox.Show("Gửi thành công!!", "Thông báo", MessageBoxButtons.OK);
                cb_ngnhan.Text = "";
                txt_phanhoi.Text = "";
            }

            c.disconnect();
        }
    }
}
