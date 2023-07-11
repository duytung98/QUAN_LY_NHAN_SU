using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class BoPhan
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_BoPhan GetItem(int id)
        {
            return db.T_BoPhan.FirstOrDefault(x => x.id_BoPhan == id);
        }
        public List<T_BoPhan> GetList()
        {
            return db.T_BoPhan.ToList();
        }
        public T_BoPhan Add(T_BoPhan pb)
        {
            try
            {
                db.T_BoPhan.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_BoPhan update(T_BoPhan dt)
        {
            try
            {
                var _tg = db.T_BoPhan.FirstOrDefault(x => x.id_BoPhan == dt.id_BoPhan);
                _tg.Ten_BoPhan = dt.Ten_BoPhan;
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
                var _tg = db.T_BoPhan.FirstOrDefault(x => x.id_BoPhan == id);
                db.T_BoPhan.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
