using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class ChucVu
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_ChucVu GetItem(int id)
        {
            return db.T_ChucVu.FirstOrDefault(x => x.id_ChucVu == id);
        }
        public List<T_ChucVu> GetList()
        {
            return db.T_ChucVu.ToList();
        }
        public T_ChucVu Add(T_ChucVu td)
        {
            try
            {
                db.T_ChucVu.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_ChucVu update(T_ChucVu dt)
        {
            try
            {
                var _tg = db.T_ChucVu.FirstOrDefault(x => x.id_ChucVu == dt.id_ChucVu);
                _tg.Ten_ChucVu = dt.Ten_ChucVu;
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
                var _tg = db.T_ChucVu.FirstOrDefault(x => x.id_ChucVu == id);
                db.T_ChucVu.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}

