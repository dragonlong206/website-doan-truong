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
    public partial class wucDangNhap : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((NGUOIDUNG)Session["NGUOIDUNG"]) == null)
                PanelDangXuat.Visible = false;
            else
            {
                PanelDangNhap.Visible = false;
                hlhoten.Text = ((NGUOIDUNG)Session["NGUOIDUNG"]).HoTen;
            }
        }
        protected void btDangNhap_Click(object sender, EventArgs e)
        {
            BUSNguoiDung BUSNguoiDung = new BUSNguoiDung();
            NGUOIDUNG NGUOIDUNG = new NGUOIDUNG();
            NGUOIDUNG = BUSNguoiDung.TimKiem(txtusername.Text, txtpassword.Text);

            if (NGUOIDUNG != null)
            {
                Session["LOGIN"] = NGUOIDUNG;
                PanelDangNhap.Visible = false;
                PanelDangXuat.Visible = true;
                hlhoten.Text = NGUOIDUNG.HoTen;
                hlhoten.NavigateUrl = "ThongTinCaNhan.aspx?id=" + NGUOIDUNG.MaNguoiDung;
                if (NGUOIDUNG.MaVaiTro == 1)
                {
                    hlVaiTro.Text = "Hoạt Động";
                    hlVaiTro.NavigateUrl = "~/VaiTro1.aspx";
                }
                else
                    if (NGUOIDUNG.MaVaiTro == 2)
                    {
                        hlVaiTro.Text = "Mượn Phòng";
                        hlVaiTro.NavigateUrl = "~/VaiTro2.aspx";
                    }
                    else
                    {
                        hlVaiTro.Text = "Quản Lý";
                        hlVaiTro.NavigateUrl = "";
                    }
            }
        }
        protected void btDangXuat_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/index.aspx");
        }
    }
}