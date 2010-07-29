using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOAuction;
using DTOAuction;

namespace BUSAuction
{
    public class BUSDapAnKhaoSat
    {
        #region Ham chung: Load Them Xoa Capnhat Timkiem 15/07/2010
        public List<DAPANKHAOSAT> SelectDAPANKHAOSATsAll()
        {
            DAODapAnKhaoSat DAPANKHAOSAT = new DAODapAnKhaoSat();
            return DAPANKHAOSAT.SelectDAPANKHAOSATsAll();
        }

        public int Them(DAPANKHAOSAT lpDTO)
        {
            DAODapAnKhaoSat DAPANKHAOSAT = new DAODapAnKhaoSat();
            return DAPANKHAOSAT.Them(lpDTO);
        }

        public int Xoa(int machungtu)
        {
            DAODapAnKhaoSat DAPANKHAOSAT = new DAODapAnKhaoSat();
            return DAPANKHAOSAT.Xoa(machungtu);
        }

        public int CapNhat(DAPANKHAOSAT lpDTO)
        {
            DAODapAnKhaoSat DAPANKHAOSAT = new DAODapAnKhaoSat();
            return DAPANKHAOSAT.CapNhat(lpDTO);
        }

        public DAPANKHAOSAT TimKiem(int machungtu)
        {
            DAODapAnKhaoSat DAPANKHAOSAT = new DAODapAnKhaoSat();
            return DAPANKHAOSAT.TimKiem(machungtu);
        }
        #endregion
    }
}
