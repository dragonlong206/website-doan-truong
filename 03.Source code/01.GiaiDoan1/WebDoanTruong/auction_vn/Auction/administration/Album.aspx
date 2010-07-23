<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="Album.aspx.cs" Inherits="Album" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionAlbum" Src="~/administration/templateLoad/Album/wucAlbum.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyAlbum" Src="~/administration/templateQuanLy/Album/wucQuanLyAlBum.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionAlbum ID="controlAlbum" Runat="Server" />
    
    <asp:Panel ID="Panel1" runat="server">
        <Auction:AuctionQuanLyAlbum ID="controlQuanLyAlbum" Runat="Server" />
    </asp:Panel>
</asp:Content>

