using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class LoaiCong
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_LoaiCong GetItem(int id)
        {
            return db.T_LoaiCong.FirstOrDefault(x => x.id_LoaiCong == id);
        }
        public List<T_LoaiCong> GetList()
        {
            return db.T_LoaiCong.ToList();
        }
        public T_LoaiCong Add(T_LoaiCong pb)
        {
            try
            {
                db.T_LoaiCong.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_LoaiCong update(T_LoaiCong dt)
        {
            try
            {
                var _tg = db.T_LoaiCong.FirstOrDefault(x => x.id_LoaiCong == dt.id_LoaiCong);
                _tg.Ten_LoaiCong = dt.Ten_LoaiCong;
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
                var _tg = db.T_LoaiCong.FirstOrDefault(x => x.id_LoaiCong == id);
                db.T_LoaiCong.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
