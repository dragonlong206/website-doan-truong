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
    public partial class wucBaiViet : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Danh Sách Bài Gửi";

            if (!IsPostBack)
            {
                int soDong = LoadBaiViet();
                FilterSTT(soDong, 0, 10);
            }
            this.GridViewBaiViet.HeaderStyle.CssClass = "headerstyle";
        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewBaiViet.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadBaiViet()
        {
            List<BAIVIET_getall_newResult> lt = new List<BAIVIET_getall_newResult>();
            BUSBaiViet BUSBaiViet = new BUSBaiViet();
            lt = BUSBaiViet.SelectBAIVIETsAll_new();
            LOAIBAIVIET ltLoaiBaiViet = new LOAIBAIVIET();
            BUSLoaiBaiViet BUSLoaiBaiViet = new BUSLoaiBaiViet();
            if (lt.Count > 0)
            {
                this.GridViewBaiViet.DataSource = lt;
                GridViewBaiViet.DataBind();
                PanelDanhSach.Visible = true;
                PanelMessage.Visible = false;
//                 for (int i = 0; i < lt.Count; i++)
//                 {
//                     GridViewBaiViet.Rows[i].Cells[4].Text = BUSLoaiBaiViet.TimKiem((int)lt[i].MaLoaiBaiViet).TenLoaiBaiViet;
//                 }
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
            this.GridViewBaiViet.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadBaiViet();
            FilterSTT(SoDong, GridViewBaiViet.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewBaiViet_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewBaiViet.PageIndex = e.NewPageIndex;
            int SoDong = LoadBaiViet();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        #region tin-xoa
        protected void GridViewBaiViet_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "XoaBaiViet")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                List<BAIVIET> lt = new List<BAIVIET>();

                BUSBaiViet busBaiViet = new BUSBaiViet();
                lt = busBaiViet.SelectBAIVIETsAll();


                XoaBaiViet(lt[index].MaBaiViet);
            }
        }
       protected void XoaBaiViet(int mabaiviet)
        {
            try
            {

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Bài viết này không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSBaiViet BUSBaiViet = new BUSBaiViet();
                    if (BUSBaiViet.Xoa(mabaiviet) == 0)
                    {
                        //Thong bao
                        DialogResult rs1 = MessageBox.Show("Xoá Bài viết thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Response.Redirect("BaiViet.aspx");
                    }
                    else
                    {
                        DialogResult rs1 = MessageBox.Show("Xoá Bài viết không thành công", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Response.Redirect("BaiViet.aspx");
                }
            }

            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}