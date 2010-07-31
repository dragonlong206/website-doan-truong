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
  //          if (!IsPostBack)
//            {

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
                MenuItem mnTrangChu = new MenuItem("Trang Chủ", "", "", "TrangChu.aspx");


                MenuItem mnGioiThieu = MenuGioiThieu();
                MenuItem mnHeThongToChuc = MenuHeThongToChuc();
                menu.Items.Add(mnTrangChu);
                menu.Items.Add(mnGioiThieu);
                menu.Items.Add(mnHeThongToChuc);
                
                BUSLoaiBaiViet LoaiBaiVietBUS = new BUSLoaiBaiViet();
                for (i = 0; i < 4; i++)
                {
                    MenuItem mnItem = new MenuItem(DSChuyenMuc[i].TenChuyenMuc, "", "");
                    menu.Items.Add(mnItem);
                    List<LOAIBAIVIET> DSLoaiBaiViet = LoaiBaiVietBUS.TimKiemLoaiBaiVietTheoChuyenMuc(DSChuyenMuc[i].MaChuyenMuc);
                    for (j = 0; j < DSLoaiBaiViet.Count(); j++)
                    {
                        MenuItem mn = new MenuItem(DSLoaiBaiViet[j].TenLoaiBaiViet, "", "", "../LoaiBaiViet.aspx?id=" + DSLoaiBaiViet[j].MaLoaiBaiViet);
                        menu.Items[i + 3].ChildItems.Add(mn);
                    }
                }
                MenuItem mnTienIch = MenuTienIch();
                menu.Items.Add(mnTienIch);
 //           }

        }

        public MenuItem MenuGioiThieu()
        {
            MenuItem mnGioiThieu = new MenuItem("Giới Thiệu");
            BUSGioiThieu GioiThieuBUS = new BUSGioiThieu();
            int i;
            List<GIOITHIEU> DSGioiThieu = GioiThieuBUS.SelectGIOITHIEUsAll();
            for (i = 0; i < DSGioiThieu.Count(); i++)
            {
                MenuItem mn = new MenuItem(DSGioiThieu[i].TieuDe, "", "", "../GioiThieu.aspx?id=" + DSGioiThieu[i].MaBai);
                mnGioiThieu.ChildItems.Add(mn);
            }
            return mnGioiThieu;
        }

        public MenuItem MenuHeThongToChuc()
        {
            MenuItem mnHeThongToChuc = new MenuItem("Hệ Thống Tổ Chức");
            BUSHeThongToChuc HttcBUS = new BUSHeThongToChuc();
            List<HETHONGTOCHUC> DSHttc = HttcBUS.SelectHETHONGTOCHUCsAll();
            int i;
            for (i = 0; i < DSHttc.Count(); i++)
            {
                MenuItem mn = new MenuItem(DSHttc[i].TieuDe,"","","../HeThongToChuc.aspx?id=" + DSHttc[i].MaBai);
                mnHeThongToChuc.ChildItems.Add(mn);
            }
            return mnHeThongToChuc;
        }

        public MenuItem MenuTienIch()
        {
            MenuItem mnTienIch = new MenuItem("Tiện Ích");
            MenuItem mnLichLamViec = new MenuItem("Lịch Làm Việc");
            MenuItem mnDangKyMuonPhong = new MenuItem("Đăng Ký Mượn Phòng");
            MenuItem mnHinhAnhHoatDong = new MenuItem("Hình Ảnh Hoạt Động");
            MenuItem mnBaiHat = new MenuItem("Bài Hát");
            mnTienIch.ChildItems.Add(mnLichLamViec);
            mnTienIch.ChildItems.Add(mnDangKyMuonPhong);
            mnTienIch.ChildItems.Add(mnHinhAnhHoatDong);
            mnTienIch.ChildItems.Add(mnBaiHat);
            return mnTienIch;
        }


    }

   
}