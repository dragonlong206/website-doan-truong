﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using DTOAuction;
using BUSAuction;

namespace WebDoanHoi_layout
{
    public partial class DoiMatKhau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOGIN"] == null)
                Response.Redirect("index.aspx");
        }

        protected void btThayDoi_Click(object sender, EventArgs e)
        {
            BUSNguoiDung busnguoidung = new BUSNguoiDung();

            string szTenDangNhap = ((NGUOIDUNG)Session["LOGIN"]).Username;

            if (szTenDangNhap != null)
            {
                NGUOIDUNG sv = busnguoidung.TimKiem(szTenDangNhap);

                if (sv.Password.Trim() == txtMatKhauCu.Text)
                {
                    if (txtMatKhauMoi.Text == "")
                    {
                        txtThongTin.Text = "Mật khẩu mới không hợp lệ.";
                    }
                    else
                        if (txtMatKhauMoi.Text != txtXacNhan.Text)
                        {
                            txtThongTin.Text = "Vui lòng xác nhận lại mật khẩu mới.";
                        }
                        else
                        {
                            sv.Password = txtMatKhauMoi.Text;
                            busnguoidung.CapNhat(sv);
                            txtThongTin.Text = "Cập nhật mật khẩu thành công.";
                        }
                }
                else
                {
                    txtThongTin.Text = "Mật khẩu cũ không đúng";
                }

                txtThongTin.Visible = true;
            }
            else
            {
                txtThongTin.Text = "Vui lòng đăng nhập";
                txtThongTin.Visible = true;
            }
        }
    }
}