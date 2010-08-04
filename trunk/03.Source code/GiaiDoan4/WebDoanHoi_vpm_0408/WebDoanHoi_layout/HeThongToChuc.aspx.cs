using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections.Generic;
using BUSAuction;
using DTOAuction;

namespace WebDoanHoi_layout
{
    public partial class HeThongToChuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                int id = int.Parse(Request.QueryString["id"]);
                BUSHeThongToChuc HeThongToChucBUS = new BUSHeThongToChuc();
                HETHONGTOCHUC HeThongToChuc = HeThongToChucBUS.TimKiem(id);

                if (HeThongToChuc != null)
                {
                    lbNoiDung.Text = HeThongToChuc.NoiDung.ToString();
                }
                else
                {

                }
            }
        }
    }
}
