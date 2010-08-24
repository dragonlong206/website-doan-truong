<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="WebDoanHoi_layout.wuc.header" %>
<html lang="en" xml:lang="en" xmlns="http://www.w3.org/1999/xhtml"><head>
<link href="../css/style.css" type="text/css" rel=Stylesheet />
<meta content="text/html; charset=iso-8859-1" http-equiv="Content-Type">
<object width="1024" height="256" align="middle" id="title" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000">
<param value="sameDomain" name="allowScriptAccess">
<param value="title.swf" name="movie">
<param value="high" name="quality">
<param value="#ffffff" name="bgcolor">

<embed width="1024" height="256" allowscriptaccess="always" wmode="transparent" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" src="Uploads/title.swf">
</object>
</html>
<!-- navigation end -->
<!-- navigation end -->
<div>
    <asp:Label ID="lblMenu" runat="server" Text="Label"></asp:Label>
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