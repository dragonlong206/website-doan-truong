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

        public TAPTIN TimKiemMaTapTin(int maTapTin)
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.TimKiemMaTapTin(maTapTin);
        }
        public TAPTIN TimKiemMaBaiViet(int maBaiViet)
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.TimKiemMaBaiViet(maBaiViet);
        }
        public TAPTIN TimKiemTenTapTin(string tenTapTin)
        {
            DAOTapTin TAPTIN = new DAOTapTin();
            return TAPTIN.TimKiemTenTapTin(tenTapTin);
        }
        public int TimSoLuongTapTin()
        {
            int sl;

            DAOTapTin TAPTIN = new DAOTapTin();
            List<TAPTIN> listTapTin = TAPTIN.SelectTAPTINsAll();
            sl = listTapTin.Count;

            return sl;
        }
        #endregion
    }
}
