﻿using System;
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
    public partial class wucTapTinThongBao : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadTapTin();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewTapTin.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewTapTin.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadTapTin()
        {
            List<TAPTINTHONGBAO> lt = new List<TAPTINTHONGBAO>();

            BUSTapTinThongBao BUSTapTinThongBao = new BUSTapTinThongBao();

            lt = BUSTapTinThongBao.SelectTAPTINTHONGBAOsAll();
            if (lt.Count > 0)
            {
                this.GridViewTapTin.DataSource = lt;
                GridViewTapTin.DataBind();
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
            this.GridViewTapTin.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadTapTin();
            FilterSTT(SoDong, GridViewTapTin.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewTapTin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewTapTin.PageIndex = e.NewPageIndex;
            int SoDong = LoadTapTin();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
    }
}