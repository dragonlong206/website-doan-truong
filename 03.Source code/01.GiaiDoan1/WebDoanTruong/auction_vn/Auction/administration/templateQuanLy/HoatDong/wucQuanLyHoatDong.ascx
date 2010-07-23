<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLyHoatDong.ascx.cs" Inherits="administration_templateQuanLy_HoatDong_wucQuanLyHoatDong" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Hoạt Động</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã hoạt động</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmahoatdong" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmahoatdong" 
                                ErrorMessage="Mời bạn nhập Mã hoạt động"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Tên Hoạt Động</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txttenhoatdong" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txttenhoatdong" 
                                ErrorMessage="Mời bạn nhập Tên Hoạt Động"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Ngày Diễn Ra</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtngaydienra" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtngaydienra" 
                                ErrorMessage="Mời bạn nhập Ngày Diễn Ra"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mã Loại Hoạt Động</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmaloaihoatdong" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtmaloaihoatdong" 
                                ErrorMessage="Mời bạn nhập Mã Loại Hoạt Động"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Thời Gian Bắt Đầu Đăng Ký</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtthoigianbatdaudangky" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtthoigianbatdaudangky" 
                                ErrorMessage="Mời bạn nhập Thời Gian Bắt Đầu Đăng Ký"></asp:RequiredFieldValidator>
	                    </li>
	                     <li>
		                    <label>Thời Gian Kết Thúc Đăng Ký</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtthoigianketthucdangky" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="txtthoigianketthucdangky" 
                                ErrorMessage="Mời bạn nhập Thời Gian Kết Thúc Đăng Ký"></asp:RequiredFieldValidator>
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