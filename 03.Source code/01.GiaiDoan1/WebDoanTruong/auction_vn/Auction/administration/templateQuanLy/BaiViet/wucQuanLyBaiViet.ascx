<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLyBaiViet.ascx.cs" Inherits="administration_templateQuanLy_BaiViet_wucQuanLyBaiViet" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Bài Viết</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Bài Viết</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmabaiviet" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmabaiviet" 
                                ErrorMessage="Mời bạn nhập Mã Bài Viết"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Tiêu Đề</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txttieude" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txttieude" 
                                ErrorMessage="Mời bạn nhập Tiêu Đề"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Nội Dung</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtnoidung" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtnoidung" 
                                ErrorMessage="Mời bạn nhập Nội Dung"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mã Loại Bài Viết</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmaloaibaiviet" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtmaloaibaiviet" 
                                ErrorMessage="Mời bạn nhập Mã Loại Bài Viết"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Ngày Đăng</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtngaydang" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtngaydang" 
                                ErrorMessage="Mời bạn nhập Ngày Đăng"></asp:RequiredFieldValidator>
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