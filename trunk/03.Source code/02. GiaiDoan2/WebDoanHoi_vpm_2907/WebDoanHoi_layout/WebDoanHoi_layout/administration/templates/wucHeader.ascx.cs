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

namespace WebDoanHoi_layout.administration.templates
{
    public partial class wucHeader : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblUserName.Text = ((NGUOIDUNG)Session["Auction_Control"]).username;
        }

        protected void linkButtonLogout_Click(object sender, EventArgs e)
        {
            Session["Auction_Control"] = null;
            Response.Redirect("~/administration/default.aspx");
        }
    }
}