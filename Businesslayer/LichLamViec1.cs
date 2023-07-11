using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class LichLamViec1
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_LichLV getItem(int id)
        {
            return db.T_LichLV.FirstOrDefault(x => x.id_LichLamViec == id);
        }
        public List<T_LichLV> getlist()
        {
            return db.T_LichLV.ToList();
        }
        public List<LichLamViecDTO> getlistFull()
        {
            var lisLLV = db.T_LichLV.ToList();
            List<LichLamViecDTO> listDTO = new List<LichLamViecDTO>();
            LichLamViecDTO lvDTO;
            foreach (var item in lisLLV)
            {
                lvDTO = new LichLamViecDTO();
                lvDTO.id_LichLamViec = item.id_LichLamViec;
                lvDTO.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(x => x.id_NhanVien == item.id_NhanVien);
                lvDTO.HoTen = nv.HoTen;

                lvDTO.id_NoiLV = item.id_NoiLV;
                var nLV = db.T_NoiLamViec.FirstOrDefault(x => x.id_NoiLV == item.id_NoiLV);
                lvDTO.Ten_NoiLV = nLV.Ten_NoiLV;

                lvDTO.id_Khoa = item.id_Khoa;
                var khoa = db.T_Khoa.FirstOrDefault(x => x.id_Khoa == item.id_Khoa);
                lvDTO.Ten_Khoa = khoa.Ten_Khoa;

                lvDTO.id_KhoaDay = item.id_KhoaDay;
                var kd = db.T_KhoaDay.FirstOrDefault(x => x.id_KhoaDay == item.id_KhoaDay);
                lvDTO.Ten_KhoaDay =  kd.Ten_KhoaDay;

                lvDTO.id_LopDay = item.id_LopDay;
                var ld = db.T_LopDay.FirstOrDefault(x => x.id_LopDay == item.id_LopDay);
                lvDTO.Ten_LopDay = ld.Ten_LopDay;

                lvDTO.id_MonDay = item.id_MonDay;
                var md = db.T_MonDay.FirstOrDefault(x => x.id_MonDay == item.id_MonDay);
                lvDTO.Ten_MonDay = md.Ten_MonDay;

                lvDTO.id_PhongHoc = item.id_PhongHoc;
                var ph = db.T_PhongHoc.FirstOrDefault(x => x.id_PhongHoc == item.id_PhongHoc);
                lvDTO.Ten_PhongHoc = ph.Ten_PhongHoc;

                lvDTO.id_LoaiCa = item.id_LoaiCa;
                var lc = db.T_LoaiCa.FirstOrDefault(x => x.id_LoaiCa == item.id_LoaiCa);
                lvDTO.TenLoaiCa = lc.TenLoaiCa;

                lvDTO.SoTin = item.SoTin;
                lvDTO.ThoiGianBD = item.ThoiGianBD;
                lvDTO.ThoiGianKT = item.ThoiGianKT;
                lvDTO.CREATEO_BY = item.CREATEO_BY;
                lvDTO.CREATEO_DATE = item.CREATEO_DATE;
                lvDTO.DELETEO_BY = item.DELETEO_BY;
                lvDTO.DELETEO_DATE = item.DELETEO_DATE;
                lvDTO.UPDATEO_BY = item.UPDATEO_BY;
                lvDTO.UPDATEO_DATE = item.UPDATEO_DATE;
                listDTO.Add(lvDTO);
            }
            return listDTO;
        }
        public T_LichLV add(T_LichLV llv)
        {
            try
            {
                db.T_LichLV.Add(llv);
                db.SaveChanges();
                return llv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public T_LichLV update(T_LichLV llv)
        {
            try
            {
                var _llv = db.T_LichLV.FirstOrDefault(x => x.id_LichLamViec == llv.id_LichLamViec);
                _llv.id_NoiLV = llv.id_NoiLV;
                _llv.id_Khoa = llv.id_Khoa;
                _llv.id_KhoaDay = llv.id_KhoaDay;
                _llv.id_LopDay = llv.id_LopDay;
                _llv.id_MonDay = llv.id_MonDay;
                _llv.id_PhongHoc = llv.id_PhongHoc;
                _llv.SoTin = llv.SoTin;
                _llv.ThoiGianBD = llv.ThoiGianBD;
                _llv.ThoiGianKT = llv.ThoiGianKT;
                _llv.id_LoaiCa = llv.id_LoaiCa;

                _llv.id_NhanVien = llv.id_NhanVien;
                
                _llv.UPDATEO_BY = llv.UPDATEO_BY;
                _llv.UPDATEO_DATE = llv.UPDATEO_DATE;
                db.SaveChanges();
                return llv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(int llv, int iduser)
        {
            try
            {
                var _llv = db.T_LichLV.FirstOrDefault(x => x.id_LichLamViec == llv);

                _llv.DELETEO_BY = iduser;
                _llv.DELETEO_DATE = DateTime.Now;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
