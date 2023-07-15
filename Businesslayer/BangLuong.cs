using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class BangLuong
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_Bang_Luong getitem(int makycong, int mnv)
        {
            return db.T_Bang_Luong.FirstOrDefault(x => x.MakyCong == makycong && x.id_NhanVien == mnv);
        }
        
        public T_Bang_Luong Add(T_Bang_Luong bl)
        {
            try
            {
                db.T_Bang_Luong.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public T_Bang_Luong Update(T_Bang_Luong bl)
        {
            try
            {
                T_Bang_Luong _lb = db.T_Bang_Luong.FirstOrDefault(x => x.MakyCong == bl.MakyCong && x.id_NhanVien == bl.id_NhanVien);
                _lb.id_NhanVien = bl.id_NhanVien;
                _lb.MakyCong = bl.MakyCong;
                _lb.HoTen = bl.HoTen;
                _lb.NgayPhep = bl.NgayPhep;
                _lb.KhongPhep = bl.KhongPhep;
                _lb.NgayLe = bl.NgayLe;
                _lb.NgayChuNhat = bl.NgayChuNhat;
                _lb.NgayThuong = bl.NgayThuong;
                _lb.UngLuong = bl.UngLuong;
                _lb.PhuCap = bl.PhuCap;
                _lb.TangCa = bl.TangCa;
                _lb.ThucLanh = bl.ThucLanh;
                _lb.UPDATEO_BY = bl.UPDATEO_BY;
                _lb.UPDATEO_DATE = bl.UPDATEO_DATE;
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        
    }
}
