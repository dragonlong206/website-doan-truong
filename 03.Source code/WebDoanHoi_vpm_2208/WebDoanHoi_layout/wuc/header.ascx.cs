using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTOAuction;
using BUSAuction;

namespace WebDoanHoi_layout.wuc
{
    public partial class header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongDateString();
            //
            if (!IsPostBack)
            {
                string strMenu = "";
                strMenu = "<ul class='art-menu'>";
                strMenu += strMenuTrangChu();
                strMenu += strMenuGioiThieu();
                strMenu += strMenuHeThongToChuc();
                strMenu += strMenuHoatDong();
                strMenu += strMenuChuyenMuc();
                strMenu += strMenuHoTroSinhVien();
                strMenu += strMenuTienIch();
                strMenu += "</ul>";
                lblMenu.Text = strMenu;
            }
           
        }
        public string strMenuTrangChu()
        {
            string strMenu = "";
            strMenu += "<li>";
            strMenu += "<a href='index.aspx'><span class='l'></span><span class='r'></span><span class='t'>Trang Chủ</span></a>";
            strMenu += "</li>";
            return strMenu;
        }
        public string strMenuGioiThieu()
        {
            BUSGioiThieu GioiThieuBUS = new BUSGioiThieu();
            int i;
            List<GIOITHIEU> DSGioiThieu = GioiThieuBUS.SelectGIOITHIEUsAll();
            string str = "";
            str += "<li>";
            str += "<a href='GioiThieu.aspx'><span class='l'></span><span class='r'></span><span class='t'>Giới Thiệu</span></a>";
            str += "<ul>";
            for (i = 0; i < DSGioiThieu.Count(); i++)
            {
                
                str += "<li><a href='GioiThieu.aspx?id="+DSGioiThieu[i].MaBai.ToString()+"'>"+DSGioiThieu[i].TieuDe+"</a>";
               // MenuItem mn = new MenuItem(DSGioiThieu[i].TieuDe, "", "", "~/GioiThieu.aspx?id=" + DSGioiThieu[i].MaBai);
               // mnGioiThieu.ChildItems.Add(mn);
                str += "</li>";
                
            }
            str += "</ul>";
            str += "</li>";
            return str;
        }
        public string strMenuHeThongToChuc()
        {
            string str = "";
            str += "<li>";
            str += "<a href='HeThongToChuc.aspx'><span class='l'></span><span class='r'></span><span class='t'>Hệ Thống Tổ Chức</span></a>";
            str += "<ul>";
            BUSHeThongToChuc HttcBUS = new BUSHeThongToChuc();
            List<HETHONGTOCHUC> DSHttc = HttcBUS.SelectHETHONGTOCHUCsAll();
            int i;
            for (i = 0; i < DSHttc.Count(); i++)
            {
                str += "<li><a href='HeThongToChuc.aspx?id=" + DSHttc[i].MaBai.ToString() + "'>" + DSHttc[i].TieuDe + "</a>";
                //MenuItem mn = new MenuItem(DSHttc[i].TieuDe, "", "", "~/HeThongToChuc.aspx?id=" + DSHttc[i].MaBai);
                //mnHeThongToChuc.ChildItems.Add(mn);
            }
            str += "</ul>";
            str += "</li>";
            return str;
        }

        public string strMenuHoatDong()
        {
            string strMenu = "";
            strMenu += "<li>";
            strMenu += "<a href='HoatDong.aspx'><span class='l'></span><span class='r'></span><span class='t'>Hoạt Động</span></a>";
            strMenu += "</li>";
            return strMenu;
        }

        public string strMenuChuyenMuc()
        {
            string lblMenu = "";
            lblMenu += "<li>";
            lblMenu += "<a href='ChuyenMuc.aspx'><span class='l'></span><span class='r'></span><span class='t'>Chuyên Mục</span></a>";
            BUSChuyenMuc ChuyenMucBUS = new BUSChuyenMuc();
            List<CHUYENMUC> DSChuyenMuc = ChuyenMucBUS.SelectCHUYENMUCsAll();
            BUSLoaiBaiViet LoaiBaiVietBUS = new BUSLoaiBaiViet();

            int i, j;
            lblMenu += "<ul>";
            for (i = 1; i < DSChuyenMuc.Count(); i++)
            {
                //MenuItem mnItem = new MenuItem(DSChuyenMuc[i].TenChuyenMuc, "", "");
                
                lblMenu += "<li><a href='#'>"+DSChuyenMuc[i].TenChuyenMuc+"</a>";
                List<LOAIBAIVIET> DSLoaiBaiViet = LoaiBaiVietBUS.TimKiemLoaiBaiVietTheoChuyenMuc(DSChuyenMuc[i].MaChuyenMuc);
                if (DSLoaiBaiViet.Count() != 0)
                {
                    lblMenu += "<ul>";
                    
                    for (j = 0; j < DSLoaiBaiViet.Count(); j++)
                    {
                        lblMenu += "<li><a href='LoaiBaiViet.aspx?id=" + DSLoaiBaiViet[j].MaLoaiBaiViet.ToString()+ "'>" + DSLoaiBaiViet[j].TenLoaiBaiViet + "</a></li>";
                       // MenuItem mn = new MenuItem(DSLoaiBaiViet[j].TenLoaiBaiViet, "", "", "~/LoaiBaiViet.aspx?id=" + DSLoaiBaiViet[j].MaLoaiBaiViet);
                        // mnChuyenMuc.ChildItems[i + 3].ChildItems.Add(mn);
                       // mnItem.ChildItems.Add(mn);
                    }
                    lblMenu += "</ul>";
                }
               // mnChuyenMuc.ChildItems.Add(mnItem);
                
            }
            lblMenu += "</ul>";
            lblMenu += "</li>";
            return lblMenu;
        }

        public string strMenuHoTroSinhVien()
        {
            BUSLoaiBaiViet LoaiBaiVietBUS = new BUSLoaiBaiViet();
            BUSChuyenMuc ChuyenMucBUS = new BUSChuyenMuc();
            List<CHUYENMUC> DSChuyenMuc = ChuyenMucBUS.SelectCHUYENMUCsAll();
            string strMenu = "";
            strMenu += "<li>";
            strMenu += "<a href='index.aspx'><span class='l'></span><span class='r'></span><span class='t'>Hỗ Trợ Sinh Viên</span></a>";
            
            int j;
           // MenuItem mnHoTroSinhVien = new MenuItem("Hỗ Trợ Sinh Viên", "", "", "~/index.aspx");
            List<LOAIBAIVIET> DSLoaiBaiVietHoTroSV = LoaiBaiVietBUS.TimKiemLoaiBaiVietTheoChuyenMuc(DSChuyenMuc[0].MaChuyenMuc);
            if (DSLoaiBaiVietHoTroSV.Count() != 0)
            {
                strMenu += "<ul>";
                for (j = 0; j < DSLoaiBaiVietHoTroSV.Count(); j++)
                {
                    //MenuItem mn = new MenuItem(DSLoaiBaiVietHoTroSV[j].TenLoaiBaiViet, "", "", "~/LoaiBaiViet.aspx?id=" + DSLoaiBaiVietHoTroSV[j].MaLoaiBaiViet);
                    //mnHoTroSinhVien.ChildItems.Add(mn);
                    strMenu += "<li><a href='LoaiBaiViet.aspx?id="+DSLoaiBaiVietHoTroSV[j].MaLoaiBaiViet.ToString()+"'>"+DSLoaiBaiVietHoTroSV[j].TenLoaiBaiViet+"</a></li>";
                }
                strMenu += "</ul>";
            }
           
            
            strMenu += "</li>";
            return strMenu;
        }
       
        public string strMenuTienIch()
        {
            string strMenu = "";
            strMenu += "<li>";
            strMenu += "<a href='#'><span class='l'></span><span class='r'></span><span class='t'>Tiện Ích</span></a>";
            strMenu += "<ul>";
            strMenu += "<li><a href='LichLamViec.aspx'>Lịch Làm Việc</a></li>";
            strMenu += "<li><a href='MuonPhong.aspx'>Đăng Ký Mượn Phòng</a></li>";
            strMenu += "<li><a href='AlbumAll.aspx'>Hình Ảnh Hoạt Động</a></li>";
            strMenu += "<li><a href='BaiHat.aspx'>Bài Hát</a></li>";
            strMenu += "</ul>";
            strMenu += "</li>";
            return strMenu;
        }
        //Le Van Long
        protected void ddlLienKet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string link = ddlLienKet.SelectedValue;
            HyperLink hp = new HyperLink();
            hp.NavigateUrl = link;
            hp.Target = "_blank";

            Response.Redirect(link);
        }
    }   
}