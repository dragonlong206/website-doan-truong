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
using System.Windows.Forms;

public partial class administration_templateQuanLy_BaiViet_wucQuanLyHeThongToChuc : System.Web.UI.UserControl
{
    #region Ham Chung
    protected void Page_Load(object sender, EventArgs e)
    {
        //Thong tin nguoi dung
        SINHVIEN a = new SINHVIEN();
        a.masinhvien  = 1;
        Session["SINHVIEN"] = a;

        if (Request.QueryString["id"] != null)
        {
            //lay ma
            int mahethongtochuc = int.Parse(Request.QueryString["id"]);

            //lay thong tin va load len cac textbox
            BUSHeThongToChuc BUSHeThongToChuc = new BUSHeThongToChuc();
            HETHONGTOCHUC lpDTO = BUSHeThongToChuc.TimKiem(mahethongtochuc);
            this.txtmahethongtochuc.Text = Convert.ToString(lpDTO.mahethongtochuc);
            this.txttenhethongtochuc.Text = lpDTO.tenhethongtochuc;
            this.txtnoidung.Text = lpDTO.noidung;
        }
    }

    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        try
        {
            //lay thong tin tu textbox
            HETHONGTOCHUC lpDTO = new HETHONGTOCHUC();
            lpDTO.mahethongtochuc = int.Parse(this.txtmahethongtochuc.Text);
            lpDTO.tenhethongtochuc  = this.txttenhethongtochuc.Text;
            lpDTO.noidung  = this.txtnoidung.Text;

            //Goi ham cap nhat
            BUSHeThongToChuc BUSHeThongToChuc = new BUSHeThongToChuc();
            if (BUSHeThongToChuc.CapNhat(lpDTO) == 0)
            {
                //Thong bao
                lbThongBao.Text = "Cập Nhật Thành Công";
                lbThongBao.Visible = true;
                //Response.Redirect("LoaiMatHang.aspx");
            }
            else
            {
                lbThongBao.Text = "Cập Nhật Không Thành Công";
                lbThongBao.Visible = true;
            }
        }

        catch (Exception ex)
        {
            lbThongBao.Text = "Cập nhật Không Thành Công";
            lbThongBao.Visible = true;
        }
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            //lay thong tin tu textbox
            HETHONGTOCHUC lpDTO = new HETHONGTOCHUC();
            lpDTO.mahethongtochuc = int.Parse(this.txtmahethongtochuc.Text);
            lpDTO.tenhethongtochuc = this.txttenhethongtochuc.Text;
            lpDTO.noidung = this.txtnoidung.Text;

            //Goi ham cap nhat
            BUSHeThongToChuc BUSHeThongToChuc = new BUSHeThongToChuc();
            if (BUSHeThongToChuc.Them(lpDTO) == 0)
            {
                //Thong bao
                lbThongBao.Text = "Thêm Thành Công";
                lbThongBao.Visible = true;
                //Response.Redirect("LoaiMatHang.aspx");
            }
            else
            {
                lbThongBao.Text = "Thêm Không Thành Công";
                lbThongBao.Visible = true;
            }
        }

        catch (Exception ex)
        {
            lbThongBao.Text = "Thêm Không Thành Công";
            lbThongBao.Visible = true;
        }
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        try
        {
            //lay thong tin tu textbox
            int mahethongtochuc = int.Parse(Request.QueryString["id"]);

            //xac nhan truoc khi xoa
            DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Hoạt Động <" + mahethongtochuc + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                //Goi ham xoa
                BUSHeThongToChuc BUSHeThongToChuc = new BUSHeThongToChuc();
                if (BUSHeThongToChuc.Xoa(mahethongtochuc) == 0)
                {
                    //Thong bao
                    lbThongBao.Text = "Xóa Thành Công";
                    lbThongBao.Visible = true;
                    Response.Redirect("HoatDong.aspx");
                }
                else
                {
                    lbThongBao.Text = "Xóa Không Thành Công";
                    lbThongBao.Visible = true;
                }
            }
            else
            {
                Response.Redirect("HoatDong.aspx");
            }
        }

        catch (Exception ex)
        {
            lbThongBao.Text = "Xoa Không Thành Công";
            lbThongBao.Visible = true;
        }
    }
    #endregion
}
