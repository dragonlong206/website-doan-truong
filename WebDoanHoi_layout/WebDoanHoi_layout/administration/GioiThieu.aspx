<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="GioiThieu.aspx.cs" Inherits="GioiThieu" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionGioiThieu" Src="~/administration/templateLoad/BaiViet/wucGioiThieu.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionGioiThieu ID="controlGioiThieu" Runat="Server" />

</asp:Content>