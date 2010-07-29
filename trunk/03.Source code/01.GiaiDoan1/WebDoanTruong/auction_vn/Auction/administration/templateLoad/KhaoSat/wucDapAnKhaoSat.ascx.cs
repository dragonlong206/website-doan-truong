﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BUSAuction;
using DTOAuction;
using System.Collections.Generic;
using System.Web.UI.MobileControls;

public partial class templates_wucDapAnKhaoSat : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "Danh Sách Bài Gửi";

        if (!IsPostBack)
        {
            int soDong = LoadDapAnKhaoSat();
            FilterSTT(soDong, 0, 10);
        }
        this.GridViewDapAnKhaoSat.HeaderStyle.CssClass = "headerstyle";
    }
    //Do STT
    public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
    {
        int stt = 0;
        for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
        {
            GridViewDapAnKhaoSat.Rows[stt].Cells[0].Text = (i + 1).ToString();
            stt += 1;
        }
    }
    //Load
    public int LoadDapAnKhaoSat()
    {
        List<DAPANKHAOSAT> lt = new List<DAPANKHAOSAT>();

        BUSDapAnKhaoSat BUSDapAnKhaoSat = new BUSDapAnKhaoSat();

        lt = BUSDapAnKhaoSat.SelectDAPANKHAOSATsAll ();
        if (lt.Count > 0)
        {
            this.GridViewDapAnKhaoSat.DataSource = lt;
            GridViewDapAnKhaoSat.DataBind();
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
        this.GridViewDapAnKhaoSat.PageSize = int.Parse(DropDownListPaging.SelectedValue);
        int SoDong = LoadDapAnKhaoSat();
        FilterSTT(SoDong, GridViewDapAnKhaoSat.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
    }
    //Chon trang NEXT
    protected void GridViewDapAnKhaoSat_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewDapAnKhaoSat.PageIndex = e.NewPageIndex;
        int SoDong = LoadDapAnKhaoSat();
        FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
    }
}