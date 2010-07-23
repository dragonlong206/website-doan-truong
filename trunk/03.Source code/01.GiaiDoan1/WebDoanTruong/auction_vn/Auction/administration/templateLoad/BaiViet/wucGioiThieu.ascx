<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucGioiThieu.ascx.cs" Inherits="templates_wucGioiThieu" %>
<div class="section-title">

            <asp:Image ID="imgTitle" runat="server" ImageUrl="~/administration/Common/ico-dashboard.png" />
            <asp:Label ID="lblTitle" runat="server" Text="Danh Sách Tin Tức trong mục Giới Thiệu" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    </div>   
     <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel>
    <asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewGioiThieu" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="magioithieu" AllowPaging="True" 
                onpageindexchanging="GridViewGioiThieu_PageIndexChanging">             
                <Columns>
                    <asp:BoundField HeaderText="STT" />
                    <asp:BoundField DataField="magioithieu" HeaderText="Giới thiệu" Visible ="false" />
                    
                    <asp:HyperLinkField DataTextField="tengioithieu" HeaderText="Tên giới thiệu" 
                        NavigateUrl="~/Default.aspx" DataNavigateUrlFields="magioithieu" 
                        DataNavigateUrlFormatString="~/administration/GioiThieu.aspx?id={0}" 
                        ItemStyle-Width="30%" SortExpression="magioithieu" >
                        <ItemStyle Width="30%" />
                     </asp:HyperLinkField>
                     
                    <asp:BoundField DataField="noidung" HeaderText="Nội Dung"/>
                    
                </Columns>
    </asp:GridView>       
            
    <div class="options">
        <asp:Label ID="Label1" runat="server" Text="Chọn số dòng hiển thị: "></asp:Label>
        <asp:DropDownList ID="DropDownListPaging" runat="server" 
            onselectedindexchanged="DropDownListPaging_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem Selected="True">10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
        </asp:DropDownList>
        
    </div>   </asp:Panel>