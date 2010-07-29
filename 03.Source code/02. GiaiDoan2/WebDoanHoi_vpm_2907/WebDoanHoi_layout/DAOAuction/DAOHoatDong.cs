using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOHoatDong
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<HOATDONG> SelectHOATDONGsAll()
        {
            List<HOATDONG> list = new List<HOATDONG>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<HOATDONG_getallResult> lp = db.HOATDONG_getall();
                foreach (HOATDONG_getallResult HOATDONG in lp)
                {
                    HOATDONG var1 = new HOATDONG();
                    var1.MaHoatDong = HOATDONG.MaHoatDong ;
                    var1.TenHoatDong = HOATDONG.TenHoatDong ;
                    var1.NgayDienRa   = HOATDONG.NgayDienRa  ;
                    var1.MaLoaiHoatDong  = HOATDONG.MaLoaiHoatDong ;
                    var1.ThoiGianBatDauDangKy  = HOATDONG.ThoiGianBatDauDangKy ;
                    var1.ThoiGianKetThucDangKy  = HOATDONG.ThoiGianKetThucDangKy ;
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
        public int Them(HOATDONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                 db.HOATDONG_add(
                    lpDTO.TenHoatDong,
                    lpDTO.NgayDienRa ,
                    lpDTO.MaLoaiHoatDong ,
                    lpDTO.ThoiGianBatDauDangKy   ,
                    lpDTO.ThoiGianKetThucDangKy  
                    );
                 return 1;
            }
            catch (Exception ex)
            {
                throw (ex);
                return 0;
            }
        }

        public int Xoa(int mahoatdong)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HOATDONG_delete(mahoatdong);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(HOATDONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HOATDONG_update(
                    lpDTO.MaHoatDong,
                    lpDTO.TenHoatDong,
                    lpDTO.NgayDienRa,
                    lpDTO.MaLoaiHoatDong ,
                    lpDTO.ThoiGianBatDauDangKy    ,
                    lpDTO.ThoiGianKetThucDangKy 
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public HOATDONG TimKiem(int mahoatdong)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.HOATDONGs
                            where (ng.MaHoatDong == mahoatdong)
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
    }
}
