<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/main_3col.Master" AutoEventWireup="true" CodeFile="ThongTinCaNhan.aspx.cs" Inherits="ThongTinCaNhan" %>
<%@ Register TagPrefix="Auction" TagName="AuctionThongTinCaNhan" Src="~/wuc/wucThongTinCaNhan.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" Runat="Server">
    <Auction:AuctionThongTinCaNhan ID="controlThongTinCaNhan" runat="server" />
</asp:Content>

