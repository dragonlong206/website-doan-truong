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
    public partial class wucHeThongToChuc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadHeThongToChuc();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewHeThongToChuc.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewHeThongToChuc.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadHeThongToChuc()
        {
            List<HETHONGTOCHUC> lt = new List<HETHONGTOCHUC>();

            BUSHeThongToChuc BUSHeThongToChuc = new BUSHeThongToChuc();

            lt = BUSHeThongToChuc.SelectHETHONGTOCHUCsAll();
            if (lt.Count > 0)
            {
                this.GridViewHeThongToChuc.DataSource = lt;
                GridViewHeThongToChuc.DataBind();
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
            this.GridViewHeThongToChuc.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadHeThongToChuc();
            FilterSTT(SoDong, GridViewHeThongToChuc.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewHeThongToChuc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewHeThongToChuc.PageIndex = e.NewPageIndex;
            int SoDong = LoadHeThongToChuc();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        #region tin-xoa
        protected void GridViewHeThongToChuc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "XoaBai")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                BUSHeThongToChuc busHeThongToChuc = new BUSHeThongToChuc();

                List<HETHONGTOCHUC> lt = busHeThongToChuc.SelectHETHONGTOCHUCsAll();
                XoaBai(lt[index].MaBai);
            }
        }
        protected void XoaBai(int maBai)
        {
            try
            {

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá bài này không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSHeThongToChuc bus = new BUSHeThongToChuc();
                    if (bus.Xoa(maBai) == 0)
                    {
                        //Thong bao
                        DialogResult rs1 = MessageBox.Show("Xoá bài thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Response.Redirect("HeThongToChuc.aspx");
                    }
                    else
                    {
                        DialogResult rs1 = MessageBox.Show("Xoá bài không thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Response.Redirect("HeThongToChuc.aspx");
                }
            }

            catch (Exception ex)
            {
            }
        }
        #endregion

    }
}