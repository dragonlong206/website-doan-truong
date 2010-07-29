<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true"
    CodeBehind="gioithieu.aspx.cs" Inherits="WebDoanHoi_layout.gioithieu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <div class="post">
        <div class="post-title">
            <asp:Label ID="txtTieuDe" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="post-content">
            <asp:Literal ID="txtNoiDung" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
