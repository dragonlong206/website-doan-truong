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
            <asp:Login ID="LoginAdmin" runat="server" LoginButtonText="Đăng Nhập" 
                PasswordLabelText="Mật khẩu" RememberMeText="Ghi nhớ" 
                TitleText="Đăng nhâp" 
                FailureText="Đăng nhập chưa thành công. Vui lòng thử lại lần nữa!" 
                onauthenticate="LoginAdmin_Authenticate" UserNameLabelText="Tên đăng nhập">
                </asp:Login>
        </tr>

    </table>
</asp:Panel>
    </div>
    </form>
</body>
</html>
