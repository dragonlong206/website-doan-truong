using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOTapTinBaiViet
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<TAPTINBAIVIET> SelectTAPTINBAIVIETsAll()
        {
            List<TAPTINBAIVIET> list = new List<TAPTINBAIVIET>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                
                ISingleResult<TAPTINBAIVIET_getallResult> lp = db.TAPTINBAIVIET_getall();
                foreach (TAPTINBAIVIET_getallResult TAPTINBAIVIET in lp)
                {
                    TAPTINBAIVIET var1 = new TAPTINBAIVIET();
                    var1.MaTapTin  = TAPTINBAIVIET.MaTapTin ;
                    var1.TenTapTin  = TAPTINBAIVIET.TenTapTin ;
                    var1.DuongDan = TAPTINBAIVIET.DuongDan ;
                    var1.MaBaiViet  = TAPTINBAIVIET.MaBaiViet ;

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
        public int Them(TAPTINBAIVIET lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                 db.TAPTINBAIVIET_add (
                    lpDTO.TenTapTin ,
                    lpDTO.DuongDan ,
                    lpDTO.MaBaiViet 
                    );
                 return 1;
            }
            catch (Exception ex)
            {
                throw (ex);
                return 0;
            }
        }

        public int Xoa(int mataptin)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.TAPTINBAIVIET_delete(mataptin);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(TAPTINBAIVIET lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.TAPTINBAIVIET_update(
                    lpDTO.MaTapTin ,
                    lpDTO.TenTapTin ,
                    lpDTO.DuongDan ,
                    lpDTO.MaBaiViet 
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public TAPTINBAIVIET TimKiemMaTapTin(int mataptin)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.TAPTINBAIVIETs
                            where (ng.MaTapTin == mataptin)
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
        public TAPTINBAIVIET TimKiemMaBaiViet(int mabaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.TAPTINBAIVIETs
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
        public TAPTINBAIVIET TimKiemTenTapTin(string tenTapTin)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.TAPTINBAIVIETs
                            where (ng.TenTapTin == tenTapTin)
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
