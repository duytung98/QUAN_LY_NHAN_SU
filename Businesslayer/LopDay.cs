using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class LopDay
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_LopDay GetItem(int id)
        {
            return db.T_LopDay.FirstOrDefault(x => x.id_LopDay == id);
        }
        public List<T_LopDay> GetList()
        {
            return db.T_LopDay.ToList();
        }
        public T_LopDay Add(T_LopDay pb)
        {
            try
            {
                db.T_LopDay.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_LopDay update(T_LopDay dt)
        {
            try
            {
                var _tg = db.T_LopDay.FirstOrDefault(x => x.id_LopDay == dt.id_LopDay);
                _tg.Ten_LopDay = dt.Ten_LopDay;
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
                var _tg = db.T_LopDay.FirstOrDefault(x => x.id_LopDay == id);
                db.T_LopDay.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
