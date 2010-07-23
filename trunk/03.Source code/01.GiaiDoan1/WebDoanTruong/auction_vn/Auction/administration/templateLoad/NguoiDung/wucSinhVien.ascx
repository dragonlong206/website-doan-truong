<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucSinhVien.ascx.cs" Inherits="templates_wucSinhVien" %>
<div class="section-title">

            <asp:Image ID="imgTitle" runat="server" ImageUrl="~/administration/Common/ico-dashboard.png" />
            <asp:Label ID="lblTitle" runat="server" Text="Danh Sách Sinh Viên / Cán Bộ" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    </div>   
     <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel>
    <asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewSinhVien" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="masinhvien" AllowPaging="True" 
                onpageindexchanging="GridViewSinhVien_PageIndexChanging">             
                <Columns>
                    <asp:BoundField HeaderText="STT" />
                    <asp:BoundField DataField="masinhvien" HeaderText="Sinh Viên" Visible ="false" />
                    
                    <asp:HyperLinkField DataTextField="pass" HeaderText="Password" 
                        NavigateUrl="~/Default.aspx" DataNavigateUrlFields="masinhvien" 
                        DataNavigateUrlFormatString="~/administration/SinhVien.aspx?id={0}" 
                        ItemStyle-Width="30%" SortExpression="masinhvien" >
                        <ItemStyle Width="30%" />
                     </asp:HyperLinkField>
                     
                    <asp:BoundField DataField="hoten" HeaderText="Họ Tên"/>
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="vaitro" HeaderText="Vai Trò"/>
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