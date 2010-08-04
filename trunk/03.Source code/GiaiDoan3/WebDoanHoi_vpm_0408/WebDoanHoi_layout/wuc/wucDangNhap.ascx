<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucDangNhap.ascx.cs"
    Inherits="WebDoanHoi_layout.wuc.wucDangNhap" %>
<div>
    <asp:Panel ID="PanelDangNhap" runat="server">
        <table border="1" cellpadding=0 cellspacing=0>
            <tr>
                <td align="center" colspan="2">
                    ĐĂNG NHẬP
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="MSSV"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"> </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Mật khẩu:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="10pt">Quên mật khẩu</asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="btDangNhap" runat="server" Text="Đăng Nhập" 
                        OnClick="btDangNhap_Click" style="height: 26px" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="PanelDangXuat" runat="server">
        <table>
            <tr>
                <td>
                    Chào bạn
                </td>
                <td>
                    <asp:HyperLink ID="hlhoten" runat="server"></asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btDangXuat" runat="server" Text="Đăng Xuất" OnClick="btDangXuat_Click" />
                </td>
                <td>
                    <asp:HyperLink ID="hlVaiTro" runat="server"></asp:HyperLink>
                </td>
            </tr>
        </table>
    </asp:Panel>
</div>
