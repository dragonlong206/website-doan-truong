<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="ChuyenMuc.aspx.cs" Inherits="ChuyenMuc" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionChuyenMuc" Src="~/administration/templateLoad/BaiViet/wucChuyenMuc.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyChuyenMuc" Src="~/administration/templateQuanLy/BaiViet/wucQuanLyChuyenMuc.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionChuyenMuc ID="controlChuyenMuc" Runat="Server" />
    <asp:Panel ID="Panel2" runat="server">
        <Auction:AuctionQuanLyChuyenMuc ID="AuctionQuanLyChuyenMuc" Runat="Server" />
    </asp:Panel>
</asp:Content>