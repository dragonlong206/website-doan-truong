﻿<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="Album.aspx.cs" Inherits="Album" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionAlbum" Src="~/administration/templateLoad/Album/wucAlbum.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionAlbum ID="controlAlbum" Runat="Server" />
    

</asp:Content>

