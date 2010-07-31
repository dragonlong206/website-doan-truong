<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyLoaiBaiViet.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.BaiViet.wucQuanLyLoaiBaiViet" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Loại Bài Viết</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Loại Bài Viết</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmaloaibaiviet" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmaloaibaiviet" 
                                ErrorMessage="Mời bạn nhập Mã Loại Bài Viết"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Tên Loại Bài Viết</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txttenloaibaiviet" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txttenloaibaiviet" 
                                ErrorMessage="Mời bạn nhập Tên Loại Bài Viết"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mã Chuyên Mục</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmachuyenmuc" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtmachuyenmuc" 
                                ErrorMessage="Mời bạn nhập Mã Chuyên Mục"></asp:RequiredFieldValidator>
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