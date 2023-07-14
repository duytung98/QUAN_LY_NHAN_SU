using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class KyCongChiTiet
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_KyCong_ChiTiet getitem(int makycong,int manv)
        {
            return db.T_KyCong_ChiTiet.FirstOrDefault(x => x.MaKyCong == makycong && x.id_NhanVien == manv);
        }
        public List<T_KyCong_ChiTiet> getlist(int makycong)
        {
            return db.T_KyCong_ChiTiet.Where(x => x.MaKyCong == makycong).ToList();
        }
        public void phatsinhkycongchitiet(int macty,int thang, int nam)
        {
            var lstNV = db.T_NhanVien.ToList();
            if (lstNV.Count == 0) return;
            foreach(var item in lstNV)
            {
                List<string> lstDay = new List<string>();

                for(int j = 1;j <= GetDayNumBer(thang, nam); j++)
                {
                    DateTime newDate = new DateTime(nam, thang, j);
                    switch (newDate.DayOfWeek.ToString())
                    {
                        //case "Saturday":
                        //    lstDay.Add("T7");
                        //    break;
                        case "Sunday":
                            lstDay.Add("CN");
                            break;

                        default:
                            lstDay.Add("X");
                            break;
                    }
                }
                switch (lstDay.Count)
                {
                    case 28:
                        lstDay.Add("");
                        lstDay.Add("");
                        lstDay.Add("");
                        break;
                    case 29:
                        lstDay.Add("");
                        lstDay.Add("");
                        break;
                    case 30:
                        lstDay.Add("");
                        break;
                }
                T_KyCong_ChiTiet kicongCT = new T_KyCong_ChiTiet();
                kicongCT.MaKyCong = nam * 100 + thang;
                kicongCT.id_NhanVien = item.id_NhanVien;
                kicongCT.HoTen = item.HoTen;
                kicongCT.id_NoiLV = item.id_NoiLV;
                kicongCT.D1 = lstDay[0];
                kicongCT.D2 = lstDay[1];
                kicongCT.D3 = lstDay[2];
                kicongCT.D4 = lstDay[3];
                kicongCT.D5 = lstDay[4];
                kicongCT.D6 = lstDay[5];
                kicongCT.D7 = lstDay[6];
                kicongCT.D8 = lstDay[7];
                kicongCT.D9 = lstDay[8];
                kicongCT.D10 = lstDay[9];
                kicongCT.D11 = lstDay[10];
                kicongCT.D12 = lstDay[11];
                kicongCT.D13 = lstDay[12];
                kicongCT.D14 = lstDay[13];
                kicongCT.D15 = lstDay[14];
                kicongCT.D16 = lstDay[15];
                kicongCT.D17 = lstDay[16];
                kicongCT.D18 = lstDay[17];
                kicongCT.D19 = lstDay[18];
                kicongCT.D20 = lstDay[19];
                kicongCT.D21 = lstDay[20];
                kicongCT.D22 = lstDay[21];
                kicongCT.D23 = lstDay[22];
                kicongCT.D24 = lstDay[23];
                kicongCT.D25 = lstDay[24];
                kicongCT.D26 = lstDay[25];
                kicongCT.D27 = lstDay[26];
                kicongCT.D28 = lstDay[27];
                kicongCT.D29 = lstDay[28];
                kicongCT.D30 = lstDay[29];
                kicongCT.D31 = lstDay[30];
                kicongCT.NgayCong = MyFunction.demngaycongtrongthang(thang, nam);
                kicongCT.TongNgayCong = MyFunction.demngaycongtrongthang(thang, nam);
                db.T_KyCong_ChiTiet.Add(kicongCT);
                db.SaveChanges();
            }
            
        }
        public T_KyCong_ChiTiet Update(T_KyCong_ChiTiet kcct)
        {
            var kicongCT = db.T_KyCong_ChiTiet.FirstOrDefault(x => x.MaKyCong == kcct.MaKyCong && x.id_NhanVien == kcct.id_NhanVien);
            kicongCT.D1 = kcct.D1;
            kicongCT.D2 = kcct.D2;
            kicongCT.D3 = kcct.D3;
            kicongCT.D4 = kcct.D4;
            kicongCT.D5 = kcct.D5;
            kicongCT.D6 = kcct.D6;
            kicongCT.D7 = kcct.D7;
            kicongCT.D8 = kcct.D8;
            kicongCT.D9 = kcct.D9;
            kicongCT.D10 = kcct.D10;
            kicongCT.D11 = kcct.D11;
            kicongCT.D12 = kcct.D12;
            kicongCT.D13 = kcct.D13;
            kicongCT.D14 = kcct.D14;
            kicongCT.D15 = kcct.D15;
            kicongCT.D16 = kcct.D16;
            kicongCT.D17 = kcct.D17;
            kicongCT.D18 = kcct.D18;
            kicongCT.D19 = kcct.D19;
            kicongCT.D20 = kcct.D20;
            kicongCT.D21 = kcct.D21;
            kicongCT.D22 = kcct.D22;
            kicongCT.D23 = kcct.D23;
            kicongCT.D24 = kcct.D24;
            kicongCT.D25 = kcct.D25;
            kicongCT.D26 = kcct.D26;
            kicongCT.D27 = kcct.D27;
            kicongCT.D28 = kcct.D28;
            kicongCT.D29 = kcct.D29;
            kicongCT.D30 = kcct.D30;
            kicongCT.D31 = kcct.D31;
            kicongCT.NgayPhep = kcct.NgayPhep;
            kicongCT.CongNgayLe = kcct.CongNgayLe;
            kicongCT.CongChuNhat = kcct.CongChuNhat;
            kicongCT.NghiKhongPhep = kcct.NghiKhongPhep;
            kicongCT.TongNgayCong = kcct.TongNgayCong;
            //kicongCT.UPDATEO_BY = kcct.UPDATEO_BY;
            //kicongCT.UPDATEO_DATE = kcct.UPDATEO_DATE;
            db.SaveChanges();
            return kcct;
        }
        private int GetDayNumBer(int thang,int nam)
        {
            int dayNumBer = 0;
            switch (thang)
            {
                case 2: dayNumBer = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
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
    }
}
