using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSTapTinThongBao
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<TAPTINTHONGBAO> SelectTAPTINTHONGBAOsAll()
        {
            DAOTapTinThongBao TAPTINTHONGBAO = new DAOTapTinThongBao();
            return TAPTINTHONGBAO.SelectTAPTINTHONGBAOsAll();
        }

        public int Them(TAPTINTHONGBAO lpDTO)
        {
            DAOTapTinThongBao TAPTINTHONGBAO = new DAOTapTinThongBao();
            return TAPTINTHONGBAO.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOTapTinThongBao TAPTINTHONGBAO = new DAOTapTinThongBao();
            return TAPTINTHONGBAO.Xoa(machungtu);
        }

        public int CapNhat(TAPTINTHONGBAO lpDTO)
        {
            DAOTapTinThongBao TAPTINTHONGBAO = new DAOTapTinThongBao();
            return TAPTINTHONGBAO.CapNhat(lpDTO);
        }

        public TAPTINTHONGBAO TimKiem(int machungtu)
        {
            DAOTapTinThongBao TAPTINTHONGBAO = new DAOTapTinThongBao();
            return TAPTINTHONGBAO.TimKiem(machungtu);
        }
        #endregion
    }
}
