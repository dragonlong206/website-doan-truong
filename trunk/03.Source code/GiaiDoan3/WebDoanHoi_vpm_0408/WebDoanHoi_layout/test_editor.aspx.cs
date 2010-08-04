using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;

namespace WebDoanHoi_layout
{
    public partial class test_editor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void alert(string info)
        {
            string script = "<script type='text/javascript'>";
            script += "alert('";
            script += info;
            script += "')";
            script += "</script>";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", script);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BAIVIET bv = new BAIVIET();
            bv.TieuDe = txtTieuDe.Text;
            bv.NoiDung = FCKeditor1.Value;
            bv.MaLoaiBaiViet = 0;
            bv.NgayDang = DateTime.Today;
            bv.HinhAnh = "";
            bv.TomTat = txtTomTat.Text;
            BUSBaiViet bbv = new BUSBaiViet();
            bbv.Them(bv);
        }
    }
}
