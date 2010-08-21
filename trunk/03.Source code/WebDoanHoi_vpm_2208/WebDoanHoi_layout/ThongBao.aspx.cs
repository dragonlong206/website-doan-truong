using System;
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
    public partial class ThongBao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadThongBao();
        }

        protected void LoadThongBao()
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                BUSThongBao ThongBaoBUS = new BUSThongBao();
                int MaThongBao = int.Parse(Request.QueryString["id"]);
                THONGBAO ThongBao = ThongBaoBUS.TimKiem(MaThongBao);
                lblNoiDungThongBao.Text = ThongBao.NoiDung;

                lblTieuDe.Text = ThongBao.TieuDe;
                lblTieuDe.Font.Bold = true;
                lblTieuDe.Font.Size = 18;

                if (ThongBao.NgayDang != null)
                {
                    lblNgayDang.Text = "Ngày đăng: " + ThongBao.NgayDang.Value.Day + "/" + ThongBao.NgayDang.Value.Month + "/" + ThongBao.NgayDang.Value.Year;
                    lblNgayDang.Font.Italic = true;
                }
                else
                    lblNgayDang.Visible = false;
            }
        }
    }

}
