using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDoanHoi_layout
{
    public partial class main_3col : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Le Van Long
            sb_hd_noibat1.LoadImage();
            sb_quangcao1.LoadImage();
        }
    }
}
