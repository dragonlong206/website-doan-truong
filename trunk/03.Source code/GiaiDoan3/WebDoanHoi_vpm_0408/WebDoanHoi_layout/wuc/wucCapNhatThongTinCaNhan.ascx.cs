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
    public partial class wucCapNhatThongTinCaNhan : System.Web.UI.UserControl
    {
        int MaNguoiDung = 2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (((NGUOIDUNG)Session["LOGIN"]) == null)
                {
                    Page.Title = "Mời bạn đăng nhập để có thể cập nhật thông tin cá nhân";
                    Response.Redirect("~/index.aspx");
                    return;
                }
                Page.Title = "Cập nhật thông tin cá nhân";
                LoadMaNguoiDung();
            }

        }

        protected void BtnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ThongTinCaNhan.aspx?id=" + MaNguoiDung.ToString());
        }
        private void LoadMaNguoiDung()
        {
            //string tempMa = Request.QueryString["id"];
            int MaND = ((NGUOIDUNG)Session["LOGIN"]).MaNguoiDung;
            BUSNguoiDung NguoiDungBUS = new BUSNguoiDung();
            NGUOIDUNG NguoiDung = NguoiDungBUS.TimKiem(MaND);
            if (NguoiDung != null)
            {
                TxbHoTen.Text = NguoiDung.HoTen;
                TxbEmail.Text = NguoiDung.Email;
            }
           /* if (tempMa != null)
            {
                MaNguoiDung = int.Parse(tempMa);
            }
            else
            {
                MaNguoiDung = 2;
            }*/
        }
    }
}