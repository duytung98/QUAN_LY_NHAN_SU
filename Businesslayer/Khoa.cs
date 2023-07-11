using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class Khoa
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_Khoa GetItem(int id)
        {
            return db.T_Khoa.FirstOrDefault(x => x.id_Khoa == id);
        }
        public List<T_Khoa> GetList()
        {
            return db.T_Khoa.ToList();
        }
        public T_Khoa Add(T_Khoa pb)
        {
            try
            {
                db.T_Khoa.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_Khoa update(T_Khoa dt)
        {
            try
            {
                var _tg = db.T_Khoa.FirstOrDefault(x => x.id_Khoa == dt.id_Khoa);
                _tg.Ten_Khoa = dt.Ten_Khoa;
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
                var _tg = db.T_Khoa.FirstOrDefault(x => x.id_Khoa == id);
                db.T_Khoa.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
