using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class BangCong_NV_ChiTiet
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_BangCong_NVien_ChiTiet getitem(int makycong,int mnv,int ngay)
        {
            return db.T_BangCong_NVien_ChiTiet.FirstOrDefault(x => x.MaKyCong == makycong && x.id_NhanVien == mnv && x.Ngay.Value.Day == ngay);
        }
        public List<T_BangCong_NVien_ChiTiet> getBangcongchitiet(int makycong,int manv)
        {
            return db.T_BangCong_NVien_ChiTiet.Where(x => x.MaKyCong == makycong && x.id_NhanVien == manv).ToList();
        }
        public T_BangCong_NVien_ChiTiet Add(T_BangCong_NVien_ChiTiet bcct)
        {
            try
            {
                db.T_BangCong_NVien_ChiTiet.Add(bcct);
                db.SaveChanges();
                return bcct;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public T_BangCong_NVien_ChiTiet Update(T_BangCong_NVien_ChiTiet bcct)
        {
            try
            {
                T_BangCong_NVien_ChiTiet bcnv = db.T_BangCong_NVien_ChiTiet.FirstOrDefault(x => x.MaKyCong == bcct.MaKyCong && x.id_NhanVien == bcct.id_NhanVien && x.Ngay == bcct.Ngay);
                bcnv.KyHieu = bcnv.KyHieu;
                bcnv.GioVao = bcct.GioVao;
                bcnv.GioRa = bcct.GioRa;
                bcnv.NgayPhep = bcct.NgayPhep;
                bcnv.GhiChu = bcct.GhiChu;
                bcnv.CongChuNhat = bcct.CongChuNhat;
                bcnv.CongNgayLe = bcnv.CongNgayLe;
                bcct.NgayCong = bcnv.NgayCong;
                bcnv.UPDATEO_BY = bcct.UPDATEO_BY;
                bcnv.UPDATEO_DATE = bcct.UPDATEO_DATE;
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public double tongngayphep(int makycong,int mnv)
        {
            return db.T_BangCong_NVien_ChiTiet.Where(x => x.MaKyCong == makycong && x.id_NhanVien == mnv && x.NgayPhep != null).ToList().Sum(p => p.NgayPhep.Value);
        }
        public double tongngaycong(int makycong, int mnv)
        {
            return db.T_BangCong_NVien_ChiTiet.Where(x => x.MaKyCong == makycong && x.id_NhanVien == mnv && x.NgayCong != null).ToList().Sum(p => p.NgayCong.Value);
        }
        public double tongngaynghile(int makycong, int mnv)
        {
            return db.T_BangCong_NVien_ChiTiet.Where(x => x.MaKyCong == makycong && x.id_NhanVien == mnv && x.CongNgayLe != null).ToList().Sum(p => p.CongNgayLe.Value);
        }
        public double tongngaycongvang(int makycong, int mnv)
        {
            return db.T_BangCong_NVien_ChiTiet.Where(x => x.MaKyCong == makycong && x.id_NhanVien == mnv && x.NghiKhongPhep != null).ToList().Sum(p => p.NghiKhongPhep.Value);
        }
        public double tongcongchunhat(int makycong, int mnv)
        {
            return db.T_BangCong_NVien_ChiTiet.Where(x => x.MaKyCong == makycong && x.id_NhanVien == mnv && x.CongChuNhat != null).ToList().Sum(p => p.CongChuNhat.Value);
        }
    }
}
