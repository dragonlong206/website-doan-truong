<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyHoatDong.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.HoatDong.wucQuanLyHoatDong" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy">&nbsp;</p>
				<h2 class="fancy">Thông tin Hoạt Động</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
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
                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtngaydienra" Format="dd/MM/yyyy">
                            </asp:CalendarExtender>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtngaydienra" 
                                ErrorMessage="Mời bạn nhập Ngày Diễn Ra"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Loại Hoạt Động</label>
		                    <asp:DropDownList ID="ddlLoaiHoatDong" runat="server">
                            </asp:DropDownList>
                            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
	                    </li>
	                    <li>
		                    <label>Thời Gian Bắt Đầu Đăng Ký</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtthoigianbatdaudangky" ></asp:TextBox>
                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtthoigianbatdaudangky" Format="dd/MM/yyyy">
                            </asp:CalendarExtender>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtthoigianbatdaudangky" 
                                ErrorMessage="Mời bạn nhập Thời Gian Bắt Đầu Đăng Ký"></asp:RequiredFieldValidator>
	                    </li>
	                     <li>
		                    <label>Thời Gian Kết Thúc Đăng Ký</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtthoigianketthucdangky" ></asp:TextBox>
                             <asp:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="txtthoigianketthucdangky" Format="dd/MM/yyyy">
                             </asp:CalendarExtender>
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