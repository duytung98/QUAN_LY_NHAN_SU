using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;


namespace Businesslayer
{
    public class PhuCap
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_NhanVienPhuCap GetItem(int id)
        {
            return db.T_NhanVienPhuCap.FirstOrDefault(x => x.id_NhanVienPhuCap == id);
        }
        public List<T_NhanVienPhuCap> GetList()
        {

            return db.T_NhanVienPhuCap.ToList();
        }
        public List<PhuCapDTo> getlistFull()
        {
            List<T_NhanVienPhuCap> listkt = db.T_NhanVienPhuCap.ToList();
            List<PhuCapDTo> lstDTO = new List<PhuCapDTo>();
            PhuCapDTo kt;
            foreach (var item in listkt)
            {
                kt = new PhuCapDTo();
                kt.id_NhanVienPhuCap = item.id_NhanVienPhuCap;
                kt.id_PhuCap = item.id_PhuCap;
                var pc = db.T_PhuCap.FirstOrDefault(n => n.id_PhuCap == item.id_PhuCap);
                kt.Ten_PhuCap = pc.Ten_PhuCap;
                kt.NgayPhuCap = item.NgayPhuCap;
                kt.NoiDungPhuCap = item.NoiDungPhuCap;
                kt.SoTien = item.SoTien;
                kt.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                kt.HoTen = nv.HoTen;

                kt.CREATEO_BY = item.CREATEO_BY;
                kt.CREATEO_DATE = item.CREATEO_DATE;
                kt.UPDATEO_BY = item.UPDATEO_BY;
                kt.UPDATEO_DATE = item.UPDATEO_DATE;
                kt.DELETEO_BY = item.DELETEO_BY;
                kt.DELETEO_DATE = item.DELETEO_DATE;

                lstDTO.Add(kt);
            }

            return lstDTO;
        }
        public List<T_PhuCap> getlistPC()
        {
            return db.T_PhuCap.ToList();
        }
        public T_PhuCap getitemPC(int id)
        {
            return db.T_PhuCap.FirstOrDefault(x => x.id_PhuCap == id);
        }
        public T_NhanVienPhuCap Add(T_NhanVienPhuCap pc)
        {
            try
            {
                db.T_NhanVienPhuCap.Add(pc);
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_NhanVienPhuCap update(T_NhanVienPhuCap dt)
        {
            try
            {
                var _tg = db.T_NhanVienPhuCap.FirstOrDefault(x => x.id_NhanVienPhuCap == dt.id_NhanVienPhuCap);
                _tg.id_NhanVien = dt.id_NhanVien;
                _tg.id_PhuCap = dt.id_PhuCap;
                _tg.SoTien = dt.SoTien;
                _tg.NgayPhuCap = dt.NgayPhuCap;
                _tg.NoiDungPhuCap = dt.NoiDungPhuCap;
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
        public void delete(int id,int user)
        {
            try
            {
                var _tg = db.T_NhanVienPhuCap.FirstOrDefault(x => x.id_NhanVienPhuCap == id);
                _tg.DELETEO_BY = user;
                _tg.DELETEO_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
