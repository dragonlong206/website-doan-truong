﻿using System;
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

        #region Nhi 31/7/2010
        public List<BAIVIET> TimKiemTheoLoaiBaiViet(int MaLoaiBaiViet)
        {
            DAOBaiViet BaiViet = new DAOBaiViet();
            return BaiViet.TimKiemTheoLoaiBaiViet(MaLoaiBaiViet);
        }

        public List<BAIVIET> LayBaiVietMoiNhat(int SoLuong)
        {

            DAOBaiViet BaiViet = new DAOBaiViet();
            return BaiViet.LayBaiVietMoiNhat(SoLuong);
        }

        public List<BAIVIET> LayBaiVietMoiNhat()
        {
            DAOBaiViet BaiViet = new DAOBaiViet();
            return BaiViet.LayBaiVietMoiNhat();
        }
        #endregion

        #region Nhi 5/8/2010
        public BAIVIET LayBaiVietMoiNhatTheoChuyenMuc(int MaChuyenMuc)
        {
            DAOBaiViet BaiVietDAO = new DAOBaiViet();
            return BaiVietDAO.LayBaiVietMoiNhatTheoChuyenMuc(MaChuyenMuc);
        }
        #endregion

        #region Tuấn 5/8/2010
        public List<BAIVIET> Search(string tieude, string tomtat)
        {
            DAOBaiViet BaiViet = new DAOBaiViet();
            return BaiViet.Search(tieude, tomtat);
        }
        #endregion

        #region Đức 5/8/2010
        public List<BAIVIET_getall_newResult> SelectBAIVIETsAll_new()
        {
            DAOBaiViet BAIVIET = new DAOBaiViet();
            return BAIVIET.SelectBAIVIETsAll_new();
        }
        #endregion
    }
}
