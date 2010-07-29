<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="KhaoSat.aspx.cs" Inherits="administration_KhaoSat" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionKhaoSat" Src="~/administration/templateLoad/KhaoSat/wucKhaoSat.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionKhaoSat ID="controlKhaoSat" Runat="Server" />

</asp:Content>

