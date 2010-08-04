<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucBaiVietSearch.ascx.cs" Inherits="WebDoanHoi_layout.wuc.search.wucBaiVietSearch" %>
<p>
    Tiêu đề&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
<p>
    Nội dung&nbsp;&nbsp;&nbsp;
</p>
<asp:TextBox ID="TextBox2" runat="server" Width="249px"></asp:TextBox>
<p>
    Ngày đăng&nbsp;
</p>
<p style="font-style: italic">
    Từ&nbsp;&nbsp;     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/images/calenicon.jpg" onclick="ImageButton1_Click" OnClientClick = "ImageButton1_Click" Width="20px" />
    <asp:Calendar ID="Calendar1" Visible = "false" runat="server" 
        onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
</p>
<p style="font-style: italic">
    Đến
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton2" runat="server" Height="19px" 
        ImageUrl="~/images/calenicon.jpg" onclick="ImageButton2_Click" OnClientClick = "ImageButton2_Click" Width="20px" />
    <asp:Calendar ID="Calendar2" Visible = "false" runat="server" 
        onselectionchanged="Calendar2_SelectionChanged" ></asp:Calendar>
</p>
<p style="margin-left: 80px">
    <asp:Button ID="Button1" runat="server" Text="Tìm" Width="79px" 
        onclick="Button1_Click" OnClientClick = "Button1_Click"/>
</p>
<p style="margin-left: 80px">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>

