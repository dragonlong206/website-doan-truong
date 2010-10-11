using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;
using System.Globalization;


namespace WebDoanHoi_layout
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             string []HinhDaiDien = new string[5];
             HinhDaiDien[0] = "1.jpg";
             HinhDaiDien[1] = "2.jpg";
             HinhDaiDien[2] = "3.jpg";
             HinhDaiDien[3] = "4.jpg";
             HinhDaiDien[4] = "5.jpg";
             BUSBaiViet BaiVietBUS = new BUSBaiViet();
             List<BAIVIET> DSBaiViet = BaiVietBUS.LayBaiVietMoiNhat(5);
             for (int i = 0; i < 5; i++)
             {
                 if (DSBaiViet[i].HinhAnh == null)
                 {
                     DSBaiViet[i].HinhAnh = HinhDaiDien[i];
                 }
             }
             string TinNoiBat = "";
             TinNoiBat += "<div id='imgBVNoiBat'><a href='" + "BaiViet.aspx?id=" + DSBaiViet[0].MaBaiViet + "'>" + "<img align='left' class='hinhdaidienTinNoiBat' src ='Uploads/" + DSBaiViet[0].HinhAnh + "' max-height = '500px' width = '514px'/></a></div>";
             TinNoiBat += "<div id='BVNoiBatNhatDiv'>";
             TinNoiBat += "<div id='BVNoiBatNhatTitle'><a href='BaiViet.aspx?id=" + DSBaiViet[0].MaBaiViet + "'>" + DSBaiViet[0].TieuDe + "</a>" + "</div>";
             TinNoiBat += "<div id='BVNoiBatNhatContent'>";             
             TinNoiBat += DSBaiViet[0].TomTat;
             TinNoiBat += "   <a class='XemTiep' href='" + "BaiViet.aspx?id=" + DSBaiViet[0].MaBaiViet + "'>" +"<i>"+ "(Xem tiếp >>)" +"</i></a>";
             TinNoiBat += "</div>";
             TinNoiBat += "</div>"; 
             /*TinNoiBat += "</div>";
             TinNoiBat += "<center><hr style='margin: 5px 0px 5px 0px;' width='95%' /></center>";
             TinNoiBat += "</div>";*/
             Label1.Text = TinNoiBat;

            /*
             lblHinhAnh.Text = "<a href='" + "BaiViet.aspx?id=" + DSBaiViet[0].MaBaiViet + "'>" + "<img src ='Uploads/" + DSBaiViet[0].HinhAnh + "' style ='width:200px; height:200px' />" + "</a>";
             lblTieuDe.Text = "<a href='" + "BaiViet.aspx?id="+ DSBaiViet[0].MaBaiViet + "'>" +DSBaiViet[0].TieuDe + "</a>";
             lblTomTat.Text = DSBaiViet[0].TomTat;*/

             lblHinh1.Text = "<img src ='Uploads/" + DSBaiViet[1].HinhAnh + "' style ='width:125px; max-height:150px' />";
             lblHinh2.Text = "<img src ='Uploads/" + DSBaiViet[2].HinhAnh + "' style ='width:125px; max-height:150px' />";
             lblHinh3.Text = "<img src ='Uploads/" + DSBaiViet[3].HinhAnh + "' style ='width:125px; max-height:150px' />";
             lblHinh4.Text = "<img src ='Uploads/" + DSBaiViet[4].HinhAnh + "' style ='width:125px; max-height:150px' />";

             lblTieuDe1.Text = "<a style='text-align:center' href ='" + "BaiViet.aspx?id=" + DSBaiViet[1].MaBaiViet + "'><span>" + CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(DSBaiViet[1].TieuDe.ToLower()) + "</span></a>";
             lblTieuDe2.Text = "<a style='text-align:center' href ='" + "BaiViet.aspx?id=" + DSBaiViet[2].MaBaiViet + "'><span>" + CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(DSBaiViet[2].TieuDe.ToLower()) + "</span></a>";
             lblTieuDe3.Text = "<a style='text-align:center' href ='" + "BaiViet.aspx?id=" + DSBaiViet[3].MaBaiViet + "'><span>" + CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(DSBaiViet[3].TieuDe.ToLower()) + "</span></a>";
             lblTieuDe4.Text = "<a style='text-align:center' href ='" + "BaiViet.aspx?id=" + DSBaiViet[4].MaBaiViet + "'><span>" + CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(DSBaiViet[4].TieuDe.ToLower()) + "</span></a>";
             
            string str = "";
           // str += "<link href='css/style-3-col.css' rel='stylesheet' type='text/css' />";
            
            BUSChuyenMuc ChuyenMucBUS = new BUSChuyenMuc();
            List<CHUYENMUC> DSChuyenMuc = ChuyenMucBUS.SelectCHUYENMUCsAll();

            str += "<div class='column'>";
            for (int i = 0; i < DSChuyenMuc.Count(); i++)
            {
                
                BUSBaiViet BvBUS = new BUSBaiViet();
                List<BAIVIET> BaiViet = BvBUS.LayBaiVietMoiNhatTheoChuyenMuc(DSChuyenMuc[i].MaChuyenMuc);
                if (BaiViet!= null)
                {
                    str += "<div class='portlet'>";
                    str += "<div class='portlet-header'>";
                    str += DSChuyenMuc[i].TenChuyenMuc;
                    str += "</div>";
                    str += "<div class='portlet-content'>";
                    /*str += "<table cellpadding='10px'><tr><td style='width: 30%' align='center' valign='middle'>";
                    str += "<img src = 'Uploads/" + BaiViet[0].HinhAnh + "' style ='width:170px; height:170px';float:left />";
                    str += "</td><td style='vertical-align:top'>";
                    str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'><b>" + BaiViet[0].TieuDe + "</b></a><br /><br />";
                    str += BaiViet[0].TomTat;
                    str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'><i>" + " Xem tiếp ..." + "</i></a><br />";
                    str += "</p></td></tr></table>";*/

                    str += "<div class='imgBaiViet'>";
                    str += "<a href='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'>" + "<img align='left' class='hinhdaidienTinNoiBat' src ='Uploads/" + BaiViet[0].HinhAnh + "' 	max-height='250px' width = '150px'/></a></div>";
                    str += "<div class='BaiViet'><a class='BaiVietTitle' href='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'><span>" + BaiViet[0].TieuDe + "</span></a><br/><p class='BaiVietContent'>";
                    str += BaiViet[0].TomTat;
                    str += "     </p><a class='XemTiep' href ='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'><i>" + "(Xem tiếp >>)" + "</i></a><br />";
                    str += "</div>";
                    
                    if (BaiViet.Count>1)
                    {
                        str += "<div class='RelatedBaiViet'><lu>";
                        str += "<li type='circle'><a href ='" + "BaiViet.aspx?id=" + BaiViet[1].MaBaiViet + "'>" + CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(BaiViet[1].TieuDe.ToLower())  + "</a></li>";
                        if (BaiViet.Count > 2)
                        {
                            str += "<li type='circle'><a href ='" + "BaiViet.aspx?id=" + BaiViet[2].MaBaiViet + "'>" + CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(BaiViet[2].TieuDe.ToLower()) + "</a></li>";
                        }
                        str += "</lu></div>";
                    }
                    

                    str += "</div></div>";
                }    
            }
            str += "</div>";
            lblChuyenMuc.Text = str;
        }
    }
}
