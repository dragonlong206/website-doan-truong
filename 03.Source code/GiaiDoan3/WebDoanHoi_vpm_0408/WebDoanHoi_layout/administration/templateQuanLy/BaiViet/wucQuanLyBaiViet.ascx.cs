﻿using System;
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
    public partial class wucQuanLyBaiViet : System.Web.UI.UserControl
    {
        #region Ham Chung

        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        protected void load()
        {
            //Thong tin nguoi dung
            NGUOIDUNG a = new NGUOIDUNG();
            a.MaNguoiDung = 1;
            Session["NGUOIDUNG"] = a;
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    //lay ma
                    int mabaiviet = int.Parse(Request.QueryString["id"]);
                    BUSBaiViet BUSBaiViet = new BUSBaiViet();
                    BAIVIET lpDTO = BUSBaiViet.TimKiem(mabaiviet);
                    DateTime dt = (DateTime)lpDTO.NgayDang;
                    BUSChuyenMuc BUSChuyenMuc = new BUSChuyenMuc();
                    CHUYENMUC cmDTO = BUSChuyenMuc.LayChuyenMucTheoBaiViet((int)lpDTO.MaLoaiBaiViet);
                    this.txtngaydang.Text = dt.ToString("dd/MM/yyyy");
                    this.txtnoidung.Value = lpDTO.NoiDung;
                    this.txttieude.Text = lpDTO.TieuDe;
                    // load ddl
                    load_ddlChuyenMuc();
                    ddlChuyenMuc.SelectedValue = cmDTO.MaChuyenMuc.ToString();
                    load_ddlLBV(cmDTO.MaChuyenMuc);
                    ddlLoaiBaiViet.SelectedValue = lpDTO.MaLoaiBaiViet.ToString();
                }
                else{
                    load_ddlChuyenMuc();
                    ddlChuyenMuc.SelectedValue = "1";
                    load_ddlLBV(1);
                }
            }
            
        }

        protected void load_ddlChuyenMuc()
        {
            // load ddlChuyenMuc
            ddlChuyenMuc.Items.Clear();
            BUSChuyenMuc BUSChuyenMuc = new BUSChuyenMuc();
            List<CHUYENMUC> lstCM = BUSChuyenMuc.SelectCHUYENMUCsAll();
            for (int i = 0; i < lstCM.Count; i++)
            {
                ListItem li = new ListItem(lstCM[i].TenChuyenMuc.ToString(), lstCM[i].MaChuyenMuc.ToString());
                this.ddlChuyenMuc.Items.Add(li);
            }
            
        }
        protected void load_ddlLBV(int machuyenmuc)
        {
            ddlLoaiBaiViet.Items.Clear();
            // load ddlLoaiBaiViet
            BUSLoaiBaiViet BUSLoaiBaiViet = new BUSLoaiBaiViet();
            List<LOAIBAIVIET> lstLBV = BUSLoaiBaiViet.TimKiemLoaiBaiVietTheoChuyenMuc(machuyenmuc);
            for (int i = 0; i < lstLBV.Count; i++)
            {
                ListItem li = new ListItem(lstLBV[i].TenLoaiBaiViet.ToString(), lstLBV[i].MaLoaiBaiViet.ToString());
                this.ddlLoaiBaiViet.Items.Add(li);
            }
        }
        protected void ddlChuyenMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_ddlLBV(int.Parse(ddlChuyenMuc.SelectedValue));
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                BAIVIET lpDTO = new BAIVIET();

                lpDTO.MaLoaiBaiViet = int.Parse(ddlLoaiBaiViet.SelectedValue);
                lpDTO.NgayDang = Convert.ToDateTime(this.txtngaydang.Text);
                lpDTO.NoiDung = this.txtnoidung.Value;
                lpDTO.TieuDe = this.txttieude.Text;

                //Goi ham cap nhat
                BUSBaiViet BUSBaiViet = new BUSBaiViet();
                if (BUSBaiViet.CapNhat(lpDTO) == 0)
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
            txtngaydang.Text = DateTime.Now.ToShortDateString();
            try
            {
                //lay thong tin tu textbox
                BAIVIET lpDTO = new BAIVIET();
                lpDTO.MaLoaiBaiViet = int.Parse(ddlLoaiBaiViet.SelectedValue);
                lpDTO.NgayDang = Convert.ToDateTime(this.txtngaydang.Text);
                lpDTO.NoiDung = this.txtnoidung.Value;
                lpDTO.TieuDe = this.txttieude.Text;

                //Goi ham cap nhat
                BUSBaiViet BUSBaiViet = new BUSBaiViet();
                if (BUSBaiViet.Them(lpDTO) == 0)
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
                int mabaiviet = int.Parse(Request.QueryString["id"]);

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Hoạt Động <" + mabaiviet + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSBaiViet BUSBaiViet = new BUSBaiViet();
                    if (BUSBaiViet.Xoa(mabaiviet) == 0)
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