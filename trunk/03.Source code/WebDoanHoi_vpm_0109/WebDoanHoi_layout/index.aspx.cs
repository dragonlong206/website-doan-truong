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
             string TinNoiBat = "";
             TinNoiBat += "<div style='width:580px'>";
             TinNoiBat += "<div class='tieudeTinNoiBat'><a href='BaiViet.aspx?id="+DSBaiViet[0].MaBaiViet+"'>"+DSBaiViet[0].TieuDe + "</a>"+"</div>";
             TinNoiBat += "<div style='margin-top:10px; margin-left:10px;min-height:200px;text-align:justify;padding-right:10px'>";
             TinNoiBat += "<a href='" + "BaiViet.aspx?id=" + DSBaiViet[0].MaBaiViet + "'>" + "<img align='left' class='hinhdaidienTinNoiBat' src ='Uploads/" + DSBaiViet[0].HinhAnh + "' height='200px' width = '200px' style='margin-right:10px'/></a>";
             TinNoiBat += DSBaiViet[0].TomTat;
             TinNoiBat += "<a href='" + "BaiViet.aspx?id=" + DSBaiViet[0].MaBaiViet + "'>" +"<i>"+ "Xem tiếp ..." +"</i></a>";
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

             lblHinh1.Text = "<img src ='Uploads/" + DSBaiViet[1].HinhAnh + "' style ='width:170px; height:170px' />";
             lblHinh2.Text = "<img src ='Uploads/" + DSBaiViet[2].HinhAnh + "' style ='width:170px; height:170px' />";
             lblHinh3.Text = "<img src ='Uploads/" + DSBaiViet[3].HinhAnh + "' style ='width:170px; height:170px' />";

             lblTieuDe1.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[1].MaBaiViet + "'>" + DSBaiViet[1].TieuDe + "</a>";
             lblTieuDe2.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[2].MaBaiViet + "'>" + DSBaiViet[2].TieuDe + "</a>";
             lblTieuDe3.Text = "<a href ='" + "BaiViet.aspx?id=" + DSBaiViet[3].MaBaiViet + "'>" + DSBaiViet[3].TieuDe + "</a>";
             
            string str = "";
           // str += "<link href='css/style-3-col.css' rel='stylesheet' type='text/css' />";
            
            BUSChuyenMuc ChuyenMucBUS = new BUSChuyenMuc();
            List<CHUYENMUC> DSChuyenMuc = ChuyenMucBUS.SelectCHUYENMUCsAll();
           
            for (int i = 0; i < DSChuyenMuc.Count(); i++)
            {
                
                BUSBaiViet BvBUS = new BUSBaiViet();
                List<BAIVIET> BaiViet = BvBUS.LayBaiVietMoiNhatTheoChuyenMuc(DSChuyenMuc[i].MaChuyenMuc);
                if (BaiViet!= null)
                {
                    str += "<div class='post-title'>";
                    str += "<img src = 'images/ico/BlockHeaderIcon.png' />";
                    str += DSChuyenMuc[i].TenChuyenMuc;
                    str += "</div>";
                    str += "<div class='post-content' style=''>";
                    /*str += "<table cellpadding='10px'><tr><td style='width: 30%' align='center' valign='middle'>";
                    str += "<img src = 'Uploads/" + BaiViet[0].HinhAnh + "' style ='width:170px; height:170px';float:left />";
                    str += "</td><td style='vertical-align:top'>";
                    str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'><b>" + BaiViet[0].TieuDe + "</b></a><br /><br />";
                    str += BaiViet[0].TomTat;
                    str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'><i>" + " Xem tiếp ..." + "</i></a><br />";
                    str += "</p></td></tr></table>";*/

                    str += "<div style='margin-top:10px; margin-left:10px; min-height:160px; text-align:justify;padding-right:10px'>";
                    str += "<a href='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'>" + "<img align='left' class='hinhdaidienTinNoiBat' src ='Uploads/" + BaiViet[0].HinhAnh + "' height='150px' width = '150px' style='margin-right:10px'/></a>";
                    str += "<a style='font-size:20px' href='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'>" + BaiViet[0].TieuDe + "</a><br /><br/>";
                    str += BaiViet[0].TomTat;
                    str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet[0].MaBaiViet + "'><i>" + " Xem tiếp ..." + "</i></a><br />";
                    str += "</div>";
                    
                    if (BaiViet.Count>1)
                    {
                        str += "<div>";
                        str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet[1].MaBaiViet + "'>" + BaiViet[1].TieuDe + "</a><br />";
                        if (BaiViet.Count > 2)
                        {
                            str += "<a href ='" + "BaiViet.aspx?id=" + BaiViet[2].MaBaiViet + "'>" + BaiViet[2].TieuDe + "</a><br />";
                        }
                        str += "</div>";
                    }
                    

                    str += "</div>";
                }
                
            }
            lblChuyenMuc.Text = str;
        }
    }
}
