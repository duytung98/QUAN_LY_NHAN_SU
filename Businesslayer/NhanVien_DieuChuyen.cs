using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class NhanVien_DieuChuyen
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_DieuChuyen getItem(string sodc)
        {
            return db.T_DieuChuyen.FirstOrDefault(x => x.SoDieuChuyen == sodc);
        }

        public List<T_DieuChuyen> getlist()
        {
            return db.T_DieuChuyen.ToList();
        }
        public List<DieuChuyenDTO> getlistFull()
        {
            var lstDC = db.T_DieuChuyen.ToList();
            List<DieuChuyenDTO> lssDTO = new List<DieuChuyenDTO>();
            DieuChuyenDTO dcDTO;
            foreach(var item in lstDC)
            {
                dcDTO = new DieuChuyenDTO();
                dcDTO.SoDieuChuyen = item.SoDieuChuyen;
                dcDTO.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                dcDTO.HoTen = nv.HoTen;
                dcDTO.id_PhongBan = item.id_PhongBan;
                var pb = db.T_PhongBan.FirstOrDefault(p => p.id_PhongBan == item.id_PhongBan);
                dcDTO.Ten_PhongBan = pb.Ten_PhongBan;
                dcDTO.id_PhongBan2 = item.id_PhongBan2;
                var pb2 = db.T_PhongBan.FirstOrDefault(p1 => p1.id_PhongBan == item.id_PhongBan2);
                dcDTO.Ten_PhongBan2 = pb2.Ten_PhongBan;
                dcDTO.LiDo = item.LiDo;
                dcDTO.Ghichu = item.Ghichu;
                dcDTO.CREATEO_BY = item.CREATEO_BY;
                dcDTO.Ngay = item.Ngay;
                dcDTO.CREATEO_DATE = item.CREATEO_DATE;
                dcDTO.UPDATEO_BY = item.UPDATEO_BY;
                dcDTO.UPDATEO_DATE = item.UPDATEO_DATE;
                dcDTO.DELETEO_BY = item.DELETEO_BY;
                dcDTO.DELETEO_DATE = item.DELETEO_DATE;
                lssDTO.Add(dcDTO);
                
            }
            return lssDTO;
        }
        public T_DieuChuyen add(T_DieuChuyen dc)
        {
            try{
                db.T_DieuChuyen.Add(dc);
                db.SaveChanges();
                return dc;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
           
        }
        public T_DieuChuyen update(T_DieuChuyen dc)
        {
            try
            {
                var _dc = db.T_DieuChuyen.FirstOrDefault(x => x.SoDieuChuyen == dc.SoDieuChuyen);
                _dc.id_PhongBan2 = dc.id_PhongBan2;
                _dc.id_PhongBan = dc.id_PhongBan;
                _dc.id_NhanVien = dc.id_NhanVien;
                _dc.Ngay = dc.Ngay;
                _dc.LiDo = dc.LiDo;
                _dc.Ghichu = dc.Ghichu;
                _dc.UPDATEO_BY = dc.UPDATEO_BY;
                _dc.UPDATEO_DATE = dc.UPDATEO_DATE;
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(string soQD, int mnv)
        {
            try
            {
                var _dc = db.T_DieuChuyen.FirstOrDefault(x => x.SoDieuChuyen == soQD);
                _dc.DELETEO_BY = mnv;
                _dc.DELETEO_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public string MaxSoQD()
        {
            var _hd = db.T_DieuChuyen.OrderByDescending(x => x.CREATEO_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SoDieuChuyen;
            }
            else
            {
                return "00000";
            }
        }
    }
}
