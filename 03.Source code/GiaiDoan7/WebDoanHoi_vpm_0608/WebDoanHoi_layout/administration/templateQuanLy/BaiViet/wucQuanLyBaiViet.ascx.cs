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
#region Đức 6/8
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
                    BUSChuyenMuc BUSChuyenMuc = new BUSChuyenMuc();
                    CHUYENMUC cmDTO = BUSChuyenMuc.LayChuyenMucTheoBaiViet((int)lpDTO.MaLoaiBaiViet);
                   //this.txtngaydang.Text = dt.ToString("dd/MM/yyyy");
                    this.txtnoidung.Value = lpDTO.NoiDung;
                    this.txttieude.Text = lpDTO.TieuDe;
                    if (lpDTO.HinhAnh!="")
                    {
                        this.lbAnhDaiDien.Text = @"<img src='~\Uploads/" + lpDTO.HinhAnh+"'style ='width:170px; height:170px' />";
                       // this.imgAnhDaiDien.Visible = true;
                    }
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
#endregion
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
        #region Đức sửa 4/8
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                BAIVIET lpDTO = new BAIVIET();
                lpDTO.MaBaiViet = int.Parse(Request.QueryString["id"]);
                lpDTO.MaLoaiBaiViet = int.Parse(ddlLoaiBaiViet.SelectedValue);
              //  lpDTO.NgayDang = Convert.ToDateTime(this.txtngaydang.Text);
                lpDTO.NoiDung = this.txtnoidung.Value;
                lpDTO.TieuDe = this.txttieude.Text;
                if (this.fulImage.HasFile)
                {
                    System.IO.File.Delete(Server.MapPath("~/Uploads/") + lpDTO.HinhAnh);
                    String currentPath = Server.MapPath("~/Uploads/");
                    String fileName = "anh_dai_dien" + lpDTO.NgayDang.Value.Day.ToString()
                        + lpDTO.NgayDang.Value.Month.ToString() + lpDTO.NgayDang.Value.Year.ToString()
                        + lpDTO.NgayDang.Value.Hour.ToString() + lpDTO.NgayDang.Value.Minute.ToString() + lpDTO.NgayDang.Value.Second.ToString() + ".jpg";
                    lpDTO.HinhAnh = fileName;
                    this.fulImage.SaveAs(currentPath + fileName);
                }       
                //Goi ham cap nhat
                BUSBaiViet BUSBaiViet = new BUSBaiViet();
                if (BUSBaiViet.CapNhat(lpDTO) == 0)
                {
                    //Thong bao
                    lbThongBao.Text = "Cập Nhật Thành Công";
                    lbThongBao.Visible = true;
                    Response.Redirect("~/administration/BaiViet.aspx?id=" + lpDTO.MaBaiViet.ToString());
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
        #endregion
        #region Duc sua 5/8
        protected void btnThem_Click(object sender, EventArgs e)
        {
            //txtngaydang.Text = DateTime.Now.ToShortDateString();
            try
            {
                //lay thong tin tu textbox
                BAIVIET lpDTO = new BAIVIET();
                
                lpDTO.MaLoaiBaiViet = int.Parse(ddlLoaiBaiViet.SelectedValue);
                lpDTO.NgayDang = Convert.ToDateTime(System.DateTime.Now);
                lpDTO.NoiDung = this.txtnoidung.Value;
                lpDTO.TieuDe = this.txttieude.Text;
                if (this.fulImage.HasFile){
                    String currentPath = Server.MapPath("~/Uploads/");
                    String fileName = "anh_dai_dien" + lpDTO.NgayDang.Value.Day.ToString()
                        + lpDTO.NgayDang.Value.Month.ToString() + lpDTO.NgayDang.Value.Year.ToString()
                        + lpDTO.NgayDang.Value.Hour.ToString() + lpDTO.NgayDang.Value.Minute.ToString() + lpDTO.NgayDang.Value.Second.ToString() + ".jpg";
                    lpDTO.HinhAnh = fileName;
                    this.fulImage.SaveAs(currentPath + fileName);
                }              
                
                //Goi ham cap nhat
                BUSBaiViet BUSBaiViet = new BUSBaiViet();
                if (BUSBaiViet.Them(lpDTO) == 1)
                {
                    //Thong bao
                    lbThongBao.Text = "Thêm Thành Công";
                    lbThongBao.Visible = true;
                    Response.Redirect("BaiViet.aspx");
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
        #endregion Đức sửa 5/8
        #region Đức sửa 4/8
        protected void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                int mabaiviet = int.Parse(Request.QueryString["id"]);

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Bài viết này không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSBaiViet BUSBaiViet = new BUSBaiViet();
                    if (BUSBaiViet.Xoa(mabaiviet) == 0)
                    {
                        //Thong bao
                        lbThongBao.Text = "Xóa Thành Công";
                        lbThongBao.Visible = true;
                        Response.Redirect("BaiViet.aspx");
                    }
                    else
                    {
                        lbThongBao.Text = "Xóa Không Thành Công";
                        lbThongBao.Visible = true;
                    }
                }
                else
                {
                    Response.Redirect("BaiViet.aspx");
                }
            }

            catch (Exception ex)
            {
                lbThongBao.Text = "Xoa Không Thành Công";
                lbThongBao.Visible = true;
            }
        }
#endregion

        
        #endregion

        
 
    }
}