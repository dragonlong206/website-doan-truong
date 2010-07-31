<%@ Page Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true"
    CodeBehind="BaiViet.aspx.cs" Inherits="WebDoanHoi_layout.BaiViet" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <div>
        <center><asp:Label ID="lblTieuDe" runat="server" Text="Label"></asp:Label></center>
    </div>
    <div>
        <asp:Label ID="lblNgayDang" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblNoiDungBaiViet" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
