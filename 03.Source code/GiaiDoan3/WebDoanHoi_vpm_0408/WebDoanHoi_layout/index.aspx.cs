﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;


namespace WebDoanHoi_layout
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BUSBaiViet BaiVietBUS = new BUSBaiViet();
            List<BAIVIET> DSBaiViet = BaiVietBUS.LayBaiVietMoiNhat(4);

            lblHinhAnh.Text = "<img src ='Uploads/" + DSBaiViet[0].HinhAnh + "' style ='width:200px; height:200px' />";
            lblTieuDe.Text = DSBaiViet[0].TieuDe;
            lblTomTat.Text = DSBaiViet[0].TomTat;

            lblHinh1.Text = "<img src ='Uploads/" + DSBaiViet[1].HinhAnh + "' style ='width:170px; height:170px' />";
            lblHinh2.Text = "<img src ='Uploads/" + DSBaiViet[2].HinhAnh + "' style ='width:170px; height:170px' />";
            lblHinh3.Text = "<img src ='Uploads/" + DSBaiViet[3].HinhAnh + "' style ='width:170px; height:170px' />";

            lblTieuDe1.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[1].MaBaiViet + "'>" + DSBaiViet[1].TieuDe + "</a>";
            lblTieuDe2.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[2].MaBaiViet + "'>" + DSBaiViet[2].TieuDe + "</a>";
            lblTieuDe3.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[3].MaBaiViet + "'>" + DSBaiViet[3].TieuDe + "</a>";

        }
    }
}