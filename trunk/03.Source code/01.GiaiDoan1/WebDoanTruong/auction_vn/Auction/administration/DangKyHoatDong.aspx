<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="DangKyHoatDong.aspx.cs" Inherits="DangKyHoatDong" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionDangKyHoatDong" Src="~/administration/templateLoad/HoatDong/wucDangKyHoatDong.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyDangKyHoatDong" Src="~/administration/templateQuanLy/HoatDong/wucQuanLyDangKyHoatDong.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionDangKyHoatDong ID="controlDangKyHoatDong" Runat="Server" />
     <asp:Panel ID="Panel1" runat="server">
        <Auction:AuctionQuanLyDangKyHoatDong ID="controlQuanLyDangKyHoatDong" Runat="Server" />
    </asp:Panel>
</asp:Content>

