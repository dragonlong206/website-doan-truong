<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="HeThongToChuc.aspx.cs" Inherits="HeThongToChuc" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionHeThongToChuc" Src="~/administration/templateLoad/BaiViet/wucHeThongToChuc.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionHeThongToChuc ID="controlHeThongToChuc" Runat="Server" />

</asp:Content>