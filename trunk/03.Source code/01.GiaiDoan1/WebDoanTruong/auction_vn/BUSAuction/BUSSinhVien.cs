using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSSinhVien
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<SINHVIEN> SelectSINHVIENsAll()
        {
            DAOSINHVIEN SINHVIEN = new DAOSINHVIEN();
            return SINHVIEN.SelectSINHVIENsAll();
        }

        public int Them(SINHVIEN lpDTO)
        {
            DAOSINHVIEN SINHVIEN = new DAOSINHVIEN();
            return SINHVIEN.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOSINHVIEN SINHVIEN = new DAOSINHVIEN();
            return SINHVIEN.Xoa(machungtu);
        }

        public int CapNhat(SINHVIEN lpDTO)
        {
            DAOSINHVIEN SINHVIEN = new DAOSINHVIEN();
            return SINHVIEN.CapNhat(lpDTO);
        }

        public SINHVIEN TimKiem(int machungtu)
        {
            DAOSINHVIEN SINHVIEN = new DAOSINHVIEN();
            return SINHVIEN.TimKiem(machungtu);
        }
        #endregion
    }
}
