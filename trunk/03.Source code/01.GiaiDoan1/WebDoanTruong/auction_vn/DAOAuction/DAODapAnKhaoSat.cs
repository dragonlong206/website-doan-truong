using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAODapAnKhaoSat
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<DAPANKHAOSAT> SelectDAPANKHAOSATsAll()
        {
            List<DAPANKHAOSAT> list = new List<DAPANKHAOSAT>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<DAPANKHAOSAT_getallResult> lp = db.DAPANKHAOSAT_getall();
                foreach (DAPANKHAOSAT_getallResult DAPANKHAOSAT in lp)
                {
                    DAPANKHAOSAT var1 = new DAPANKHAOSAT();
                    var1.madapankhaosat = DAPANKHAOSAT.madapankhaosat;
                    var1.makhaosat = DAPANKHAOSAT.makhaosat;
                    var1.tieude = DAPANKHAOSAT.tieude;

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
        public int Them(DAPANKHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DAPANKHAOSAT_add(
                    lpDTO.madapankhaosat,
                    lpDTO.makhaosat,
                    lpDTO.tieude
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int madapankhaosat)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DAPANKHAOSAT_delete(madapankhaosat);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(DAPANKHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DAPANKHAOSAT_update(
                    lpDTO.madapankhaosat,
                    lpDTO.makhaosat,
                    lpDTO.tieude
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public DAPANKHAOSAT TimKiem(int madapankhaosat)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.DAPANKHAOSATs
                            where (ng.madapankhaosat == madapankhaosat)
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
