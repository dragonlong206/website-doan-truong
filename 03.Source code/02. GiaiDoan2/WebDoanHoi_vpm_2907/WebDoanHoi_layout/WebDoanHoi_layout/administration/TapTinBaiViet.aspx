<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="TapTinBaiViet.aspx.cs" Inherits="administration_TapTinBaiViet" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionTapTinBaiViet" Src="~/administration/templateLoad/BaiViet/wucTapTinBaiViet.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionTapTinBaiViet ID="controlTapTinBaiViet" Runat="Server" />

</asp:Content>

