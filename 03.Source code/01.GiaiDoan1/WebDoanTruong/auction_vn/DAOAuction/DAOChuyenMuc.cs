using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOChuyenMuc
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<CHUYENMUC> SelectCHUYENMUCsAll()
        {
            List<CHUYENMUC> list = new List<CHUYENMUC>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<CHUYENMUC_getallResult> lp = db.CHUYENMUC_getall();
                foreach (CHUYENMUC_getallResult CHUYENMUC in lp)
                {
                    CHUYENMUC var1 = new CHUYENMUC();
                    var1.machuyenmuc = CHUYENMUC.machuyenmuc;
                    var1.tenchuyenmuc = CHUYENMUC.tenchuyenmuc;

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
        public int Them(CHUYENMUC lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.CHUYENMUC_add(
                    lpDTO.machuyenmuc,
                    lpDTO.tenchuyenmuc
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int machuyenmuc)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.CHUYENMUC_delete(machuyenmuc);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(CHUYENMUC lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.CHUYENMUC_update(
                    lpDTO.machuyenmuc,
                    lpDTO.tenchuyenmuc
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public CHUYENMUC TimKiem(int machuyenmuc)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.CHUYENMUCs
                            where (ng.machuyenmuc == machuyenmuc)
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
