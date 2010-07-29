<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="DangKyHoatDong.aspx.cs" Inherits="DangKyHoatDong" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionDangKyHoatDong" Src="~/administration/templateLoad/HoatDong/wucDangKyHoatDong.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionDangKyHoatDong ID="controlDangKyHoatDong" Runat="Server" />

</asp:Content>

