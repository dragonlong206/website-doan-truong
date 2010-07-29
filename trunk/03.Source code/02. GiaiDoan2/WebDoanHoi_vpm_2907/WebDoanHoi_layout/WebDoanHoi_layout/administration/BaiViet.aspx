<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="BaiViet.aspx.cs" Inherits="BaiViet" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionBaiViet" Src="~/administration/templateLoad/BaiViet/wucBaiViet.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionBaiViet ID="controlBaiViet" Runat="Server" />

</asp:Content>


    
