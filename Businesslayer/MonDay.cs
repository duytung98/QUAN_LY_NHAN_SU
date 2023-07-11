using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class MonDay
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_MonDay GetItem(int id)
        {
            return db.T_MonDay.FirstOrDefault(x => x.id_MonDay == id);
        }
        public List<T_MonDay> GetList()
        {
            return db.T_MonDay.ToList();
        }
        public T_MonDay Add(T_MonDay pb)
        {
            try
            {
                db.T_MonDay.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_MonDay update(T_MonDay dt)
        {
            try
            {
                var _tg = db.T_MonDay.FirstOrDefault(x => x.id_MonDay == dt.id_MonDay);
                _tg.Ten_MonDay = dt.Ten_MonDay;
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
                var _tg = db.T_MonDay.FirstOrDefault(x => x.id_MonDay == id);
                db.T_MonDay.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
