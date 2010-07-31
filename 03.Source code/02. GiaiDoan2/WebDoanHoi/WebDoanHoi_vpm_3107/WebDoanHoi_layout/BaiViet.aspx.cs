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

namespace WebDoanHoi_layout
{
    public partial class BaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BUSBaiViet BaiVietBUS = new BUSBaiViet();
            int MaBaiViet = int.Parse(Request.QueryString["id"]);
            //int MaBaiViet = 2;
            BAIVIET BaiViet = BaiVietBUS.TimKiem(MaBaiViet);
            lblNoiDungBaiViet.Text = BaiViet.NoiDung;

            lblTieuDe.Text = BaiViet.TieuDe;
            lblTieuDe.Font.Bold = true;
            lblTieuDe.Font.Size = 18;
            

            lblNgayDang.Text = "Ngày đăng: "+ BaiViet.NgayDang.Value.Day + "/" + BaiViet.NgayDang.Value.Month + "/" + BaiViet.NgayDang.Value.Year;
            lblNgayDang.Font.Italic = true;
        }
    }
}
