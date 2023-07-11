using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class PhongBan
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_PhongBan GetItem(int id)
        {
            return db.T_PhongBan.FirstOrDefault(x => x.id_PhongBan == id);
        }
        public List<T_PhongBan> GetList()
        {
            return db.T_PhongBan.ToList();
        }
        public T_PhongBan Add(T_PhongBan pb)
        {
            try
            {
                db.T_PhongBan.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_PhongBan update(T_PhongBan dt)
        {
            try
            {
                var _tg = db.T_PhongBan.FirstOrDefault(x => x.id_PhongBan == dt.id_PhongBan);
                _tg.Ten_PhongBan = dt.Ten_PhongBan;
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
                var _tg = db.T_PhongBan.FirstOrDefault(x => x.id_PhongBan == id);
                db.T_PhongBan.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}

