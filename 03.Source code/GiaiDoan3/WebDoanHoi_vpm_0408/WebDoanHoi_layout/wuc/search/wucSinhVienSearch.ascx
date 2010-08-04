<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucSinhVienSearch.ascx.cs" Inherits="WebDoanHoi_layout.wuc.search.wucSinhVienSearch" %>
<>
<p>
    Tài Khoản&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
</p>
<p>
    Họ tên người dùng
</p>
<p>
    <asp:TextBox ID="TextBox2" runat="server" Width="209px"></asp:TextBox>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click"
        style="text-align: center" Text="Tìm" Width="94px" 
        onclientclick="Button1_Click" />
</p>

<%if (lstNguoiDung != null)
  {
      Response.Write(@"<p>Kết quả tìm kiếm</p>");    
  }
      %>
      <asp:GridView ID="GridView1"  runat="server">
</asp:GridView>