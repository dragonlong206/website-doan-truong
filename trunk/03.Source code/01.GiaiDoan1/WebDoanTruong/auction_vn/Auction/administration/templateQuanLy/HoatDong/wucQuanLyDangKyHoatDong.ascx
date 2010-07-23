<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLyDangKyHoatDong.ascx.cs" Inherits="administration_templateQuanLy_HoatDong_wucQuanLyDangKyHoatDong" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Đăng Ký Hoạt Động</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Đăng Ký Hoạt Động</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmadangky" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmadangky" 
                                ErrorMessage="Mời bạn nhập Mã Đăng Ký Hoạt Động"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Mã Sinh Viên</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmasinhvien" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtmasinhvien" 
                                ErrorMessage="Mời bạn nhập Mã Sinh Viên"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mã Hoạt Động</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmahoatdong" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtmahoatdong" 
                                ErrorMessage="Mời bạn nhập Mã Hoạt Động"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Ngày Đăng Ký</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtngaydangky" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtngaydangky" 
                                ErrorMessage="Mời bạn nhập Ngày Đăng Ký"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Tham Gia</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtthamgia" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtthamgia" 
                                ErrorMessage="Mời bạn nhập Tham Gia"></asp:RequiredFieldValidator>
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