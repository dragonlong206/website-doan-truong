<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="HoatDong.aspx.cs" Inherits="HoatDong" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionHoatDong" Src="~/administration/templateLoad/HoatDong/wucHoatDong.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyHoatDong" Src="~/administration/templateQuanLy/HoatDong/wucQuanLyHoatDong.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionHoatDong ID="controlHoatDong" Runat="Server" />
    <asp:Panel ID="Panel1" runat="server">
        <Auction:AuctionQuanLyHoatDong ID="controlQuanLyHoatDong" Runat="Server" />
    </asp:Panel>
</asp:Content>



