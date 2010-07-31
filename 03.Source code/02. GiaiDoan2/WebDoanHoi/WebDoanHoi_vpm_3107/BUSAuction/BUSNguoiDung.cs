using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSNguoiDung
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<NGUOIDUNG> SelectNGUOIDUNGsAll()
        {
            DAONguoiDung NGUOIDUNG = new DAONguoiDung();
            return NGUOIDUNG.SelectNGUOIDUNGsAll ();
        }

        public int Them(NGUOIDUNG lpDTO)
        {
            DAONguoiDung NGUOIDUNG = new DAONguoiDung();
            return NGUOIDUNG.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAONguoiDung NGUOIDUNG = new DAONguoiDung();
            return NGUOIDUNG.Xoa(machungtu);
        }

        public int CapNhat(NGUOIDUNG lpDTO)
        {
            DAONguoiDung NGUOIDUNG = new DAONguoiDung();
            return NGUOIDUNG.CapNhat(lpDTO);
        }

        public NGUOIDUNG TimKiem(int machungtu)
        {
            DAONguoiDung NGUOIDUNG = new DAONguoiDung();
            return NGUOIDUNG.TimKiem(machungtu);
        }
        #endregion
        public NGUOIDUNG TimKiem(string tennguoidung, string password)
        {
            DAONguoiDung NGUOIDUNG = new DAONguoiDung();
            return NGUOIDUNG.TimKiem(tennguoidung, password);
        }
       
    }
}
