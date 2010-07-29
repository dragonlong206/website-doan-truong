<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="NguoiDung.aspx.cs" Inherits="administration_NguoiDung" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionNguoiDung" Src="~/administration/templateLoad/NguoiDung/wucNguoiDung.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionNguoiDung ID="controlNguoiDung" Runat="Server" />

</asp:Content>

