<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLyBaiHat.ascx.cs" Inherits="administration_templateQuanLy_BaiHat_wucQuanLyBaiHatl" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Bài Hát</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Bài Hát</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmabaihat" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmabaihat" 
                                ErrorMessage="Mời bạn nhập Mã Bài Hát"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Tên Bài Hát</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txttenbaihat" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txttenbaihat" 
                                ErrorMessage="Mời bạn nhập Tên Bài Hát"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Link Bài Hát</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtlinkbaihat" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtlinkbaihat" 
                                ErrorMessage="Mời bạn nhập Link Bài Hát"></asp:RequiredFieldValidator>
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