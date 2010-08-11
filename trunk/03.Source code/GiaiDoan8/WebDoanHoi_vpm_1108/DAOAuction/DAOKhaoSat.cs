using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using DTOAuction;
using System.Configuration;

namespace DAOAuction
{
    public class DAOKhaoSat
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<KHAOSAT> SelectKHAOSATsAll()
        {
            List<KHAOSAT> list = new List<KHAOSAT>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<KHAOSAT_getallResult> lp = db.KHAOSAT_getall();
                foreach (KHAOSAT_getallResult KHAOSAT in lp)
                {
                    KHAOSAT var1 = new KHAOSAT();
                    var1.MaDapAn  = KHAOSAT.MaDapAn ;
                    var1.MaNguoiDung  = KHAOSAT.MaNguoiDung ;
                    var1.YKienKhac  = KHAOSAT.YKienKhac ;

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
        public int Them(KHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.KHAOSAT_add(
                    lpDTO.MaDapAn ,
                    lpDTO.MaNguoiDung ,
                    lpDTO.YKienKhac 
                    );

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Xoa(KHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.KHAOSAT_delete(
                    lpDTO.MaDapAn,
                    lpDTO.MaNguoiDung
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int CapNhat(KHAOSAT lpDTO)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);
                return db.KHAOSAT_update(
                    lpDTO.MaDapAn,
                    lpDTO.MaNguoiDung,
                    lpDTO.YKienKhac 
                    );
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public KHAOSAT TimKiem(int macauhoi)
        {
            try
            {
                LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString);

                var query = from ng in db.KHAOSATs
                            where (ng.MaDapAn  == macauhoi)
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

        #region Nhi: 

        public List<KHAOSAT> LayKhaoSatTheoMaNguoiDung(int MaNguoiDung)
        {
            List<KHAOSAT> list = new List<KHAOSAT>();
            using (LinQDataContext db = new LinQDataContext(global::DAOAuction.Properties.Settings.Default.webdoantruongConnectionString))
            {
                ISingleResult<KHAOSAT_TimKiemKhaoSatTheoMaNguoiDungResult> lp = db.KHAOSAT_TimKiemKhaoSatTheoMaNguoiDung(MaNguoiDung);
                foreach (KHAOSAT_TimKiemKhaoSatTheoMaNguoiDungResult KHAOSAT in lp)
                {
                    KHAOSAT var1 = new KHAOSAT();
                    var1.MaDapAn = KHAOSAT.MaDapAn;
                    var1.MaNguoiDung = KHAOSAT.MaNguoiDung;
                    var1.YKienKhac = KHAOSAT.YKienKhac;

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
        public Boolean KiemTraRangBuoc(int MaNguoiDung, int MaCauHoi)
        {
            DAOKhaoSat KhaoSatDAO = new DAOKhaoSat();
            List<KHAOSAT> DsKhaoSat = KhaoSatDAO.LayKhaoSatTheoMaNguoiDung(MaNguoiDung);
            //Tim khao sat theo ma nguoi dung
            DAODapAnKhaoSat DapAnKhaoSatDAO = new DAODapAnKhaoSat();
            List<DAPANKHAOSAT> DSDapAnKhaoSat = DapAnKhaoSatDAO.layDapAnTheoMaCauHoi(MaCauHoi);

            for (int i = 0; i < DSDapAnKhaoSat.Count(); i++)
            {
                for (int j = 0; j < DsKhaoSat.Count(); j++)
                {
                    if (DSDapAnKhaoSat[i].MaDapAn == DsKhaoSat[j].MaDapAn)
                        return false;
                }
            }
            return true;
        }
        #endregion
    }
}
