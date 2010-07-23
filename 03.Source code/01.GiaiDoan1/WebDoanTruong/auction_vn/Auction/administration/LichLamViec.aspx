<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="LichLamViec.aspx.cs" Inherits="administration_LichLamViec" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionLichLamViec" Src="~/administration/templateLoad/LichLamViec/wucLichLamViec.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyLichLamViec" Src="~/administration/templateQuanLy/LichLamViec/wucQuanLyLichLamViec.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionLichLamViec ID="controlLichLamViec" Runat="Server" />
    <asp:Panel ID="Panel1" runat="server">
        <Auction:AuctionQuanLyLichLamViec ID="controlQuanLyLichLamViec" Runat="Server" />
    </asp:Panel>
</asp:Content>

