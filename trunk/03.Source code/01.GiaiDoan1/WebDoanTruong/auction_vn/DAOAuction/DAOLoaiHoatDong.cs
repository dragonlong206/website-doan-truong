using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOLOAIHOATDONG
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LOAIHOATDONG> SelectLOAIHOATDONGsAll()
        {
            List<LOAIHOATDONG> list = new List<LOAIHOATDONG>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<LOAIHOATDONG_getallResult> lp = db.LOAIHOATDONG_getall();
                foreach (LOAIHOATDONG_getallResult LOAIHOATDONG in lp)
                {
                    LOAIHOATDONG var1 = new LOAIHOATDONG();
                    var1.maloaihoatdong = LOAIHOATDONG.maloaihoatdong;
                    var1.tenloaihoatdong = LOAIHOATDONG.tenloaihoatdong;

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
        public int Them(LOAIHOATDONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIHOATDONG_add(
                    lpDTO.maloaihoatdong,
                    lpDTO.tenloaihoatdong
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int maloaihoatdong)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIHOATDONG_delete(maloaihoatdong);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(LOAIHOATDONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIHOATDONG_update(
                    lpDTO.maloaihoatdong,
                    lpDTO.tenloaihoatdong
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public LOAIHOATDONG TimKiem(int maloaihoatdong)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.LOAIHOATDONGs
                            where (ng.maloaihoatdong == maloaihoatdong)
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
