<%@ Page Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="WebDoanHoi_layout.DoiMatKhau" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
<table style="width: 47%" align="center">
        <tr>
            <td style="width: 158px">
                Mật khẩu cũ:</td>
            <td>
                <asp:TextBox ID="txtMatKhauCu" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 158px">
                Mật khẩu mới:</td>
            <td>
                <asp:TextBox ID="txtMatKhauMoi" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 158px">
                Xác nhận mật khẩu:</td>
            <td>
                <asp:TextBox ID="txtXacNhan" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btThayDoi" runat="server" onclick="btThayDoi_Click" 
                    Text="Thay Đổi" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Literal ID="txtThongTin" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>
</asp:Content>
