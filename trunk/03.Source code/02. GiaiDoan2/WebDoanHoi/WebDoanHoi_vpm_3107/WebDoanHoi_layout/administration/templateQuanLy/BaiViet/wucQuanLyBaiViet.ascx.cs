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
    public partial class wucQuanLyBaiViet : System.Web.UI.UserControl
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
                int mabaiviet = int.Parse(Request.QueryString["id"]);

                //lay thong tin va load len cac textbox
                BUSBaiViet BUSBaiViet = new BUSBaiViet();
                BAIVIET lpDTO = BUSBaiViet.TimKiem(mabaiviet);
                this.txtmabaiviet.Text = Convert.ToString(lpDTO.MaBaiViet );
                this.txtmaloaibaiviet.Text = Convert.ToString(lpDTO.MaLoaiBaiViet );
                this.txtngaydang.Text = Convert.ToString(lpDTO.NgayDang );
                this.txtnoidung.Text = lpDTO.NoiDung ;
                this.txttieude.Text = lpDTO.TieuDe ;
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                BAIVIET lpDTO = new BAIVIET();

                lpDTO.MaBaiViet  = Convert.ToInt32(this.txtmabaiviet.Text);
                lpDTO.MaLoaiBaiViet  = Convert.ToInt32(this.txtmaloaibaiviet.Text);
                lpDTO.NgayDang  = Convert.ToDateTime(this.txtngaydang.Text);
                lpDTO.NoiDung  = this.txtnoidung.Text;
                lpDTO.TieuDe  = this.txttieude.Text;


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
            try
            {
                //lay thong tin tu textbox
                BAIVIET lpDTO = new BAIVIET();
                lpDTO.MaBaiViet = Convert.ToInt32(this.txtmabaiviet.Text);
                lpDTO.MaLoaiBaiViet = Convert.ToInt32(this.txtmaloaibaiviet.Text);
                lpDTO.NgayDang = Convert.ToDateTime(this.txtngaydang.Text);
                lpDTO.NoiDung = this.txtnoidung.Text;
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