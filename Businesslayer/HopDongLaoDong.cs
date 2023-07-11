using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businesslayer;
using Businesslayer.DTO;
using Datalayer;

namespace Businesslayer
{
    public class HopDongLaoDong
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_HopDong getItem(string soHD)
        {
            return db.T_HopDong.FirstOrDefault(x => x.So_HopDong == soHD);
        }
        public List<HopDongDTO> getItemFull(string soHD)
        {
            List<T_HopDong> listHD = db.T_HopDong.Where(x=>x.So_HopDong ==soHD ).ToList();
            List<HopDongDTO> lstDTO = new List<HopDongDTO>();
            HopDongDTO hd;
            foreach (var item in listHD)
            {
                hd = new HopDongDTO();
                hd.So_HopDong = item.So_HopDong;
                hd.NgayBatDau = item.NgayBatDau.Value.ToString("dd/MM/yyyy");
                hd.NgayKetThuc = item.NgayKetThuc.Value.ToString("dd/MM/yyyy");
                hd.NgayKy = item.NgayKy.Value.ToString("dd/MM/yyyy");
                hd.ThoiHan = item.ThoiHan;
                hd.HeSoLuong = item.HeSoLuong;
                hd.LanKy = item.Lanky;
                hd.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                hd.HoTen = nv.HoTen;
                hd.CCCD = nv.CCCD;
                hd.DiaChi = nv.DiaChi;
                hd.Email = nv.Email;
                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.DienThoai = nv.DienThoai;
                hd.CREATEO_BY = item.CREATEO_BY;
                hd.CREATEO_DATE = item.CREATEO_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETE_BY = item.DELETE_BY;
                hd.DELETE_DATE = item.DELETE_DATE;
                hd.id_NoiLV = item.id_NoiLV;
                lstDTO.Add(hd);
            }

            return lstDTO;
        }
        public List<T_HopDong> getList()
        {
            return db.T_HopDong.ToList();
        }
        public List<HopDongDTO> getListfull()
        {
            List<T_HopDong> listHD = db.T_HopDong.ToList();
            List<HopDongDTO> lstDTO = new List<HopDongDTO>();
            HopDongDTO hd;
            foreach(var item in listHD)
            {
                hd = new HopDongDTO();
                hd.So_HopDong = item.So_HopDong;
                hd.NgayBatDau = item.NgayBatDau.Value.ToString("dd/MM/yyyy");
                hd.NgayKetThuc = item.NgayKetThuc.Value.ToString("dd/MM/yyyy");
                hd.NgayKy = item.NgayKy.Value.ToString("dd/MM/yyyy");
                hd.ThoiHan = item.ThoiHan;
                hd.HeSoLuong = item.HeSoLuong;
                hd.LanKy = item.Lanky;
                hd.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                hd.HoTen = nv.HoTen;
                hd.CCCD = nv.CCCD;
                hd.DiaChi = nv.DiaChi;
                hd.DienThoai = nv.DienThoai;
                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.Email = nv.Email;
                hd.TrinhDo = nv.T_TrinhDo.Ten_TrinhDo;
                hd.CREATEO_BY = item.CREATEO_BY;
                hd.CREATEO_DATE = item.CREATEO_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETE_BY = item.DELETE_BY;
                hd.DELETE_DATE = item.DELETE_DATE;
                hd.id_NoiLV = item.id_NoiLV;
                lstDTO.Add(hd);
            }

            return lstDTO;
        }
        public T_HopDong add(T_HopDong hd){
            try{
                db.T_HopDong.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public T_HopDong Update(T_HopDong hd)
        {
            try
            {
                var _hd = db.T_HopDong.FirstOrDefault(x => x.So_HopDong == hd.So_HopDong);
                _hd.NgayBatDau = hd.NgayBatDau;
                _hd.NgayKetThuc = hd.NgayKetThuc;
                _hd.id_NhanVien = hd.id_NhanVien;
                _hd.NgayKy = hd.NgayKy;
                _hd.Lanky = hd.Lanky;
                _hd.HeSoLuong = hd.HeSoLuong;
                _hd.ThoiHan = hd.ThoiHan;
                _hd.id_NoiLV = hd.id_NoiLV;
                _hd.UPDATE_BY = hd.UPDATE_BY;
                _hd.UPDATE_DATE = hd.UPDATE_DATE;
                db.T_HopDong.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(string sohd, int mnv)
        {
            var _hd = db.T_HopDong.FirstOrDefault(x => x.So_HopDong == sohd);
            
            _hd.DELETE_BY = mnv;
            _hd.DELETE_DATE = DateTime.Now;
            
            db.SaveChanges();
            
        }
        public string MaxSoHopDong()
        {
            var _hd = db.T_HopDong.OrderByDescending(x => x.CREATEO_DATE).FirstOrDefault();
            if (_hd != null){
                return _hd.So_HopDong;
            }
            else
            {
                return "00000";
            }
        }
        public List<HopDongDTO> getTangLuong()
        {
            List<T_HopDong> listHD = db.T_HopDong.Where(x=> (x.NgayBatDau.Value.Month - DateTime.Now.Month) == 0 && (DateTime.Now.Year - x.NgayBatDau.Value.Year) == 2) .ToList();
            List<HopDongDTO> lstDTO = new List<HopDongDTO>();
            HopDongDTO hd;
            foreach (var item in listHD)
            {
                hd = new HopDongDTO();
                hd.So_HopDong = item.So_HopDong;
                hd.NgayBatDau = item.NgayBatDau.Value.ToString("dd/MM/yyyy");
                hd.NgayKetThuc = item.NgayKetThuc.Value.ToString("dd/MM/yyyy");
                hd.NgayKy = item.NgayKy.Value.ToString("dd/MM/yyyy");
                hd.ThoiHan = item.ThoiHan;
                hd.HeSoLuong = item.HeSoLuong;
                hd.LanKy = item.Lanky;
                hd.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                hd.HoTen = nv.HoTen;
                hd.CCCD = nv.CCCD;
                hd.DiaChi = nv.DiaChi;
                hd.DienThoai = nv.DienThoai;
                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.Email = nv.Email;
                hd.TrinhDo = nv.T_TrinhDo.Ten_TrinhDo;
                hd.CREATEO_BY = item.CREATEO_BY;
                hd.CREATEO_DATE = item.CREATEO_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETE_BY = item.DELETE_BY;
                hd.DELETE_DATE = item.DELETE_DATE;
                hd.id_NoiLV = item.id_NoiLV;
                lstDTO.Add(hd);
            }

            return lstDTO;
        }
    }
}
