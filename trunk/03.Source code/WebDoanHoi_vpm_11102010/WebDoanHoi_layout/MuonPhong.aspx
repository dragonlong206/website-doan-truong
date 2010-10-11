<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/main_3col.Master" AutoEventWireup="true" CodeBehind="MuonPhong.aspx.cs" Inherits="WebDoanHoi_layout.MuonPhong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPost" runat="server">
<div id="BVNoiBatDiv">
<asp:Label ID="Label1" runat="server" Text="Đăng Ký Mượn Phòng" 
        Font-Size="X-Large" ForeColor="#000099"></asp:Label>

    <br />
    <br />
    <table style="width: 100%">
        <tr>
            <td style="width: 213px">
                <asp:Label ID="Label6" runat="server" Text="Mã Người Dùng"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMaNguoiDung" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="txtMaNguoiDung" 
                                ErrorMessage="Mời bạn nhập mã người dùng"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 213px">
                <asp:Label ID="Label2" runat="server" Text="Ngày Mượn"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNgayMuon" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtNgayMuon" 
                                ErrorMessage="Mời bạn nhập ngày mượn"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 213px">
                <asp:Label ID="Label3" runat="server" Text="Số Lượng"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtSoLuong" 
                                ErrorMessage="Mời bạn nhập số lượng"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 213px">
                <asp:Label ID="Label4" runat="server" Text="Mục Đích"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMucDich" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtMucDich" 
                                ErrorMessage="Mời bạn nhập mục đích mượn"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 213px">
                <asp:Label ID="Label5" runat="server" Text="Đơn Vị Mượn"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDonViMuon" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtDonViMuon" 
                                ErrorMessage="Mời bạn nhập đơn vị mượn"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 213px">
                <asp:Literal ID="lbThongBao" runat="server" Visible="False"></asp:Literal>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 213px">
                <asp:Button ID="btnDangKy" runat="server" onclick="Button2_Click1" 
                    Text="Đăng Ký" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel>
    <asp:Panel ID="PanelDanhSach" runat="server">
            
    <div class="options">
        <asp:GridView ID="GridViewDanhSachPhongMuon" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" CssClass="tablestyle" DataKeyNames="madangky">
            <%--onpageindexchanging="GridViewLoaiVaiTro_PageIndexChanging"--%>
            <Columns>
                <asp:BoundField DataField="madangky" HeaderText="Mã Đăng Ký" />
                <asp:BoundField DataField="username" HeaderText="UserName" />
                <asp:BoundField DataField="ngaymuon" HeaderText="Ngày Mượn" />
                <asp:BoundField DataField="soluong" HeaderText="Số Lượng" />
                <asp:BoundField DataField="mucdich" HeaderText="Mục Đích" />
                <asp:BoundField DataField="donvimuon" HeaderText="Đơn Vị Mượn" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label8" runat="server" Text="Chọn số dòng hiển thị: "></asp:Label>
        <asp:DropDownList ID="DropDownListPaging" runat="server" AutoPostBack="True" >
        <%--onselectedindexchanged="DropDownListPaging_SelectedIndexChanged"--%>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem Selected="True">10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
        </asp:DropDownList>
        
    </div>   </asp:Panel>
    </div>
</asp:Content>
