﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAODangKyHoatDong
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<DANGKYHOATDONG> SelectDANGKYHOATDONGsAll()
        {
            List<DANGKYHOATDONG> list = new List<DANGKYHOATDONG>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<DANGKYHOATDONG_getallResult> lp = db.DANGKYHOATDONG_getall();
                foreach (DANGKYHOATDONG_getallResult DANGKYHOATDONG in lp)
                {
                    DANGKYHOATDONG var1 = new DANGKYHOATDONG();
                    var1.MaHoatDong = DANGKYHOATDONG.MaHoatDong ;
                    var1.MaNguoiDung  = DANGKYHOATDONG.MaNguoiDung ;
                    var1.MaHoatDong  = DANGKYHOATDONG.MaHoatDong ;

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
        public int Them(DANGKYHOATDONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DANGKYHOATDONG_add(
                    lpDTO.MaNguoiDung ,
                    lpDTO.MaHoatDong 
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(DANGKYHOATDONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DANGKYHOATDONG_delete(
                    lpDTO.MaNguoiDung,
                    lpDTO.MaHoatDong
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(DANGKYHOATDONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DANGKYHOATDONG_update(
                    lpDTO.MaNguoiDung,
                    lpDTO.MaHoatDong
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public DANGKYHOATDONG TimKiem(int manguoidung)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.DANGKYHOATDONGs
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
