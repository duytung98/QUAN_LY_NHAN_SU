using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businesslayer.DTO;
using Datalayer;


namespace Businesslayer
{
    public class NhanVien
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_NhanVien GetItem(int id)
        {
            return db.T_NhanVien.FirstOrDefault(x => x.id_NhanVien == id);
        }
        public List<T_NhanVien> GetList()
        {
            return db.T_NhanVien.ToList();
        }
        public List<NhanVienDTO> getlistFull()
        {
            var lstNV = db.T_NhanVien.ToList();
            List<NhanVienDTO> lstNVDTO = new List<NhanVienDTO>();
            NhanVienDTO nvDTO;
            foreach(var item in lstNV)
            {
                nvDTO = new NhanVienDTO();
                nvDTO.id_NhanVien = item.id_NhanVien;
                nvDTO.HoTen = item.HoTen;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.DiaChi = item.DiaChi;
                nvDTO.DienThoai = item.DienThoai;
                nvDTO.Email = item.Email;
                nvDTO.CCCD = item.CCCD;
                nvDTO.HinhAnh = item.HinhAnh;
                nvDTO.PhanQuyen = item.PhanQuyen;
                nvDTO.THOIVIEC = item.DATHOIVIEC;
                nvDTO.Password = item.Password;

                nvDTO.id_BoPhan = item.id_BoPhan;
                var bp = db.T_BoPhan.FirstOrDefault(b => b.id_BoPhan == item.id_BoPhan);
                nvDTO.Ten_BoPhan = bp.Ten_BoPhan;

                nvDTO.id_ChucVu = item.id_ChucVu;
                var cv = db.T_ChucVu.FirstOrDefault(b => b.id_ChucVu == item.id_ChucVu);
                nvDTO.Ten_ChucVu = cv.Ten_ChucVu;

                nvDTO.id_DanToc = item.id_DanToc;
                var dt = db.T_DanToc.FirstOrDefault(b => b.id_DanToc == item.id_DanToc);
                nvDTO.DanToc = dt.DanToc;

                nvDTO.id_NoiLV = item.id_NoiLV;
                var nlv = db.T_NoiLamViec.FirstOrDefault(b => b.id_NoiLV == item.id_NoiLV);
                nvDTO.Ten_NoiLV = nlv.Ten_NoiLV;

                nvDTO.id_PhongBan = item.id_PhongBan;
                var pb = db.T_PhongBan.FirstOrDefault(b => b.id_PhongBan == item.id_PhongBan);
                nvDTO.Ten_PhongBan = pb.Ten_PhongBan;

                nvDTO.id_TonGiao = item.id_TonGiao;
                var tg = db.T_TonGiao.FirstOrDefault(b => b.id_TonGiao == item.id_TonGiao);
                nvDTO.TonGiao = tg.TonGiao;

                nvDTO.id_TrinhDo = item.id_TrinhDo;
                var td = db.T_TrinhDo.FirstOrDefault(b => b.id_TrinhDo == item.id_TrinhDo);
                nvDTO.Ten_TrinhDo = td.Ten_TrinhDo;

                lstNVDTO.Add(nvDTO);
            }
            return lstNVDTO;
        }
        public T_NhanVien Add(T_NhanVien nv)
        {
            try
            {
                db.T_NhanVien.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public T_NhanVien update(T_NhanVien dt)
        {
            try
            {
                var _tg = db.T_NhanVien.FirstOrDefault(x => x.id_NhanVien == dt.id_NhanVien);
                _tg.HoTen = dt.HoTen;
                _tg.GioiTinh = dt.GioiTinh;
                _tg.NgaySinh = dt.NgaySinh;
                _tg.DienThoai = dt.DienThoai;
                _tg.Email = dt.Email;
                _tg.CCCD = dt.CCCD;
                _tg.DATHOIVIEC = dt.DATHOIVIEC;
                _tg.DiaChi = dt.DiaChi;
                _tg.HinhAnh = dt.HinhAnh;
                _tg.PhanQuyen = dt.PhanQuyen;
                _tg.id_NoiLV = dt.id_NoiLV;
                _tg.id_PhongBan = dt.id_PhongBan;
                _tg.id_BoPhan = dt.id_BoPhan;
                _tg.id_ChucVu = dt.id_ChucVu;
                _tg.id_TrinhDo = dt.id_TrinhDo;
                _tg.id_DanToc = dt.id_DanToc;
                _tg.id_TonGiao = dt.id_TonGiao;
                _tg.Password = dt.Password;
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
                var _tg = db.T_NhanVien.FirstOrDefault(x => x.id_NhanVien == id);
                db.T_NhanVien.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public List<T_NhanVien> getSinhNhat()
        {
            return db.T_NhanVien.Where(x => x.NgaySinh.Value.Month == DateTime.Now.Month).ToList();

        }
    }
}
