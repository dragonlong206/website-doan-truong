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

namespace WebDoanHoi_layout.administration.templateLoad.BaiViet
{
    public partial class wucLoaiBaiViet : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Loại Bài Viết";

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
        #region tin-xoa
        protected void GridViewLoaiBaiViet_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "XoaLoaiBaiViet")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                BUSLoaiBaiViet bus = new BUSLoaiBaiViet();

                List<LOAIBAIVIET> lt = bus.SelectLOAIBAIVIETsAll();
                XoaBai(lt[index].MaLoaiBaiViet);
            }
        }
        protected void XoaBai(int maloai)
        {
            try
            {

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá loại bài viết này không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSLoaiBaiViet bus = new BUSLoaiBaiViet();
                    if (bus.Xoa(maloai) == 0)
                    {
                        //Thong bao
                        DialogResult rs1 = MessageBox.Show("Xoá loại bài viết thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Response.Redirect("LoaiBaiViet.aspx");
                    }
                    else
                    {
                        DialogResult rs1 = MessageBox.Show("Xoá loại bài viết không thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Response.Redirect("LoaiBaiViet.aspx");
                }
            }

            catch (Exception ex)
            {
            }
        }
        #endregion

    }
}