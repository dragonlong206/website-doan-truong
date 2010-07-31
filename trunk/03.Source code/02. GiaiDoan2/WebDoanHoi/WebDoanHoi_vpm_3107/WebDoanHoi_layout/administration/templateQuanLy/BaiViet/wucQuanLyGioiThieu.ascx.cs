using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;
using System.Collections.Generic;
using System.Web.UI.MobileControls;
using System.Windows.Forms;

namespace WebDoanHoi_layout.administration.templateQuanLy.BaiViet
{
    public partial class wucQuanLyGioiThieu : System.Web.UI.UserControl
    {
        #region Ham Chung
        protected void Page_Load(object sender, EventArgs e)
        {
            //Thong tin nguoi dung
            NGUOIDUNG a = new NGUOIDUNG();
            a.MaNguoiDung = 1;
            Session["NGUOIDUNG"] = a;

            if (Request.QueryString["id"] != null)
            {
                //lay ma
                int magioithieu = int.Parse(Request.QueryString["id"]);

                //lay thong tin va load len cac textbox
                BUSGioiThieu BUSGioiThieu = new BUSGioiThieu();
                GIOITHIEU lpDTO = BUSGioiThieu.TimKiem(magioithieu);
                this.txtmagioithieu.Text = Convert.ToString(lpDTO.MaBai );
                this.txttengioithieu.Text = lpDTO.TieuDe ;
                this.txtnoidung.Text = lpDTO.NoiDung ;

            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                GIOITHIEU lpDTO = new GIOITHIEU();
                lpDTO.MaBai  = int.Parse(this.txtmagioithieu.Text);
                lpDTO.TieuDe  = this.txttengioithieu.Text;
                lpDTO.NoiDung  = this.txtnoidung.Text;

                //Goi ham cap nhat
                BUSGioiThieu BUSGioiThieu = new BUSGioiThieu();
                if (BUSGioiThieu.CapNhat(lpDTO) == 0)
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
                GIOITHIEU lpDTO = new GIOITHIEU();
                lpDTO.MaBai  = int.Parse(this.txtmagioithieu.Text);
                lpDTO.TieuDe  = this.txttengioithieu.Text;
                lpDTO.NoiDung  = this.txtnoidung.Text;


                //Goi ham cap nhat
                BUSGioiThieu BUSGioiThieu = new BUSGioiThieu();
                if (BUSGioiThieu.Them(lpDTO) == 0)
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
                int magioithieu = int.Parse(Request.QueryString["id"]);

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Hoạt Động <" + magioithieu + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSGioiThieu BUSGioiThieu = new BUSGioiThieu();
                    if (BUSGioiThieu.Xoa(magioithieu) == 0)
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
}