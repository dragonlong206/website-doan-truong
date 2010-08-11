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
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebDoanHoi_layout
{
    public partial class BaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
                LoadBaiViet();
        }
        protected void LoadBaiViet()
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                BUSBaiViet BaiVietBUS = new BUSBaiViet();
                int MaBaiViet = int.Parse(Request.QueryString["id"]);
                BAIVIET BaiViet = BaiVietBUS.TimKiem(MaBaiViet);
                lblNoiDungBaiViet.Text = BaiViet.NoiDung;

                lblTieuDe.Text = BaiViet.TieuDe;
                lblTieuDe.Font.Bold = true;
                lblTieuDe.Font.Size = 18;

                if (BaiViet.NgayDang != null)
                {
                    lblNgayDang.Text = "Ngày đăng: " + BaiViet.NgayDang.Value.Day + "/" + BaiViet.NgayDang.Value.Month + "/" + BaiViet.NgayDang.Value.Year;
                    lblNgayDang.Font.Italic = true;
                }
                else
                    lblNgayDang.Visible = false;

                BUSTapTinBaiViet busTapTinBaiViet = new BUSTapTinBaiViet();
                TAPTINBAIVIET tapTinBaiViet = busTapTinBaiViet.TimKiemMaBaiViet(MaBaiViet);
                if (tapTinBaiViet != null)
                {
                    hplDownloadLink.NavigateUrl = tapTinBaiViet.DuongDan.ToString();
                    hplDownloadLink.Text = tapTinBaiViet.TenTapTin.ToString();
                }
            }
        }

        
    }
}
