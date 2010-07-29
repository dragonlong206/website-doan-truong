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
    public partial class BaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BUSBaiViet BaiVietBUS = new BUSBaiViet();
            int MaBaiViet = int.Parse(Request.QueryString["id"]);
            BAIVIET BaiViet = BaiVietBUS.TimKiem(MaBaiViet);
            lblNoiDungBaiViet.Text = BaiViet.NoiDung;
        }
    }
}
