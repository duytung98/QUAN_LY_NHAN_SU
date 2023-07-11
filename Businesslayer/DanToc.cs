using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;


namespace Businesslayer
{
    public class DanToc
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_DanToc GetItem(int id)
        {
            return db.T_DanToc.FirstOrDefault(x => x.id_DanToc == id);
        }
        public List<T_DanToc> GetList()
        {
            return db.T_DanToc.ToList();
        }
        public T_DanToc Add(T_DanToc dt)
        {
            try
            {
                db.T_DanToc.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_DanToc update(T_DanToc dt)
        {
            try {
                var _dt = db.T_DanToc.FirstOrDefault(x => x.id_DanToc == dt.id_DanToc);
                _dt.DanToc = dt.DanToc;
                db.SaveChanges();
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception("lỗi : " + ex.Message);
            }
        }
        public void delete(int id)
        {
            try
            {
                var _dt = db.T_DanToc.FirstOrDefault(x => x.id_DanToc == id);
                db.T_DanToc.Remove(_dt);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
