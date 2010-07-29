using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAONguoiDung
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<NGUOIDUNG> SelectSINHVIENsAll()
        {
            List<NGUOIDUNG> list = new List<NGUOIDUNG>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                
                ISingleResult<NGUOIDUNG_getallResult> lp = db.NGUOIDUNG_getall();
                foreach (NGUOIDUNG_getallResult NGUOIDUNG in lp)
                {
                    NGUOIDUNG var1 = new NGUOIDUNG();
                    var1.MaNguoiDung   = NGUOIDUNG.MaNguoiDung ;
                    var1.Username = NGUOIDUNG.Username;
                    var1.Password  = NGUOIDUNG.Password ;
                    var1.HoTen  = NGUOIDUNG.HoTen ;
                    var1.Email  = NGUOIDUNG.Email ;
                    var1.MaVaiTro  = NGUOIDUNG.MaVaiTro  ;
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
        public int Them(NGUOIDUNG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                 db.NGUOIDUNG_add(
                    lpDTO.Username  ,
                    lpDTO.Password ,
                    lpDTO.HoTen ,
                    lpDTO.Email ,
                    lpDTO.MaVaiTro 
                    );
                 return 1;
            }
            catch (Exception ex)
            {
                throw (ex);
                return 0;
            }
        }

        public int Xoa(int manguoidung)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.NGUOIDUNG_delete(manguoidung);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(NGUOIDUNG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.NGUOIDUNG_update(
                    lpDTO.MaNguoiDung,
                    lpDTO.Username,
                    lpDTO.Password,
                    lpDTO.HoTen,
                    lpDTO.Email,
                    lpDTO.MaVaiTro
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public NGUOIDUNG TimKiem(int manguoidung)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.NGUOIDUNGs
                            where (ng.MaNguoiDung  == manguoidung)
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
