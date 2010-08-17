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
using System.Globalization;

namespace WebDoanHoi_layout.administration.templateQuanLy.HoatDong
{
    public partial class wucQuanLyHoatDong : System.Web.UI.UserControl
    {
        #region Ham Chung

        protected bool KiemTra()
        {
            IFormatProvider culture = new CultureInfo("vi-VN", true);

            DateTime NgayDienRa = DateTime.Parse(txtngaydienra.Text, culture);
            DateTime ThoiGianBatDauDangKy = DateTime.Parse(txtthoigianbatdaudangky.Text, culture);
            DateTime ThoiGianKetThucDangKy = DateTime.Parse(txtthoigianketthucdangky.Text, culture);

            if (ThoiGianKetThucDangKy < ThoiGianBatDauDangKy)
            {
                lbThongBao.Text = "Ngày Kết Thúc Đăng Ký Phải Sau Ngày Bắt Đầu Đăng Ký";
                lbThongBao.Visible = true;
                return false;
            }
            else
                if (NgayDienRa < ThoiGianKetThucDangKy)
                {
                    lbThongBao.Text = "Ngày Diễn Ra Hoạt Động Phải Sau Ngày Kết Thúc Đăng Ký";
                    lbThongBao.Visible = true;
                    return false;
                }

            return true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Do loai hoat dong
                BUSLoaiHoatDong BUSLoaiHoatDong = new BUSLoaiHoatDong();
                ddlLoaiHoatDong.DataSource = BUSLoaiHoatDong.SelectLOAIHOATDONGsAll();
                ddlLoaiHoatDong.DataTextField = "TenLoaiHoatDong";
                ddlLoaiHoatDong.DataValueField = "MaLoaiHoatDong";
                ddlLoaiHoatDong.DataBind();

                if (Request.QueryString["id"] != null)
                {
                    LoadHoatDong();
                }
                //else
                //{
                //    Response.Redirect("~/administration/index.aspx");
                //}
            }
        }

        protected void LoadHoatDong()
        {
            //lay ma
            int mahoatdong = int.Parse(Request.QueryString["id"]);

            //lay thong tin va load len cac textbox
            BUSHoatDong BUSHoatDong = new BUSHoatDong();
            HOATDONG lpDTO = BUSHoatDong.TimKiem(mahoatdong);
            txttenhoatdong.Text = lpDTO.TenHoatDong;
            ddlLoaiHoatDong.SelectedValue = lpDTO.MaLoaiHoatDong.ToString();
            txtngaydienra.Text = ((DateTime)lpDTO.NgayDienRa).ToString("dd/MM/yyyy");
            txtthoigianbatdaudangky.Text = ((DateTime)lpDTO.ThoiGianBatDauDangKy).ToString("dd/MM/yyyy");
            txtthoigianketthucdangky.Text = ((DateTime)lpDTO.ThoiGianKetThucDangKy).ToString("dd/MM/yyyy");
        }
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra() == false)
            {
                return;
            }

            try
            {
                //lay thong tin tu textbox
                HOATDONG lpDTO = new HOATDONG();
                lpDTO.MaHoatDong = int.Parse(Request.QueryString["id"]);
                lpDTO.TenHoatDong = txttenhoatdong.Text;
                lpDTO.MaLoaiHoatDong = int.Parse(ddlLoaiHoatDong.SelectedValue);
                //
                IFormatProvider culture = new CultureInfo("vi-VN", true);

                lpDTO.NgayDienRa = DateTime.Parse(txtngaydienra.Text, culture);
                lpDTO.ThoiGianBatDauDangKy = DateTime.Parse(txtthoigianbatdaudangky.Text, culture);
                lpDTO.ThoiGianKetThucDangKy = DateTime.Parse(txtthoigianketthucdangky.Text, culture);

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

            Response.Redirect("HoatDong.aspx?id=" + Request.QueryString["id"]);
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra() == false)
            {
                return;
            }

            try
            {
                //lay thong tin tu textbox
                HOATDONG lpDTO = new HOATDONG();
                lpDTO.TenHoatDong = txttenhoatdong.Text;
                lpDTO.MaLoaiHoatDong = int.Parse(ddlLoaiHoatDong.SelectedValue);

                IFormatProvider culture = new CultureInfo("vi-VN", true);

                lpDTO.NgayDienRa = DateTime.Parse(txtngaydienra.Text, culture);
                lpDTO.ThoiGianBatDauDangKy = DateTime.Parse(txtthoigianbatdaudangky.Text, culture);
                lpDTO.ThoiGianKetThucDangKy = DateTime.Parse(txtthoigianketthucdangky.Text, culture);

                //Goi ham cap nhat
                BUSHoatDong BUSHoatDong = new BUSHoatDong();
                if (BUSHoatDong.Them(lpDTO) == 1)
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

            Response.Redirect("HoatDong.aspx");
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
                lbThongBao.Text = "Xóa Không Thành Công";
                lbThongBao.Visible = true;
            }
        }

        #endregion
    }
}