using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class KyCong
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_Ky_Cong getItem(int makycong)
        {
            return db.T_Ky_Cong.FirstOrDefault(x => x.MaKyCong == makycong);
        }
        public List<T_Ky_Cong>  getlist()
        {
            return db.T_Ky_Cong.ToList();
        }
        public T_Ky_Cong add(T_Ky_Cong kc)
        {
            try
            {
                db.T_Ky_Cong.Add(kc);
                db.SaveChanges();
                return kc;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public T_Ky_Cong update(T_Ky_Cong kc)
        {
            try
            {
                var _kc = db.T_Ky_Cong.FirstOrDefault(x => x.MaKyCong == kc.MaKyCong);
               
                _kc.Nam = kc.Nam;
                _kc.Thang = kc.Thang;
                _kc.Khoa = kc.Khoa;
                _kc.NgayTinhCong = kc.NgayTinhCong;
                _kc.NgayCongTrongThang = kc.NgayCongTrongThang;
                _kc.TrangThai = kc.TrangThai;
                _kc.UPDATEO_BY = kc.UPDATEO_BY;
                _kc.UPDATEO_DATE = kc.UPDATEO_DATE;
                db.SaveChanges();
                return kc;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int makycong,int iduerd)
        {
            try
            {
                var _kc = db.T_Ky_Cong.FirstOrDefault(x => x.MaKyCong == makycong);
                
                _kc.DELETEO_BY = iduerd;
                _kc.DELETEO_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public bool kiemtraPSKC(int makycong)
        {
            var kc = db.T_Ky_Cong.FirstOrDefault(x => x.MaKyCong == makycong);
            if(kc == null)
            {
                return false;
            }
            else
            {
                {
                    if (kc.TrangThai == true)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            
            
        }

    }
}
