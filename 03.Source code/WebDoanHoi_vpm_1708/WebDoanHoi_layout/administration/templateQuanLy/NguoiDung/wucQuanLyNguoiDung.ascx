<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyNguoiDung.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.NguoiDung.wucQuanLyNguoiDung" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 100px;
    }
    .style3
    {
        width: 99px;
    }
    .style4
    {
        width: 98px;
    }
    .style5
    {
        width: 97px;
    }
    .style6
    {
        width: 196px;
    }
    .style7
    {
        width: 212px;
    }
    .style8
    {
        width: 211px;
    }
    .style9
    {
        width: 209px;
    }
</style>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Sinh Viên - Cán Bộ</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <table class="style1">
                                <tr>
                                    <td class="style2">
                                        <label>
                                        Mã Sinh Viên</label></td>
                                    <td class="style9">
                                        <asp:TextBox ID="txtmasinhvien" runat="server" CssClass="field-input" 
                                            Width="190px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="txtmasinhvien" ErrorMessage="Mời bạn nhập Mã Sinh Viên"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </li>
	                    <li>
		                    <table class="style1">
                                <tr>
                                    <td class="style3">
                                        <label>
                                        Password</label></td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtpass" runat="server" CssClass="field-input" Width="190px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="txtpass" ErrorMessage="Mời bạn nhập Password"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
	                    </li>
	                    <li>
		                    <table class="style1">
                                <tr>
                                    <td class="style4">
                                        <label>
                                        Họ Tên</label></td>
                                    <td class="style7">
                                        <asp:TextBox ID="txthoten" runat="server" CssClass="field-input" Width="190px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ControlToValidate="txthoten" ErrorMessage="Mời bạn nhập Họ Tên"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
	                    </li>
	                    <li>
		                    <table class="style1">
                                <tr>
                                    <td class="style4">
                                        <label>
                                        Email</label>&nbsp;</td>
                                    <td class="style7">
                                        <asp:TextBox ID="txtemail" runat="server" CssClass="field-input" Width="190px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="txtemail" ErrorMessage="Mời bạn nhập Email"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
	                    </li>
	                    <li>
		                    <table class="style1">
                                <tr>
                                    <td class="style5">
                                        <label>
                                        Vai Trò</label>&nbsp;</td>
                                    <td class="style6">
                                        <asp:DropDownList ID="txtvaitro" runat="server" AutoPostBack="True" 
                                            DataSourceID="SqlDataSourceVaiTro" DataTextField="TenLoaiVaiTro" 
                                            DataValueField="MaLoaiVaiTro" Width="190px">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSourceVaiTro" runat="server" 
                                            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                            SelectCommand="SELECT * FROM [LOAIVAITRO]"></asp:SqlDataSource>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                            ControlToValidate="txtvaitro" ErrorMessage="Mời bạn nhập Vai Trò"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
	                    </li>
			         </ul>
			         <asp:Literal runat="server" ID="lbThongBao" Visible="false"></asp:Literal>
			         <br />
			         <asp:LinkButton runat="server" ID="btnCapNhat" CssClass="new-study-model" OnClick="btnCapNhat_Click" Text="Cập nhật"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnThem" CssClass="new-study-model" OnClick="btnThem_Click" Text="Thêm"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnXoa" CssClass="new-study-model" 
                        OnClick="btnXoa_Click" Text="Xóa" Visible="False"></asp:LinkButton>
			     </asp:Panel>
			     
			</div>
		</div>
	</div>