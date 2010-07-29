<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="ChuyenMuc.aspx.cs" Inherits="ChuyenMuc" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionChuyenMuc" Src="~/administration/templateLoad/BaiViet/wucChuyenMuc.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionChuyenMuc ID="controlChuyenMuc" Runat="Server" />

</asp:Content>