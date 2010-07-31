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

namespace WebDoanHoi_layout.administration.templateLoad.Album
{
    public partial class wucAlbum : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Album";

            if (!IsPostBack)
            {
                int soDong = LoadAlbum();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewAlbum.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewAlbum.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadAlbum()
        {
            List<ALBUM> lt = new List<ALBUM>();

            BUSAlbum BUSAlbum = new BUSAlbum();

            lt = BUSAlbum.SelectALBUMsAll();
            if (lt.Count > 0)
            {
                this.GridViewAlbum.DataSource = lt;
                GridViewAlbum.DataBind();
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
            this.GridViewAlbum.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadAlbum();
            FilterSTT(SoDong, GridViewAlbum.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewAlbum_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewAlbum.PageIndex = e.NewPageIndex;
            int SoDong = LoadAlbum();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
    }
}