using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOThongBao
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<THONGBAO> SelectTHONGBAOsAll()
        {
            List<THONGBAO> list = new List<THONGBAO>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<THONGBAO_getallResult> lp = db.THONGBAO_getall();
                foreach (THONGBAO_getallResult THONGBAO in lp)
                {
                    THONGBAO var1 = new THONGBAO();
                    var1.MaThongBao  = THONGBAO.MaThongBao ;
                    var1.TieuDe  = THONGBAO.TieuDe ;
                    var1.NoiDung  = THONGBAO.NoiDung ;
                    var1.MaHoatDong  = THONGBAO.MaHoatDong ;
                    var1.NgayDang  = THONGBAO.NgayDang ;
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
        public int Them(THONGBAO lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                 db.THONGBAO_add(
                    lpDTO.TieuDe ,
                    lpDTO.NoiDung ,
                    lpDTO.MaHoatDong ,
                    lpDTO.NgayDang 
                    );
                 return 1;
            }
            catch (Exception ex)
            {
                throw (ex);
                return 0;
            }
        }

        public int Xoa(int mathongbao)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.THONGBAO_delete(mathongbao);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(THONGBAO lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.THONGBAO_update(
                    lpDTO.MaThongBao,
                    lpDTO.TieuDe,
                    lpDTO.NoiDung,
                    lpDTO.MaHoatDong,
                    lpDTO.NgayDang
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public THONGBAO TimKiem(int mathongbao)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.THONGBAOs
                            where (ng.MaThongBao  == mathongbao)
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
