using System;
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

public partial class templates_wucSinhVien : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "Danh Sách Bài Gửi";

        if (!IsPostBack)
        {
            int soDong = LoadSinhVien();
            FilterSTT(soDong, 0, 10);
        }
        this.GridViewSinhVien.HeaderStyle.CssClass = "headerstyle";
    }
    //Do STT
    public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
    {
        int stt = 0;
        for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
        {
            GridViewSinhVien.Rows[stt].Cells[0].Text = (i + 1).ToString();
            stt += 1;
        }
    }
    //Load
    public int LoadSinhVien()
    {
        List<SINHVIEN> lt = new List<SINHVIEN>();

        BUSSinhVien BUSSinhVien = new BUSSinhVien();

        lt = BUSSinhVien.SelectSINHVIENsAll ();
        if (lt.Count > 0)
        {
            this.GridViewSinhVien.DataSource = lt;
            GridViewSinhVien.DataBind();
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
        this.GridViewSinhVien.PageSize = int.Parse(DropDownListPaging.SelectedValue);
        int SoDong = LoadSinhVien();
        FilterSTT(SoDong, GridViewSinhVien.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
    }
    //Chon trang NEXT
    protected void GridViewSinhVien_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewSinhVien.PageIndex = e.NewPageIndex;
        int SoDong = LoadSinhVien();
        FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
    }
}
