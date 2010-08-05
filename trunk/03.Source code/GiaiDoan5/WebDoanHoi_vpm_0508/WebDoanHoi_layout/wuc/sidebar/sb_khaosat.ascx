<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sb_khaosat.ascx.cs"
    Inherits="WebDoanHoi_layout.wuc.sidebar.sb_khaosat" %>
<div class="module">
    <div class="post-title">
        Khảo sát
    </div>
    <div class="post-content">
        <asp:Label ID="lbCauHoi" runat="server" Text="Label"></asp:Label>
        <asp:RadioButtonList ID="rblistDanhSachDapAn" runat="server" OnSelectedIndexChanged="rblistDanhSachDapAn_SelectedIndexChanged">
        </asp:RadioButtonList>
        <center>
            <asp:Button ID="btSubmit" runat="server" OnClick="btSubmit_Click" Text="Chọn" /></center>
        <p style="margin-top: 10px;">
            <hr />
        </p>
        <asp:Literal ID="lThongTin" runat="server"></asp:Literal>
    </div>
</div>
