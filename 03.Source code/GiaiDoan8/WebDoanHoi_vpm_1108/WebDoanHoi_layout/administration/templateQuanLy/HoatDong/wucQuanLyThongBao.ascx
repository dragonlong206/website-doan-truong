<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyThongBao.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.HoatDong.wucQuanLyThongBao" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Thông Báo</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Thông Báo</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmathongbao" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmathongbao" 
                                ErrorMessage="Mời bạn nhập Mã Thông Báo"></asp:RequiredFieldValidator>
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
		                    <label>Ngày Đăng</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtngaydang" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtngaydang" 
                                ErrorMessage="Mời bạn nhập Ngày Đăng"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mã Hoạt Động</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmahoatdong" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
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