using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSDangKyHoatDong
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<DANGKYHOATDONG> SelectDANGKYHOATDONGsAll()
        {
            DAODangKyHoatDong DANGKYHOATDONG = new DAODangKyHoatDong();
            return DANGKYHOATDONG.SelectDANGKYHOATDONGsAll();
        }

        public int Them(DANGKYHOATDONG lpDTO)
        {
            DAODangKyHoatDong DANGKYHOATDONG = new DAODangKyHoatDong();
            return DANGKYHOATDONG.Them(lpDTO);
        }

        public int Xoa(DANGKYHOATDONG lpDTO)
        {
            DAODangKyHoatDong DANGKYHOATDONG = new DAODangKyHoatDong();
            return DANGKYHOATDONG.Xoa(lpDTO);
        }

        public int CapNhat(DANGKYHOATDONG lpDTO)
        {
            DAODangKyHoatDong DANGKYHOATDONG = new DAODangKyHoatDong();
            return DANGKYHOATDONG.CapNhat(lpDTO);
        }

        public DANGKYHOATDONG TimKiem(int machungtu)
        {
            DAODangKyHoatDong DANGKYHOATDONG = new DAODangKyHoatDong();
            return DANGKYHOATDONG.TimKiem(machungtu);
        }
        #endregion
    }
}
