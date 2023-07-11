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
    public partial class F_DangNhap : Form
    {
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
    }
}
