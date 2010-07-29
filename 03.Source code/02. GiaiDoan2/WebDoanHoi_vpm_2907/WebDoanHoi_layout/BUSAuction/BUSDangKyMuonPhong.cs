using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSDangKyMuonPhong
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<DANGKYMUONPHONG> SelectDANGKYMUONPHONGsAll()
        {
            DAODangKyMuonPhong DANGKYMUONPHONG = new DAODangKyMuonPhong();
            return DANGKYMUONPHONG.SelectDANGKYMUONPHONGsAll();
        }

        public int Them(DANGKYMUONPHONG lpDTO)
        {
            DAODangKyMuonPhong DANGKYMUONPHONG = new DAODangKyMuonPhong();
            return DANGKYMUONPHONG.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAODangKyMuonPhong DANGKYMUONPHONG = new DAODangKyMuonPhong();
            return DANGKYMUONPHONG.Xoa(machungtu);
        }

        public int CapNhat(DANGKYMUONPHONG lpDTO)
        {
            DAODangKyMuonPhong DANGKYMUONPHONG = new DAODangKyMuonPhong();
            return DANGKYMUONPHONG.CapNhat(lpDTO);
        }

        public DANGKYMUONPHONG TimKiem(int machungtu)
        {
            DAODangKyMuonPhong DANGKYMUONPHONG = new DAODangKyMuonPhong();
            return DANGKYMUONPHONG.TimKiem(machungtu);
        }
        #endregion
    }
}
