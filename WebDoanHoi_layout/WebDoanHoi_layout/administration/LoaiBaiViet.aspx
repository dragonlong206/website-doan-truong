<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="LoaiBaiViet.aspx.cs" Inherits="administration_LoaiBaiViet" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionLoaiBaiViet" Src="~/administration/templateLoad/BaiViet/wucLoaiBaiViet.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionLoaiBaiViet ID="controlLoaiBaiViet" Runat="Server" />

</asp:Content>
