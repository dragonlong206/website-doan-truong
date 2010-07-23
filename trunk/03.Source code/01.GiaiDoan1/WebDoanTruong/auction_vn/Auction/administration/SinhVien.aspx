<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="SinhVien.aspx.cs" Inherits="SinhVien" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionSinhVien" Src="~/administration/templateLoad/NguoiDung/wucSinhVien.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLySinhVien" Src="~/administration/templateQuanLy/NguoiDung/wucQuanLySinhVien.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionSinhVien ID="controlSinhVien" Runat="Server" />
    <asp:Panel ID="Panel1" runat="server">
        <Auction:AuctionQuanLySinhVien ID="controlQuanLySinhVien" Runat="Server" />
    </asp:Panel>
</asp:Content>
