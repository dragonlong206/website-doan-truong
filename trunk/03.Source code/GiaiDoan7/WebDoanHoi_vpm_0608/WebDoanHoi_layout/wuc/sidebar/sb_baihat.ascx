<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sb_baihat.ascx.cs" Inherits="WebDoanHoi_layout.wuc.sidebar.sb_baihat" %>
<div class="module">
    <div class="post-title">
        Bài hát
    </div>
    <div class="post-content">
        <asp:Panel ID="PanelBaiHat" runat="server">
    <embed allowscriptaccess="never" src="../Uploads/ListBaiHat/BaiHat1.m3u"
        type="application/x-mplayer2" autostart="true" loop="true" height="100" width="350">
        </asp:Panel>
<asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewBaiHat" runat="server" AutoGenerateColumns="False" CssClass="tablestyle"
        DataKeyNames="MaBaiHat" AllowPaging="True">
        <Columns>
            <asp:BoundField HeaderText="STT">
                <ControlStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="TenBaiHat" HeaderText="Tên Bài Hát" />
            <asp:HyperLinkField DataNavigateUrlFields="LinkBaiHat" DataNavigateUrlFormatString="~/administration/BaiHat.aspx?id={0}"
                DataTextField="LinkBaiHat" HeaderText="Link bài hát" ItemStyle-Width="30%" NavigateUrl="~/index.aspx">
                <ItemStyle Width="30%" />
            </asp:HyperLinkField>
        </Columns>
    </asp:GridView>
    
</asp:Panel>
    </div>
</div>
