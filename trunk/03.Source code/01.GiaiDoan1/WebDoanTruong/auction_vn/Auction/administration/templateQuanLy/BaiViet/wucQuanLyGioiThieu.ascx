<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLyGioiThieu.ascx.cs" Inherits="administration_templateQuanLy_BaiViet_wucQuanLyGioiThieu" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Giới Thiệu</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Giới Thiệu</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmagioithieu" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmagioithieu" 
                                ErrorMessage="Mời bạn nhập Mã Giới Thiệu"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Tên Giới Thiệu</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txttengioithieu" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txttengioithieu" 
                                ErrorMessage="Mời bạn nhập Tên Giới Thiệu"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Nội Dung</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtnoidung" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtnoidung" 
                                ErrorMessage="Mời bạn nhập Nội Dung"></asp:RequiredFieldValidator>
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