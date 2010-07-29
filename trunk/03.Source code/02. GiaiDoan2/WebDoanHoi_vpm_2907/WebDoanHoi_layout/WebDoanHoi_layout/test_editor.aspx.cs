using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDoanHoi_layout
{
    public partial class test_editor : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var qr = from bv in db.baiviets
                     select bv;
            GridView1.DataSource = qr.ToArray();
            GridView1.DataBind();
        }
        public void alert(string info)
        {
            string script = "<script type='text/javascript'>";
            script += "alert('";
            script += info;
            script += "')";
            script += "</script>";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", script);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baiviet bv = new baiviet
            {
                noidung = FCKeditor1.Value
            };
            db.baiviets.InsertOnSubmit(bv);
            db.SubmitChanges();
            FCKeditor1.Value = null;
            Page_Load(null, null);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var qr = from bv in db.baiviets
                     where bv.idbaiviet == 16
                     select bv.noidung;
            Literal1.Text = qr.Single();
            Label1.Text = qr.Single();
        }
    }
}
