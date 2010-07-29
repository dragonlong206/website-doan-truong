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
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    <div>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Width="500px">
        </FCKeditorV2:FCKeditor>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
    </div>
    <div>
        <asp:Button ID="Button2" runat="server" Text="Show" onclick="Button2_Click" />
    </div>
    </form>
</body>
</html>
