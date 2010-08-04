<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyLichLamViec.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.KhaoSat.wucLichLamViec" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin lịch làm việc</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Ngày bắt đầu lịch làm việc</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtNgayBatDau" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtNgayBatDau" 
                                ErrorMessage="Mời bạn nhập ngày bắt đầu lịch làm việc"></asp:RequiredFieldValidator>
                        </li>
	                    <li>
		                    <label>Ngày kết thúc lịch làm việc</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtNgayKetThuc" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtNgayKetThuc" 
                                ErrorMessage="Mời bạn nhập ngày kết thúc lịch làm việc"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
                            <asp:Label ID="Label1" runat="server" Text="Hãy chọn file lịch làm việc"></asp:Label>
                            <asp:FileUpload ID="FileUploadLichLamViec" runat="server" />
	                    </li>
	                    <li>
	                        <asp:Label ID="LabelUploadStatus" runat="server"></asp:Label>
	                    </li>
			         </ul>
			         <asp:LinkButton runat="server" ID="btnThem" CssClass="new-study-model" OnClick="btnThem_Click" Text="Thêm"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnXoa" CssClass="new-study-model" OnClick="btnXoa_Click" Text="Xóa"></asp:LinkButton>
			     </asp:Panel>
			     
			</div>
		</div>
	</div>