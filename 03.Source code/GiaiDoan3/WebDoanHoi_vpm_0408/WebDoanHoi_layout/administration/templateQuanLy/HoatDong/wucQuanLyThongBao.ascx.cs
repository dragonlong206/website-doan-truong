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

namespace WebDoanHoi_layout.administration.templateQuanLy.HoatDong
{
    public partial class wucQuanLyThongBao : System.Web.UI.UserControl
    {
        #region Ham Chung
        protected void Page_Load(object sender, EventArgs e)
        {
            //Thong tin nguoi dung
            NGUOIDUNG a = new NGUOIDUNG();
            a.MaNguoiDung = 1;
            Session["NguoiDung"] = a;

            if (Request.QueryString["id"] != null)
            {
                //lay ma
                int mahoatdong = int.Parse(Request.QueryString["id"]);

                //lay thong tin va load len cac textbox
                BUSThongBao BUSThongBao = new BUSThongBao();
                THONGBAO lpDTO = BUSThongBao.TimKiem(mahoatdong);
                txtmathongbao.Text = lpDTO.MaThongBao .ToString();
                txttieude.Text = lpDTO.TieuDe ;
                txtnoidung.Text = lpDTO.NoiDung ;
                txtmahoatdong.Text = lpDTO.MaHoatDong .ToString();
                txtngaydang.Text = lpDTO.NgayDang .ToString();
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                THONGBAO lpDTO = new THONGBAO();
                lpDTO.MaThongBao  = int.Parse(txtmathongbao.Text);
                lpDTO.TieuDe  = txttieude.Text;
                lpDTO.NoiDung  = txtnoidung.Text;
                lpDTO.MaHoatDong  = int.Parse(txtmahoatdong.Text);
                lpDTO.NgayDang  = DateTime.Parse(txtngaydang.Text);

                //Goi ham cap nhat
                BUSThongBao BUSThongBao = new BUSThongBao();
                if (BUSThongBao.CapNhat(lpDTO) == 0)
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
                THONGBAO lpDTO = new THONGBAO();
                lpDTO.MaThongBao = int.Parse(txtmathongbao.Text);
                lpDTO.TieuDe = txttieude.Text;
                lpDTO.NoiDung = txtnoidung.Text;
                lpDTO.MaHoatDong = int.Parse(txtmahoatdong.Text);
                lpDTO.NgayDang = DateTime.Parse(txtngaydang.Text);

                //Goi ham cap nhat
                BUSThongBao BUSThongBao = new BUSThongBao();
                if (BUSThongBao.Them(lpDTO) == 0)
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
                int mahoatdong = int.Parse(Request.QueryString["id"]);

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Hoạt Động <" + mahoatdong + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSThongBao BUSThongBao = new BUSThongBao();
                    if (BUSThongBao.Xoa(mahoatdong) == 0)
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