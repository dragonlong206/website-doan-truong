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
            if (!IsPostBack)
            {
                if (((NGUOIDUNG)Session["LOGIN"]) == null)//chua dang nhap
                {
                    PanelDangNhap.Visible = true;
                    PanelDangXuat.Visible = false;
                }
                else
                {
                    PanelDangNhap.Visible = false;
                    PanelDangXuat.Visible = true;
                    LoadSinhVien();
                }
            }
        }
        protected void LoadSinhVien()
        {
            hlhoten.Text = ((NGUOIDUNG)Session["LOGIN"]).HoTen;
            hlhoten.NavigateUrl = "~/ThongTinCaNhan.aspx?id=" + ((NGUOIDUNG)Session["LOGIN"]).MaNguoiDung;
            hlhoten.Visible = true;

            if (((NGUOIDUNG)Session["LOGIN"]).MaVaiTro == 1)
            {
                hlVaiTro.Text = "Hoạt Động";
                hlVaiTro.NavigateUrl = "~/HoatDong.aspx";
            }
            else if (((NGUOIDUNG)Session["LOGIN"]).MaVaiTro == 2)
            {
                hlVaiTro.Text = "Mượn Phòng";
                hlVaiTro.NavigateUrl = "~/MuonPhong.aspx";
            }
            else
            {
                hlVaiTro.Text = "Quản Lý";
                hlVaiTro.NavigateUrl = "~/administration/HoatDong.aspx";
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
                LoadSinhVien();
            }
        }
        protected void btDangXuat_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            PanelDangNhap.Visible = true;
            PanelDangXuat.Visible = false;
        }
    }
}