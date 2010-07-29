using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSBaiViet
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<BAIVIET> SelectBAIVIETsAll()
        {
            DAOBaiViet BAIVIET = new DAOBaiViet();
            return BAIVIET.SelectBAIVIETsAll();
        }

        public int Them(BAIVIET lpDTO)
        {
            DAOBaiViet BAIVIET = new DAOBaiViet();
            return BAIVIET.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOBaiViet BAIVIET = new DAOBaiViet();
            return BAIVIET.Xoa(machungtu);
        }

        public int CapNhat(BAIVIET lpDTO)
        {
            DAOBaiViet BAIVIET = new DAOBaiViet();
            return BAIVIET.CapNhat(lpDTO);
        }

        public BAIVIET TimKiem(int machungtu)
        {
            DAOBaiViet BAIVIET = new DAOBaiViet();
            return BAIVIET.TimKiem(machungtu);
        }
        #endregion
    }
}
