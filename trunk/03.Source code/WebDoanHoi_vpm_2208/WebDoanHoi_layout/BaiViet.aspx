﻿<%@ Page Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true"
    CodeBehind="BaiViet.aspx.cs" Inherits="WebDoanHoi_layout.BaiViet" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <div class="post-content">
        <div class="tieude" style="margin-top: 5px;">
            <center>
                <asp:Label ID="lblTieuDe" runat="server" Text="Label"></asp:Label></center>
        </div>
        <div style="text-align: right; color: Blue; margin-top: 5px;">
            <asp:Label ID="lblNgayDang" runat="server" Text="Label"></asp:Label>
        </div>
        <p style="margin-top: 10px; margin-left: 5px;">
            <asp:Label ID="lblNoiDungBaiViet" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="margin-top: 10px;">
            <hr />
        </p>
        <asp:Panel ID="PanelDownload" runat="server">
            <asp:HyperLink ID="hplDownloadLink" runat="server"></asp:HyperLink>
        </asp:Panel>
    </div>
</asp:Content>