using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOTapTin
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<TAPTIN> SelectTAPTINsAll()
        {
            List<TAPTIN> list = new List<TAPTIN>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<TAPTIN_getallResult> lp = db.TAPTIN_getall();
                foreach (TAPTIN_getallResult TAPTIN in lp)
                {
                    TAPTIN var1 = new TAPTIN();
                    var1.mataptin = TAPTIN.mataptin ;
                    var1.tentaptin  = TAPTIN.tentaptin ;
                    var1.duongdan = TAPTIN.duongdan;
                    var1.mabaiviet  = TAPTIN.mabaiviet;

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
        public int Them(TAPTIN lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.TAPTIN_add(
                    lpDTO.mataptin,
                    lpDTO.tentaptin,
                    lpDTO.duongdan,
                    lpDTO.mabaiviet
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int mataptin)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.TAPTIN_delete(mataptin);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(TAPTIN lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.TAPTIN_update(
                    lpDTO.mataptin,
                    lpDTO.tentaptin,
                    lpDTO.duongdan,
                    lpDTO.mabaiviet
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public TAPTIN TimKiemMaTapTin(int mataptin)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.TAPTINs
                            where (ng.mataptin == mataptin)
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
        public TAPTIN TimKiemMaBaiViet(int mabaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.TAPTINs
                            where (ng.mabaiviet == mabaiviet)
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
        public TAPTIN TimKiemTenTapTin(string tenTapTin)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.TAPTINs
                            where (ng.tentaptin == tenTapTin)
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
