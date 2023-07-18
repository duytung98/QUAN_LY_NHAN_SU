using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businesslayer.DTO;
using Datalayer;

namespace Businesslayer
{
    public class KhenThuong
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public KhenThuong_KyLuat getItem(string SoQD)
        {
            return db.KhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == SoQD);
        }
        public List<KhenThuongDTO> getItemFull(string SoQD)
        {
            var listkt = db.KhenThuong_KyLuat.Where(x => x.SoQuyetDinh == SoQD).ToList();
            List<KhenThuongDTO> lstDTO = new List<KhenThuongDTO>();
            KhenThuongDTO kt;
            foreach (var item in listkt)
            {
                kt = new KhenThuongDTO();
                kt.SoQuyetDinh = item.SoQuyetDinh;
                kt.TuNgay = item.TuNgay;
                kt.DenNgay = item.DenNgay;
                kt.NgayTao = item.NgayTao.Value.ToString("dd/MM/yyyy");
                kt.Loai = item.Loai;
                kt.NoiDung = item.NoiDung;
                kt.LyDo = item.LyDo;
                kt.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                kt.HoTen = nv.HoTen;

                kt.CREATE0_BY = item.CREATE0_BY;
                kt.CREATE0_DATE = item.CREATE0_DATE;
                kt.UPDATEO_BY = item.UPDATEO_BY;
                kt.UPDATEO_DATE = item.UPDATEO_DATE;
                kt.DELETEO_BY = item.DELETEO_BY;
                kt.DELETEO_DATE = item.DELETEO_DATE;

                lstDTO.Add(kt);
            }

            return lstDTO;
        }
        public List<KhenThuong_KyLuat> getlist(int loai)
        {
            return db.KhenThuong_KyLuat.Where(x=>x.Loai == loai).ToList();
        }

        public List<KhenThuongDTO> getlistFull(int loai)
        {
            List<KhenThuong_KyLuat> listkt = db.KhenThuong_KyLuat.Where(x => x.Loai == loai).ToList();
            List<KhenThuongDTO> lstDTO = new List<KhenThuongDTO>();
            KhenThuongDTO kt;
            foreach (var item in listkt)
            {
                kt = new KhenThuongDTO();
                kt.SoQuyetDinh = item.SoQuyetDinh;
                kt.TuNgay = item.TuNgay;
                kt.DenNgay = item.DenNgay;
                kt.NgayTao = item.NgayTao.Value.ToString("dd/MM/yyyy");
                kt.Loai = item.Loai;
                kt.NoiDung = item.NoiDung;
                kt.LyDo = item.LyDo;
                kt.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(n => n.id_NhanVien == item.id_NhanVien);
                kt.HoTen = nv.HoTen;
                
                kt.CREATE0_BY = item.CREATE0_BY;
                kt.CREATE0_DATE = item.CREATE0_DATE;
                kt.UPDATEO_BY = item.UPDATEO_BY;
                kt.UPDATEO_DATE = item.UPDATEO_DATE;
                kt.DELETEO_BY = item.DELETEO_BY;
                kt.DELETEO_DATE = item.DELETEO_DATE;
                
                lstDTO.Add(kt);
            }

            return lstDTO;
        }
        public KhenThuong_KyLuat add(KhenThuong_KyLuat kt)
        {
            try
            {
                db.KhenThuong_KyLuat.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi"+ex.Message);
            }
        }
        public KhenThuong_KyLuat update(KhenThuong_KyLuat kt)
        {
            try
            {
                KhenThuong_KyLuat _kt = db.KhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == kt.SoQuyetDinh);
                _kt.NgayTao = kt.NgayTao;
                _kt.TuNgay = kt.TuNgay;
                _kt.DenNgay = kt.DenNgay;
                _kt.LyDo = kt.LyDo;
                _kt.NoiDung = kt.NoiDung;
                _kt.Loai = kt.Loai;
                _kt.id_NhanVien = kt.id_NhanVien;
                _kt.UPDATEO_BY = kt.UPDATEO_BY;
                _kt.UPDATEO_DATE = kt.UPDATEO_DATE;
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
        public void Delete(string SoQD,int MaNV)
        {
            try
            {
                KhenThuong_KyLuat _kt = db.KhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == SoQD);
                _kt.DELETEO_BY = MaNV;
                _kt.DELETEO_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
        public string MaxSoQD(int loai)
        {
            var _kt = db.KhenThuong_KyLuat.Where(x=>x.Loai == loai).OrderByDescending(x => x.CREATE0_DATE).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SoQuyetDinh;
            }
            else
            {
                return "00000";
            }
        }
    }
}
