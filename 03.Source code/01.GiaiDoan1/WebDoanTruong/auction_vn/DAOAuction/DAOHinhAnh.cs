using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOHinhAnh
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<HINHANH> SelectHINHANHsAll()
        {
            List<HINHANH> list = new List<HINHANH>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<HINHANH_getallResult> lp = db.HINHANH_getall();
                foreach (HINHANH_getallResult HINHANH in lp)
                {
                    HINHANH var1 = new HINHANH();
                    var1.mahinhanh = HINHANH.mahinhanh;
                    var1.hinhanh = HINHANH.hinhanh  ;
                    var1.maalbum = HINHANH.maalbum;

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
        public int Them(HINHANH lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HINHANH_add(
                    lpDTO.mahinhanh,
                    lpDTO.hinhanh,
                    lpDTO.maalbum 
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int mahinhanh)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HINHANH_delete(mahinhanh);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(HINHANH lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HINHANH_update(
                    lpDTO.mahinhanh,
                    lpDTO.hinhanh ,
                    lpDTO.maalbum 
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public HINHANH TimKiem(int mahinhanh)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.HINHANHs
                            where (ng.mahinhanh == mahinhanh)
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
