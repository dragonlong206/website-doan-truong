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
             int MaLoaiBaiViet = int.Parse(Request.QueryString["id"]);
            BUSBaiViet BaiVietBUS = new BUSBaiViet();
             List<BAIVIET> DSBaiViet = BaiVietBUS.TimKiemTheoLoaiBaiViet(MaLoaiBaiViet);
            //List<BAIVIET> DSBaiViet = BaiVietBUS.SelectBAIVIETsAll();
            //  string link = "";
            /*   for (int i = 0; i < DSBaiViet.Count(); i++)
               {
                   //HyperLink h = new HyperLink();
                   //h.Text = DSBaiViet[i].tieude;

                   //h.NavigateUrl = "BaiViet.aspx?id=" + DSBaiViet[i].mabaiviet;
                   //Page.Controls.Add(h);


                   link += "<a href='" + "BaiViet.aspx?id=" + DSBaiViet[i].MaBaiViet + "'>" + DSBaiViet[i].TieuDe + "</a>";
                   link += "<br />";

               }
               Label1.Text = link;*/
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
