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
using BUSAuction;
using DTOAuction;
using System.IO;
using System.Collections.Generic;

namespace WebDoanHoi_layout
{
    public partial class LoaiBaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("index.aspx");
            }
             int MaLoaiBaiViet = int.Parse(Request.QueryString["id"]);
            BUSBaiViet BaiVietBUS = new BUSBaiViet();
             List<BAIVIET> DSBaiViet = BaiVietBUS.TimKiemTheoLoaiBaiViet(MaLoaiBaiViet);
             if (DSBaiViet.Count() == 0)
             {
                 Label1.Visible = false;
             }
             else
             {
                 Label1.Visible = true;
             }
            string str = "";
            for (int j = 0; j < DSBaiViet.Count(); j++)
            {
                str += "<div class='dsbaiviet'>";
                str += "<lable>";
                str += "<div class='tieude'>";
                str += "<img src='images/ico/favicon_002.ico'/>";
                str += DSBaiViet[j].TieuDe + "</div>";
                str += "<div class='tomtat'>" + DSBaiViet[j].TomTat + "</div>";
                str += "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[j].MaBaiViet + "'><i>" + " Xem tiếp ..." + "</i></a>";
                str += "</div>";
                str += "<hr width='50%'>";
            }
            Label1.Text = str;
        }
    }
}
