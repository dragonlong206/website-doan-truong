using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSTapTin
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<TAPTIN> SelectTAPTINsAll()
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.SelectTAPTINsAll();
        }

        public int Them(TAPTIN lpDTO)
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.Xoa(machungtu);
        }

        public int CapNhat(TAPTIN lpDTO)
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.CapNhat(lpDTO);
        }

        public TAPTIN TimKiem(int machungtu)
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.TimKiem(machungtu);
        }
        #endregion
    }
}
