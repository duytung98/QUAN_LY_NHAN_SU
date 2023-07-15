using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Businesslayer.DTO;

namespace Businesslayer
{
    public class BaoHiem
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_BaoHiem getItem(int id)
        {
            return db.T_BaoHiem.FirstOrDefault(x => x.id_BaoHiem == id);
        }
        public List<T_BaoHiem> getlist()
        {
            return db.T_BaoHiem.ToList();
        }
        public List<BaohiemDTO> getlistFull()
        {
            var lisLLV = db.T_BaoHiem.ToList();
            List<BaohiemDTO> listDTO = new List<BaohiemDTO>();
            BaohiemDTO lvDTO;
            foreach (var item in lisLLV)
            {
                lvDTO = new BaohiemDTO();
                lvDTO.id_BaoHiem = item.id_BaoHiem;
                lvDTO.id_NhanVien = item.id_NhanVien;
                var nv = db.T_NhanVien.FirstOrDefault(x => x.id_NhanVien == item.id_NhanVien);
                lvDTO.HoTen = nv.HoTen;
                lvDTO.GhiChu = item.GhiChu;
                lvDTO.So_BaoHiem = item.So_BaoHiem;
                lvDTO.NoiCap = item.NoiCap;
                lvDTO.NgayCap = item.NgayCap;
                lvDTO.Noi_DK_Kham_Benh = item.Noi_DK_Kham_Benh;
                lvDTO.CREATEO_BY = item.CREATEO_BY;
                lvDTO.CREATEO_DATE = item.CREATEO_DATE;
                lvDTO.DELETE_BY = item.DELETE_BY;
                lvDTO.DELETE_DATE = item.DELETE_DATE;
                lvDTO.UPDATE_BY = item.UPDATE_BY;
                lvDTO.UPDATE_DATE = item.UPDATE_DATE;
                listDTO.Add(lvDTO);
            }
            return listDTO;
        }
        public T_BaoHiem add(T_BaoHiem llv)
        {
            try
            {
                db.T_BaoHiem.Add(llv);
                db.SaveChanges();
                return llv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public T_BaoHiem update(T_BaoHiem llv)
        {
            try
            {
                var _llv = db.T_BaoHiem.FirstOrDefault(x => x.id_BaoHiem == llv.id_BaoHiem);
                _llv.id_NhanVien = llv.id_NhanVien;
                _llv.NgayCap = llv.NgayCap;
                _llv.NoiCap = llv.NoiCap;
                _llv.Noi_DK_Kham_Benh = llv.Noi_DK_Kham_Benh;
                _llv.So_BaoHiem = llv.So_BaoHiem;
                _llv.GhiChu = llv.GhiChu;
                _llv.UPDATE_BY = llv.UPDATE_BY;
                _llv.UPDATE_DATE = llv.UPDATE_DATE;
                db.SaveChanges();
                return llv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(int id,int user)
        {
            try
            {
                var _llv = db.T_BaoHiem.FirstOrDefault(x => x.id_BaoHiem == id);
                _llv.DELETE_BY = user;
                _llv.DELETE_DATE = DateTime.Now;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
