﻿<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="NguoiDung.aspx.cs" Inherits="administration_NguoiDung" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionNguoiDung" Src="~/administration/templateLoad/NguoiDung/wucNguoiDung.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyNguoiDung" Src="~/administration/templateQuanLy/NguoiDung/wucQuanLyNguoiDung.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionNguoiDung ID="controlNguoiDung" Runat="Server" />
     <asp:Panel ID="Panel2" runat="server">
        <Auction:AuctionQuanLyNguoiDung ID="AuctionQuanLyNguoiDung" Runat="Server" />
    </asp:Panel>
</asp:Content>

