<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="ThongBao.aspx.cs" Inherits="ThongBao" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionThongBao" Src="~/administration/templateLoad/HoatDong/wucThongBao.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionThongBao ID="controlThongBao" Runat="Server" />

</asp:Content>
