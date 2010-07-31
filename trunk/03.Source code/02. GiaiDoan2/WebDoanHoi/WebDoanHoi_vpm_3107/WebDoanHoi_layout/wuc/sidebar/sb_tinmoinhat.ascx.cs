using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;

namespace WebDoanHoi_layout.wuc
{
    public partial class sb_tinmoinhat : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BUSBaiViet BaiVietBUS = new BUSBaiViet();
            List<BAIVIET> DSBaiVietMoiNhat = BaiVietBUS.LayBaiVietMoiNhat();
            string str = "";
            for (int i = 0; i < DSBaiVietMoiNhat.Count(); i++)
            {
                str += "<ul>";
                str += "<li><a href='#'>";
                str += DSBaiVietMoiNhat[i].TieuDe;
                str += "</a></li>";
                str += "</ul>";
            }
            lblBaiVietMoiNhat.Text = str;
        }
    }
}