using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDoanHoi_layout.wuc.search
{
    public partial class wucBaiVietSearch : System.Web.UI.UserControl
    {
        List<DTOAuction.BAIVIET> lstBaiViet;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
            Calendar2.Visible = false;            
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime tungay;
            DateTime denngay;
            tungay = Calendar1.SelectedDate;
            denngay = Calendar2.SelectedDate;
            BUSAuction.BUSBaiViet bv = new BUSAuction.BUSBaiViet();
            //lstBaiViet = bv.TimKiem(TextBox1.Text, TextBox2.Text, tungay, denngay);
            GridView1.DataSource = lstBaiViet;
            GridView1.DataBind();
            GridView1.AllowPaging = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = false;
        }
    }
}