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
//using System.Web.UI.MobileControls;
using System.Windows.Forms;

namespace WebDoanHoi_layout
{
    public partial class MuonPhong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NGUOIDUNG a = new NGUOIDUNG();
                a.MaNguoiDung = 1;
                a.HoTen = "nguyen van a";
                Session["LOGIN"] = a;

               
                if ((NGUOIDUNG)Session["LOGIN"] != null)
                {
                    txtMaNguoiDung.Text = ((NGUOIDUNG)(Session["LOGIN"])).MaNguoiDung.ToString();
                     LoadDanhSachPhong(a.MaNguoiDung);
                }
                else
                    Response.Redirect("index.aspx");
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            try
            {
                NGUOIDUNG a = new NGUOIDUNG();
                a.MaNguoiDung = 1;
                a.HoTen = "nguyen van a";
                Session["LOGIN"] = a;
                //lay thong tin tu textbox
                DANGKYMUONPHONG lpDTO = new DANGKYMUONPHONG();
                //lpDTO.MaDangKy = int.Parse(txtMaDangKy.Text);
                lpDTO.MaNguoiDung = int.Parse(txtMaNguoiDung.Text);
                lpDTO.NgayMuon = DateTime.Parse(txtNgayMuon.Text);
                lpDTO.SoLuong = int.Parse(txtSoLuong.Text);
                lpDTO.MucDich = txtMucDich.Text;
                lpDTO.DonViMuon = txtDonViMuon.Text;

                //lpDTO.BiKhoa  = txtlock.Text;
                //Goi ham cap nhat
                BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();
                if (BUSDangKyMuonPhong.Them(lpDTO) == 1)
                {
                    //Thong bao
                    lbThongBao.Text = "Đăng Kí Thành Công";
                    lbThongBao.Visible = true;
                    LoadDanhSachPhong(a.MaNguoiDung);
                    //LoadDanhSachPhong()
                    //Response.Redirect("LoaiMatHang.aspx");
                }
                else
                {
                    lbThongBao.Text = "Đăng Kí Không Thành Công";
                    lbThongBao.Visible = true;
                }
            }

            catch (Exception ex)
            {
                lbThongBao.Text = "Đăng Kí Không Thành Công";
                lbThongBao.Visible = true;
            }
        }

        public int LoadDanhSachPhong(int manguoidung)
        {
            List<NGUOIDUNG_DANGKYMUONPHONG_layUsernameTheoMaNguoiDungResult> lt = new List<NGUOIDUNG_DANGKYMUONPHONG_layUsernameTheoMaNguoiDungResult>();

            BUSDangKyMuonPhong BUSDangKyMuonPhong = new BUSDangKyMuonPhong();
            lt = BUSDangKyMuonPhong.DangKyMuonPhongVoiUsername(manguoidung);
            if (lt.Count > 0)
            {
                this.GridViewDanhSachPhongMuon.DataSource = lt;
                GridViewDanhSachPhongMuon.DataBind();
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
    }
}