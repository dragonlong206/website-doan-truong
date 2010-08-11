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
using System.Collections.Generic;


namespace WebDoanHoi_layout.administration
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ADMIN"] != null && ((NGUOIDUNG)Session["ADMIN"]).MaVaiTro == 3)
            {
                Response.Redirect("~/administration/BaiViet.aspx");
            }
        }
        protected void btDangNhap_Click(object sender, EventArgs e)
        {
            BUSNguoiDung BUSNguoiDung = new BUSNguoiDung();
            NGUOIDUNG NGUOIDUNG = new NGUOIDUNG();
            NGUOIDUNG = BUSNguoiDung.TimKiem(txtusername.Text, txtpassword.Text);

            if (NGUOIDUNG != null)
            {
                if (NGUOIDUNG.MaVaiTro == 3)
                {
                    Session["ADMIN"] = NGUOIDUNG;
                    Response.Redirect("~/administration/BaiViet.aspx");
                }
                else
                {
                    LabelError.Text = "Moi ban dang nhap lai!";
                }
            }
            else
            {
                LabelError.Text = "Moi ban dang nhap lai!";
            }

        }
    }
}
