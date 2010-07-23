<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucQuanLyLichLamViec.ascx.cs" Inherits="administration_templateQuanLy_LichLamViec_wucQuanLyLichLamViec" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Lịch Làm Việc</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
                        <li>
                            <label>Nội dung</label>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtnoidung" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtnoidung" 
                                ErrorMessage="Mời bạn nhập Nội dung"></asp:RequiredFieldValidator>
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