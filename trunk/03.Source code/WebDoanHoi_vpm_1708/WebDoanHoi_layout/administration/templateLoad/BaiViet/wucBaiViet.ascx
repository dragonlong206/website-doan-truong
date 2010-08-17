<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucBaiViet.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateLoad.BaiViet.wucBaiViet" %>
<div class="section-title">

            <asp:Image ID="imgTitle" runat="server" ImageUrl="~/administration/Common/ico-dashboard.png" />
            <asp:Label ID="lblTitle" runat="server" Text="Danh Sách Bài Viết" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    </div>   
     <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel>
    <asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewBaiViet" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="mabaiviet" AllowPaging="True" 
                onpageindexchanging="GridViewBaiViet_PageIndexChanging" 
            onrowcommand="GridViewBaiViet_RowCommand">             
                <Columns>
                    <asp:BoundField HeaderText="STT" />
                    <asp:BoundField DataField="mabaiviet" HeaderText="Bài viết" Visible = "false" />
                    
                    <asp:HyperLinkField DataTextField="tieude" HeaderText="Tiêu Đề" 
                        NavigateUrl="~/index.aspx" DataNavigateUrlFields="mabaiviet" 
                        DataNavigateUrlFormatString="~/administration/BaiViet.aspx?id={0}" 
                        ItemStyle-Width="30%" SortExpression="mabaiviet" >
                        <ItemStyle Width="30%" />
                     </asp:HyperLinkField>
                    <asp:BoundField DataField="tenloaibaiviet" HeaderText="Tên loại bài viết" />
                    <asp:BoundField DataField="ngaydang" HeaderText="Ngày đăng"/>
                    <asp:ButtonField CommandName="XoaBaiViet" HeaderText="Xóa Bài Viết" 
                        Text="Xóa" />
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