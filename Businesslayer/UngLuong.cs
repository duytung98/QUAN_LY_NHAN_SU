using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class UngLuong
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_UngLuong GetItem(int id)
        {
            return db.T_UngLuong.FirstOrDefault(x => x.id_UngLuong == id);
        }
        public List<T_UngLuong> GetList()
        {
            return db.T_UngLuong.ToList();
        }
        public List<UngLuongDTO> getlistFull()
        {
            List<T_UngLuong> lstUngLuong = db.T_UngLuong.ToList();
            List<UngLuongDTO> lstDTO = new List<UngLuongDTO>();
            UngLuongDTO ul;
            foreach (var item in lstUngLuong)
            {
                ul = new UngLuongDTO();
                ul.id_UngLuong = item.id_UngLuong;
                ul.Nam_Ung = item.Nam_Ung;
                ul.Thang_Ung = item.Thang_Ung;
                ul.So_Tien_Ung = item.So_Tien_Ung; 
                ul.GhiChu = item.GhiChu;
                ul.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                ul.HoTen = nv.HoTen;
                ul.CREATEO_BY = item.CREATEO_BY;
                ul.CREATEO_DATE = item.CREATEO_DATE;
                ul.UPDATEO_BY = item.UPDATEO_BY;
                ul.UPDATEO_DATE = item.UPDATEO_DATE;
                ul.DELETEO_BY = item.DELETEO_BY;
                ul.DELETEO_DATE = item.DELETEO_DATE;

                lstDTO.Add(ul);
            }

            return lstDTO;
        }
        public T_UngLuong Add(T_UngLuong pb)
        {
            try
            {
                db.T_UngLuong.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_UngLuong update(T_UngLuong dt)
        {
            try
            {
                var _tg = db.T_UngLuong.FirstOrDefault(x => x.id_UngLuong == dt.id_UngLuong);
                _tg.id_NhanVien = dt.id_NhanVien;
                _tg.Nam_Ung = dt.Nam_Ung;
                _tg.Thang_Ung = dt.Thang_Ung;
                _tg.So_Tien_Ung = dt.So_Tien_Ung;
                _tg.Ngay_Ung = dt.Ngay_Ung;
                _tg.GhiChu = dt.GhiChu;
                _tg.UPDATEO_BY = dt.UPDATEO_BY;
                _tg.UPDATEO_DATE = dt.UPDATEO_DATE;
                db.SaveChanges();
                return _tg;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi : " + ex.Message);
            }
        }
        public void delete(int id, int user)
        {
            try
            {
                var _tg = db.T_UngLuong.FirstOrDefault(x => x.id_UngLuong == id);
                _tg.DELETEO_BY = user;
                _tg.DELETEO_DATE = DateTime.Now;
                db.T_UngLuong.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
