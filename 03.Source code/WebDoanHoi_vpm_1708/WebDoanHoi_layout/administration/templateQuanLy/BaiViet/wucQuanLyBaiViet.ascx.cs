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
using System.Drawing;

namespace WebDoanHoi_layout.administration.templateQuanLy.BaiViet
{
    public partial class wucQuanLyBaiViet : System.Web.UI.UserControl
    {
        static BAIVIET BaiVietTemp = new BAIVIET();
        #region Ham Chung
        #region Đức 17/8
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        public int LoadTapTin()
        {
            List<TAPTINBAIVIET> lt = new List<TAPTINBAIVIET>();


            BUSTapTinBaiViet BUSTapTinBaiViet = new BUSTapTinBaiViet();
            int sodong;
            BaiVietTemp = (BAIVIET)Session["BaiVietTemp"];
            lt = BUSTapTinBaiViet.TimKiemMaBaiViet(BaiVietTemp.MaBaiViet);
            if (lt != null)
            {
                this.GridViewTapTin.DataSource = lt;
                GridViewTapTin.DataBind();
                PanelMessage.Visible = false;
                PanelDanhSach.Visible = true;
                sodong = lt.Count;
            }
            else
            {
                lt = new List<TAPTINBAIVIET>();
                this.GridViewTapTin.DataSource = lt;
                GridViewTapTin.DataBind();
                PanelMessage.Visible = true;
                PanelDanhSach.Visible = true;
                sodong = 0;
            }
            Session.Add("GridViewTapTinDataSource", lt);
            List<TAPTINBAIVIET> lFileTemp = new List<TAPTINBAIVIET>();
            Session.Add("FileUploadTemp", lFileTemp);
            List<HttpPostedFile> lFileClientPath = new List<HttpPostedFile>();
            Session.Add("FileClientTemp", lFileClientPath);
            return sodong;
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
                    Session.Add("BaiVietTemp", BaiVietTemp);
                    BUSChuyenMuc BUSChuyenMuc = new BUSChuyenMuc();
                    CHUYENMUC cmDTO = BUSChuyenMuc.LayChuyenMucTheoBaiViet((int)lpDTO.MaLoaiBaiViet);
                    //this.txtngaydang.Text = dt.ToString("dd/MM/yyyy");
                    this.txtnoidung.Value = lpDTO.NoiDung;
                    this.txtTomTat.Text = lpDTO.TomTat;
                    this.txttieude.Text = lpDTO.TieuDe;
                    if (lpDTO.HinhAnh != "")
                    {

                        this.imgAnhDaiDien.ImageUrl = @"~\Uploads/" + lpDTO.HinhAnh;
                    }
                    // load ddl
                    load_ddlChuyenMuc();
                    ddlChuyenMuc.SelectedValue = cmDTO.MaChuyenMuc.ToString();
                    load_ddlLBV(cmDTO.MaChuyenMuc);
                    ddlLoaiBaiViet.SelectedValue = lpDTO.MaLoaiBaiViet.ToString();
                    int soDong = LoadTapTin();
                    FilterSTT(soDong, 0, 30);
                    PanelBtnUpload.Visible = true;
                }
                else
                {
                    load_ddlChuyenMuc();
                    ddlChuyenMuc.SelectedValue = "1";
                    load_ddlLBV(1);
                    PanelBtnUpload.Visible = false;
                }
            }

        }
        //Do STT
        public void FilterSTT(int TongSoDong, int TrangHienTai, int SoDongTrenTrang)
        {
            int stt = 0;
            for (int i = TrangHienTai * SoDongTrenTrang; i < TongSoDong && i < (TrangHienTai + 1) * SoDongTrenTrang; i++)
            {
                GridViewTapTin.Rows[stt].Cells[0].Text = (i + 1).ToString();
                stt += 1;
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
        #region Đức sửa 17/8
        #region chỉnh sửa ảnh đại diện
        public bool ThumbnailCallback()
        {
            return false;
        }
        protected System.Drawing.Image getThumbnailImage(string imgFileName)
        {
            System.Drawing.Image.GetThumbnailImageAbort myCallback =
        new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
            Bitmap myBitmap = new Bitmap(imgFileName);
            System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(
            300, 300, myCallback, IntPtr.Zero);
            myBitmap.Dispose();
            return myThumbnail;
        }
        protected void SaveImageThumbnail(string imgSourceFile, string desPath, bool deleteSource)
        {
            System.Drawing.Image img = getThumbnailImage(imgSourceFile);
            if (deleteSource == true)
                System.IO.File.Delete(imgSourceFile);
            img.Save(desPath, System.Drawing.Imaging.ImageFormat.Png);
        }
        #endregion


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
                BaiVietTemp = (BAIVIET)Session["BaiVietTemp"];
                BUSBaiViet BUSBaiViet = new BUSBaiViet();
                if (this.fulImage.HasFile)
                {
                    if (BaiVietTemp.HinhAnh != "")
                        System.IO.File.Delete(Server.MapPath("~/Uploads/") + BaiVietTemp.HinhAnh);
                    String currentPath = Server.MapPath("~/Uploads/");
                    String fileName = "anh_dai_dien" + lpDTO.NgayDang.Value.Day.ToString()
                        + lpDTO.NgayDang.Value.Month.ToString() + lpDTO.NgayDang.Value.Year.ToString()
                        + lpDTO.NgayDang.Value.Hour.ToString() + lpDTO.NgayDang.Value.Minute.ToString() + lpDTO.NgayDang.Value.Second.ToString() + ".jpg";
                    lpDTO.HinhAnh = fileName;
                    this.fulImage.SaveAs(currentPath + fileName);
                    SaveImageThumbnail(currentPath + fileName, currentPath + fileName, true);
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
                    //Upload tập tin
                    List<TAPTINBAIVIET> lTapTinDTO = new List<TAPTINBAIVIET>();
                    string savePath = Server.MapPath("~/Uploads\\");
                    string fileName;
                    lTapTinDTO = (List<TAPTINBAIVIET>)Session["FileUploadTemp"];
                    List<HttpPostedFile> lFile = (List<HttpPostedFile>)Session["FileClientTemp"];
                    BUSTapTinBaiViet BUSTapTinBaiViet = new BUSTapTinBaiViet();
                    for (int i = 0; i < lTapTinDTO.Count && i < lFile.Count; i++)
                    {
                        lFile[i].SaveAs(savePath + lTapTinDTO[i].TenTapTin);
                        if (BUSTapTinBaiViet.Them(lTapTinDTO[i]) == 0)
                        {
                            MessageBox.Show("Upload tập tin " + lTapTinDTO[i].TenTapTin + " thất bại.");

                        }
                    }
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
        #region Đức sửa hàm Thêm 17/8
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
                    // SaveImageThumbnail(this.fulImage.FileName.)

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

        #region Upload file
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
   
                MessageBox.Show("Tập tin trùng với tập tin đã có trên csdl");
            }
            else
            {
                // Thong bao la da upload thanh cong               
                TAPTINBAIVIET ttbvDTO = new TAPTINBAIVIET();
                ttbvDTO.TenTapTin = fileName;
                string linkDir = "~/Uploads/" + fileName;
                ttbvDTO.DuongDan = linkDir;
                ttbvDTO.MaBaiViet = int.Parse(Request.QueryString["id"]);
                List<TAPTINBAIVIET> gvTapTinDS = (List<TAPTINBAIVIET>)Session["GridViewTapTinDataSource"];
                gvTapTinDS.Add(ttbvDTO);
                this.GridViewTapTin.DataSource = gvTapTinDS;
                this.GridViewTapTin.DataBind();
                FilterSTT(gvTapTinDS.Count, 0, 30);
                ((List<TAPTINBAIVIET>)Session["FileUploadTemp"]).Add(ttbvDTO);
                ((List<HttpPostedFile>)Session["FileClientTemp"]).Add(file);
            }

        }

        #endregion

        protected void imgBtnXoa_Click(object sender, ImageClickEventArgs e)
        {

        }


    }
}