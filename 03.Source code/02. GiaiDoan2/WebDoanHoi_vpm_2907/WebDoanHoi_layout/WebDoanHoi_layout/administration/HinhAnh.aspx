<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="HinhAnh.aspx.cs" Inherits="HinhAnh" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionHinhAnh" Src="~/administration/templateLoad/Album/wucHinhAnh.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
 <Auction:AuctionHinhAnh ID="controlHinhAnh" Runat="Server" />

</asp:Content>