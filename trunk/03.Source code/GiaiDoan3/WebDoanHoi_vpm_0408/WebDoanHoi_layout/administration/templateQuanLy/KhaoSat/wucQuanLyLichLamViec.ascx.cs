using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSAuction;
using DTOAuction;
using System.Windows.Forms;

namespace WebDoanHoi_layout.administration.templateQuanLy.KhaoSat
{
    public partial class wucLichLamViec : System.Web.UI.UserControl
    {
        #region Ham Chung
        protected void Page_Load(object sender, EventArgs e)
        {
            //Thong tin nguoi dung
            NGUOIDUNG a = new NGUOIDUNG();
            a.MaNguoiDung = 1;
            Session["NguoiDung"] = a;

            if(!IsPostBack)
                
            if (Request.QueryString["id"] != null)
            {
                int maTapTin = int.Parse(Request.QueryString["id"]);

                //lay thong tin va load len cac textbox
                BUSTapTinBaiViet busTapTinBaiViet = new BUSTapTinBaiViet();
                TAPTINBAIVIET tt = busTapTinBaiViet.TimKiemMaTapTin(maTapTin);

                string name = tt.TenTapTin.ToString();
                int subIndex = name.IndexOf('-');
                string dateStart = name.Substring(0, subIndex);
                string dateEnd = name.Substring(subIndex, name.Length - subIndex);
                txtNgayBatDau.Text = dateStart;
                txtNgayKetThuc.Text = dateEnd;
            }
                
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
              if (Request.QueryString["id"] != null)
                {
                    int maTapTin = int.Parse(Request.QueryString["id"]);
                    //lay thong tin tu textbox
                    BUSTapTinBaiViet busTapTinBaiViet = new BUSTapTinBaiViet();
                    TAPTINBAIVIET tt = busTapTinBaiViet.TimKiemMaTapTin(maTapTin);
                    SaveFile(FileUploadLichLamViec.PostedFile);
                }
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (FileUploadLichLamViec.HasFile)
                SaveFile(FileUploadLichLamViec.PostedFile);
            else
                LabelUploadStatus.Text = "Bạn vẫn chưa chọn file để upload.";
        }
        void SaveFile(HttpPostedFile file)
        {
            //Duong dan den thu muc Uploads tren server
            string savePath = Server.MapPath("~/Uploads\\");

            // Ten file upload
            string originalFileName = FileUploadLichLamViec.FileName;
            int pointIndex = originalFileName.LastIndexOf('.');
            string extension =  originalFileName.Substring(pointIndex,originalFileName.Length - pointIndex);

            string dateStart = txtNgayBatDau.Text;
            string dateEnd = txtNgayKetThuc.Text;
            string textFileName = dateStart + "-" + dateEnd;

            while (dateStart.IndexOf('/') > -1)
            {
                dateStart = dateStart.Remove(dateStart.IndexOf('/'), 1);
            }
            while (dateEnd.IndexOf('/') > -1)
            {
                dateEnd = dateEnd.Remove(dateEnd.IndexOf('/'), 1);
            }

            string fileName = dateStart + "-" + dateEnd + extension;
            
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
            }

            savePath += fileName;

            //Luu file
            FileUploadLichLamViec.SaveAs(savePath);

            //Duong dan de tai file
            string linkDir = "~/Uploads/" + fileName;

            //Them vao bang TapTin
            //id la tham so truyen vao url, la id cua bai viet lien quan den tap tin

                if (overwrite == false)
                {
                    int maBaiViet = 19;

                    BUSTapTinBaiViet busTapTin = new BUSTapTinBaiViet();
                    int numberTapTin = busTapTin.TimSoLuongTapTin();
                    TAPTINBAIVIET lpDTO = new TAPTINBAIVIET();
                    lpDTO.TenTapTin = textFileName;
                    lpDTO.DuongDan = linkDir;
                    lpDTO.MaBaiViet = maBaiViet;
                    lpDTO.MaTapTin = numberTapTin + 1;
                    busTapTin.Them(lpDTO);
                }
                else
                {
                    int maBaiViet = 19;

                    BUSTapTinBaiViet busTapTin = new BUSTapTinBaiViet();
                    TAPTINBAIVIET lpDTO = busTapTin.TimKiemTenTapTin(fileName);

                    lpDTO.MaBaiViet = maBaiViet;
                    busTapTin.CapNhat(lpDTO);
                }
            }
        protected void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(Request.QueryString["id"] != null)
                {
                //lay thong tin tu textbox
                int maTapTin = int.Parse(Request.QueryString["id"]);

                //xac nhan truoc khi xoa
                DialogResult rs = MessageBox.Show("Bạn có chắc là muốn xoá Hoạt Động <" + maTapTin + "> không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //Goi ham xoa
                    BUSTapTinBaiViet BUSCauHoiKhaoSat = new BUSTapTinBaiViet();
                    if (BUSCauHoiKhaoSat.Xoa(maTapTin) == 0)
                    {
                        //Thong bao
                        LabelUploadStatus.Text = "Xóa Thành Công";
                        
                        //Response.Redirect("HoatDong.aspx");
                    }
                    else
                    {
                        LabelUploadStatus.Text = "Xóa Không Thành Công";
                        
                    }
                }
                }
                else
                {
                    Response.Redirect("HoatDong.aspx");
                }
            }

            catch (Exception ex)
            {
                LabelUploadStatus.Text = "Xoa Không Thành Công";
                
            }
        }
        #endregion
    }
}