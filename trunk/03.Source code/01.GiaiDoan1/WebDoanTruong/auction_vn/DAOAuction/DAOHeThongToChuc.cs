using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOHeThongToChuc
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<HETHONGTOCHUC> SelectHETHONGTOCHUCsAll()
        {
            List<HETHONGTOCHUC> list = new List<HETHONGTOCHUC>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<HETHONGTOCHUC_getallResult> lp = db.HETHONGTOCHUC_getall();
                foreach (HETHONGTOCHUC_getallResult HETHONGTOCHUC in lp)
                {
                    HETHONGTOCHUC var1 = new HETHONGTOCHUC();
                    var1.mahethongtochuc = HETHONGTOCHUC.mahethongtochuc;
                    var1.tenhethongtochuc = HETHONGTOCHUC.tenhethongtochuc;
                    var1.noidung = HETHONGTOCHUC.noidung;

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
        public int Them(HETHONGTOCHUC lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HETHONGTOCHUC_add(
                    lpDTO.mahethongtochuc,
                    lpDTO.tenhethongtochuc,
                    lpDTO.noidung
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int mahethongtochuc)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HETHONGTOCHUC_delete(mahethongtochuc);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(HETHONGTOCHUC lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.HETHONGTOCHUC_update(
                    lpDTO.mahethongtochuc,
                    lpDTO.tenhethongtochuc,
                    lpDTO.noidung
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public HETHONGTOCHUC TimKiem(int mahethongtochuc)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.HETHONGTOCHUCs
                            where (ng.mahethongtochuc == mahethongtochuc)
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
