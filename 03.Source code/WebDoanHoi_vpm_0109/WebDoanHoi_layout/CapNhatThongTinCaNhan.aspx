<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/main_3col.Master" AutoEventWireup="true" CodeFile="CapNhatThongTinCaNhan.aspx.cs" Inherits="CapNhatThongTinCaNhan" %>
<%@ Register TagPrefix="Auction" TagName="AuctionCapNhatThongTinCaNhan" Src="~/wuc/wucCapNhatThongTinCaNhan.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" Runat="Server">
<Auction:AuctionCapNhatThongTinCaNhan ID="controlCapNhatThongTinCaNhan" runat="server" />
</asp:Content>

