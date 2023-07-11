using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class PhongHoc
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_PhongHoc GetItem(int id)
        {
            return db.T_PhongHoc.FirstOrDefault(x => x.id_PhongHoc == id);
        }
        public List<T_PhongHoc> GetList()
        {
            return db.T_PhongHoc.ToList();
        }
        public T_PhongHoc Add(T_PhongHoc pb)
        {
            try
            {
                db.T_PhongHoc.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_PhongHoc update(T_PhongHoc dt)
        {
            try
            {
                var _tg = db.T_PhongHoc.FirstOrDefault(x => x.id_PhongHoc == dt.id_PhongHoc);
                _tg.Ten_PhongHoc = dt.Ten_PhongHoc;
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
                var _tg = db.T_PhongHoc.FirstOrDefault(x => x.id_PhongHoc == id);
                db.T_PhongHoc.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
