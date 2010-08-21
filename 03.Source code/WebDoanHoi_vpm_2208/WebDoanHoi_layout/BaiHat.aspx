<%@ Page Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeBehind="BaiHat.aspx.cs" Inherits="WebDoanHoi_layout.BaiHat1" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionBaiHat" Src="~/wuc/wucBaiHat.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <Auction:AuctionBaiHat ID="controlBaiHat" Runat="Server" />
</asp:Content>
