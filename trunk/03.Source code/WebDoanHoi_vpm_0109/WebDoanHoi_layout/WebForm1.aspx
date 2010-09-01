<%@ Page Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebDoanHoi_layout.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">

<div class="post-content">
  <table cellpadding="10px">
            <tr>
                <td style="width: 30%" align="center" valign="middle">
                    <asp:Label ID="lblHinhAnh" runat="server" Text="Label" Width="100%"></asp:Label>
                </td>
                <td style="vertical-align:top">
                    <asp:Label ID="lblTieuDe" runat="server" Text="Label" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    <p>
                        <asp:Label ID="lblTomTat" runat="server" Text="Label"></asp:Label></p>
                </td>
            </tr>
        </table>
        <center>
            <hr style="margin: 5px 0px 5px 0px;" width="95%" />
        </center>
        <table style="text-align: center">
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
