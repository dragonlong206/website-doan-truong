using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSTapTinBaiViet
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<TAPTINBAIVIET> SelectTAPTINBAIVIETsAll()
        {
            DAOTapTinBaiViet TAPTINBAIVIET = new DAOTapTinBaiViet();
            return TAPTINBAIVIET.SelectTAPTINBAIVIETsAll();
        }

        public int Them(TAPTINBAIVIET lpDTO)
        {
            DAOTapTinBaiViet TAPTINBAIVIET = new DAOTapTinBaiViet();
            return TAPTINBAIVIET.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOTapTinBaiViet TAPTINBAIVIET = new DAOTapTinBaiViet();
            return TAPTINBAIVIET.Xoa(machungtu);
        }

        public int CapNhat(TAPTINBAIVIET lpDTO)
        {
            DAOTapTinBaiViet TAPTINBAIVIET = new DAOTapTinBaiViet();
            return TAPTINBAIVIET.CapNhat(lpDTO);
        }

        public TAPTINBAIVIET TimKiem(int machungtu)
        {
            DAOTapTinBaiViet TAPTINBAIVIET = new DAOTapTinBaiViet();
            return TAPTINBAIVIET.TimKiem(machungtu);
        }
        #endregion
    }
}
