﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExcelCOM = Microsoft.Office.Interop.Excel;
using DTOAuction;
using BUSAuction;

namespace WebDoanHoi_layout.wuc
{
    public partial class wucThongTinCaNhan : System.Web.UI.UserControl
    {
        int MaNguoiDung;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Thông tin cá nhân";

            if (Request.QueryString["id"]==null)
            {
                Response.Redirect("index.aspx");
            }

            MaNguoiDung = int.Parse(Request.QueryString["id"]);
            
            if(!IsPostBack)
            {
                LoadMaSinhVien();
                LoadData();
                LoadThongTinSinhVien();
            }
            this.ChangeProfileLink.NavigateUrl = "~/CapNhatThongTinCaNhan.aspx?id=" + Request.QueryString["id"].ToString();
            this.ChangePassWord.NavigateUrl = "~/index.aspx";
        }
        public void LoadData()
        {
            LoadDKMuonPhong();
            LoadDKHoatDong();
        }
        public void LoadDKMuonPhong()
        {
            GridViewDanhSachPhongMuon.HeaderStyle.CssClass = "headestyle";
            BUSAuction.BUSDangKyMuonPhong busDKMuonPhong = new BUSAuction.BUSDangKyMuonPhong();
            List<DTOAuction.DANGKYMUONPHONG> dsDKMuonPhong = busDKMuonPhong.TimKiemDANGKYMUONPHONGtheoSV(MaNguoiDung);
            //List<DTOAuction.DANGKYMUONPHONG> dsDKMuonPhong = busDKMuonPhong.SelectDANGKYMUONPHONGsAll();
            this.GridViewDanhSachPhongMuon.DataSource = dsDKMuonPhong;
            this.GridViewDanhSachPhongMuon.DataBind();
            FilterSTTDKMuonPhong(dsDKMuonPhong);
            for (int i = 0; i < GridViewDanhSachPhongMuon.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridViewDanhSachPhongMuon.Rows[i].FindControl("cbChonXoaMuonPhong");
                if (cb != null)
                {
                    cb.Checked = false;
                }
            }
        }
        public void LoadDKHoatDong()
        {
            GridViewHoatDong.HeaderStyle.CssClass = "headerstyle";
            BUSAuction.BUSDangKyHoatDong busDKHoatDong = new BUSAuction.BUSDangKyHoatDong();
            List<DTOAuction.DANGKYHOATDONG> dsDKHoatDong = busDKHoatDong.TimKiemTheoMaSinhVien(MaNguoiDung);
            //List<DTOAuction.DANGKYHOATDONG> dsDKHoatDong = busDKHoatDong.SelectDANGKYHOATDONGsAll();
            this.GridViewHoatDong.DataSource = dsDKHoatDong;
            this.GridViewHoatDong.DataBind();
            FilterSTTDKHoatDong(dsDKHoatDong);
            ConvertMaHoatDongToTenHoatDong(dsDKHoatDong);
            for (int i = 0; i < GridViewHoatDong.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridViewHoatDong.Rows[i].FindControl("cbChonXoaHoatDong");
                if (cb != null)
                {
                    cb.Checked = false;
                }
            }
        }
        public void FilterSTTDKMuonPhong(List<DTOAuction.DANGKYMUONPHONG> dsDKMuonPhong)
        {
            for (int i = 0; i < dsDKMuonPhong.Count; i++)
            {
                this.GridViewDanhSachPhongMuon.Rows[i].Cells[0].Text = (i + 1).ToString();
            }
        }
        public void FilterSTTDKHoatDong(List<DTOAuction.DANGKYHOATDONG> dsDKHoatDong)
        {
            for (int i = 0; i < dsDKHoatDong.Count; i++)
            {
                this.GridViewHoatDong.Rows[i].Cells[0].Text = (i + 1).ToString();
            }
        }
        public void LoadThongTinSinhVien()
        {
            BUSAuction.BUSNguoiDung busNguoiDung = new BUSAuction.BUSNguoiDung();
            DTOAuction.NGUOIDUNG nguoiDung = busNguoiDung.TimKiem(MaNguoiDung);
            if (nguoiDung != null)
            {
                TxbHoTen.Text = nguoiDung.HoTen;
                TxbMaSV.Text = nguoiDung.Username.ToString();
                BUSAuction.BUSLoaiVaiTro busLoaiVaiTro = new BUSAuction.BUSLoaiVaiTro();
                DTOAuction.LOAIVAITRO loaiVaiTro = busLoaiVaiTro.TimKiem(int.Parse(nguoiDung.MaVaiTro.ToString()));
                TxbVaiTro.Text = loaiVaiTro.TenLoaiVaiTro;
                TxbEmail.Text = nguoiDung.Email;
            }
        }
        private void LoadMaSinhVien()
        {
            string tempMa = Request.QueryString["id"];
            if (tempMa != null)
            {
                MaNguoiDung = int.Parse(tempMa);
            }
            else
            {
                MaNguoiDung = 1;
            }
        }
        public void ConvertMaHoatDongToTenHoatDong(List<DTOAuction.DANGKYHOATDONG> dsDangKyHoatDong)
        {
            DTOAuction.HOATDONG aHoatDong;
            BUSAuction.BUSHoatDong busHoatDong = new BUSAuction.BUSHoatDong();
            for (int i = 0; i < dsDangKyHoatDong.Count; i++)
            {
                aHoatDong = busHoatDong.TimKiem(dsDangKyHoatDong[i].MaHoatDong);
                Label lbl = (Label)GridViewHoatDong.Rows[i].FindControl("LblTenHoatDong");
                if (lbl != null)
                {
                    lbl.Text = aHoatDong.TenHoatDong;
                }
            }
        }

        protected void BtbHuyDangKyHoatDong_Click(object sender, EventArgs e)
        {
            BUSAuction.BUSDangKyHoatDong busDKHoatDong = new BUSAuction.BUSDangKyHoatDong();
            for (int i = 0; i < GridViewHoatDong.Rows.Count; i++)
            {
                CheckBox ckb = (CheckBox)GridViewHoatDong.Rows[i].FindControl("cbChonXoaHoatDong");
                if (ckb!=null && ckb.Checked == true)
                {
                    busDKHoatDong.Xoa(busDKHoatDong.TimKiem(MaNguoiDung, int.Parse(GridViewHoatDong.Rows[i].Cells[1].Text)));
                    //ckb.Checked = false;
                }
            }
            LoadMaSinhVien();
            LoadData();
            LoadThongTinSinhVien();
        }
        protected void XoaDangKyMuonPhong_Click(object sender, EventArgs e)
        {
            BUSAuction.BUSDangKyMuonPhong busDKMuonPhong = new BUSAuction.BUSDangKyMuonPhong();
            for (int i = 0; i < GridViewDanhSachPhongMuon.Rows.Count; i++)
            {
                CheckBox ckb = (CheckBox)GridViewDanhSachPhongMuon.Rows[i].FindControl("cbChonXoaMuonPhong");
                if (ckb != null && ckb.Checked)
                {
                    busDKMuonPhong.Xoa(int.Parse(GridViewDanhSachPhongMuon.Rows[i].Cells[1].Text));
                    //ckb.Checked = false;
                }
            }
            LoadMaSinhVien();
            LoadData();
            LoadThongTinSinhVien();
        }

        protected void btExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        protected void ExportToExcel()
        {
            string path = "E:\\abc.xls";



            ExcelCOM.Application app = new ExcelCOM.Application();
            ExcelCOM.Workbook workbook = app.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
            ExcelCOM.Worksheet sheet = (ExcelCOM.Worksheet)workbook.Worksheets[1];

            sheet.Name = "Danh Sách Hoạt Động Đăng Ký";

            WriteTitle(sheet);
            WriteDataGridView(sheet);

            app.Visible = false;
            workbook.SaveAs(path, ExcelCOM.XlFileFormat.xlWorkbookNormal,
                            null, null, false, false,
                            ExcelCOM.XlSaveAsAccessMode.xlExclusive,
                            false, false, false, false, false);

            workbook.Close(false, false, false);
            app.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }

        protected void WriteTitle(ExcelCOM.Worksheet worksheet)
        {
            ExcelCOM.Range sheetTitle = (ExcelCOM.Range)worksheet.get_Range("A1", "C1");
            sheetTitle.MergeCells = true;
            sheetTitle.Value2 = "Danh Sách Chi Tiết Hoạt Động Đăng Ký Của " + TxbHoTen.Text + " ( MSSV: " + TxbMaSV.Text + ")";
            sheetTitle.Font.Bold = true;
            sheetTitle.Font.Size = 20;
            sheetTitle.HorizontalAlignment = ExcelCOM.XlHAlign.xlHAlignCenter;
            sheetTitle.Rows.AutoFit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(sheetTitle);

            for (int i = 0; i < GridViewHoatDong.Columns.Count - 1; i++)
            {
                WriteIndexColumn(worksheet, 3, i + 1, GridViewHoatDong.Columns[i].ToString());
            }
        }

        protected void WriteIndexColumn(ExcelCOM.Worksheet worksheet, int rowIndex, int colIndex, object value)
        {
            ExcelCOM.Range rng = (ExcelCOM.Range)worksheet.Cells[rowIndex, colIndex];
            rng.Select();
            rng.Value2 = value.ToString();
            rng.Columns.EntireColumn.AutoFit();
            rng.Rows.EntireRow.AutoFit();
            rng.Borders.Weight = ExcelCOM.XlBorderWeight.xlThin;
            rng.Borders.LineStyle = ExcelCOM.XlLineStyle.xlContinuous;
            rng.Borders.ColorIndex = ExcelCOM.XlColorIndex.xlColorIndexAutomatic;
            rng.Font.Bold = true;
            rng.Font.Underline = true;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(rng);
        }

        protected void WriteDataGridView(ExcelCOM.Worksheet worksheet)
        {
            int rowIndex = 4;
            int colIndex = 1;

            for (int i = 0; i < GridViewHoatDong.Rows.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    WriteData(worksheet, i + rowIndex, j + colIndex, GridViewHoatDong.Rows[i].Cells[j].Text);
                }

                BUSAuction.BUSHoatDong bushoatdong = new BUSAuction.BUSHoatDong();
                DTOAuction.HOATDONG hoatdong = bushoatdong.TimKiem(int.Parse(GridViewHoatDong.Rows[i].Cells[1].Text));
                WriteData(worksheet, i + rowIndex, 3, hoatdong.TenHoatDong);
            }
        }

        protected void WriteData(ExcelCOM.Worksheet worksheet, int rowIndex, int colIndex, object value)
        {
            ExcelCOM.Range rng = (ExcelCOM.Range)worksheet.Cells[rowIndex, colIndex];
            rng.Select();
            rng.Value2 = value.ToString();
            rng.Columns.EntireColumn.AutoFit();
            rng.Rows.EntireRow.AutoFit();
            rng.Borders.Weight = ExcelCOM.XlBorderWeight.xlThin;
            rng.Borders.LineStyle = ExcelCOM.XlLineStyle.xlContinuous;
            rng.Borders.ColorIndex = ExcelCOM.XlColorIndex.xlColorIndexAutomatic;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(rng);
        }
    }
}