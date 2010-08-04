using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSChuyenMuc
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<CHUYENMUC> SelectCHUYENMUCsAll()
        {
            DAOChuyenMuc CHUYENMUC = new DAOChuyenMuc();
            return CHUYENMUC.SelectCHUYENMUCsAll();
        }

        public int Them(CHUYENMUC lpDTO)
        {
            DAOChuyenMuc CHUYENMUC = new DAOChuyenMuc();
            return CHUYENMUC.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOChuyenMuc CHUYENMUC = new DAOChuyenMuc();
            return CHUYENMUC.Xoa(machungtu);
        }

        public int CapNhat(CHUYENMUC lpDTO)
        {
            DAOChuyenMuc CHUYENMUC = new DAOChuyenMuc();
            return CHUYENMUC.CapNhat(lpDTO);
        }

        public CHUYENMUC TimKiem(int machungtu)
        {
            DAOChuyenMuc CHUYENMUC = new DAOChuyenMuc();
            return CHUYENMUC.TimKiem(machungtu);
        }
        #endregion

        #region Nhi:Lay CHUYENMUC theo loai bai viet

        public CHUYENMUC LayChuyenMucTheoBaiViet(int maloaibaiviet)
        {
            DAOChuyenMuc CHUYENMUC = new DAOChuyenMuc();
            return CHUYENMUC.LayChuyenMucTheoBaiViet(maloaibaiviet);
        }
        #endregion
    }
}
