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

public partial class administration_templateQuanLy_Album_wucQuanLyAlBum1 : System.Web.UI.UserControl
{
    #region Ham Chung
    protected void Page_Load(object sender, EventArgs e)
    {
        //Thong tin nguoi dung
        SINHVIEN a = new SINHVIEN();
        a.masinhvien = 1;
        Session["SINHVIEN"] = a;

        if (Request.QueryString["id"] != null)
        {
            //lay ma
            int maalbum = int.Parse(Request.QueryString["id"]);
            //lay thong tin va load len cac textbox
            BUSAlbum BUSAlbum = new BUSAlbum();
            ALBUM lpDTO = BUSAlbum.TimKiem(maalbum);
            this.txtmaalbum.Text = Convert.ToString(lpDTO.maalbum);
            this.txttenalbum.Text = lpDTO.tenalbum ;
        }
    }

    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        try
        {
            //lay thong tin tu textbox
            ALBUM lpDTO = new ALBUM();
            lpDTO.maalbum =Convert.ToInt32( this.txtmaalbum.Text );
            lpDTO.tenalbum = this.txttenalbum.Text;

            //Goi ham cap nhat
            BUSAlbum BUSAlbum = new BUSAlbum();
            if (BUSAlbum.CapNhat(lpDTO) == 0)
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
            ALBUM lpDTO = new ALBUM();
            lpDTO.maalbum = Convert.ToInt32(this.txtmaalbum.Text);
            lpDTO.tenalbum = this.txttenalbum.Text;

            //Goi ham cap nhat
            BUSAlbum BUSAlbum = new BUSAlbum();
            if (BUSAlbum.Them(lpDTO) == 0)
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
            int maalbum = int.Parse(Request.QueryString["id"]);

            //xac nhan truoc khi xoa
            DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Hoạt Động <" + maalbum + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                //Goi ham xoa
                BUSAlbum BUSAlbum = new BUSAlbum();
                if (BUSAlbum.Xoa(maalbum) == 0)
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
