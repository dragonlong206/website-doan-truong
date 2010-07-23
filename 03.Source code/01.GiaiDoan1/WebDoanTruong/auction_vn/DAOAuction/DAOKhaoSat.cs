using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOKhaoSat
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<KHAOSAT> SelectKHAOSATsAll()
        {
            List<KHAOSAT> list = new List<KHAOSAT>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<KHAOSAT_getallResult> lp = db.KHAOSAT_getall();
                foreach (KHAOSAT_getallResult KHAOSAT in lp)
                {
                    KHAOSAT var1 = new KHAOSAT();
                    var1.macauhoi = KHAOSAT.macauhoi;
                    var1.masinhvien = KHAOSAT.masinhvien;
                    var1.madapan = KHAOSAT.madapan;

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
        public int Them(KHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.KHAOSAT_add(
                    lpDTO.macauhoi,
                    lpDTO.masinhvien,
                    lpDTO.madapan
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int macauhoi)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.KHAOSAT_delete(macauhoi);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(KHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.KHAOSAT_update(
                    lpDTO.macauhoi,
                    lpDTO.masinhvien,
                    lpDTO.madapan
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public KHAOSAT TimKiem(int macauhoi)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.KHAOSATs
                            where (ng.macauhoi == macauhoi)
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
