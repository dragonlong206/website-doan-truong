<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucChuyenMuc.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateLoad.BaiViet.wucChuyenMuc" %>
<div class="section-title">

            <asp:Image ID="imgTitle" runat="server" ImageUrl="~/administration/Common/ico-dashboard.png" />
            <asp:Label ID="lblTitle" runat="server" Text="Danh Sách Chuyên Mục" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    </div>   
     <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel>
    <asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewChuyenMuc" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="machuyenmuc" AllowPaging="True" 
                onpageindexchanging="GridViewChuyenMuc_PageIndexChanging" 
            onrowcommand="GridViewChuyenMuc_RowCommand">             
                <Columns>
                    <asp:BoundField HeaderText="STT" />
                    <asp:BoundField DataField="machuyenmuc" HeaderText="Chuyên mục" Visible ="false" />
                    
                    <asp:HyperLinkField DataTextField="tenchuyenmuc" HeaderText="Tên chuyên mục" 
                        NavigateUrl="~/Default.aspx" DataNavigateUrlFields="machuyenmuc" 
                        DataNavigateUrlFormatString="~/administration/ChuyenMuc.aspx?id={0}" 
                        ItemStyle-Width="30%" SortExpression="machuyenmuc" >
                        <ItemStyle Width="30%" />
                     </asp:HyperLinkField>
                     
                    
                    <asp:ButtonField CommandName="XoaChuyenMuc" HeaderText="Xóa Chuyên Mục" 
                        Text="Xóa">
                    <ControlStyle Width="30px" />
                    </asp:ButtonField>
                     
                    
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