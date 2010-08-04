﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOLoaiBaiViet
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
                    var1.MaLoaiBaiViet = LOAIBAIVIET.MaLoaiBaiViet;
                    var1.TenLoaiBaiViet = LOAIBAIVIET.TenLoaiBaiViet;
                    var1.MaChuyenMuc = LOAIBAIVIET.MaChuyenMuc;

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
                db.LOAIBAIVIET_add(
                   lpDTO.TenLoaiBaiViet,
                   lpDTO.MaChuyenMuc
                   );
                return 1;

            }
            catch (Exception ex)
            {
                throw (ex);
                return 0;
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
                    lpDTO.MaChuyenMuc,
                    lpDTO.TenLoaiBaiViet,
                    lpDTO.MaChuyenMuc
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
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.LOAIBAIVIETs
                            where (ng.MaLoaiBaiViet == maloaibaiviet)
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

        #region Nhi 31/7/2010
        public List<LOAIBAIVIET> TimKiemLoaiBaiVietTheoChuyenMuc(int MaChuyenMuc)
        {
            List<LOAIBAIVIET> list = new List<LOAIBAIVIET>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<LOAIBAIVIET_TimKiemTheoChuyenMucResult> lp = db.LOAIBAIVIET_TimKiemTheoChuyenMuc(MaChuyenMuc);
                foreach (LOAIBAIVIET_TimKiemTheoChuyenMucResult LOAIBAIVIET in lp)
                {
                    LOAIBAIVIET var1 = new LOAIBAIVIET();
                    var1.MaLoaiBaiViet = LOAIBAIVIET.MaLoaiBaiViet;
                    var1.TenLoaiBaiViet = LOAIBAIVIET.TenLoaiBaiViet;
                    var1.MaChuyenMuc = LOAIBAIVIET.MaChuyenMuc;

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
        #endregion
    }
}