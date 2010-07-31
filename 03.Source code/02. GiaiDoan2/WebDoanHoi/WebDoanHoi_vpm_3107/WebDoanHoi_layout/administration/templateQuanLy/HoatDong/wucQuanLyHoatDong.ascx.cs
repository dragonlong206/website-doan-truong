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

namespace WebDoanHoi_layout.administration.templateQuanLy.HoatDong
{
    public partial class wucQuanLyHoatDong : System.Web.UI.UserControl
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
                BUSHoatDong BUSHoatDong = new BUSHoatDong();
                HOATDONG lpDTO = BUSHoatDong.TimKiem(mahoatdong);
                txtmahoatdong.Text = lpDTO.MaHoatDong .ToString();
                txttenhoatdong.Text = lpDTO.TenHoatDong ;
                txtngaydienra.Text = lpDTO.NgayDienRa .ToString();
                txtmaloaihoatdong.Text = lpDTO.MaLoaiHoatDong .ToString();
                txtthoigianbatdaudangky.Text = lpDTO.ThoiGianBatDauDangKy .ToString();
                txtthoigianketthucdangky.Text = lpDTO.ThoiGianKetThucDangKy .ToString();
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                HOATDONG lpDTO = new HOATDONG();
                lpDTO.MaHoatDong  = int.Parse(txtmahoatdong.Text);
                lpDTO.TenHoatDong  = txttenhoatdong.Text;
                lpDTO.NgayDienRa  = DateTime.Parse(txtngaydienra.Text);
                lpDTO.MaLoaiHoatDong  = int.Parse(txtmaloaihoatdong.Text);
                lpDTO.ThoiGianBatDauDangKy  = DateTime.Parse(txtthoigianbatdaudangky.Text);
                lpDTO.ThoiGianKetThucDangKy  = DateTime.Parse(txtthoigianketthucdangky.Text);

                //Goi ham cap nhat
                BUSHoatDong BUSHoatDong = new BUSHoatDong();
                if (BUSHoatDong.CapNhat(lpDTO) == 0)
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
                HOATDONG lpDTO = new HOATDONG();
                lpDTO.MaHoatDong = int.Parse(txtmahoatdong.Text);
                lpDTO.TenHoatDong = txttenhoatdong.Text;
                lpDTO.NgayDienRa = DateTime.Parse(txtngaydienra.Text);
                lpDTO.MaLoaiHoatDong = int.Parse(txtmaloaihoatdong.Text);
                lpDTO.ThoiGianBatDauDangKy = DateTime.Parse(txtthoigianbatdaudangky.Text);
                lpDTO.ThoiGianKetThucDangKy = DateTime.Parse(txtthoigianketthucdangky.Text);

                //Goi ham cap nhat
                BUSHoatDong BUSHoatDong = new BUSHoatDong();
                if (BUSHoatDong.Them(lpDTO) == 0)
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
                    BUSHoatDong BUSHoatDong = new BUSHoatDong();
                    if (BUSHoatDong.Xoa(mahoatdong) == 0)
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