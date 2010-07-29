﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAODangKyMuonPhong
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<DANGKYMUONPHONG> SelectDANGKYMUONPHONGsAll()
        {
            List<DANGKYMUONPHONG> list = new List<DANGKYMUONPHONG>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<DANGKYMUONPHONG_getallResult> lp = db.DANGKYMUONPHONG_getall();
                foreach (DANGKYMUONPHONG_getallResult DANGKYMUONPHONG in lp)
                {
                    DANGKYMUONPHONG var1 = new DANGKYMUONPHONG();
                    var1.MaDangKy  = DANGKYMUONPHONG.MaDangKy ;
                    var1.MaNguoiDung  = DANGKYMUONPHONG.MaNguoiDung ;
                    var1.NgayMuon  = DANGKYMUONPHONG.NgayMuon ;
                    var1.SoLuong  = DANGKYMUONPHONG.SoLuong ;
                    var1.MucDich   = DANGKYMUONPHONG.MucDich ;
                    var1.DonViMuon  = DANGKYMUONPHONG.DonViMuon ;

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
        public int Them(DANGKYMUONPHONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                 db.DANGKYMUONPHONG_add(
                    lpDTO.MaNguoiDung ,
                    lpDTO.NgayMuon ,
                    lpDTO.SoLuong ,
                    lpDTO.MucDich ,
                    lpDTO.DonViMuon 
                    );
                 return 1;
            }
            catch (Exception ex)
            {
                throw (ex);
                return 0;
            }
        }

        public int Xoa(int madangky)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DANGKYMUONPHONG_delete(madangky);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(DANGKYMUONPHONG lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.DANGKYMUONPHONG_update(
                    lpDTO.MaDangKy,
                    lpDTO.MaNguoiDung,
                    lpDTO.NgayMuon,
                    lpDTO.SoLuong,
                    lpDTO.MucDich,
                    lpDTO.DonViMuon 
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public DANGKYMUONPHONG TimKiem(int madangky)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.DANGKYMUONPHONGs
                            where (ng.MaDangKy  == madangky)
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