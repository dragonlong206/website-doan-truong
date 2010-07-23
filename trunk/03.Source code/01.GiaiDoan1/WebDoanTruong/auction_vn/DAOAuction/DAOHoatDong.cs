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
                    var1.mahoatdong = HOATDONG.mahoatdong;
                    var1.tenhoatdong = HOATDONG.tenhoatdong;
                    var1.ngaydienra  = HOATDONG.ngaydienra ;
                    var1.maloaihoatdong = HOATDONG.maloaihoatdong;
                    var1.thoigianbatdaudangky = HOATDONG.thoigianbatdaudangky;
                    var1.thoigianketthucdangky = HOATDONG.thoigianketthucdangky;
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
                return db.HOATDONG_add(
                    lpDTO.mahoatdong,
                    lpDTO.tenhoatdong,
                    lpDTO.ngaydienra,
                    lpDTO.maloaihoatdong,
                    lpDTO.thoigianbatdaudangky  ,
                    lpDTO.thoigianketthucdangky 
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
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
                    lpDTO.mahoatdong,
                    lpDTO.tenhoatdong,
                    lpDTO.ngaydienra,
                    lpDTO.maloaihoatdong,
                    lpDTO.thoigianbatdaudangky  ,
                    lpDTO.thoigianketthucdangky
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
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.HOATDONGs
                            where (ng.mahoatdong == mahoatdong)
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
