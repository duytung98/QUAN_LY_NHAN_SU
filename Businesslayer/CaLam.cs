using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;


namespace Businesslayer
{
    public class CaLam
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_LoaiCa GetItem(int id)
        {
            return db.T_LoaiCa.FirstOrDefault(x => x.id_LoaiCa == id);
        }
        public List<T_LoaiCa> GetList()
        {
            return db.T_LoaiCa.ToList();
        }
        public T_LoaiCa Add(T_LoaiCa pb)
        {
            try
            {
                db.T_LoaiCa.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_LoaiCa update(T_LoaiCa dt)
        {
            try
            {
                var _tg = db.T_LoaiCa.FirstOrDefault(x => x.id_LoaiCa == dt.id_LoaiCa);
                _tg.TenLoaiCa = dt.TenLoaiCa;
                _tg.HeSo = dt.HeSo;
                db.SaveChanges();
                return _tg;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi : " + ex.Message);
            }
        }
        public void delete(int id)
        {
            try
            {
                var _tg = db.T_LoaiCa.FirstOrDefault(x => x.id_LoaiCa == id);
                db.T_LoaiCa.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
