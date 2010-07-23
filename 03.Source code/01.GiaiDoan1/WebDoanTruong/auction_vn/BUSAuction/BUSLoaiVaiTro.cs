using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSLoaiVaiTro
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<LOAIVAITRO> SelectLOAIVAITROsAll()
        {
            DAOLOAIVAITRO LOAIVAITRO = new DAOLOAIVAITRO();
            return LOAIVAITRO.SelectLOAIVAITROsAll();
        }

        public int Them(LOAIVAITRO lpDTO)
        {
            DAOLOAIVAITRO LOAIVAITRO = new DAOLOAIVAITRO();
            return LOAIVAITRO.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAOLOAIVAITRO LOAIVAITRO = new DAOLOAIVAITRO();
            return LOAIVAITRO.Xoa(machungtu);
        }

        public int CapNhat(LOAIVAITRO lpDTO)
        {
            DAOLOAIVAITRO LOAIVAITRO = new DAOLOAIVAITRO();
            return LOAIVAITRO.CapNhat(lpDTO);
        }

        public LOAIVAITRO TimKiem(int machungtu)
        {
            DAOLOAIVAITRO LOAIVAITRO = new DAOLOAIVAITRO();
            return LOAIVAITRO.TimKiem(machungtu);
        }
        #endregion
    }
}
