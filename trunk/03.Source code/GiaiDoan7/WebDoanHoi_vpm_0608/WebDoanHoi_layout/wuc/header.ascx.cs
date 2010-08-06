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

                BUSChuyenMuc ChuyenMucBUS = new BUSChuyenMuc();
                List<CHUYENMUC> DSChuyenMuc = ChuyenMucBUS.SelectCHUYENMUCsAll();
                Menu menu = Menu1;
                menu.Orientation = Orientation.Horizontal;
                menu.ForeColor = System.Drawing.Color.White;
                menu.DynamicHoverStyle.BackColor = System.Drawing.Color.White;
                menu.DynamicHoverStyle.ForeColor = System.Drawing.Color.FromArgb(0x00, 0x66, 0xFF);
                menu.DynamicMenuStyle.BackColor = System.Drawing.Color.FromArgb(0x33, 0x99, 0xFF);
                int i;
                int j;
                MenuItem mnTrangChu = new MenuItem("Trang Chủ", "", "", "~/index.aspx");


                MenuItem mnGioiThieu = MenuGioiThieu();
                MenuItem mnHeThongToChuc = MenuHeThongToChuc();
                menu.Items.Add(mnTrangChu);
                menu.Items.Add(mnGioiThieu);
                menu.Items.Add(mnHeThongToChuc);

                MenuItem mnHoatDong = new MenuItem("Hoạt Động", "", "", "~/HoatDong.aspx");
               
                menu.Items.Add(mnHoatDong);
                MenuItem mnChuyenMuc = new MenuItem("Chuyên Mục");
                
                BUSLoaiBaiViet LoaiBaiVietBUS = new BUSLoaiBaiViet();
                for (i = 1; i < DSChuyenMuc.Count(); i++)
                {
                    MenuItem mnItem = new MenuItem(DSChuyenMuc[i].TenChuyenMuc, "", "");
                    
                    List<LOAIBAIVIET> DSLoaiBaiViet = LoaiBaiVietBUS.TimKiemLoaiBaiVietTheoChuyenMuc(DSChuyenMuc[i].MaChuyenMuc);
                    if (DSLoaiBaiViet.Count() != 0)
                    {
                        for (j = 0; j < DSLoaiBaiViet.Count(); j++)
                        {
                            MenuItem mn = new MenuItem(DSLoaiBaiViet[j].TenLoaiBaiViet, "", "", "~/LoaiBaiViet.aspx?id=" + DSLoaiBaiViet[j].MaLoaiBaiViet);
                            // mnChuyenMuc.ChildItems[i + 3].ChildItems.Add(mn);
                            mnItem.ChildItems.Add(mn);
                        }
                    }
                    mnChuyenMuc.ChildItems.Add(mnItem);
                }
                menu.Items.Add(mnChuyenMuc);
                MenuItem mnHoTroSinhVien = new MenuItem("Hỗ Trợ Sinh Viên", "", "", "~/index.aspx");
                List<LOAIBAIVIET> DSLoaiBaiVietHoTroSV = LoaiBaiVietBUS.TimKiemLoaiBaiVietTheoChuyenMuc(DSChuyenMuc[0].MaChuyenMuc);
                if (DSLoaiBaiVietHoTroSV.Count() != 0)
                {
                    for (j = 0; j < DSLoaiBaiVietHoTroSV.Count(); j++)
                    {
                        MenuItem mn = new MenuItem(DSLoaiBaiVietHoTroSV[j].TenLoaiBaiViet, "", "", "~/LoaiBaiViet.aspx?id=" + DSLoaiBaiVietHoTroSV[j].MaLoaiBaiViet);
                        mnHoTroSinhVien.ChildItems.Add(mn);
                    }
                }
                menu.Items.Add(mnHoTroSinhVien);
                MenuItem mnTienIch = MenuTienIch();
                menu.Items.Add(mnTienIch);
            }

        }

        public MenuItem MenuGioiThieu()
        {
            MenuItem mnGioiThieu = new MenuItem("Giới Thiệu","","","~/GioiThieu.aspx");
            BUSGioiThieu GioiThieuBUS = new BUSGioiThieu();
            int i;
            List<GIOITHIEU> DSGioiThieu = GioiThieuBUS.SelectGIOITHIEUsAll();
            for (i = 0; i < DSGioiThieu.Count(); i++)
            {
                MenuItem mn = new MenuItem(DSGioiThieu[i].TieuDe, "", "", "~/GioiThieu.aspx?id=" + DSGioiThieu[i].MaBai);
                mnGioiThieu.ChildItems.Add(mn);
            }
            return mnGioiThieu;
        }

        public MenuItem MenuHeThongToChuc()
        {
            MenuItem mnHeThongToChuc = new MenuItem("Hệ Thống Tổ Chức","","","~/HeThongToChuc.aspx");
            BUSHeThongToChuc HttcBUS = new BUSHeThongToChuc();
            List<HETHONGTOCHUC> DSHttc = HttcBUS.SelectHETHONGTOCHUCsAll();
            int i;
            for (i = 0; i < DSHttc.Count(); i++)
            {
                MenuItem mn = new MenuItem(DSHttc[i].TieuDe,"","","~/HeThongToChuc.aspx?id=" + DSHttc[i].MaBai);
                mnHeThongToChuc.ChildItems.Add(mn);
            }
            return mnHeThongToChuc;
        }

        public MenuItem MenuTienIch()
        {
            MenuItem mnTienIch = new MenuItem("Tiện Ích");
            MenuItem mnLichLamViec = new MenuItem("Lịch Làm Việc", "", "", "~/LichLamViec.aspx");
            MenuItem mnDangKyMuonPhong = new MenuItem("Đăng Ký Mượn Phòng", "", "", "~/MuonPhong.aspx");
            MenuItem mnHinhAnhHoatDong = new MenuItem("Hình Ảnh Hoạt Động", "", "", "~/AlbumAll.aspx");
            MenuItem mnBaiHat = new MenuItem("Bài Hát", "", "", "~/BaiHat.aspx");
            mnTienIch.ChildItems.Add(mnLichLamViec);
            mnTienIch.ChildItems.Add(mnDangKyMuonPhong);
            mnTienIch.ChildItems.Add(mnHinhAnhHoatDong);
            mnTienIch.ChildItems.Add(mnBaiHat);
            return mnTienIch;
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