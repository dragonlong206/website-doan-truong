using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDoanHoi_layout
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "";
            str += "<link href='css/style-3-col.css' rel='stylesheet' type='text/css' />";
            str += "<div class='post-title'>";
            string strCM1 = "<a>Chuyên Mục 1</a>";
            string strCM2 = "<a>Chuyên Mục 2</a>";
            string strCM3 = "<a>Chuyên Mục 3</a>";
            str +=  strCM1 + "|" + strCM2 + " | " + strCM3;

            str += "</div>";
            lblTest.Text = str;

           /* str += "<div class='post-content'>";
            str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet.MaBaiViet + "'><b>" + BaiViet.TieuDe + "</b></a><br /><br />";
            str += BaiViet.TomTat;
            str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet.MaBaiViet + "'><i>" + " Xem tiếp ..." + "</i></a>";
            str += "</div>";*/
            int i;
            for (i = 0; i < 3; i++)
            {
                string str2 = "";
                str2 += "<asp:ScriptManager ID='ScriptManager1' runat='server'>";
                str2 += "</asp:ScriptManager>";
                str2 += "<asp:UpdatePanel ID='UpdatePanel1' runat='server'>";
                str2 += "<ContentTemplate>";
                str2 += "<asp:LinkButton ID='LinkButton" + "' runat='server' onclick='LinkButton" + "_Click'>Chuyên Mục 1</asp:LinkButton>";
                str2 += "<asp:Label ID='lblTest' runat='server' Text='Label'></asp:Label>";
                str2 += "</ContentTemplate>";
                str2 += "</asp:UpdatePanel>";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            lblTest.Text = "Đây là Chuyên Mục 1";
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            lblTest.Text = "Đây là Chuyên Mục 2";
        }
    }
}
