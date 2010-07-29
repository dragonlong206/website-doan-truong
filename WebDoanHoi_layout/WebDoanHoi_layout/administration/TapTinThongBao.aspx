<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="TapTinThongBao.aspx.cs" Inherits="administration_TapTinThongBao" Title="Untitled Page" %>

<%@ Register TagPrefix="Auction" TagName="AuctionTapTinThongBao" Src="~/administration/templateLoad/HoatDong/wucTapTinThongBao.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionTapTinThongBao ID="controlTapTinThongBao" Runat="Server" />

</asp:Content>



