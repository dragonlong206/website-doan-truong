<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="BaiHat.aspx.cs" Inherits="BaiHat" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionBaiHat" Src="~/administration/templateLoad/BaiHat/wucBaiHat.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyBaiHat" Src="~/administration/templateQuanLy/BaiHat/wucQuanLyBaiHat.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionBaiHat ID="controlBaiHat" Runat="Server" />
     <asp:Panel ID="Panel1" runat="server">
        <Auction:AuctionQuanLyBaiHat ID="controlQuanLyBaiHat" Runat="Server" />
    </asp:Panel>

</asp:Content>
