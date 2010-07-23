<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLySinhVien.ascx.cs" Inherits="administration_templateQuanLy_NguoiDung_wucQuanLySinhVien" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Sinh Viên</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Sinh Viên</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmasinhvien" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmasinhvien" 
                                ErrorMessage="Mời bạn nhập Mã Sinh Viên"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Password</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtpass" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtpass" 
                                ErrorMessage="Mời bạn nhập Password"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Họ Tên</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txthoten" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txthoten" 
                                ErrorMessage="Mời bạn nhập Họ Tên"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Email</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtemail" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtemail" 
                                ErrorMessage="Mời bạn nhập Email"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Vai Trò</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtvaitro" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtvaitro" 
                                ErrorMessage="Mời bạn nhập Vai Trò"></asp:RequiredFieldValidator>
	                    </li>
			         </ul>
			         <asp:Literal runat="server" ID="lbThongBao" Visible="false"></asp:Literal>
			         <br />
			         <asp:LinkButton runat="server" ID="btnCapNhat" CssClass="new-study-model" OnClick="btnCapNhat_Click" Text="Cập nhật"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnThem" CssClass="new-study-model" OnClick="btnThem_Click" Text="Thêm"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnXoa" CssClass="new-study-model" OnClick="btnXoa_Click" Text="Xóa"></asp:LinkButton>
			     </asp:Panel>
			     
			</div>
		</div>
	</div>