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
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string []HinhDaiDien = new string[4];
            HinhDaiDien[0] = "1.jpg";
            HinhDaiDien[1] = "2.jpg";
            HinhDaiDien[2] = "3.jpg";
            HinhDaiDien[3] = "4.jpg";
            BUSBaiViet BaiVietBUS = new BUSBaiViet();
            List<BAIVIET> DSBaiViet = BaiVietBUS.LayBaiVietMoiNhat(4);
            for (int i = 0; i < 4; i++)
            {
                if (DSBaiViet[i].HinhAnh == null)
                {
                    DSBaiViet[i].HinhAnh = HinhDaiDien[i];
                }
            }

            lblHinhAnh.Text = "<a href='" + "BaiViet.aspx?id=" + DSBaiViet[0].MaBaiViet + "'>" + "<img src ='Uploads/" + DSBaiViet[0].HinhAnh + "' style ='width:200px; height:200px' />" + "</a>";
            lblTieuDe.Text = "<a href='" + "BaiViet.aspx?id="+ DSBaiViet[0].MaBaiViet + "'>" +DSBaiViet[0].TieuDe + "</a>";
            lblTomTat.Text = DSBaiViet[0].TomTat;

            lblHinh1.Text = "<img src ='Uploads/" + DSBaiViet[1].HinhAnh + "' style ='width:170px; height:170px' />";
            lblHinh2.Text = "<img src ='Uploads/" + DSBaiViet[2].HinhAnh + "' style ='width:170px; height:170px' />";
            lblHinh3.Text = "<img src ='Uploads/" + DSBaiViet[3].HinhAnh + "' style ='width:170px; height:170px' />";

            lblTieuDe1.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[1].MaBaiViet + "'>" + DSBaiViet[1].TieuDe + "</a>";
            lblTieuDe2.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[2].MaBaiViet + "'>" + DSBaiViet[2].TieuDe + "</a>";
            lblTieuDe3.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[3].MaBaiViet + "'>" + DSBaiViet[3].TieuDe + "</a>";
            
            string str = "";
            str += "<link href='css/style-3-col.css' rel='stylesheet' type='text/css' />";
            
            BUSChuyenMuc ChuyenMucBUS = new BUSChuyenMuc();
            List<CHUYENMUC> DSChuyenMuc = ChuyenMucBUS.SelectCHUYENMUCsAll();
            for (int i = 0; i < DSChuyenMuc.Count(); i++)
            {
                
                BUSBaiViet BvBUS = new BUSBaiViet();
                BAIVIET BaiViet = BvBUS.LayBaiVietMoiNhatTheoChuyenMuc(DSChuyenMuc[i].MaChuyenMuc);
                if (BaiViet != null)
                {
                    str += "<div class='post-title'>";
                    str += DSChuyenMuc[i].TenChuyenMuc;
                    str += "</div>";
                    str += "<div class='post-content'>";
                    str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet.MaBaiViet + "'><b>" + BaiViet.TieuDe + "</b></a><br /><br />";
                    str += BaiViet.TomTat;
                    str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet.MaBaiViet + "'><i>" + " Xem tiếp ..." + "</i></a>";
                    str += "</div>";
                    
                }
                
            }
            lblChuyenMuc.Text = str;
        }
    }
}
