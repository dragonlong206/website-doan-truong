<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucBaiHat.ascx.cs" Inherits="WebDoanHoi_layout.wuc.wucBaiHat" %>
<asp:Panel ID="PanelBaiHat" runat="server">
<embed allowScriptAccess="never" src="Uploads/playlist.m3u" 
type="application/x-mplayer2" autostart="true" loop="true" 
height="100" width="350"></embed>
</asp:Panel>
<asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewBaiHat" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="MaBaiHat" AllowPaging="True" 
                onpageindexchanging="GridViewBaiHat_PageIndexChanging">             
                <Columns>
                    <asp:BoundField HeaderText="STT" >
                    <ControlStyle Width="100px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TenBaiHat" HeaderText="Tên Bài Hát" />
                    <asp:HyperLinkField DataNavigateUrlFields="LinkBaiHat" 
                        DataNavigateUrlFormatString="~/administration/BaiHat.aspx?id={0}" 
                        DataTextField="LinkBaiHat" HeaderText="Link bài hát" ItemStyle-Width="30%" 
                        NavigateUrl="~/Default.aspx">
                        <ItemStyle Width="30%" />
                    </asp:HyperLinkField>
                    
                    
                </Columns>
    </asp:GridView>       
            
    <asp:Label ID="Label1" runat="server" Text="Chọn số dòng hiển thị: "></asp:Label>
        <asp:DropDownList ID="DropDownListPaging" runat="server" 
            onselectedindexchanged="DropDownListPaging_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem Selected="True">10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
        </asp:DropDownList>
        
    </asp:Panel> 