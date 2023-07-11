using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class Trinhdo
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_TrinhDo GetItem(int id)
        {
            return db.T_TrinhDo.FirstOrDefault(x => x.id_TrinhDo == id);
        }
        public List<T_TrinhDo> GetList()
        {
            return db.T_TrinhDo.ToList();
        }
        public T_TrinhDo Add(T_TrinhDo td)
        {
            try
            {
                db.T_TrinhDo.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_TrinhDo update(T_TrinhDo dt)
        {
            try
            {
                var _tg = db.T_TrinhDo.FirstOrDefault(x => x.id_TrinhDo == dt.id_TrinhDo);
                _tg.Ten_TrinhDo = dt.Ten_TrinhDo;
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
                var _tg = db.T_TrinhDo.FirstOrDefault(x => x.id_TrinhDo == id);
                db.T_TrinhDo.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
