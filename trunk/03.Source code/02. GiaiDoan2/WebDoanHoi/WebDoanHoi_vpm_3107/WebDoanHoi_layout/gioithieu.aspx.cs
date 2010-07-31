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
    public partial class gioithieu : System.Web.UI.Page
    {
        int magioithieu = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                magioithieu = int.Parse(Request.QueryString["id"]);
                loadGioiThieu(magioithieu);
            }
            else
            {

                loadDSGioiThieu();
            }
        }
        private void loadDSGioiThieu()
        {
            BUSGioiThieu GioiThieuBus = new BUSGioiThieu();
            List<GIOITHIEU> DSGioiThieu = GioiThieuBus.SelectGIOITHIEUsAll();

            string noidung = "";
            for (int i = 0; i < DSGioiThieu.Count(); i++)
            {
                noidung += "<a href='" + "gioithieu.aspx?id=" + DSGioiThieu[i].MaBai + "'>" + DSGioiThieu[i].TieuDe + "</a>";
                noidung += "<br />";
            }
            ltrNoiDung.Text = noidung;
        }
        private void loadGioiThieu(int magioithieu)
        {
            BUSGioiThieu GioiThieuBus = new BUSGioiThieu();
            GIOITHIEU GioiThieu = GioiThieuBus.TimKiem(magioithieu);
            ltrNoiDung.Text = GioiThieu.NoiDung;
        }
    }
}
