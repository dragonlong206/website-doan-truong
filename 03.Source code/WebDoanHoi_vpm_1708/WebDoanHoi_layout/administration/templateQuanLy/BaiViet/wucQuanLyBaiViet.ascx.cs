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
        static BAIVIET BaiVietTemp = new BAIVIET();
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
                    BaiVietTemp = lpDTO;
                    BUSChuyenMuc BUSChuyenMuc = new BUSChuyenMuc();
                    CHUYENMUC cmDTO = BUSChuyenMuc.LayChuyenMucTheoBaiViet((int)lpDTO.MaLoaiBaiViet);
                   //this.txtngaydang.Text = dt.ToString("dd/MM/yyyy");
                    this.txtnoidung.Value = lpDTO.NoiDung;
                    this.txtTomTat.Text = lpDTO.TomTat;
                    this.txttieude.Text = lpDTO.TieuDe;
                    this.FileUploadTapTin.Visible = true;
                    this.PanelBtnUpload.Visible = true;
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
                    BUSTapTinBaiViet busTapTinBaiViet = new BUSTapTinBaiViet();
                    TAPTINBAIVIET tapTinBaiViet = busTapTinBaiViet.TimKiemMaBaiViet(mabaiviet);
                    if (tapTinBaiViet != null)
                    {
                        hplDownloadLink.NavigateUrl = tapTinBaiViet.DuongDan.ToString();
                        hplDownloadLink.Text = tapTinBaiViet.TenTapTin.ToString();
                    }
                }
                else
                {
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
                lpDTO.NgayDang = Convert.ToDateTime(System.DateTime.Now);
                lpDTO.NoiDung = this.txtnoidung.Value;
                lpDTO.TieuDe = this.txttieude.Text;
                lpDTO.TomTat = this.txtTomTat.Text;
                if (this.fulImage.HasFile)
                {
                    String currentPath = Server.MapPath("~/Uploads/");
                    String fileName = "anh_dai_dien" + lpDTO.NgayDang.Value.Day.ToString()
                        + lpDTO.NgayDang.Value.Month.ToString() + lpDTO.NgayDang.Value.Year.ToString()
                        + lpDTO.NgayDang.Value.Hour.ToString() + lpDTO.NgayDang.Value.Minute.ToString() + lpDTO.NgayDang.Value.Second.ToString() + ".jpg";
                    lpDTO.HinhAnh = fileName;
                    this.fulImage.SaveAs(currentPath + fileName);
                }
                BUSBaiViet BUSBaiViet = new BUSBaiViet();
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
                else
                {
                    lpDTO.HinhAnh = BaiVietTemp.HinhAnh;
                }
                //Goi ham cap nhat
                
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
        #region Đức sửa hàm Thêm 5/8
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
                //Nhi sửa: thêm phần tóm tắt bài viết 11/8/2010
                lpDTO.TomTat = this.txtTomTat.Text;
                if (this.fulImage.HasFile)
                {
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
        #endregion Đức  5/8
        #region Đức sửa hàm Xóa 4/8
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

        #region Nhi 11/8
        protected void btnUploadFiles_Click(object sender, EventArgs e)
        {
            PanelUploadTapTinBaiViet.Visible = true;
            PanelBtnUpload.Visible = false;
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
            if (FileUploadTapTin.HasFile)
            {
                SaveFile(FileUploadTapTin.PostedFile);
            }
            else
            {
                LabelUploadStatus.Text = "Bạn vẫn chưa chọn file để upload.";
            }
        }
        void SaveFile(HttpPostedFile file)
        {
            //Duong dan den thu muc Uploads tren server
            string savePath = Server.MapPath("~/Uploads\\");

            // Ten file upload
            string fileName = FileUploadTapTin.FileName;

            // Tao duong dan de kiem tra xem file da ton tai chua
            string pathToCheck = savePath + fileName;
            string tempfileName = fileName;
            bool overwrite = false;

            // Kiem tra xem da ton tai file co ten giong voi file nguoi dung muon up chua
            if (System.IO.File.Exists(pathToCheck))
            {
                int counter = 2;
                while (System.IO.File.Exists(pathToCheck))
                {
                    DialogResult result;
                    string message = "Tên file " + tempfileName + " đã tồn tại. Bạn có muốn ghi đè lên không?";
                    result = MessageBox.Show(message, "Caution", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        // them (so) vao sau ten file
                        int point = fileName.LastIndexOf('.');
                        string nameNumber = "(" + counter.ToString() + ")";
                        tempfileName = fileName.Insert(point, nameNumber);
                        pathToCheck = savePath + tempfileName;
                        counter++;
                    }
                    else
                    {
                        overwrite = true;
                        LabelUploadStatus.Text = "File của bạn đã được ghi đè thành công.";
                        break;
                    }
                }

                fileName = tempfileName;
                if (counter > 2)
                    LabelUploadStatus.Text = "File của bạn đã được ghi dưới tên: " + fileName;
            }
            else
            {
                // Thong bao la da upload thanh cong
                LabelUploadStatus.Text = "File của bạn đã được ghi thành công.";
                imgBtnXoa.Visible = true;
            }

            savePath += fileName;

            //Luu file
            FileUploadTapTin.SaveAs(savePath);

            //Duong dan de tai file
            string linkDir = "~/Uploads/" + fileName;

            //Them vao bang TapTin
            //id la tham so truyen vao url, la id cua bai viet lien quan den tap tin

            if (Request.QueryString["id"] != null)
            {
                if (overwrite == false)
                {
                    int maBaiViet = int.Parse(Request.QueryString["id"]);

                    BUSTapTinBaiViet busTapTin = new BUSTapTinBaiViet();
                    int numberTapTin = busTapTin.TimSoLuongTapTin();
                    TAPTINBAIVIET lpDTO = new TAPTINBAIVIET();
                    lpDTO.TenTapTin = fileName;
                    lpDTO.DuongDan = linkDir;
                    lpDTO.MaBaiViet = maBaiViet;
                    lpDTO.MaTapTin = numberTapTin + 1;
                    busTapTin.Them(lpDTO);
                }
                else
                {
                    int maBaiViet = int.Parse(Request.QueryString["id"]);

                    BUSTapTinBaiViet busTapTin = new BUSTapTinBaiViet();
                    TAPTINBAIVIET lpDTO = busTapTin.TimKiemTenTapTin(fileName);

                    lpDTO.MaBaiViet = maBaiViet;
                    busTapTin.CapNhat(lpDTO);
                }
            }
        }

        #endregion

        protected void imgBtnXoa_Click(object sender, ImageClickEventArgs e)
        {

        }


    }
}