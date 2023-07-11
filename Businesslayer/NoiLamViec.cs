using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class NoiLamViec
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_NoiLamViec GetItem(int id)
        {
            return db.T_NoiLamViec.FirstOrDefault(x => x.id_NoiLV == id);
        }
        public List<T_NoiLamViec> GetList()
        {
            return db.T_NoiLamViec.ToList();
        }
        public T_NoiLamViec Add(T_NoiLamViec pb)
        {
            try
            {
                db.T_NoiLamViec.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_NoiLamViec update(T_NoiLamViec dt)
        {
            try
            {
                var _tg = db.T_NoiLamViec.FirstOrDefault(x => x.id_NoiLV == dt.id_NoiLV);
                _tg.Ten_NoiLV = dt.Ten_NoiLV;
                _tg.Email = dt.Email;
                _tg.DienThoai = dt.DienThoai;
                _tg.DiaChi = dt.DiaChi;
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
                var _tg = db.T_NoiLamViec.FirstOrDefault(x => x.id_NoiLV == id);
                db.T_NoiLamViec.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
