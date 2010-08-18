﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQuanLyBaiViet.ascx.cs"
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
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
            <asp:Panel runat="server" ID="UpdatePanel">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <table width="70%">
                                    <tr>
                                        <td>
                                            <label>
                                            Tiêu đề</label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txttieude" runat="server" CssClass="field-input" Width="200px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="txttieude" ErrorMessage="Mời bạn nhập Tiêu Đề"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Chuyên mục
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlChuyenMuc" runat="server" AutoPostBack="True" 
                                                OnSelectedIndexChanged="ddlChuyenMuc_SelectedIndexChanged" Width="200px">
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
                                            <lable>
                                                Ảnh đại diện</lable>
                                        </td>
                                        <td>
                                            <asp:FileUpload ID="fulImage" runat="server" />
                                        </td>
                                        <td>
                                            <asp:Label ID="lbAnhDaiDien" runat="server" Text="ảnh đại diện"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Tóm tắt</td>
                                        <td>
                                            <asp:TextBox ID="txtTomTat" runat="server" Height="93px" TextMode="MultiLine" 
                                                Width="441px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            </td> 
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                    <tabe>
                    <caption>
                        <caption>
                            <label>
                            Nội dung</label></caption>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <FCKeditorV2:FCKeditor ID="txtnoidung" runat="server" Height="500px">
                                </FCKeditorV2:FCKeditor>
                            </td>
                        </tr>
                    </caption>
                </table>
                <div class="post-content">
    <asp:Panel ID="PanelBtnUpload" runat="server" Style="margin-top: 10px;">
            <asp:Button ID="btnUploadFiles" runat="server" Text="Upload Files" 
                onclick="btnUploadFiles_Click" />
    </asp:Panel>
    <asp:Panel ID="PanelUploadTapTinBaiViet" runat="server" Visible="false">
            <asp:FileUpload ID="FileUploadTapTin" runat="server" />
            <asp:Label ID="LabelUploadStatus" runat="server"></asp:Label>
            <asp:Button ID="btnUpload" runat="server" Text="Upload" 
                onclick="btnUpload_Click"/>
    </asp:Panel>
    <asp:Panel ID="PanelDownload" runat="server">
            <asp:HyperLink ID="hplDownloadLink" runat="server"></asp:HyperLink>
    </asp:Panel>
    
    </div>
                <asp:Literal runat="server" ID="lbThongBao" Visible="false"></asp:Literal>
                <asp:ImageButton ID="imgBtnXoa" runat="server" ImageUrl="~/Uploads/but_xoa.jpg" 
                    onclick="imgBtnXoa_Click" Visible="False" />
                <br />
                            </asp:Panel>
        </div>
    </div>
</div>
