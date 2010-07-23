using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOBaiViet
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<BAIVIET> SelectBAIVIETsAll()
        {
            List<BAIVIET> list = new List<BAIVIET>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<BAIVIET_getallResult> lp = db.BAIVIET_getall();
                foreach (BAIVIET_getallResult BAIVIET in lp)
                {
                    BAIVIET var1 = new BAIVIET();
                    var1.mabaiviet = BAIVIET.mabaiviet;
                    var1.tieude = BAIVIET.tieude;
                    var1.noidung = BAIVIET.noidung;
                    var1.maloaibaiviet  = BAIVIET.maloaibaiviet;
                    var1.ngaydang = BAIVIET.ngaydang;
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
        public int Them(BAIVIET lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIVIET_add(
                    lpDTO.mabaiviet,
                    lpDTO.tieude,
                    lpDTO.noidung,
                    lpDTO.maloaibaiviet,
                    lpDTO.ngaydang 
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int mabaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIVIET_delete(mabaiviet);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(BAIVIET lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.BAIVIET_update(
                    lpDTO.mabaiviet,
                    lpDTO.tieude,
                    lpDTO.noidung,
                    lpDTO.maloaibaiviet,
                    lpDTO.ngaydang 
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public BAIVIET TimKiem(int mabaiviet)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.BAIVIETs
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
        #endregion
    }
}
