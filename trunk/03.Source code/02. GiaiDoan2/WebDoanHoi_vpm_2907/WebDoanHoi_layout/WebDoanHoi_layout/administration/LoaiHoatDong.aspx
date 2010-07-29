<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="LoaiHoatDong.aspx.cs" Inherits="LoaiHoatDong" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionLoaiHoatDong" Src="~/administration/templateLoad/HoatDong/wucLoaiHoatDong.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionLoaiHoatDong ID="controlLoaiHoatDong" Runat="Server" />

</asp:Content>
