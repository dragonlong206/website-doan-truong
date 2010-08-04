using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOBaiViet
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<BAIVIET> SelectBAIVIETsAll()
        {
            List<BAIVIET> list = new List<BAIVIET>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<BAIVIET_getallResult> lp = db.BAIVIET_getall();
                foreach (BAIVIET_getallResult BAIVIET in lp)
                {
                    BAIVIET var1 = new BAIVIET();
                    var1.MaBaiViet = BAIVIET.MaBaiViet;
                    var1.TieuDe = BAIVIET.TieuDe;
                    var1.NoiDung = BAIVIET.NoiDung;
                    var1.MaLoaiBaiViet = BAIVIET.MaLoaiBaiViet;
                    var1.NgayDang = BAIVIET.NgayDang;
                    var1.HinhAnh = BAIVIET.HinhAnh;
                    var1.TomTat = BAIVIET.TieuDe;
                    list.Add(var1);
                }
                try
                {
                    // Save the changes.
                    db.SubmitChanges();
                }
                // Detect concurrency conflicts.
                catch (ChangeConflictException)
                {
                    // Resolve conflicts.
                    db.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
                }
            }

            return list;
        }
        public int Them(BAIVIET lpDTO)
        {
            try
            {

                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                db.BAIVIET_add(
                   lpDTO.TieuDe,
                   lpDTO.NoiDung,
                   lpDTO.MaLoaiBaiViet,
                   lpDTO.NgayDang,
                   lpDTO.HinhAnh,
                   lpDTO.TomTat
                   );
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int Xoa(int mabaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIVIET_delete(mabaiviet);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(BAIVIET lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIVIET_update(
                    lpDTO.MaBaiViet,
                    lpDTO.TieuDe,
                    lpDTO.NoiDung,
                    lpDTO.MaLoaiBaiViet,
                    lpDTO.NgayDang,
                    lpDTO.HinhAnh,
                    lpDTO.TomTat
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public BAIVIET TimKiem(int mabaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.BAIVIETs
                            where (ng.MaBaiViet == mabaiviet)
                            select ng;
                if (query.Count() > 0)
                    return query.First();
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        #endregion

        #region Nhi: Tim Kiem DS BaiViet Theo Loai Bai Viet, Lấy Bài Viết Mới Nhất
        public List<BAIVIET> TimKiemTheoLoaiBaiViet(int MaLoaiBaiViet)
        {
            List<BAIVIET> list = new List<BAIVIET>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<BAIVIET_TimKiemTheoLoaiBaiVietResult> lp = db.BAIVIET_TimKiemTheoLoaiBaiViet(MaLoaiBaiViet);
                foreach (BAIVIET_TimKiemTheoLoaiBaiVietResult BAIVIET in lp)
                {
                    BAIVIET var1 = new BAIVIET();
                    var1.MaBaiViet = BAIVIET.MaBaiViet;
                    var1.TieuDe = BAIVIET.TieuDe;
                    var1.NoiDung = BAIVIET.NoiDung;
                    var1.MaLoaiBaiViet = BAIVIET.MaLoaiBaiViet;
                    var1.NgayDang = BAIVIET.NgayDang;
                    var1.HinhAnh = BAIVIET.HinhAnh;
                    var1.TomTat = BAIVIET.TieuDe;
                    list.Add(var1);
                }
                try
                {
                    // Save the changes.
                    db.SubmitChanges();
                }
                // Detect concurrency conflicts.
                catch (ChangeConflictException)
                {
                    // Resolve conflicts.
                    db.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
                }
            }

            return list;
        }
        public List<BAIVIET> LayBaiVietMoiNhat(int SoLuong)
        {
            List<BAIVIET> list = new List<BAIVIET>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<BAIVIET_LayBaiVietMoiNhatResult> lp = db.BAIVIET_LayBaiVietMoiNhat();

                int i = 0;
                foreach(BAIVIET_LayBaiVietMoiNhatResult bv in lp)
                {
                    if (i == SoLuong)
                    {
                        break;
                    }
                    //BAIVIET_LayBaiVietMoiNhatResult bv = temp[i];
                    BAIVIET var1 = new BAIVIET();
                    var1.MaBaiViet = bv.MaBaiViet;
                    var1.TieuDe = bv.TieuDe;
                    var1.NoiDung = bv.NoiDung;
                    var1.MaLoaiBaiViet = bv.MaLoaiBaiViet;
                    var1.NgayDang = bv.NgayDang;
                    var1.HinhAnh = bv.HinhAnh;
                    var1.TomTat = bv.TieuDe;
                    list.Add(var1);
                    i++;
                }
                try
                {
                    // Save the changes.
                    db.SubmitChanges();
                }
                // Detect concurrency conflicts.
                catch (ChangeConflictException)
                {
                    // Resolve conflicts.
                    db.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
                }
            }

            return list;
        }

        public List<BAIVIET> LayBaiVietMoiNhat()
        {
            return LayBaiVietMoiNhat(5);
        }

        #endregion
    }
}
