<%@ Page Title="DTN-HSV HCMUS" Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebDoanHoi_layout.index1" Theme="Blue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <div id="BVNoiBatDiv">
        <asp:Literal ID="Label1" runat="server" Text="txtTinNoiBat"></asp:Literal>
        <div id="DSBVNoiBatDiv">
            <div class="DSBVNoiBatDiv-area">
                <div class="imgDSBVNoiBatDiv">
                    <asp:Label ID="lblHinh1" runat="server" Text="Hinh1"></asp:Label>
                </div>
                <div class="DSBVNoiBatDiv-title">
                    <asp:Label ID="lblTieuDe1" runat="server" Text="TieuDe1"></asp:Label>
                </div>
            </div>
            <div class="DSBVNoiBatDiv-area">
                <div class="imgDSBVNoiBatDiv">
                    <asp:Label ID="lblHinh2" runat="server" Text="Hinh2"></asp:Label>
                </div>
                <div class="DSBVNoiBatDiv-title">
                    <asp:Label ID="lblTieuDe2" runat="server" Text="TieuDe2"></asp:Label>
                </div>
            </div>
            <div class="DSBVNoiBatDiv-area">
                <div class="imgDSBVNoiBatDiv">
                    <asp:Label ID="lblHinh3" runat="server" Text="Hinh3"></asp:Label>
                </div>
                <div class="DSBVNoiBatDiv-title">
                    <asp:Label ID="lblTieuDe3" runat="server" Text="TieuDe3"></asp:Label>
                </div>
            </div>
            <div class="DSBVNoiBatDiv-area">
                <div class="imgDSBVNoiBatDiv">
                    <asp:Label ID="lblHinh4" runat="server" Text="Hinh4"></asp:Label>
                </div>
                <div class="DSBVNoiBatDiv-title">
                    <asp:Label ID="lblTieuDe4" runat="server" Text="TieuDe4"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <asp:Label ID="lblChuyenMuc" runat="server" Text="Label"></asp:Label>
</asp:Content>



