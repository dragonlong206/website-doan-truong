using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOLOAIBAIVIET
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LOAIBAIVIET> SelectLOAIBAIVIETsAll()
        {
            List<LOAIBAIVIET> list = new List<LOAIBAIVIET>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<LOAIBAIVIET_getallResult> lp = db.LOAIBAIVIET_getall();
                foreach (LOAIBAIVIET_getallResult LOAIBAIVIET in lp)
                {
                    LOAIBAIVIET var1 = new LOAIBAIVIET();
                    var1.maloaibaiviet = LOAIBAIVIET.maloaibaiviet;
                    var1.tenloaibaiviet = LOAIBAIVIET.tenloaibaiviet;
                    var1.machuyenmuc = LOAIBAIVIET.machuyenmuc;

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
        public int Them(LOAIBAIVIET lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIBAIVIET_add(
                    lpDTO.maloaibaiviet,
                    lpDTO.tenloaibaiviet,
                    lpDTO.machuyenmuc
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int maloaibaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIBAIVIET_delete(maloaibaiviet);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(LOAIBAIVIET lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIBAIVIET_update(
                    lpDTO.maloaibaiviet,
                    lpDTO.tenloaibaiviet,
                    lpDTO.machuyenmuc
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public LOAIBAIVIET TimKiem(int maloaibaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.LOAIBAIVIETs
                            where (ng.maloaibaiviet == maloaibaiviet)
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
