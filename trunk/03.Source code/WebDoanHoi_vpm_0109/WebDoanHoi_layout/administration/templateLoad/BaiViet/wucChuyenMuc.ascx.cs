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
//using Google.Picasa;

namespace WebDoanHoi_layout.administration.templateLoad.BaiViet
{
    public partial class wucChuyenMuc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadChuyenMuc();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewChuyenMuc.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewChuyenMuc.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadChuyenMuc()
        {
            List<CHUYENMUC> lt = new List<CHUYENMUC>();

            BUSChuyenMuc BUSChuyenMuc = new BUSChuyenMuc();

            lt = BUSChuyenMuc.SelectCHUYENMUCsAll();
            if (lt.Count > 0)
            {
                this.GridViewChuyenMuc.DataSource = lt;
                GridViewChuyenMuc.DataBind();
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
            this.GridViewChuyenMuc.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadChuyenMuc();
            FilterSTT(SoDong, GridViewChuyenMuc.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewChuyenMuc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewChuyenMuc.PageIndex = e.NewPageIndex;
            int SoDong = LoadChuyenMuc();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        #region tin-xoa
        protected void GridViewChuyenMuc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            

            if (e.CommandName == "XoaChuyenMuc")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                BUSChuyenMuc busChuyenMuc = new BUSChuyenMuc();

                List<CHUYENMUC> lt = busChuyenMuc.SelectCHUYENMUCsAll();
                XoaChuyenMuc(lt[index].MaChuyenMuc);
            }
        }
        protected void XoaChuyenMuc(int maChuyenMuc)
        {
            try
            {

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá chuyên mục này không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSChuyenMuc busChuyenMuc = new BUSChuyenMuc();
                    if (busChuyenMuc.Xoa(maChuyenMuc) == 0)
                    {
                        //Thong bao
                        DialogResult rs1 = MessageBox.Show("Xoá chuyên mục thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Response.Redirect("ChuyenMuc.aspx");
                    }
                    else
                    {
                        DialogResult rs1 = MessageBox.Show("Xoá chuyên mục không thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Response.Redirect("ChuyenMuc.aspx");
                }
            }

            catch (Exception ex)
            {
            }
        }
        #endregion

    }
}