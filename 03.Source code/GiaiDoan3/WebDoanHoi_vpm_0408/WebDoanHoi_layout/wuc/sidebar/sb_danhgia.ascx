<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sb_danhgia.ascx.cs" Inherits="WebDoanHoi_layout.wuc.sidebar.sb_danhgia" %>
<div class="module">
    <div class="post-title">
        Đánh giá
    </div>
    <div class="post-content">
        <asp:Label ID="lbCauHoi" runat="server" Text="Label"></asp:Label>
    </div>
</div>
<asp:RadioButtonList ID="rblDanhSachDapAn" runat="server" >
</asp:RadioButtonList>
<asp:Button ID="btSubmit" runat="server" onclick="btSubmit_Click" 
    Text="Submit" />
<br />
<asp:Literal ID="lThongTin" runat="server"></asp:Literal>
<p>
    &nbsp;</p>
