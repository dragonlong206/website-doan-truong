using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOLICHLAMVIEC
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LICHLAMVIEC> SelectLICHLAMVIECsAll()
        {
            List<LICHLAMVIEC> list = new List<LICHLAMVIEC>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<LICHLAMVIEC_getallResult> lp = db.LICHLAMVIEC_getall();
                foreach (LICHLAMVIEC_getallResult LICHLAMVIEC in lp)
                {
                    LICHLAMVIEC var1 = new LICHLAMVIEC();
                    var1.noidung = LICHLAMVIEC.noidung;
                    
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
        public int Them(LICHLAMVIEC lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LICHLAMVIEC_add(
                    lpDTO.noidung
                    
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int noidung)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LICHLAMVIEC_delete();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(LICHLAMVIEC lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LICHLAMVIEC_update(
                    lpDTO.noidung
                    
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public LICHLAMVIEC TimKiem(string noidung)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.LICHLAMVIECs
                            where (ng.noidung  == noidung)
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
