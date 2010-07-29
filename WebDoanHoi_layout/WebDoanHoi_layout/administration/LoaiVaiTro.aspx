<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="LoaiVaiTro.aspx.cs" Inherits="administration_LoaiVaiTro" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionLoaiVaiTro" Src="~/administration/templateLoad/NguoiDung/wucLoaiVaiTro.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionLoaiVaiTro ID="controlLoaiVaiTro" Runat="Server" />

</asp:Content>
