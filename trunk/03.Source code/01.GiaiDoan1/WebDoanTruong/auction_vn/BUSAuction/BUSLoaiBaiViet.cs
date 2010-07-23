using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSLoaiBaiViet
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LOAIBAIVIET> SelectLOAIBAIVIETsAll()
        {
            DAOLOAIBAIVIET LOAIBAIVIET = new DAOLOAIBAIVIET();
            return LOAIBAIVIET.SelectLOAIBAIVIETsAll();
        }

        public int Them(LOAIBAIVIET lpDTO)
        {
            DAOLOAIBAIVIET LOAIBAIVIET = new DAOLOAIBAIVIET();
            return LOAIBAIVIET.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOLOAIBAIVIET LOAIBAIVIET = new DAOLOAIBAIVIET();
            return LOAIBAIVIET.Xoa(machungtu);
        }

        public int CapNhat(LOAIBAIVIET lpDTO)
        {
            DAOLOAIBAIVIET LOAIBAIVIET = new DAOLOAIBAIVIET();
            return LOAIBAIVIET.CapNhat(lpDTO);
        }

        public LOAIBAIVIET TimKiem(int machungtu)
        {
            DAOLOAIBAIVIET LOAIBAIVIET = new DAOLOAIBAIVIET();
            return LOAIBAIVIET.TimKiem(machungtu);
        }
        #endregion
    }
}
