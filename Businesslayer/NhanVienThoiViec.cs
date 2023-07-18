using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class NhanVienThoiViec
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_THOIVIEC getitem(string soqd)
        {
            return db.T_THOIVIEC.FirstOrDefault(x => x.SOQDTV == soqd);
        }
        public List<NhanvienThoiViecDTO> getitemFull(string soqd)
        {
            var lisNL = db.T_THOIVIEC.Where(x => x.SOQDTV == soqd).ToList();
            List<NhanvienThoiViecDTO> lssDTO = new List<NhanvienThoiViecDTO>();
            NhanvienThoiViecDTO tvDTO;
            foreach (var item in lisNL)
            {
                tvDTO = new NhanvienThoiViecDTO();
                tvDTO.SOQDTV = item.SOQDTV;
                tvDTO.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                tvDTO.HoTen = nv.HoTen;
                tvDTO.LYDO = item.LYDO;
                tvDTO.GHICHU = item.GHICHU;
                tvDTO.CREATEO_BY = item.CREATEO_BY;
                tvDTO.NGAYNGHI = item.NGAYNGHI.Value.ToString("dd/MM/yyyy");
                tvDTO.NGAYNOPDON = item.NGAYNOPDON.Value.ToString("dd/MM/yyyy");
                tvDTO.CREATEO_DATE = item.CREATEO_DATE;
                tvDTO.UPDATEO_BY = item.UPDATEO_BY;
                tvDTO.UPDATEO_DATE = item.UPDATEO_DATE;
                tvDTO.DELETEO_BY = item.DELETEO_BY;
                tvDTO.DELETEO_DATE = item.DELETEO_DATE;
                lssDTO.Add(tvDTO);

            }
            return lssDTO;
        }
        public List<T_THOIVIEC> getlist()
        {
            return db.T_THOIVIEC.ToList();
        }
        public List<NhanvienThoiViecDTO> getlistFull()
        {
            var lstTV = db.T_THOIVIEC.ToList();
            List<NhanvienThoiViecDTO> lssDTO = new List<NhanvienThoiViecDTO>();
            NhanvienThoiViecDTO tvDTO;
            foreach (var item in lstTV)
            {
                tvDTO = new NhanvienThoiViecDTO();
                tvDTO.SOQDTV = item.SOQDTV;
                tvDTO.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                tvDTO.HoTen = nv.HoTen;
                tvDTO.LYDO = item.LYDO;
                tvDTO.GHICHU = item.GHICHU;
                tvDTO.CREATEO_BY = item.CREATEO_BY;
                tvDTO.NGAYNGHI = item.NGAYNGHI.Value.ToString("dd/MM/yyyy");
                tvDTO.NGAYNOPDON = item.NGAYNOPDON.Value.ToString("dd/MM/yyyy");
                tvDTO.CREATEO_DATE = item.CREATEO_DATE;
                tvDTO.UPDATEO_BY = item.UPDATEO_BY;
                tvDTO.UPDATEO_DATE = item.UPDATEO_DATE;
                tvDTO.DELETEO_BY = item.DELETEO_BY;
                tvDTO.DELETEO_DATE = item.DELETEO_DATE;
                lssDTO.Add(tvDTO);

            }
            return lssDTO;
        }
        public T_THOIVIEC add(T_THOIVIEC tv)
        {
            try
            {
                db.T_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public T_THOIVIEC update(T_THOIVIEC tv)
        {
            try
            {
                var _tv = db.T_THOIVIEC.FirstOrDefault(x => x.SOQDTV == tv.SOQDTV);
                _tv.NGAYNOPDON = tv.NGAYNOPDON;
                _tv.NGAYNGHI = tv.NGAYNGHI;
                _tv.id_NhanVien = tv.id_NhanVien;
                _tv.LYDO = tv.LYDO;
                _tv.GHICHU = tv.GHICHU;
                _tv.UPDATEO_BY = tv.UPDATEO_BY;
                _tv.UPDATEO_DATE = tv.UPDATEO_DATE;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(string soqd, int iduser)
        {
            try
            {
                var _tv = db.T_THOIVIEC.FirstOrDefault(x => x.SOQDTV == soqd);

                _tv.DELETEO_BY = iduser;
                _tv.DELETEO_DATE = DateTime.Now;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQD()
        {
            var _hd = db.T_THOIVIEC.OrderByDescending(x => x.CREATEO_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQDTV;
            }
            else
            {
                return "00000";
            }
        }
    }
}
