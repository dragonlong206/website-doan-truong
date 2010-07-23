<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLyLoaiVaiTro.ascx.cs" Inherits="administration_templateQuanLy_NguoiDung_wucQuanLyLoaiVaiTro" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Loại Vai Trò</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Loại Vai Trò</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmaloaivaitro" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmaloaivaitro" 
                                ErrorMessage="Mời bạn nhập Mã Loại Vai Trò"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Tên Vai Trò</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txttenloaivaitro" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txttenloaivaitro" 
                                ErrorMessage="Mời bạn nhập Tên Vai Trò"></asp:RequiredFieldValidator>
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