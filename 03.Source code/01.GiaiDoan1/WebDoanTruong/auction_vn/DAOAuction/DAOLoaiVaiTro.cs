using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOLOAIVAITRO
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LOAIVAITRO> SelectLOAIVAITROsAll()
        {
            List<LOAIVAITRO> list = new List<LOAIVAITRO>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<LOAIVAITRO_getallResult> lp = db.LOAIVAITRO_getall();
                foreach (LOAIVAITRO_getallResult LOAIVAITRO in lp)
                {
                    LOAIVAITRO var1 = new LOAIVAITRO();
                    var1.maloaivaitro = LOAIVAITRO.maloaivaitro;
                    var1.tenloaivaitro = LOAIVAITRO.tenloaivaitro;

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
        public int Them(LOAIVAITRO lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIVAITRO_add(
                    lpDTO.maloaivaitro,
                    lpDTO.tenloaivaitro
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int mavaitro)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIVAITRO_delete(mavaitro);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(LOAIVAITRO lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.LOAIVAITRO_update(
                    lpDTO.maloaivaitro,
                    lpDTO.tenloaivaitro
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public LOAIVAITRO TimKiem(int mavaitro)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.LOAIVAITROs
                            where (ng.maloaivaitro == mavaitro)
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
