<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="DangKyMuonPhong.aspx.cs" Inherits="DangKyMuonPhong" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionDangKyMuonPhong" Src="~/administration/templateLoad/Phong/wucDangKyMuonPhong.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionDangKyMuonPhong ID="controlDangKyMuonPhong" Runat="Server" />

</asp:Content>
