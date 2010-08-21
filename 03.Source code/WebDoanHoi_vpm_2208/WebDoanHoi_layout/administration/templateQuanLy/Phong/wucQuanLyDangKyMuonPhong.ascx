<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyDangKyMuonPhong.ascx.cs" Inherits="WebDoanHoi_layout.administration.templateQuanLy.Phong.wucQuanLyDangKyMuonPhong" %>


            <asp:Image ID="imgTitle" runat="server" ImageUrl="~/administration/Common/ico-dashboard.png" />
            <asp:Label ID="lblTitle" runat="server" Text="Danh Sách Ðăng Ký Mượn Phòng" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    </div>   
     <asp:Panel ID="PanelMessage" runat="server">
             <div class="message" style="width:90%;display:table; background-image:url('./images/icon-error.gif'); background-color:#FFFFCC;background-position:10px 50%;background-repeat:no-repeat; border:0.1em solid #CC0000;margin:0.5em 0;padding:10px 10px 10px 36px;">
                   Chưa có dữ liệu
            </div>
            </asp:Panel>
    <asp:Panel ID="PanelDanhSach" runat="server">
    <asp:GridView ID="GridViewDangKyMuonPhong" runat="server" 
                AutoGenerateColumns="False" 
                CssClass="tablestyle" DataKeyNames="madangky" AllowPaging="True" 
                onpageindexchanging="GridViewDangKyMuonPhong_PageIndexChanging">             
                <Columns>
                    <asp:BoundField HeaderText="STT" />
                    <asp:BoundField DataField="madangky" HeaderText="Đăng Ký Mượn Phòng" Visible ="false" />
                    
                    <asp:HyperLinkField DataTextField="hoten" HeaderText="Họ Tên Sinh Viên" 
                        NavigateUrl="~/Default.aspx" DataNavigateUrlFields="madangky" 
                        DataNavigateUrlFormatString="~/administration/DangKyMuonPhong.aspx?id={0}" 
                        ItemStyle-Width="30%" SortExpression="madangky" >
                        <ItemStyle Width="30%" />
                     </asp:HyperLinkField>
                     
                    <asp:BoundField DataField="ngaymuon" HeaderText="Ngày Mượn"/>
                    <asp:BoundField DataField="soluong" HeaderText="Số Lượng Sinh Viên" />
                    <asp:BoundField DataField="mucdich" HeaderText="Mục đích"/>
                    <asp:BoundField DataField="donvimuon" HeaderText="Ðơn Vị Mượn"/>
                </Columns>
    </asp:GridView>       
            
    <div class="options">
        <asp:Label ID="Label1" runat="server" Text="Chọn số dòng hiển thị: "></asp:Label>
        <asp:DropDownList ID="DropDownListPaging" runat="server" 
            onselectedindexchanged="DropDownListPaging_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem Selected="True">10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
        </asp:DropDownList>
        
    </div>   </asp:Panel>

<div id="body" class="clearfix">
		<div class="wrapper">
			<div class="col">
			<p class="fancy"></p>
				<h2 class="fancy">Thông tin Ðang Ký Mượn Phòng</h2>
                
                <asp:Panel runat="server" ID="UpdatePanel">
                    
                    
                    <ul class="normal-form">
	                  <%--  <li>
		                    <label>Mã Sinh Viên</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmasinhvien" 
                                ReadOnly="True" ></asp:TextBox>
	                    </li>--%>
	                    <li>
		                    <label>Ngày</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtngay" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtngay" 
                                ErrorMessage="Mời bạn nhập ngày"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Số Lượng</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtsoluong" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtsoluong" 
                                ErrorMessage="Mời bạn nhập số lượng"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Mục Ðích</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtmucdich" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtmucdich" 
                                ErrorMessage="Mời bạn nhập mục đích"></asp:RequiredFieldValidator>
	                    </li>
	                    <li>
		                    <label>Đơn Vị Mượn</label>
		                    <asp:TextBox runat="server" CssClass="field-input" ID="txtdonvimuon" ></asp:TextBox>
	                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="txtdonvimuon" 
                                ErrorMessage="Mời bạn nhập đơn vị mượn"></asp:RequiredFieldValidator>
	                    </li>
			         </ul>
			         <asp:Literal runat="server" ID="lbThongBao" Visible="false"></asp:Literal>
			         <br />
			         <asp:LinkButton runat="server" ID="btnCapNhat" CssClass="new-study-model" OnClick="btnCapNhat_Click" Text="Cập Nhật"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnThem" CssClass="new-study-model" OnClick="btnThem_Click" Text="Thêm"></asp:LinkButton>&nbsp;&nbsp;
			         <asp:LinkButton runat="server" ID="btnXoa" CssClass="new-study-model" OnClick="btnXoa_Click" Text="Xóa"></asp:LinkButton> <br />
			         <asp:LinkButton runat="server" ID="btnXoaNhieu" CssClass="new-study-model" OnClick="btnXoaNhieu_Click" Text="Xóa trước ngày: "></asp:LinkButton>
			         <asp:TextBox ID="txtXoaNhieu" runat="server"></asp:TextBox>
			     </asp:Panel>
			     
			</div>
		</div>
	</div>