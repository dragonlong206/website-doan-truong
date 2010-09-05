﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;
using System.Web.UI.MobileControls;
using System.Windows.Forms;

namespace WebDoanHoi_layout.administration.templateQuanLy.Phong
{
    public partial class wucQuanLyDangKyMuonPhong : System.Web.UI.UserControl
    {
        #region Ham Chung
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMuonPhong();
                Load_Danh_Sach();
            }

        }
        protected void LoadMuonPhong()
        {
            //Xu ly session
            if (Session["LOGIN"] == null)
                Response.Redirect("~/administration/index.aspx");

            if (Convert.ToInt32(((NGUOIDUNG)Session["LOGIN"]).MaVaiTro) != 3)
                Response.Redirect("~/administration/index.aspx");

            NGUOIDUNG a = (NGUOIDUNG)Session["LOGIN"];

            if (Request.QueryString["id"] != null)
            {
                //lay ma
                int madangky = int.Parse(Request.QueryString["id"]);


                //lay thong tin va load len cac textbox
                BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();
                DANGKYMUONPHONG lpDTO = BUSDangKyMuonPhong.TimKiem(madangky);
                txtngay.Text = lpDTO.NgayMuon.ToString();
                txtsoluong.Text = lpDTO.SoLuong.ToString();
                txtmucdich.Text = lpDTO.MucDich;
                txtdonvimuon.Text = lpDTO.DonViMuon;
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                DANGKYMUONPHONG lpDTO = new DANGKYMUONPHONG();
                lpDTO.MaDangKy = int.Parse(Request.QueryString["id"]);
                lpDTO.MaNguoiDung = ((NGUOIDUNG)Session["LOGIN"]).MaNguoiDung;
                lpDTO.NgayMuon = DateTime.Parse(txtngay.Text);
                lpDTO.SoLuong = int.Parse(txtsoluong.Text);
                lpDTO.MucDich = txtmucdich.Text;
                lpDTO.DonViMuon = txtdonvimuon.Text;

                BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();
                if (BUSDangKyMuonPhong.CapNhat(lpDTO) == 1)
                {
                    //Thong bao
                    lbThongBao.Text = "Cập Nhật Thành Công";
                    lbThongBao.Visible = true;
                    //LoadMuonPhong();
                    Load_Danh_Sach();
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
                DANGKYMUONPHONG lpDTO = new DANGKYMUONPHONG();
                lpDTO.MaNguoiDung = ((NGUOIDUNG)Session["LOGIN"]).MaNguoiDung;
                lpDTO.NgayMuon = DateTime.Parse(txtngay.Text);
                lpDTO.SoLuong = int.Parse(txtsoluong.Text);
                lpDTO.MucDich = txtmucdich.Text;
                lpDTO.DonViMuon = txtdonvimuon.Text;

                //Goi ham cap nhat
                BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();
                if (BUSDangKyMuonPhong.Them(lpDTO) == 1)
                {
                    //Thong bao
                    lbThongBao.Text = "Thêm Thành Công";
                    lbThongBao.Visible = true;
                    //LoadMuonPhong();
                    Load_Danh_Sach();
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
                int madangky = int.Parse(Request.QueryString["id"]);

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Hoạt Động <" + madangky + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();
                    if (BUSDangKyMuonPhong.Xoa(madangky) == 0)
                    {
                        //Thong bao
                        lbThongBao.Text = "Xóa Thành Công";
                        lbThongBao.Visible = true;
                        Load_Danh_Sach();
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

        protected void btnXoaNhieu_Click(object sender, EventArgs e)
        {
            try
            {
                List<DANGKYMUONPHONG> lt = new List<DANGKYMUONPHONG>();

                BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();

                lt = BUSDangKyMuonPhong.SelectDANGKYMUONPHONGBYDATE(DateTime.Parse(txtXoaNhieu.Text));
                //lay thong tin tu textbox

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("B?n có ch?c là mu?n xoá các Ho?t Ð?ng tru?c ngày <" + DateTime.Parse(txtXoaNhieu.Text) + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    for (int i = 0; i < lt.Count; i++)
                    {
                        int madangky = lt[i].MaDangKy;
                        //Goi ham xoa
                        BUSDangKyMuonPhong BUSDangKyMuonPhong2 = new BUSDangKyMuonPhong();
                        if (BUSDangKyMuonPhong2.Xoa(madangky) == 0)
                        {
                            //Thong bao
                        }
                        else
                        {
                            lbThongBao.Text = "Xóa Không Thành Công";
                            lbThongBao.Visible = true;
                            break;
                        }
                    }
                    lbThongBao.Text = "Xóa Thành Công";
                    lbThongBao.Visible = true;
                    Response.Redirect("DangKyMuonPhong.aspx");
                }
                else
                {
                    Response.Redirect("DangKyMuonPhong.aspx");
                }
            }

            catch (Exception ex)
            {
                lbThongBao.Text = "Xóa Không Thành Công";
                lbThongBao.Visible = true;
            }
        }

        protected void Load_Danh_Sach()
        {
            Page.Title = "Danh Sách Mượn Phòng";

            int soDong = LoadDangKyMuonPhong();
            FilterSTT(soDong, 0, 10);
            //}
            this.GridViewDangKyMuonPhong.HeaderStyle.CssClass = "headerstyle";
        }
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewDangKyMuonPhong.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
            }
        }
        //Load
        public int LoadDangKyMuonPhong()
        {
            List<DANGKYMUONPHONG_getallwithNameUserResult> lt = new List<DANGKYMUONPHONG_getallwithNameUserResult>();

            BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();

            lt = BUSDangKyMuonPhong.SelectDANGKYMUONPHONGsAllwithNameUser();
            if (lt.Count > 0)
            {
                this.GridViewDangKyMuonPhong.DataSource = lt;
                GridViewDangKyMuonPhong.DataBind();
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
            this.GridViewDangKyMuonPhong.PageSize = int.Parse(DropDownListPaging.SelectedValue);
            int SoDong = LoadDangKyMuonPhong();
            FilterSTT(SoDong, GridViewDangKyMuonPhong.PageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
        //Chon trang NEXT
        protected void GridViewDangKyMuonPhong_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewDangKyMuonPhong.PageIndex = e.NewPageIndex;
            int SoDong = LoadDangKyMuonPhong();
            FilterSTT(SoDong, e.NewPageIndex, int.Parse(DropDownListPaging.SelectedValue));
        }
    }
}