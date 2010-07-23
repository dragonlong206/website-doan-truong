using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOBaiHat
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<BAIHAT> SelectBAIHATsAll()
        {
            List<BAIHAT> list = new List<BAIHAT>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<BAIHAT_getallResult> lp = db.BAIHAT_getall();
                foreach (BAIHAT_getallResult BAIHAT in lp)
                {
                    BAIHAT var1 = new BAIHAT();
                    var1.mabaihat = BAIHAT.mabaihat;
                    var1.tenbaihat = BAIHAT.tenbaihat;
                    var1.linkbaihat = BAIHAT.linkbaihat;

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
        public int Them(BAIHAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIHAT_add(
                    lpDTO.mabaihat,
                    lpDTO.tenbaihat,
                    lpDTO.linkbaihat
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int mabaihat)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIHAT_delete(mabaihat);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(BAIHAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIHAT_update(
                    lpDTO.mabaihat,
                    lpDTO.tenbaihat,
                    lpDTO.linkbaihat
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public BAIHAT TimKiem(int mabaihat)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.BAIHATs
                            where (ng.mabaihat == mabaihat)
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
