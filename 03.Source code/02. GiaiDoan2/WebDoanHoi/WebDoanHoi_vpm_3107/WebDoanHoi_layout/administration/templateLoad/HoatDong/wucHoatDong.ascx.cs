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

namespace WebDoanHoi_layout.administration.templateLoad.HoatDong
{
    public partial class wucHoatDong : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadHoatDong();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewHoatDong.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewHoatDong.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadHoatDong()
        {
            List<HOATDONG> lt = new List<HOATDONG>();

            BUSHoatDong BUSHoatDong = new BUSHoatDong();

            lt = BUSHoatDong.SelectHOATDONGsAll();
            if (lt.Count > 0)
            {
                this.GridViewHoatDong.DataSource = lt;
                GridViewHoatDong.DataBind();
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
            this.GridViewHoatDong.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadHoatDong();
            FilterSTT(SoDong, GridViewHoatDong.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewHoatDong_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewHoatDong.PageIndex = e.NewPageIndex;
            int SoDong = LoadHoatDong();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
    }
}