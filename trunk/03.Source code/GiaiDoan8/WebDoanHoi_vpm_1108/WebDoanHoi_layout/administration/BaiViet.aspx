<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminDefault.master" AutoEventWireup="true" CodeFile="BaiViet.aspx.cs" Inherits="BaiViet" Title="Untitled Page" %>
<%@ Register TagPrefix="Auction" TagName="AuctionBaiViet" Src="~/administration/templateLoad/BaiViet/wucBaiViet.ascx" %>
<%@ Register TagPrefix="Auction" TagName="AuctionQuanLyBaiViet" Src="~/administration/templateQuanLy/BaiViet/wucQuanLyBaiViet.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderAdmin" Runat="Server">
    <Auction:AuctionBaiViet ID="controlBaiViet" Runat="Server" />
    <asp:Panel ID="Panel2" runat="server">
        <Auction:AuctionQuanLyBaiViet ID="AuctionQuanLyBaiViet" Runat="Server" />
    </asp:Panel>
    <asp:Panel ID="PanelBtnUpload" runat="server" Style="margin-top: 10px;">
            <asp:Button ID="btnUploadFiles" runat="server" Text="Upload Files" OnClick="btnUploadFilesClick" />
        </asp:Panel>
        <asp:Panel ID="PanelUploadTapTinBaiViet" runat="server" Visible="false">
            <asp:FileUpload ID="FileUploadTapTin" runat="server" />
            <asp:Label ID="LabelUploadStatus" runat="server"></asp:Label>
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUploadClick" />
        </asp:Panel>
        <asp:Panel ID="PanelDownload" runat="server">
            <asp:HyperLink ID="hplDownloadLink" runat="server"></asp:HyperLink>
        </asp:Panel>
</asp:Content>


    
