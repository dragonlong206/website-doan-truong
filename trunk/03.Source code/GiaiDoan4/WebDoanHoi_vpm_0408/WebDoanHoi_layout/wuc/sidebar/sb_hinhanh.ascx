<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sb_hinhanh.ascx.cs" Inherits="WebDoanHoi_layout.wuc.sidebar.sb_hinhanh" %>
<div class="module">
    <div class="post-title">
        Hình ảnh hoạt động
    </div>
    <div class="post-content">
        Nội dung
    </div>
        <div class="post-album">
        <asp:Label ID="lbAlBum" runat="server" Text="Album"></asp:Label>
            <asp:HyperLink ID="hlAlbum" runat="server" NavigateUrl="~/AlbumAll.aspx">Tất cả</asp:HyperLink>
    </div>
</div>
