<%@ Page Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" 
CodeBehind="HeThongToChuc.aspx.cs" Inherits="WebDoanHoi_layout.HeThongToChuc" 
Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <div id="BVNoiBatDiv">
    <asp:Panel ID="PanelNoiDungChiTiet" runat="server">
        <div class="post-content">
        <div class="tieude" style="margin-top: 5px;">
            <center>
                <asp:Label ID="lblTieuDe" runat="server" Text="Label"></asp:Label></center>
        </div>
        <p style="margin-top: 10px; margin-left: 5px;">
            <asp:Label ID="lblNoiDungBaiViet" runat="server" Text="Label"></asp:Label>
        </p>

    </div>
    </asp:Panel>
    
    <asp:Panel ID="PanelNoiDungAll" runat="server">
        <asp:Label ID="ltrNoiDung" runat="server"  ></asp:Label>
    </asp:Panel>
    </div>
</asp:Content>
