using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class TonGiao
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_TonGiao GetItem(int id)
        {
            return db.T_TonGiao.FirstOrDefault(x => x.id_TonGiao == id);
        }
        public List<T_TonGiao> GetList()
        {
            return db.T_TonGiao.ToList();
        }
        public T_TonGiao Add(T_TonGiao tg)
        {
            try
            {
                db.T_TonGiao.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_TonGiao update(T_TonGiao dt)
        {
            try
            {
                var _tg = db.T_TonGiao.FirstOrDefault(x => x.id_TonGiao == dt.id_TonGiao);
                _tg.TonGiao = dt.TonGiao;
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
                var _tg = db.T_TonGiao.FirstOrDefault(x => x.id_TonGiao == id);
                db.T_TonGiao.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}

