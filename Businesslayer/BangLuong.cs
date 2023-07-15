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
        public List<T_Bang_Luong> getList(int makycong)
        {
            return db.T_Bang_Luong.Where(x => x.MakyCong == makycong).ToList();
        }
        public void TinhLuongnhanvien (int makycong)
        {
            double luongngaythuong, luongphep, luongtangca, luongchunhat, luongngayle, luongphucap, ungluong, thuclanh, hesoluong;
            var lstNV = db.T_NhanVien.Where(x => x.DATHOIVIEC == null).ToList();
            foreach(var item in lstNV)
            {
                var hd = db.T_HopDong.FirstOrDefault(x => x.id_NhanVien == item.id_NhanVien && x.DELETE_BY == null);
                if (hd != null)
                {
                    var kcct = db.T_KyCong_ChiTiet.FirstOrDefault(x => x.MaKyCong == makycong && x.id_NhanVien == item.id_NhanVien);
                    var nangluong = db.T_NhanVien_NangLuong.OrderByDescending(x => x.NgayKy).FirstOrDefault(x => x.So_HopDong == hd.So_HopDong&&x.id_NhanVien==item.id_NhanVien&&x.DELETEO_BY==null);
                    if (nangluong != null)
                    {
                        hesoluong = Convert.ToDouble(nangluong.HSLuongMoi);
                    }
                    else
                    {
                        hesoluong = Convert.ToDouble(hd.HeSoLuong);
                    }
                    var luong1ngaycong = hd.LuongCB * hesoluong / kcct.NgayCong;
                    luongngaythuong = Convert.ToDouble(kcct.TongNgayCong * luong1ngaycong);
                    luongngayle = Convert.ToDouble(kcct.CongNgayLe * luong1ngaycong * 3);
                    luongphep = Convert.ToDouble(kcct.NgayPhep * luong1ngaycong * 0.3);
                    luongchunhat = Convert.ToDouble(kcct.CongChuNhat * luong1ngaycong * 2);
                    luongtangca = Convert.ToDouble(db.T_TangCa.Where(x => (x.Nam * 100 + x.Thang) == makycong && x.id_NhanVien == item.id_NhanVien).Sum(x => x.SoTien));
                    luongphucap = Convert.ToDouble(db.T_NhanVienPhuCap.Where(x => x.id_NhanVien == item.id_NhanVien).Sum(x => x.SoTien));
                    ungluong = Convert.ToDouble(db.T_UngLuong.Where(x => x.id_NhanVien == item.id_NhanVien && (x.Nam_Ung * 100 + x.Thang_Ung) == makycong).Sum(x => x.So_Tien_Ung));
                    thuclanh = luongngaythuong + luongphep + luongngayle + luongchunhat + luongtangca + luongphucap - ungluong;
                    T_Bang_Luong bl = new T_Bang_Luong();
                    bl.MakyCong = makycong;
                    bl.id_NhanVien = item.id_NhanVien;
                    bl.HoTen = item.HoTen;
                    bl.NgayCongTrongThang = int.Parse(kcct.NgayCong.ToString());
                    bl.NgayPhep = luongphep;
                    bl.NgayChuNhat = luongchunhat;
                    bl.NgayLe = luongngayle;
                    bl.NgayThuong = luongngaythuong;
                    bl.PhuCap = luongphucap;
                    bl.TangCa = luongtangca;
                    bl.ThucLanh = thuclanh;
                    bl.UngLuong = ungluong;
                    bl.CREATEO_BY = 2000000000;
                    bl.CREATEO_DATE = DateTime.Now;
                    Add(bl);
                }
                

            }
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
