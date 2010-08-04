<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucHoatDongSearch.ascx.cs" Inherits="WebDoanHoi_layout.wuc.search.wucHoatDongSearch" %>
<p>
    Tên họat động&nbsp;
</p>
<p>
    &nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Width="305px"></asp:TextBox>
</p>
<p>
    Thời gian diễn ra </p>
<p>
    <i>Từ </i>
    <asp:TextBox ID="TextBox2" runat="server" Width="131px"></asp:TextBox>
&nbsp;<i>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" 
        ImageUrl="~/images/calenicon.jpg" Width="28px" 
        onclick="ImageButton1_Click" />
    đến
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton2" runat="server" Height="22px" 
        ImageUrl="~/images/calenicon.jpg" Width="28px" />
    </i>
</p>
<p>
    <asp:Calendar ID="Calendar1" runat="server" Visible ="false" ></asp:Calendar>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Tìm" Width="110px" />
</p>