<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebDoanHoi_layout.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <table style="width: 594px;">
        <tr>
            <td style =" width:150px; height:150px" rowspan="2">
                
                <asp:Label ID="lblHinhAnh" runat="server" Text="Label"></asp:Label>
            </td>
            <td style ="height:50px; width:444px; font-family:Arial; font-size:larger; color:Red; vertical-align:top">
                <asp:Label ID="lblTieuDe" runat="server" Text="Label"></asp:Label>
            </td>            
        </tr>
        <tr>
            <td style ="height:100px; width:444px; font-family:Times New Roman; vertical-align:top">
                <asp:Label ID="lblTomTat" runat="server" Text="Label"></asp:Label>
                
            </td>            
        </tr>
       
    </table>
   
     <hr />
    <table style="width: 594px;">
        <tr>
            <td style="width: 198px;">
                <asp:Label ID="lblHinh1" runat="server" Text="Hinh1"></asp:Label>
            </td>
            <td style="width: 198px;">
                <asp:Label ID="lblHinh2" runat="server" Text="Hinh2"></asp:Label>
            </td>
            <td style="width: 198px;">
                <asp:Label ID="lblHinh3" runat="server" Text="Hinh3"></asp:Label>
            </td>
        </tr>
    </table>
    <table style="width: 594px;">
        <tr>
            <td style="width: 198px;font-family:Times New Roman; vertical-align:top; text-align:center">
                <asp:Label ID="lblTieuDe1" runat="server" Text="TieuDe1"></asp:Label>
            </td>
            <td style="width: 198px;font-family:Times New Roman; vertical-align:top;text-align:center">
                <asp:Label ID="lblTieuDe2" runat="server" Text="TieuDe2"></asp:Label>
            </td>
            <td  style="width: 198px;font-family:Times New Roman; vertical-align:top;text-align:center">
                <asp:Label ID="lblTieuDe3" runat="server" Text="TieuDe3"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

