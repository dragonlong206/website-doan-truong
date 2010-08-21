<%@ Page Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeFile="HoatDong.aspx.cs" Inherits="WebDoanHoi_layout.HoatDong" Title="Danh sách hoạt động" %>
<%@ Register TagPrefix="Auction" TagName="AuctionHoatDong" Src="~/wuc/wucHoatDong.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" Runat="Server">
    <Auction:AuctionHoatDong ID="controlHoatDong" Runat="Server" />

</asp:Content>

