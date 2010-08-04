<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Masterpages/main_3col.Master" CodeBehind="LichLamViec.aspx.cs" Inherits="WebDoanHoi_layout.LichLamViec" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
    <asp:GridView ID="GridViewLichLamViec" runat="server" 
        onselectedindexchanged="GridViewLichLamViec_SelectedIndexChanged" 
        AutoGenerateColumns="False">
        <Columns>            
            <asp:BoundField DataField="TenTapTin" HeaderText="Lịch Làm Việc" />
            <asp:HyperLinkField DataTextField="TenTapTin" DataNavigateUrlFields="DuongDan" 
                HeaderText="Link Download" >
            <ControlStyle Font-Underline="True" ForeColor="#0000CC" />
            </asp:HyperLinkField>
        </Columns>
    </asp:GridView>
</asp:Content>