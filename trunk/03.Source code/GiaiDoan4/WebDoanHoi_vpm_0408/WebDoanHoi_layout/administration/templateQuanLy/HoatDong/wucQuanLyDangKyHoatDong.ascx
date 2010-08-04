<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyDangKyHoatDong.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.HoatDong.wucQuanLyDangKyHoatDong" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Đăng Ký Hoạt Động</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
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