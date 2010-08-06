using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;
using System.Web.UI.MobileControls;

namespace WebDoanHoi_layout.administration.templateLoad.BaiViet
{
    public partial class wucLoaiBaiViet : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadLoaiBaiViet();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewLoaiBaiViet.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewLoaiBaiViet.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadLoaiBaiViet()
        {
            List<LOAIBAIVIET_getall_chitietResult> lt = new List<LOAIBAIVIET_getall_chitietResult>();

            BUSLoaiBaiViet BUSLoaiBaiViet = new BUSLoaiBaiViet();

            lt = BUSLoaiBaiViet.SelectLOAIBAIVIETsAll_chitiet();
            if (lt.Count > 0)
            {
                this.GridViewLoaiBaiViet.DataSource = lt;
                GridViewLoaiBaiViet.DataBind();
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
            this.GridViewLoaiBaiViet.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadLoaiBaiViet();
            FilterSTT(SoDong, GridViewLoaiBaiViet.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewLoaiBaiViet_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewLoaiBaiViet.PageIndex = e.NewPageIndex;
            int SoDong = LoadLoaiBaiViet();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
    }
}