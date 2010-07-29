<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="CauHoiKhaoSat.aspx.cs" Inherits="CauHoiKhaoSat" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionCauHoiKhaoSat" Src="~/administration/templateLoad/KhaoSat/wucCauHoiKhaoSat.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionCauHoiKhaoSat ID="controlCauHoiKhaoSat" Runat="Server" />
    
 
</asp:Content>