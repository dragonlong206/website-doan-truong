<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Test_WebUserControl.ascx.cs" Inherits="WebDoanHoi_layout.Test_WebUserControl" %>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:LinkButton ID="LinkButton1" runat="server">Button1</asp:LinkButton>&nbsp;
<asp:LinkButton ID="LinkButton2" runat="server">Button2</asp:LinkButton>
&nbsp;
<asp:LinkButton ID="LinkButton3" runat="server">Button3</asp:LinkButton>
&nbsp;
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
    <asp:Label ID="lblNoiDung" runat="server" Text="Label"></asp:Label>
</ContentTemplate>
</asp:UpdatePanel>
