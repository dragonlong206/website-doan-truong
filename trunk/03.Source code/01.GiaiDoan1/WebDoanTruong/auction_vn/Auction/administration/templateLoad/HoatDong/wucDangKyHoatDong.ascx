<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucDangKyHoatDong.ascx.cs" Inherits="templates_wucDangKyHoatDong" %>
<div class="section-title">

            <asp:Image ID="imgTitle" runat="server" ImageUrl="~/administration/Common/ico-dashboard.png" />
            <asp:Label ID="lblTitle" runat="server" Text="Danh Sách Sinh Viên Đăng Ký Hoạt Động" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    </div>   
     <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel>
    <asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewDangKyHoatDong" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="madangky" AllowPaging="True" 
                onpageindexchanging="GridViewDangKyHoatDong_PageIndexChanging">             
                <Columns>
                    <asp:BoundField HeaderText="STT" />
                    <asp:BoundField DataField="madangky" HeaderText="Đăng ký" Visible ="false" />
                    
                    <asp:HyperLinkField DataTextField="masinhvien" HeaderText="Sinh viên" 
                        NavigateUrl="~/Default.aspx" DataNavigateUrlFields="madangky" 
                        DataNavigateUrlFormatString="~/administration/DangKyHoatDong.aspx?id={0}" 
                        ItemStyle-Width="30%" SortExpression="madangky" >
                        <ItemStyle Width="30%" />
                     </asp:HyperLinkField>
                     
                    <asp:BoundField DataField="mahoatdong" HeaderText="Mã hoạt động"/>
                    <asp:BoundField DataField="ngaydangky" HeaderText="Ngày Đăng Ký" />
                    <asp:BoundField DataField="thamgia" HeaderText="Tham gia"/>
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