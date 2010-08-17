using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;
using System.Web.UI.MobileControls;
using System.Windows.Forms;

namespace WebDoanHoi_layout.administration.templateLoad.HoatDong
{
    public partial class wucLoaiHoatDong : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadLoaiHoatDong();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewLoaiHoatDong.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewLoaiHoatDong.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadLoaiHoatDong()
        {
            List<LOAIHOATDONG> lt = new List<LOAIHOATDONG>();

            BUSLoaiHoatDong BUSLoaiHoatDong = new BUSLoaiHoatDong();

            lt = BUSLoaiHoatDong.SelectLOAIHOATDONGsAll();
            if (lt.Count > 0)
            {
                this.GridViewLoaiHoatDong.DataSource = lt;
                GridViewLoaiHoatDong.DataBind();
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
            this.GridViewLoaiHoatDong.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadLoaiHoatDong();
            FilterSTT(SoDong, GridViewLoaiHoatDong.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewLoaiHoatDong_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewLoaiHoatDong.PageIndex = e.NewPageIndex;
            int SoDong = LoadLoaiHoatDong();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }

        protected void GridViewLoaiHoatDong_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "XoaLoaiHoatDong")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                BUSLoaiHoatDong busLoaiHoatDong = new BUSLoaiHoatDong();
                List<LOAIHOATDONG> lt = busLoaiHoatDong.SelectLOAIHOATDONGsAll();

                XoaLoaiHoatDong(lt[index].MaLoaiHoatDong);
            }
        }
        protected void XoaLoaiHoatDong(int maLoaiHoatDong)
        {
            try
            {

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá loại hoạt động này không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSBaiViet BUSBaiViet = new BUSBaiViet();
                    if (BUSBaiViet.Xoa(maLoaiHoatDong) == 0)
                    {
                        //Thong bao
                        DialogResult rs1 = MessageBox.Show("Xoá loại hoạt động thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Response.Redirect("LoaiHoatDong.aspx");
                    }
                    else
                    {
                        DialogResult rs1 = MessageBox.Show("Xoá loại hoạt động không thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Response.Redirect("LoaiHoatDong.aspx");
                }
            }

            catch (Exception ex)
            {
            }
        }
    }
}