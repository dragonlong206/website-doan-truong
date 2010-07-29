<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="DapAnKhaoSat.aspx.cs" Inherits="DanAnKhaoSat" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionDapAnKhaoSat" Src="~/administration/templateLoad/KhaoSat/wucDapAnKhaoSat.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionDapAnKhaoSat ID="controlDapAnKhaoSat" Runat="Server" />

</asp:Content>

