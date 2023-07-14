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
using Businesslayer;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraSplashScreen;
using Datalayer;
using QL_NHAN_SU.Report;
using DevExpress.XtraReports.UI;

namespace QL_NHAN_SU.ChamCong
{
    public partial class F_BangCongChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public F_BangCongChiTiet()
        {
            InitializeComponent();
        }
        NhanVien _nhanvien;
        KyCong _kycong;
        KyCongChiTiet _kycongchitiet;
        BangCong_NV_ChiTiet _bangcongCT;
        public int _makycong;
        public int _macty;
        public int _thang;
        public int _nam;


        private void F_BangCongChiTiet_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _kycong = new KyCong();
            _kycongchitiet = new KyCongChiTiet();
            _bangcongCT = new BangCong_NV_ChiTiet();
            gcBangCongChiTiet.DataSource = _kycongchitiet.getlist(_makycong);
            gvBangCongChiTiet.OptionsBehavior.Editable = false;
            CustomView(_thang,_nam);
            cb_Thang.Text = _thang.ToString();
            cb_Nam.Text = _nam.ToString();

        }
        public void loadBangCong()
        {
            _kycongchitiet = new KyCongChiTiet();
            gcBangCongChiTiet.DataSource = _kycongchitiet.getlist(int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text));
            CustomView(int.Parse(cb_Thang.Text), int.Parse(cb_Nam.Text));
            gvBangCongChiTiet.OptionsBehavior.Editable = false;
        }
        
        private void btn_phatsinhkycong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(F_Wartifom), true, true);
            if (_kycong.kiemtraPSKC(int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text)))
            {
                MessageBox.Show("Kỳ công đã được phát sinh.", "Thông báo");
                SplashScreenManager.CloseForm();
                return;
            }
            _kycongchitiet.phatsinhkycongchitiet(_macty, int.Parse(cb_Thang.Text), int.Parse(cb_Nam.Text));
            List<T_NhanVien> listNhanVien = _nhanvien.GetList();
            foreach(var item in listNhanVien)
            {
                for (int i = 1; i <= GetDayNumBer(int.Parse(cb_Thang.Text), int.Parse(cb_Nam.Text)); i++)
                {
                    T_BangCong_NVien_ChiTiet bcct = new T_BangCong_NVien_ChiTiet();
                    bcct.id_NhanVien = item.id_NhanVien;
                    bcct.id_NoiLV = item.id_NoiLV;
                    bcct.HoTen = item.HoTen;
                    bcct.GioVao = "08 : 30";
                    bcct.GioRa = "17 : 30";
                    bcct.Ngay = DateTime.Parse(cb_Nam.Text + " - " + cb_Thang.Text + "-" + i.ToString());
                    bcct.Thu = ChamCong_Function.Laythutrongtuan(int.Parse(cb_Nam.Text),int.Parse(cb_Thang.Text),i);
                    bcct.NgayPhep = 0;
                    bcct.CongNgayLe = 0;
                    bcct.CongChuNhat = 0;
                    if(bcct.Thu == "Chủ Nhật")
                    {
                        bcct.KyHieu = "CN";
                        bcct.NgayCong = 0;
                    }
                        
                    else
                    {
                        bcct.KyHieu = "X";
                        bcct.NgayCong = 1;
                    }
                    bcct.MaKyCong = _makycong;
                    bcct.CREATEO_BY = 2000000000;
                    bcct.CREATEO_DATE = DateTime.Now;
                    _bangcongCT.Add(bcct);
                }
            }
            var kc = _kycong.getItem(int.Parse(cb_Nam.Text) * 100 + int.Parse(cb_Thang.Text));
            kc.TrangThai = true;
            _kycong.update(kc);
            SplashScreenManager.CloseForm();
            loadBangCong();
        }

        private void btn_xemkycong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }

        private void btn_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }

        private void btn_print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<T_KyCong_ChiTiet> lst = _kycongchitiet.getlist(_makycong); 
            rpt_BangCong rpt = new rpt_BangCong(lst,_makycong.ToString());
            
            rpt.ShowPreviewDialog();
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void CustomView(int thang,int nam)
        {
            //gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\ChamCong_Layout.xml");
            gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\ChamCong.xml");
            int i;
            foreach (GridColumn gridColumn in gvBangCongChiTiet.Columns)
            {
                if (gridColumn.FieldName == "HoTen") continue;
                RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
                textEdit.Mask.MaskType = MaskType.RegEx;
                textEdit.Mask.EditMask = @"\p{Lu}+";
                gridColumn.ColumnEdit = textEdit;
            }

            for (i = 1; i <= GetDayNumBer(thang, nam); i++){
                DateTime newdate = new DateTime(_nam,_thang,i);
                GridColumn column = new GridColumn();
                column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                string fieldName = "D" + i;
                switch (newdate.DayOfWeek.ToString())
                {
                    case "Monday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Hai" + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;
                    case "Tuesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Ba" + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;
                    case "Wednesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Tư" + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;
                    case "Thursday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Năm" + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;
                    case "Friday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Sáu" + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;
                    case "Saturday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Bảy" + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;
                    case "Sunday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "CN" + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = false;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.GreenYellow;
                        column.AppearanceHeader.BackColor2 = Color.GreenYellow;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Orange;
                        //column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;
                }

            }
            while (i <= 31)
            {
                gvBangCongChiTiet.Columns[i + 1].Visible = false;
                i++;
            }
        }
        private int GetDayNumBer(int thang, int nam)
        {
            int dayNumBer = 0;
            switch (thang)
            {
                case 2:
                    dayNumBer = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumBer = 30;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumBer = 31;
                    break;
            }
            return dayNumBer;
        }

        private void CapNhatNgayCong_Click(object sender, EventArgs e)
        {
            F_CapNhatNgayCong frm = new F_CapNhatNgayCong();
            frm._makycong = int.Parse(gvBangCongChiTiet.GetFocusedRowCellValue("MaKyCong").ToString());
            frm._manv = int.Parse(gvBangCongChiTiet.GetFocusedRowCellValue("id_NhanVien").ToString());
            frm._hoten = gvBangCongChiTiet.GetFocusedRowCellValue("HoTen").ToString();
            frm._ngay = gvBangCongChiTiet.FocusedColumn.FieldName.ToString();
            frm.ShowDialog();
        }

        private void gvBangCongChiTiet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if( e.CellValue == null)
            {

            }
            else
            {
                if(e.CellValue.ToString() == "CT")
                {
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "NL")
                {
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "P")
                {
                    e.Appearance.BackColor = Color.LightBlue;
                    
                }
                if (e.CellValue.ToString() == "V")
                {
                    e.Appearance.BackColor = Color.IndianRed;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }
    }
}