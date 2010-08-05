<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucDangNhap.ascx.cs"
    Inherits="WebDoanHoi_layout.wuc.wucDangNhap" %>
<div class="module">
    <div class="post-title">
        Đăng nhập
    </div>
    <div class="post-content">
        <asp:Panel ID="PanelDangNhap" runat="server">
            <table cellpadding="1px" cellspacing="1px" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Tên đăng nhập"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtusername" runat="server" BorderColor="Black" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Mật khẩu"></asp:Label>
                        &nbsp; - &nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/QuenMatKhau.aspx#">Quên mật khẩu</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" BorderColor="Black"
                            BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btDangNhap" runat="server" Text="Đăng Nhập" OnClick="btDangNhap_Click"
                            Style="height: 26px" />
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
                    <tr>
                        <td style="text-align: center">
                            <asp:HyperLink ID="hlhoten" runat="server"></asp:HyperLink>
                        </td>
                    </tr>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="hlVaiTro" runat="server"></asp:HyperLink>
                        -
                        <asp:Button ID="btDangXuat" runat="server" Text="Đăng Xuất" OnClick="btDangXuat_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</div>