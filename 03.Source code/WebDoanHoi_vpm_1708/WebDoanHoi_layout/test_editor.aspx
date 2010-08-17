<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test_editor.aspx.cs" Inherits="WebDoanHoi_layout.test_editor" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Tiêu đề:<asp:TextBox ID="txtTieuDe" runat="server"></asp:TextBox><br />
    </div>
    <div>
        Tóm tắt:<asp:TextBox ID="txtTomTat" runat="server" Height="200px" 
            TextMode="MultiLine" Width="300px"></asp:TextBox>
    </div>
    <div>
        Nội dung<br />
        <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server">
        </FCKeditorV2:FCKeditor>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
