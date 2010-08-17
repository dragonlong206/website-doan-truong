using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;

namespace WebDoanHoi_layout.administration
{
    public partial class LichLamViec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ADMIN"] == null || ((NGUOIDUNG)Session["ADMIN"]).MaVaiTro != 3)
                Response.Redirect("~/administration/index.aspx?id=13");
        }
    }
}
