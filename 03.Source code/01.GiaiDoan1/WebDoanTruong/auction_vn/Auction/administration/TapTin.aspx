<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="LoaiBaiViet.aspx.cs" Inherits="administration_LoaiBaiViet" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionTapTin" Src="~/administration/templateLoad/BaiViet/wucTapTin.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyTapTin" Src="~/administration/templateQuanLy/BaiViet/wucQuanLyTapTin.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
 <Auction:AuctionTapTin ID="controlTapTin" Runat="Server" />
    <asp:Panel ID="Panel2" runat="server">
        <Auction:AuctionQuanLyTapTin ID="AuctionQuanLyTapTin" Runat="Server" />
    </asp:Panel>
</asp:Content>