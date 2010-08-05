<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyDangKyMuonPhong.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.Phong.wucQuanLyDangKyMuonPhong" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Đăng Ký Mượn Phòng</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Đăng Ký Mượn Phòng</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmadangky" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmadangky" 
                                ErrorMessage="Mời bạn nhập Mã Đăng Ký Mượn Phòng"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Mã Sinh Viên</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmasinhvien" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtmasinhvien" 
                                ErrorMessage="Mời bạn nhập Mã Sinh Viên"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Ngày</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtngay" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtngay" 
                                ErrorMessage="Mời bạn nhập Ngày"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Số lượng</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtsoluong" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtsoluong" 
                                ErrorMessage="Mời bạn nhập Số lượng"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mục Đích</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmucdich" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtmucdich" 
                                ErrorMessage="Mời bạn nhập Mục Đích"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Đơn vị mượn</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtdonvimuon" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="txtdonvimuon" 
                                ErrorMessage="Mời bạn nhập Đơn Vị Mượn"></asp:RequiredFieldValidator>
	                    </li>
			         </ul>
			         <asp:Literal runat="server" ID="lbThongBao" Visible="false"></asp:Literal>
			         <br />
			         <asp:LinkButton runat="server" ID="btnCapNhat" CssClass="new-study-model" OnClick="btnCapNhat_Click" Text="Cập nhật"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnThem" CssClass="new-study-model" OnClick="btnThem_Click" Text="Thêm"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnXoa" CssClass="new-study-model" OnClick="btnXoa_Click" Text="Xóa"></asp:LinkButton> <br />
			         <asp:LinkButton runat="server" ID="btnXoaNhieu" CssClass="new-study-model" OnClick="btnXoaNhieu_Click" Text="Xóa trước ngày: "></asp:LinkButton>
			         <asp:TextBox ID="txtXoaNhieu" runat="server"></asp:TextBox>
			     </asp:Panel>
			     
			</div>
		</div>
	</div>