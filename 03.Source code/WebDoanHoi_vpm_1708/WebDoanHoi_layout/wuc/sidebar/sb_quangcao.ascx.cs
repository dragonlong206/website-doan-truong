using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDoanHoi_layout.wuc
{
    public partial class sb_quangcao : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LoadImage()
        {
            // Hình quảng cáo 1
            Image1.ImageUrl = "~/Uploads/HinhAnhQuangCao/qc1.jpg";
            Image1.AlternateText = "Dành cho quảng cáo";
            Image1.PostBackUrl = "~/GioiThieu.aspx"; //Test
            //Image1.DescriptionUrl = "BaiViet.aspx";

            // Hình quảng cáo 2
            Image2.ImageUrl = "~/Uploads/HinhAnhQuangCao/qc2.jpg";
            Image2.AlternateText = "Dành cho quảng cáo";
            Image2.PostBackUrl = "GioiThieu.aspx";
        }
    }
}