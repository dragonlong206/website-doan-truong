﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOCauHoiKhaoSat
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<CAUHOIKHAOSAT> SelectCAUHOIKHAOSATsAll()
        {
            List<CAUHOIKHAOSAT> list = new List<CAUHOIKHAOSAT>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<CAUHOIKHAOSAT_getallResult> lp = db.CAUHOIKHAOSAT_getall();
                foreach (CAUHOIKHAOSAT_getallResult CAUHOIKHAOSAT in lp)
                {
                    CAUHOIKHAOSAT var1 = new CAUHOIKHAOSAT();
                    var1.macauhoikhaosat = CAUHOIKHAOSAT.macauhoikhaosat;
                    var1.tieude = CAUHOIKHAOSAT.tieude;
                    var1.@lock = CAUHOIKHAOSAT.@lock;

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
        public int Them(CAUHOIKHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.CAUHOIKHAOSAT_add(
                    lpDTO.macauhoikhaosat,
                    lpDTO.tieude,
                    lpDTO.@lock 
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(int macauhoikhaosat)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.CAUHOIKHAOSAT_delete(macauhoikhaosat);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(CAUHOIKHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.CAUHOIKHAOSAT_update(
                    lpDTO.macauhoikhaosat,
                    lpDTO.tieude,
                    lpDTO.@lock 
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public CAUHOIKHAOSAT TimKiem(int macauhoikhaosat)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(ConfigurationSettings.AppSettings["primaryConnection"].ToString());

                var query = from ng in db.CAUHOIKHAOSATs
                            where (ng.macauhoikhaosat == macauhoikhaosat)
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
