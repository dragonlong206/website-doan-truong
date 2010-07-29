using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSHoatDong
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<HOATDONG> SelectHOATDONGsAll()
        {
            DAOHoatDong HOATDONG = new DAOHoatDong();
            return HOATDONG.SelectHOATDONGsAll();
        }

        public int Them(HOATDONG lpDTO)
        {
            DAOHoatDong HOATDONG = new DAOHoatDong();
            return HOATDONG.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOHoatDong HOATDONG = new DAOHoatDong();
            return HOATDONG.Xoa(machungtu);
        }

        public int CapNhat(HOATDONG lpDTO)
        {
            DAOHoatDong HOATDONG = new DAOHoatDong();
            return HOATDONG.CapNhat(lpDTO);
        }

        public HOATDONG TimKiem(int machungtu)
        {
            DAOHoatDong HOATDONG = new DAOHoatDong();
            return HOATDONG.TimKiem(machungtu);
        }
        #endregion
    }
}
