<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="WebDoanHoi_layout.wuc.header" %>
<img src="../images/top_banner.jpg" alt="banner" />
<!-- navigation end -->
<div id="navigation">
    <asp:Menu ID="Menu1" runat="server">
    </asp:Menu>
</div>
<div id="menu">
    <asp:Label ID="txtTime" runat="server"></asp:Label>
    &nbsp;- Văn bản - tài liệu
    <asp:DropDownList ID="ddlLienKet" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlLienKet_SelectedIndexChanged">
        <asp:ListItem Value="0">Trang web liên kết</asp:ListItem>
        <asp:ListItem Value="http://www.vnuhcm.edu.vn/">Đại học Quốc gia TP.HCM</asp:ListItem>
        <asp:ListItem Value="http://hcmus.edu.vn/">Trường DH KHTN TP.HCM</asp:ListItem>
        <asp:ListItem Value="http://www.fit.hcmus.edu.vn/vn/">Khoa CNTT</asp:ListItem>
        <asp:ListItem Value="http://www.thanhdoan.hochiminhcity.gov.vn/webtd/vn/Home.aspx">Thành 
        Đoàn TP.HCM</asp:ListItem>
        <asp:ListItem Value="http://tuoitre.vn/">Báo Tuổi Trẻ</asp:ListItem>
        <asp:ListItem Value="http://www.thanhnien.com.vn/pages/default.aspx">Báo Thanh 
        Niên</asp:ListItem>
    </asp:DropDownList>
</div>