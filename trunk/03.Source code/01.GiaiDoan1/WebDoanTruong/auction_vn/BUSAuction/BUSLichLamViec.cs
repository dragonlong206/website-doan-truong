using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSLichLamViec
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LICHLAMVIEC> SelectLICHLAMVIECsAll()
        {
            DAOLICHLAMVIEC LICHLAMVIEC = new DAOLICHLAMVIEC();
            return LICHLAMVIEC.SelectLICHLAMVIECsAll();
        }

        public int Them(LICHLAMVIEC lpDTO)
        {
            DAOLICHLAMVIEC LICHLAMVIEC = new DAOLICHLAMVIEC();
            return LICHLAMVIEC.Them(lpDTO);
        }

        public int Xoa(int manoidung)
        {
            DAOLICHLAMVIEC LICHLAMVIEC = new DAOLICHLAMVIEC();
            return LICHLAMVIEC.Xoa(manoidung);
        }

        public int CapNhat(LICHLAMVIEC lpDTO)
        {
            DAOLICHLAMVIEC LICHLAMVIEC = new DAOLICHLAMVIEC();
            return LICHLAMVIEC.CapNhat(lpDTO);
        }

        public LICHLAMVIEC TimKiem(string manoidung)
        {
            DAOLICHLAMVIEC LICHLAMVIEC = new DAOLICHLAMVIEC();
            return LICHLAMVIEC.TimKiem(manoidung);
        }
        #endregion
    }
}
