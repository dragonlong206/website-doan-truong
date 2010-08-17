<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="BaiViet.aspx.cs" Inherits="BaiViet" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionBaiViet" Src="~/administration/templateLoad/BaiViet/wucBaiViet.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyBaiViet" Src="~/administration/templateQuanLy/BaiViet/wucQuanLyBaiViet.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionBaiViet ID="controlBaiViet" Runat="Server" />
    <asp:Panel ID="Panel2" runat="server">
        <Auction:AuctionQuanLyBaiViet ID="AuctionQuanLyBaiViet" Runat="Server" />
    </asp:Panel>
</asp:Content>


    
