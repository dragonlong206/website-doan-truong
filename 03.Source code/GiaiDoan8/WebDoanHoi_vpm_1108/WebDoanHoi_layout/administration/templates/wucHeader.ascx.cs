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
            if (!IsPostBack)
            {
                lblUserName.Text = ((NGUOIDUNG)Session["ADMIN"]).Username;
            }
        }

        protected void linkButtonLogout_Click(object sender, EventArgs e)
        {
            Session["ADMIN"] = null;
            Response.Redirect("~/index.aspx");
        }
    }
}