using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class NhanVien_NangLuong
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_NhanVien_NangLuong getItem(string sqdnl)
        {
            return db.T_NhanVien_NangLuong.FirstOrDefault(x => x.SQDNL == sqdnl);
        }
        public List<T_NhanVien_NangLuong>  getlist()
        {
            return db.T_NhanVien_NangLuong.ToList();
        }
        public List<NhanVien_NangLuongDTO>  getlistFull()
        {
            var lisNL = db.T_NhanVien_NangLuong.ToList();
            List<NhanVien_NangLuongDTO> listDTO = new List<NhanVien_NangLuongDTO>();
            NhanVien_NangLuongDTO nlDTO;
            foreach(var item in lisNL)
            {
                nlDTO = new NhanVien_NangLuongDTO();
                nlDTO.So_HopDong = item.So_HopDong;
                nlDTO.SQDNL = item.SQDNL;
                nlDTO.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(x => x.id_NhanVien == item.id_NhanVien);
                nlDTO.HoTen = nv.HoTen;
                nlDTO.GhiChu = item.GhiChu;
                nlDTO.HSLuongMoi = item.HSLuongMoi;
                nlDTO.HeSoLuongHT = item.HeSoLuongHT;
                nlDTO.NgayKy = item.NgayKy;
                nlDTO.NgayLenLuong = item.NgayLenLuong;
                nlDTO.CREATEO_BY = item.CREATEO_BY;
                nlDTO.CREATEO_DATE = item.CREATEO_DATE;
                nlDTO.DELETEO_BY = item.DELETEO_BY;
                nlDTO.DELETEO_DATE = item.DELETEO_DATE;
                nlDTO.UPDATEO_BY = item.UPDATEO_BY;
                nlDTO.UPDATEO_DATE = item.UPDATEO_DATE;
                listDTO.Add(nlDTO);
            }
            return listDTO;
        }
        public T_NhanVien_NangLuong add(T_NhanVien_NangLuong nl)
        {
            try
            {
                db.T_NhanVien_NangLuong.Add(nl);
                db.SaveChanges();
                return nl;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public T_NhanVien_NangLuong update(T_NhanVien_NangLuong nl)
        {
            try
            {
                var _nl = db.T_NhanVien_NangLuong.FirstOrDefault(x => x.SQDNL == nl.SQDNL);
                _nl.So_HopDong = nl.So_HopDong;
                _nl.HeSoLuongHT = nl.HeSoLuongHT;
                _nl.HSLuongMoi = nl.HSLuongMoi;
                _nl.NgayKy = nl.NgayKy;
                _nl.NgayLenLuong = nl.NgayLenLuong;
                _nl.id_NhanVien = nl.id_NhanVien;
                _nl.GhiChu = nl.GhiChu;
                _nl.UPDATEO_BY = nl.UPDATEO_BY;
                _nl.UPDATEO_DATE = nl.UPDATEO_DATE;
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(string sqdnl,int iduser)
        {
            try
            {
                var _nl = db.T_NhanVien_NangLuong.FirstOrDefault(x => x.SQDNL == sqdnl);

                _nl.DELETEO_BY = iduser;
                _nl.DELETEO_DATE = DateTime.Now;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQD()
        {
            var _hd = db.T_NhanVien_NangLuong.OrderByDescending(x => x.CREATEO_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SQDNL;
            }
            else
            {
                return "00000";
            }
        }
    }
}
