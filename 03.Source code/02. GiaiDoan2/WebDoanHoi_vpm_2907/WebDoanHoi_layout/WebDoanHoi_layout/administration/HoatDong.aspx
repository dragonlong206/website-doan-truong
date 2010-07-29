<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/AdminDefault.master" AutoEventWireup="true" CodeBehind="HoatDong.aspx.cs" Inherits="WebDoanHoi_layout.administration.HoatDong" %>
<%@ Register src="templateLoad/HoatDong/wucHoatDong.ascx" tagname="wucHoatDong" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" runat="server">

    <uc1:wucHoatDong ID="wucHoatDong1" runat="server" />

</asp:Content>
