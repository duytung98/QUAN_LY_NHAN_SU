using DevExpress.Utils.Extensions;
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

namespace QL_NHAN_SU.ChamCong
{
    public partial class F_CapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public F_CapNhatNgayCong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _Cngay;
        F_BangCongChiTiet FBcct = (F_BangCongChiTiet) Application.OpenForms["F_BangCongChiTiet"];
        KyCongChiTiet _kcct;
        BangCong_NV_ChiTiet _Bcct_nhanVien;

        private void F_CapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KyCongChiTiet();
            _Bcct_nhanVien = new BangCong_NV_ChiTiet();
            lbl_nv.Text = _manv.ToString();
            lbl_hoten.Text = _hoten.ToString();
            string nam = _makycong.ToString().Substring(0, 4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + " - " + ngay);
            cdr_ngaycong.SetDate(_d);
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_manv.ToString() + " - " + _makycong.ToString() + "-" + _ngay);
            string _valulchamcong = rdg_ChamCong.Properties.Items[rdg_ChamCong.SelectedIndex].Value.ToString();
            string _valungaynghi = rdg_ngaynghi.Properties.Items[rdg_ngaynghi.SelectedIndex].Value.ToString();
            string fleName = "D" + _Cngay.ToString();
            var kcct = _kcct.getitem(_makycong, _manv);
            //double? tongngaycong = kcct.TongNgayCong;
            //double? tongngayphep = kcct.NgayPhep;
            //double? tongngaykhongphep = kcct.NghiKhongPhep;
            //double? tongngayle = kcct.CongNgayLe;
            if(cdr_ngaycong.SelectionRange.Start.Year*100 + cdr_ngaycong.SelectionRange.Start.Month != _makycong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }

            ChamCong_Function.exeQuery("Update T_KyCong_ChiTiet set " + fleName + " = '" + _valulchamcong + "' where MaKyCong = " + _makycong + " and id_NhanVien = "+_manv+" ");
            T_BangCong_NVien_ChiTiet bcctnv = _Bcct_nhanVien.getitem(_makycong, _manv, cdr_ngaycong.SelectionStart.Day);
            bcctnv.KyHieu = _valulchamcong;
            if(cdr_ngaycong.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                if (_valungaynghi == "NN")
                {
                    bcctnv.NgayPhep = 0;
                    bcctnv.NgayCong = 0;
                    bcctnv.CongChuNhat = 1;
                    bcctnv.CongNgayLe = 0;
                    bcctnv.NghiKhongPhep = 0;

                }
                else
                {
                    bcctnv.NgayPhep = 0;
                    bcctnv.NgayCong = 0;
                    bcctnv.CongChuNhat = 0.5;
                    bcctnv.CongNgayLe = 0;
                    bcctnv.NghiKhongPhep = 0;

                }
            }
            else
            {
                bcctnv.KyHieu = _valulchamcong;
                switch (_valulchamcong)
                {
                    case "P":

                        if (_valungaynghi == "NN")
                        {
                            bcctnv.NgayPhep = 1;
                            bcctnv.NgayCong = 0;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 0;
                            bcctnv.NghiKhongPhep = 0;

                        }
                        else
                        {
                            bcctnv.NgayPhep = 0.5;
                            bcctnv.NgayCong = 0.5;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 0;
                            bcctnv.NghiKhongPhep = 0;

                        }
                        break;
                    case "CT":

                        if (_valungaynghi == "NN")
                        {
                            bcctnv.NgayCong = 1;
                            bcctnv.NgayPhep = 0;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 0;
                            bcctnv.NghiKhongPhep = 0;
                        }
                        else
                        {
                            bcctnv.NgayPhep = 0.5;
                            bcctnv.NgayCong = 0.5;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 0;
                            bcctnv.NghiKhongPhep = 0;

                        }
                        break;
                    case "V":
                        if (_valungaynghi == "NN")
                        {
                            bcctnv.NgayCong = 0;
                            bcctnv.NgayPhep = 0;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 0;
                            bcctnv.NghiKhongPhep = 1;
                        }
                        else
                        {
                            bcctnv.NgayPhep = 0;
                            bcctnv.NgayCong = 0.5;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 0;
                            bcctnv.NghiKhongPhep = 0;

                        }
                        break;
                    case "NL":

                        if (_valungaynghi == "NN")
                        {
                            bcctnv.NgayCong = 1;
                            bcctnv.NgayPhep = 0;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 1;
                            bcctnv.NghiKhongPhep = 0;
                        }
                        else
                        {
                            bcctnv.NgayPhep = 0;
                            bcctnv.NgayCong = 0.5;
                            bcctnv.CongChuNhat = 0;
                            bcctnv.CongNgayLe = 0.5;
                            bcctnv.NghiKhongPhep = 0;

                        }
                        break;

                    default:
                        break;
                }
            }
            

            _Bcct_nhanVien.Update(bcctnv);
            double tongngayphep = _Bcct_nhanVien.tongngayphep(_makycong, _manv);
            
            double tongngayle = _Bcct_nhanVien.tongngaynghile(_makycong, _manv);
            double tongngaykophep = _Bcct_nhanVien.tongngaycongvang(_makycong, _manv);
            double tongcongchunhat = _Bcct_nhanVien.tongcongchunhat(_makycong, _manv);
            double tongngaycong = _Bcct_nhanVien.tongngaycong(_makycong, _manv);

            kcct.NgayPhep = tongngayphep;
            kcct.TongNgayCong = tongngaycong;
            kcct.CongNgayLe = tongngayle;
            kcct.CongChuNhat = tongcongchunhat;
            kcct.NghiKhongPhep = tongngaykophep;

            _kcct.Update(kcct);
            FBcct.loadBangCong();
            

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cdr_ngaycong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _Cngay=cdr_ngaycong.SelectionRange.Start.Day;
        }
    }
}