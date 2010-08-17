<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyHeThongToChuc.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.BaiViet.wucQuanLyHeThongToChuc" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Hệ Thống Tổ Chức</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Mã Hệ Thống Tổ Chức</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtmahethongtochuc" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtmahethongtochuc" 
                                ErrorMessage="Mời bạn nhập Mã Hệ Thống Tổ Chức"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Tên Hệ Thống Tổ Chức</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txttenhethongtochuc" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txttenhethongtochuc" 
                                ErrorMessage="Mời bạn nhập Tên Hệ Thống Tổ Chức"></asp:RequiredFieldValidator>
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