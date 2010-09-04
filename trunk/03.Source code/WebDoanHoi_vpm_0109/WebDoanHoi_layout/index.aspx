<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebDoanHoi_layout.index1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <div class="post-content">
            <asp:Label ID="Label1" runat="server" Text="txtTinNoiBat"></asp:Label>
            <br />
            
        <table style="text-align: center">
        <tr>
            <td colspan="3">
                <center>
                    <hr style="margin: 5px 0px 5px 0px;" width="95%" />
                </center>
            </td>
        </tr>
            <tr>
                <td style="width: 30%">
                    <asp:Label ID="lblHinh1" runat="server" Text="Hinh1"></asp:Label>
                </td>
                <td style="width: 30%">
                    <asp:Label ID="lblHinh2" runat="server" Text="Hinh2"></asp:Label>
                </td>
                <td style="width: 30%">
                    <asp:Label ID="lblHinh3" runat="server" Text="Hinh3"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTieuDe1" runat="server" Text="TieuDe1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblTieuDe2" runat="server" Text="TieuDe2"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblTieuDe3" runat="server" Text="TieuDe3"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblChuyenMuc" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>



