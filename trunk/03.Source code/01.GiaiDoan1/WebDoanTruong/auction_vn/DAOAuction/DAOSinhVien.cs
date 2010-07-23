using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOSINHVIEN
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<SINHVIEN> SelectSINHVIENsAll()
        {
            List<SINHVIEN> list = new List<SINHVIEN>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<SINHVIEN_getallResult> lp = db.SINHVIEN_getall();
                foreach (SINHVIEN_getallResult SINHVIEN in lp)
                {
                    SINHVIEN var1 = new SINHVIEN();
                    var1.masinhvien = SINHVIEN.masinhvien;
                    var1.pass = SINHVIEN.pass;
                    var1.hoten = SINHVIEN.hoten;
                    var1.email = SINHVIEN.email;
                    var1.vaitro = SINHVIEN.vaitro;
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
        public int Them(SINHVIEN lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.SINHVIEN_add(
                    lpDTO.masinhvien,
                    lpDTO.pass,
                    lpDTO.hoten,
                    lpDTO.email,
                    lpDTO.vaitro
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int masinhvien)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.SINHVIEN_delete(masinhvien);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(SINHVIEN lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.SINHVIEN_update(
                    lpDTO.masinhvien,
                    lpDTO.pass,
                    lpDTO.hoten,
                    lpDTO.email,
                    lpDTO.vaitro
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public SINHVIEN TimKiem(int masinhvien)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.SINHVIENs
                            where (ng.masinhvien == masinhvien)
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
