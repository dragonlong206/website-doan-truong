using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;
using System.Collections.Generic;
using System.Web.UI.MobileControls;

namespace WebDoanHoi_layout.administration.templateLoad.BaiViet
{
    public partial class wucBaiViet : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadBaiViet();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewBaiViet.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewBaiViet.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadBaiViet()
        {
            List<BAIVIET> lt = new List<BAIVIET>();

            BUSBaiViet BUSBaiViet = new BUSBaiViet();

            lt = BUSBaiViet.SelectBAIVIETsAll();
            if (lt.Count > 0)
            {
                this.GridViewBaiViet.DataSource = lt;
                GridViewBaiViet.DataBind();
                PanelDanhSach.Visible = true;
                PanelMessage.Visible = false;
                return lt.Count;
            }
            else
            {
                PanelDanhSach.Visible = false;
                PanelMessage.Visible = true;
                return 0;
            }
        }

        //Chon Phan Trang Theo y nguoi dung: 5, 10, 15, 20,..
        protected void DropDownListPaging_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GridViewBaiViet.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadBaiViet();
            FilterSTT(SoDong, GridViewBaiViet.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewBaiViet_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewBaiViet.PageIndex = e.NewPageIndex;
            int SoDong = LoadBaiViet();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
    }
}