<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebDoanHoi_layout.administration.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="PanelDangNhap" runat="server" Width="459px">
<table style="width: 500px;">
        <tr>
            <td align="center" colspan="2">
                &nbsp;
            &nbsp;
            &nbsp;
            ĐĂNG NHẬP</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;
                <asp:Label ID="Label1" runat="server" Text="Tên Đăng Nhập"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtusername" runat="server"> </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtusername" ErrorMessage="Nhập Tên Đăng Nhập">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Mật Khẩu"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtpassword" ErrorMessage="Nhập Mật Khẩu">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="btDangNhap" runat="server" Text="Đăng Nhập" Width="125px" 
                    onclick="btDangNhap_Click" />
            </td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
                <asp:Label ID="LabelError" runat="server" ForeColor="Red" Text="Label" 
                    Visible="False"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Panel>
    </div>
    </form>
</body>
</html>
