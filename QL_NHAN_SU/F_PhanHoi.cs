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
    public partial class F_PhanHoi : Form
    {
        public F_PhanHoi()
        {
            InitializeComponent();
        }
        public F_PhanHoi(string user)
        {
            InitializeComponent();
            lblnhanvien.Text = user;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_PhanHoi_Load(object sender, EventArgs e)
        {
            txt_phanhoi.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnecDaTa c = new ConnecDaTa();
            c.connect();
           
            if(txt_phanhoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập phản hồi!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string query = "insert into T_PhanHoi values('" + lblnhanvien.Text + "',N'" + txt_phanhoi.Text + "',GETDATE())";
                bool kq = c.exeSQL(query);
                MessageBox.Show("Gửi thành công!!", "Thông báo", MessageBoxButtons.OK);
                txt_phanhoi.Text = "";
            }
            
            c.disconnect();
        }
    }
}
