using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class TangCa
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_TangCa GetItem(int id)
        {
            return db.T_TangCa.FirstOrDefault(x => x.id_TangCa == id);
        }
        public List<T_TangCa> GetList()
        {
            return db.T_TangCa.ToList();
        }
        public List<TangCaDTO> getlistFull()
        {
            List<T_TangCa> lstTangCa = db.T_TangCa.ToList();
            List<TangCaDTO> lstDTO = new List<TangCaDTO>();
            TangCaDTO tc;
            foreach (var item in lstTangCa)
            {
                tc = new TangCaDTO();
                tc.id_TangCa = item.id_TangCa;
                tc.id_LoaiCa = item.id_LoaiCa;
                var pc = db.T_LoaiCa.FirstOrDefault(l => l.id_LoaiCa == item.id_LoaiCa);
                tc.TenLoaiCa = pc.TenLoaiCa;
                tc.HeSo = pc.HeSo;
                tc.Nam = item.Nam;
                tc.Thang = item.Thang;
                tc.SoTien = item.SoTien;
                tc.SoGioTangCa = item.SoGioTangCa;
                tc.GhiChu = item.GhiChu;
                tc.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                tc.HoTen = nv.HoTen;
                tc.CREATE0_BY = item.CREATE0_BY;
                tc.CREATE0_DATE = item.CREATE0_DATE;
                tc.UPDATEO_BY = item.UPDATEO_BY;
                tc.UPDATEO_DATE = item.UPDATEO_DATE;
                tc.DELETEO_BY = item.DELETEO_BY;
                tc.DELETEO_DATE = item.DELETEO_DATE;

                lstDTO.Add(tc);
            }

            return lstDTO;
        }
        public T_TangCa Add(T_TangCa pb)
        {
            try
            {
                db.T_TangCa.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_TangCa update(T_TangCa dt)
        {
            try
            {
                var _tg = db.T_TangCa.FirstOrDefault(x => x.id_TangCa == dt.id_TangCa);
                _tg.id_NhanVien = dt.id_NhanVien;
                _tg.Nam = dt.Nam;
                _tg.Thang = dt.Thang;
                _tg.SoGioTangCa = dt.SoGioTangCa;
                _tg.SoTien = dt.SoTien;
                _tg.Ngay = dt.Ngay;
                _tg.GhiChu = dt.GhiChu;
                _tg.id_LoaiCa = dt.id_LoaiCa;
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
                var _tg = db.T_TangCa.FirstOrDefault(x => x.id_TangCa == id);
                _tg.DELETEO_BY = user;
                _tg.DELETEO_DATE = DateTime.Now;
                db.T_TangCa.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
