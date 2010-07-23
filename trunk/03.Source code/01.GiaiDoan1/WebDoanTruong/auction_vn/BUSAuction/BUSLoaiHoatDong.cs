using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSLoaiHoatDong
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LOAIHOATDONG> SelectLOAIHOATDONGsAll()
        {
            DAOLOAIHOATDONG LOAIHOATDONG = new DAOLOAIHOATDONG();
            return LOAIHOATDONG.SelectLOAIHOATDONGsAll();
        }

        public int Them(LOAIHOATDONG lpDTO)
        {
            DAOLOAIHOATDONG LOAIHOATDONG = new DAOLOAIHOATDONG();
            return LOAIHOATDONG.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOLOAIHOATDONG LOAIHOATDONG = new DAOLOAIHOATDONG();
            return LOAIHOATDONG.Xoa(machungtu);
        }

        public int CapNhat(LOAIHOATDONG lpDTO)
        {
            DAOLOAIHOATDONG LOAIHOATDONG = new DAOLOAIHOATDONG();
            return LOAIHOATDONG.CapNhat(lpDTO);
        }

        public LOAIHOATDONG TimKiem(int machungtu)
        {
            DAOLOAIHOATDONG LOAIHOATDONG = new DAOLOAIHOATDONG();
            return LOAIHOATDONG.TimKiem(machungtu);
        }
        #endregion
    }
}
