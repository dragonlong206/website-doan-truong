using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;

namespace WebDoanHoi_layout
{
    public partial class LichLamViec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BUSTapTinBaiViet busTapTinBaiViet = new BUSTapTinBaiViet();
            List<TAPTINBAIVIET> list= new List<TAPTINBAIVIET>();
            list = busTapTinBaiViet.GetLichLamViec();
            if (list.Count > 0)
            {
                GridViewLichLamViec.DataSource = list;
                GridViewLichLamViec.DataBind();
                GridViewLichLamViec.AllowPaging = true;                

               // GridViewLichLamViec.
                //GridViewLichLamViec.HeaderRow.Cells[0].Text= "test";
               // GridViewLichLamViec.Columns[0].HeaderText = "test";
            }
        }

        protected void GridViewLichLamViec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
