﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace WebDoanHoi_layout
{
    public partial class main_3col : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Le Van Long
            //WebPartManager1.DisplayMode = WebPartManager.DesignDisplayMode;
                      sb_hd_noibat1.LoadImage();
            sb_quangcao1.LoadImage();
        }
    }
}
