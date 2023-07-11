using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class KhoaDay
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_KhoaDay GetItem(int id)
        {
            return db.T_KhoaDay.FirstOrDefault(x => x.id_KhoaDay == id);
        }
        public List<T_KhoaDay> GetList()
        {
            return db.T_KhoaDay.ToList();
        }
        public T_KhoaDay Add(T_KhoaDay pb)
        {
            try
            {
                db.T_KhoaDay.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_KhoaDay update(T_KhoaDay dt)
        {
            try
            {
                var _tg = db.T_KhoaDay.FirstOrDefault(x => x.id_KhoaDay == dt.id_KhoaDay);
                _tg.Ten_KhoaDay = dt.Ten_KhoaDay;
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
                var _tg = db.T_KhoaDay.FirstOrDefault(x => x.id_KhoaDay == id);
                db.T_KhoaDay.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
