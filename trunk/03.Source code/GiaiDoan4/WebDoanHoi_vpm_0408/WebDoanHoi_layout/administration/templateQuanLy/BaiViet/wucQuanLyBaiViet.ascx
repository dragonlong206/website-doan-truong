<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyBaiViet.ascx.cs"
    Inherits="WebDoanHoi_layout.administration.templateQuanLy.BaiViet.wucQuanLyBaiViet" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<div id="body" class="clearfix">
    <div class="wrapper">
        <div class="col">
            <table>
                <tr>
                    <td colspan="2" align="center">
                        <h2>
                            <asp:LinkButton ID="btnCapNhat" runat="server" OnClick="btnCapNhat_Click">Cập nhật</asp:LinkButton>
                            &nbsp;-&nbsp;
                            <asp:LinkButton runat="server" ID="btnThem" CssClass="new-study-model" OnClick="btnThem_Click"
                                Text="Thêm"></asp:LinkButton>
                            &nbsp;-&nbsp;
                            <asp:LinkButton runat="server" ID="btnXoa" CssClass="new-study-model" OnClick="btnXoa_Click"
                                Text="Xóa"></asp:LinkButton>
                        </h2>
                    </td>
                </tr>
            </table>
            <h1>
                Thông tin Bài Viết</h1>
            <asp:Panel runat="server" ID="UpdatePanel">
                <table width="70%">
                    <tr>
                        <td>
                            <label>
                                Tiêu đề</label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txttieude" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txttieude"
                                ErrorMessage="Mời bạn nhập Tiêu Đề"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Chuyên mục
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlChuyenMuc" runat="server" Width="200px" 
                                AutoPostBack="True" onselectedindexchanged="ddlChuyenMuc_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Loại bài viết
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlLoaiBaiViet" runat="server" Width="200px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>
                                Ngày đăng</label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" CssClass="field-input" ID="txtngaydang" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtngaydang"
                                ErrorMessage="Mời bạn nhập Ngày Đăng"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <label>
                                Nội dung</label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <FCKeditorV2:FCKeditor ID="txtnoidung" runat="server" Height="500px">
                            </FCKeditorV2:FCKeditor>
                        </td>
                    </tr>
                </table>
                <asp:Literal runat="server" ID="lbThongBao" Visible="false"></asp:Literal>
                <br />
            </asp:Panel>
        </div>
    </div>
</div>
