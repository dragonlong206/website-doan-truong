﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLykhaoSat.ascx.cs" Inherits="administration_templateQuanLy_KhaoSat_wucQuanLykhaoSat" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Khảo Sát</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã câu hỏi</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmacauhoi" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmacauhoi" 
                                ErrorMessage="Mời bạn nhập Mã câu hỏi"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Mã Sinh Viên</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmasinhvien" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtmasinhvien" 
                                ErrorMessage="Mời bạn nhập Mã Sinh Viên"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mã Đáp Án</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmadapan" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtmadapan" 
                                ErrorMessage="Mời bạn nhập Mã Đáp Án"></asp:RequiredFieldValidator>
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