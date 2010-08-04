<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sb_khaosat.ascx.cs" Inherits="WebDoanHoi_layout.wuc.sidebar.sb_khaosat" %>
<div class="module">
    <div class="post-title">
        Khảo sát
    </div>
    <div class="post-content">
        <asp:Label ID="lbCauHoi" runat="server" Text="Label"></asp:Label>
    </div>
</div>
    <asp:RadioButtonList ID="rblistDanhSachDapAn" runat="server" 
    onselectedindexchanged="rblistDanhSachDapAn_SelectedIndexChanged">
    </asp:RadioButtonList>
    <asp:Button ID="btSubmit" runat="server" onclick="btSubmit_Click" 
    Text="Submit" />
    <br />
    <asp:Literal ID="lThongTin" runat="server"></asp:Literal>
    <p>
    &nbsp;</p>
