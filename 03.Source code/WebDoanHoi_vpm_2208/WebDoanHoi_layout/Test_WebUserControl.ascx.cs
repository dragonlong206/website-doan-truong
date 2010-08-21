using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DTOAuction;
using BUSAuction;
using System.Collections.Generic;

namespace WebDoanHoi_layout
{
    public partial class Test_WebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            BUSLoaiBaiViet LoaiBaiViet = new BUSLoaiBaiViet();
            List<LOAIBAIVIET> DSLoaiBaiViet = LoaiBaiViet.TimKiemLoaiBaiVietTheoChuyenMuc(id);
            LinkButton1.Text = DSLoaiBaiViet[0].TenLoaiBaiViet;
            LinkButton2.Text = DSLoaiBaiViet[1].TenLoaiBaiViet;
            LinkButton3.Text = DSLoaiBaiViet[2].TenLoaiBaiViet;

            string str = DSLoaiBaiViet[0].TenLoaiBaiViet + "</br>" + DSLoaiBaiViet[1].TenLoaiBaiViet + "</br>" + DSLoaiBaiViet[0].TenLoaiBaiViet;
            lblNoiDung.Text = str;
        }
    }
}